using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProjectB
{
    public partial class ManageAssessments : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DQ8VIPT\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");

        public ManageAssessments()
        {
            InitializeComponent();
        }

        private void ManageAssessments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter.Fill(this.projectBDataSet.Assessment);

        }

        private void btnAddRubric_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAssessments addAssessments = new AddAssessments();
            addAssessments.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Edit")
            {

                Class1.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                this.Hide();
                AddAssessments registerStudent = new AddAssessments();
                registerStudent.Show();
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {

                int clo_Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("Do you want to delete " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM AssessmentComponent WHERE AssessmentId  = '" + clo_Id + "'", con);
                    cmd.ExecuteNonQuery();
                    SqlCommand command = new SqlCommand("DELETE FROM Assessment WHERE Id  = '" + clo_Id + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    this.assessmentTableAdapter.Fill(this.projectBDataSet.Assessment);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 d = new Form1();
            this.Hide();
            d.Show();
        }
    }
}
