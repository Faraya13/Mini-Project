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
    public partial class AddAssessments : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DQ8VIPT\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");

        public AddAssessments()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ManageAssessments manageAssessments = new ManageAssessments();
            manageAssessments.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Class1.id != -1)
            {
                con.Open();
                string query = "UPDATE Assessment set Title= '" + textBox1.Text.ToString() + "', DateCreated= '" + DateTime.Now + "' ,TotalMarks='" + Convert.ToInt32(textBox2.Text) + "', TotalWeightage='" + Convert.ToInt32(textBox3.Text) + "' WHERE Id = '" + Class1.id + "'";

                SqlCommand sqlCmd = new SqlCommand(query, con); //ProjectB.exe!ProjectB.Register_Student.button1_Click(object sender, System.EventArgs e) Line 32	C#

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Updataion Successful!");
                con.Close();
                Class1.id = -1;

            }
            else
            {
                con.Open();
                string query = "INSERT INTO Assessment(Title,DateCreated, TotalMarks, TotalWeightage) VALUES ('" + textBox1.Text.ToString() + "', '" + DateTime.Now + "','" + Convert.ToInt32(textBox2.Text) + "','" + Convert.ToInt32(textBox2.Text) + " ')";

                SqlCommand sqlCmd = new SqlCommand(query, con); //ProjectB.exe!ProjectB.Register_Student.button1_Click(object sender, System.EventArgs e) Line 32	C#

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Addition Successful!");
                con.Close();

            }
        }

        private void AddAssessments_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
