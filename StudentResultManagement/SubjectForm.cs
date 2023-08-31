using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dapper;
using StudentResultManagementSystem.Models;

namespace StudentResultManagementSystem
{
    public partial class SubjectForm : Form
    {
        public SubjectForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=studentResult;User ID=us;Password=mypass;Encrypt=false");
        int snnn { get; set; }
        private void SubjectForm_Load(object sender, EventArgs e)
        {
            showSubjects();
        }

        private void showSubjects()
        {
            var tb = conn.Query<Subject>("select * from Subjects");
            gridViewSubF.DataSource = tb;
        }

        private void btnAddSubF_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtIDSubF.Text == string.Empty || txtIDSubF.Text == "0")
                {
                    MessageBox.Show("Invalid ID", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    var para = new { id = txtIDSubF.Text, name = txtNameSubF.Text };
                    conn.Query<Subject>("addSubject", para, commandType: System.Data.CommandType.StoredProcedure);
                    showSubjects();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnUpdateSubF_Click(object sender, EventArgs e)
        {
            try
            {
                if (snnn == 0 || txtIDSubF.Text == string.Empty)
                {
                    MessageBox.Show("Select record to update.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    conn.Query<Subject>("update Subjects set subject_id = @id, subject_name = @name where subject_id = @id2", new { id = txtIDSubF.Text, name = txtNameSubF.Text, id2 = snnn });
                    showSubjects();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Error", MessageBoxButtons.OK);
            }
        }

        private void gridViewSubF_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDSubF.Text = gridViewSubF.SelectedRows[0].Cells[0].Value.ToString();
            string idSubF = txtIDSubF.Text;
            txtNameSubF.Text = gridViewSubF.SelectedRows[0].Cells[1].Value.ToString();
            snnn = int.Parse(idSubF);
        }

        private void btnDelSubF_Click(object sender, EventArgs e)
        {
            try
            {
                if (snnn == 0 || txtIDSubF.Text == string.Empty)
                {
                    MessageBox.Show("Select record to delete.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    conn.Query<Subject>("delete from Subjects where subject_id = @id", new { id = snnn });
                    showSubjects();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnResetSubF_Click(object sender, EventArgs e)
        {
            snnn = 0;
            txtIDSubF.Text = string.Empty;
            txtNameSubF.Text= string.Empty;
        }
    }
}
