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

namespace ProjectB
{
    public partial class AddAssessmentComponent : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DQ8VIPT\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");

        public AddAssessmentComponent()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ManageAssessmentComponents manageAssessmentComponents = new ManageAssessmentComponents();
            manageAssessmentComponents.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Class1.id != -1)
            {
                con.Open();
                string query = "UPDATE AssessmentComponent set Name= '" + textBox1.Text.ToString() + "', RubricId='" + Convert.ToInt32(comboRubricId.SelectedValue) + "', TotalMarks='" + Convert.ToInt32(textBox3.Text) + "', DateCreated= '" + DateTime.Now + "' , DateUpdated= '" + DateTime.Now + "' ,AssessmentId='" + Convert.ToInt32(comboAssessmentId.SelectedValue) + "' WHERE Id = '" + Class1.id + "'";

                SqlCommand sqlCmd = new SqlCommand(query, con); //ProjectB.exe!ProjectB.Register_Student.button1_Click(object sender, System.EventArgs e) Line 32	C#

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Updataion Successful!");
                con.Close();
                Class1.id = -1;

            }
            else
            {
                con.Open();
                string q= "Insert into AssessmentComponent(Name, TotalMarks, AssessmentId, RubricId) " +
                    "Values('" + textBox1.Text.ToString() + "'," +
                    "'" + Convert.ToInt32(textBox3.Text) + "','" + Convert.ToInt32(comboAssessmentId.SelectedValue) + "','" + Convert.ToInt32(comboRubricId.SelectedValue) + "')";
                string query = "INSERT INTO AssessmentComponent(Name,RubricId, TotalMarks, DateCreated, DateUpdated, AssessmentId) " +
                    "VALUES ('" + textBox1.Text.ToString() + "','" + Convert.ToInt32(comboRubricId.SelectedValue) + " ', '" + Convert.ToInt32(textBox3.Text) + " ', '" + DateTime.Now + "', '" + DateTime.Now + " ', '" + Convert.ToInt32(comboAssessmentId.SelectedValue) + "')";

                SqlCommand sqlCmd = new SqlCommand(q, con); //ProjectB.exe!ProjectB.Register_Student.button1_Click(object sender, System.EventArgs e) Line 32	C#

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Addition Successful!");
                con.Close();

            }
        }

        private void AddAssessmentComponent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter.Fill(this.projectBDataSet.Assessment);
            // TODO: This line of code loads data into the 'projectBDataSet.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet.Rubric);
            if (Class1.id!=-1)
            {
                SqlCommand sqlCommand = new SqlCommand("Select * from AssessmentComponent where Id='" + Class1.id + "'", con);
                con.Open();
                SqlDataReader ss = sqlCommand.ExecuteReader();
                while (ss.Read())
                {
                    textBox1.Text=ss["Name"].ToString();
                    textBox3.Text=ss["TotalMarks"].ToString();
                    comboAssessmentId.SelectedValue = ss["AssessmentId"].ToString();
                    comboRubricId.SelectedValue = ss["RubricId"].ToString();
                }
                ss.Close();
                con.Close();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch!=8)
            {
                e.Handled = true;
            }
        }
    }
}
