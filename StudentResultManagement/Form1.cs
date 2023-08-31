using Dapper;
using StudentResultManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentResultManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=studentResult;User ID=us;Password=mypass;Encrypt=false");
        int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            showRecord(cnt);
        }

        private void showRecord(int cnt)
        {
            List<Record> r = new List<Record>();
            var tb1 = conn.Query<Student>("select * from Students");
            var tb2 = conn.Query<Subject>("select * from Subjects");
            foreach (var c in tb1)
            {
                Record record = new Record();
                record.id = c.symbol_no;
                record.name = c.first_name + " " + c.last_name;
                showResultandPercent(c, ref record,tb2);
                r.Add(record);
            }
            if (cnt == 0)
                gridViewMain.DataSource = r;
            else if (cnt == 1)
                gridViewMain.DataSource = r.OrderByDescending(x=>x.percent).ToList();
            else
                gridViewMain.DataSource = r.OrderBy(x=>x.percent).ToList();
        }

        private void showResultandPercent(Student c, ref Record record, IEnumerable<Subject> s)
        {
            int percentage = 0;
            var tb3 = conn.Query<Result>("select * from Results where std_id = @id", new { id = c.symbol_no });
            if (tb3.Count() != s.Count())
            {
                record.overall_result = "No Data";
                record.percent = "*";
            }
            else
            {
                
                var tb2 = conn.Query<Result>("select * from Results where std_id = @id and result_obt='Fail'", new { id = c.symbol_no });
                if (tb2.Count() == 0)
                {
                    record.overall_result = "Pass";
                    foreach (var d in tb3)
                    {
                        percentage += int.Parse(d.total);
                    }
                    record.percent = Convert.ToString(percentage / tb3.Count()) + "%";
                }
                else
                {
                    record.overall_result = "Fail";
                    record.percent = "-";
                }
            }
        }

        private void btnStdMF_Click(object sender, EventArgs e)
        {
            StudentForm frm = new StudentForm();
            frm.ShowDialog();
        }

        private void btnSubMF_Click(object sender, EventArgs e)
        {
            SubjectForm frm = new SubjectForm();
            frm.ShowDialog();
        }

        private void btnResultMF_Click(object sender, EventArgs e)
        {
            ResultForm frm = new ResultForm();
            frm.ShowDialog();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            cnt = 0;
            showRecord(cnt);
        }

        private void gridViewMain_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                cnt = (cnt + 1) % 3;
                showRecord(cnt);
            }
        }
    }
}
