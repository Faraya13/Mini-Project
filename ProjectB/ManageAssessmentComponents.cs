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
    public partial class ManageAssessmentComponents : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DQ8VIPT\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");

        public ManageAssessmentComponents()
        {
            InitializeComponent();
        }

        private void ManageAssessmentComponents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.AssessmentComponent' table. You can move, or remove it, as needed.
            this.assessmentComponentTableAdapter.Fill(this.projectBDataSet.AssessmentComponent);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAssessmentComponent addAssessmentComponent = new AddAssessmentComponent();
            addAssessmentComponent.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 d = new Form1();
            this.Hide();
            d.Show();
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
                    SqlCommand cmd = new SqlCommand("DELETE FROM AssessmentComponent WHERE Id  = '" + clo_Id + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.assessmentComponentTableAdapter.Fill(this.projectBDataSet.AssessmentComponent);
                }
            }
        }
    }
}
