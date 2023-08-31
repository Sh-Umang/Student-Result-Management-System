using Dapper;
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
using StudentResultManagementSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace StudentResultManagementSystem
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=studentResult;User ID=us;Password=mypass;Encrypt=false");
        int snnn = 0;
        private void Student_Load(object sender, EventArgs e)
        {
            showStudents();
        }

        private void showStudents()
        {
            var tb = conn.Query<Student>("select * from Students");
            gridViewSF.DataSource = tb;
        }

        private void btnAddSF_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSNSF.Text ==string.Empty || txtSNSF.Text == "0")
                {
                    MessageBox.Show("Symbol No. Invalid", "Error", MessageBoxButtons.OK);
                }
                else if (txtFNSF.Text == string.Empty || txtLNSF.Text == string.Empty || txtEmailSF.Text == string.Empty || txtAddressSF.Text == string.Empty || txtPNSF.Text == string.Empty ||  ctxtGenderSF.Text == string.Empty)
                {
                    MessageBox.Show("All Fields Required.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    var para = new { sn = txtSNSF.Text, fn = txtFNSF.Text, ln = txtLNSF.Text, email = txtEmailSF.Text, address = txtAddressSF.Text, phone_no = txtPNSF.Text, gender = ctxtGenderSF.Text };
                    conn.Query<Student>("addStudent", para, commandType: System.Data.CommandType.StoredProcedure);
                    showStudents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateSF_Click(object sender, EventArgs e)
        {
            try
            {
                if (snnn == 0 || txtSNSF.Text ==string.Empty)
                {
                    MessageBox.Show("Select record to update.", "Error", MessageBoxButtons.OK);
                }
                else if (txtFNSF.Text == string.Empty || txtLNSF.Text == string.Empty || txtEmailSF.Text == string.Empty || txtAddressSF.Text == string.Empty || txtPNSF.Text == string.Empty ||  ctxtGenderSF.Text == string.Empty)
                {
                    MessageBox.Show("All Fields Required.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    conn.Query<Student>("updateStud", new { snn = snnn, sn = txtSNSF.Text, fn = txtFNSF.Text, ln = txtLNSF.Text, em = txtEmailSF.Text, ad = txtAddressSF.Text, pn = txtPNSF.Text, g = ctxtGenderSF.Text }, commandType: System.Data.CommandType.StoredProcedure);
                    showStudents();
                    resetFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewSF_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSNSF.Text = gridViewSF.SelectedRows[0].Cells[0].Value.ToString();
            string snsf = txtSNSF.Text;
            txtFNSF.Text = gridViewSF.SelectedRows[0].Cells[1].Value.ToString();
            txtLNSF.Text = gridViewSF.SelectedRows[0].Cells[2].Value.ToString();
            txtEmailSF.Text = gridViewSF.SelectedRows[0].Cells[3].Value.ToString();
            txtAddressSF.Text = gridViewSF.SelectedRows[0].Cells[4].Value.ToString();
            txtPNSF.Text = gridViewSF.SelectedRows[0].Cells[5].Value.ToString();
            ctxtGenderSF.Text = gridViewSF.SelectedRows[0].Cells[6].Value.ToString();
            snnn = int.Parse(snsf);
        }

        private void btnDelSF_Click(object sender, EventArgs e)
        {
            try
            {
                if (snnn == 0 || txtSNSF.Text ==string.Empty)
                {
                    MessageBox.Show("Select record to delete.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    conn.Query<Student>("Delete from Students where symbol_no = @id", new { id = snnn });
                    showStudents();
                    resetFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetSF_Click(object sender, EventArgs e)
        {
            resetFields();
        }

        private void resetFields()
        {
            txtSNSF.Text = string.Empty;
            txtFNSF.Text = string.Empty;
            txtLNSF.Text = string.Empty;
            txtAddressSF.Text = string.Empty;
            txtEmailSF.Text = string.Empty;
            ctxtGenderSF.Text = string.Empty;
            txtPNSF.Text = string.Empty;
            snnn = 0;
        }
    }
}
