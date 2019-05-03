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
    public partial class AddResult : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DQ8VIPT\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");
        public AddResult()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Class1.id != -1)
            {
                con.Open();
                string query = "UPDATE StudentResult set StudentId= '" + Convert.ToInt32(comboStudentId.SelectedValue) + "'," +
                    " AssessmentComponentId='" + Convert.ToInt32(comboAssessmentComponent.SelectedValue) + "', " +
                    "RubricMeasurementId='" + Convert.ToInt32(comboRubric.SelectedValue) + "' WHERE StudentId = '" + Class1.id + "'";

                SqlCommand sqlCmd = new SqlCommand(query, con);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Updataion Successful!");
                con.Close();
                Class1.id = -1;

            }
            else
            {
                con.Open();
                string query = "INSERT INTO StudentResult(StudentId,AssessmentComponentId,RubricMeasurementId, EvaluationDate) "
                    +"VALUES ('" + Convert.ToInt32(comboStudentId.SelectedValue) + "','" + Convert.ToInt32(comboAssessmentComponent.SelectedValue) + " '," +
                    " '" + Convert.ToInt32(comboRubric.SelectedValue) + " ', '" + Convert.ToDateTime(DateTime.Now) + "')";
                SqlCommand sqlCmd = new SqlCommand(query, con); //ProjectB.exe!ProjectB.Register_Student.button1_Click(object sender, System.EventArgs e) Line 32	C#
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Addition Successful!");
                con.Close();

            }
        }

        private void AddResult_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.RubricLevel' table. You can move, or remove it, as needed.
            this.rubricLevelTableAdapter.Fill(this.projectBDataSet.RubricLevel);
            // TODO: This line of code loads data into the 'projectBDataSet.AssessmentComponent' table. You can move, or remove it, as needed.
            this.assessmentComponentTableAdapter.Fill(this.projectBDataSet.AssessmentComponent);
            // TODO: This line of code loads data into the 'projectBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet.Student);
            if (Class1.id != -1)
            {
                SqlCommand sqlCommand = new SqlCommand("Select * from StudentResult where StudentId='" + Class1.id + "'", con);
                con.Open();
                SqlDataReader ss = sqlCommand.ExecuteReader();
                while (ss.Read())
                {
                    comboStudentId.SelectedValue = ss["StudentId"].ToString();
                    comboAssessmentComponent.SelectedValue = ss["AssessmentComponentId"].ToString();
                    comboRubric.SelectedValue = ss["RubricMeasurementId"].ToString();
                }
                ss.Close();
                con.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ManageResult manageResult = new ManageResult();
            manageResult.Show();

        }

        private void comboStudentId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
