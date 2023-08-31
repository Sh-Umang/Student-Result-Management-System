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
using System.Security.Cryptography;

namespace StudentResultManagementSystem
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=studentResult;User ID=us;Password=mypass;Encrypt=false");
        private void ResultForm_Load(object sender, EventArgs e)
        {
            showResults();
        }

        private void showResults()
        {
            conn.Query<Result>("updateresult", commandType: System.Data.CommandType.StoredProcedure);
            var tb = conn.Query<Result>("show_results", commandType: System.Data.CommandType.StoredProcedure);
            gridViewRF.DataSource = tb;
        }

        private void btnAddRF_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtTheoryRF.Text) < 0 || int.Parse(txtTheoryRF.Text) > 60)
                {
                    MessageBox.Show("Theory Marks is invalid.", "Error", MessageBoxButtons.OK);
                }
                else if ( int.Parse(txtAssignRF.Text)<0 || int.Parse(txtAssignRF.Text) > 20 || int.Parse(txtPracticalRF.Text) < 0 || int.Parse(txtPracticalRF.Text) > 20)
                {
                    MessageBox.Show("Internal Marks or Practical Marks is invalid.","Error", MessageBoxButtons.OK);
                }
                else
                {
                    var para = new { sid = txtSNRF.Text, @subid = txtSubIDRF.Text, @tm = txtTheoryRF.Text, @am = txtAssignRF.Text, @pm = txtPracticalRF.Text, r = "", t = "" };
                    conn.Query<Result>("addResult", para, commandType: System.Data.CommandType.StoredProcedure);
                    showResults();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
