using System;
using System.Collections;
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
    public partial class Register_Student : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DQ8VIPT\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");
        public Register_Student()
        {
            InitializeComponent();
        }

        private void Register_Student_Load(object sender, EventArgs e)
        {
            button1.Text = "Register";
            if (Class1.id !=  -1)
            {
                button1.Text = "Edit";
                con.Open();
                string query = "Select * from Student WHERE Id=" + Class1.id;
                SqlCommand sqlCommand = new SqlCommand(query, con);
                SqlDataReader read = sqlCommand.ExecuteReader();
                while (read.Read())
                {
                    textBox1.Text = read["FirstName"].ToString();
                    textBox2.Text = read["LastName"].ToString();
                    textBox3.Text = read["Email"].ToString();
                    textBox4.Text = read["Contact"].ToString();
                    textBox5.Text = read["RegistrationNumber"].ToString();
                }
                con.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Class1.id != -1)
            {
                con.Open();
                string query = "UPDATE Student set FirstName= '" + textBox1.Text.ToString() + "' , LastName= '" + textBox2.Text.ToString() + "', Contact= '" + textBox3.Text.ToString() + "', Email= '" + textBox4.Text.ToString() + "', RegistrationNumber= '" + textBox5.Text.ToString() + "',Contact='"+textBox3.Text.ToString()+"',Status='"+Convert.ToInt32(textBox6.Text)+"' WHERE Id = '" + Class1.id + "'";

                SqlCommand sqlCmd = new SqlCommand(query, con); //ProjectB.exe!ProjectB.Register_Student.button1_Click(object sender, System.EventArgs e) Line 32	C#

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Updataion Successful!");
                con.Close();
                Class1.id = -1;

            }
            else
            {
                con.Open();
                string query = "INSERT INTO Student(FirstName, LastName, Contact, Email, RegistrationNumber, Status) VALUES ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + Convert.ToInt32(textBox6.Text) + "')";

                SqlCommand sqlCmd = new SqlCommand(query, con); //ProjectB.exe!ProjectB.Register_Student.button1_Click(object sender, System.EventArgs e) Line 32	C#

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successful!");
                con.Close();

            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Manage_Students ad = new Manage_Students();
            ad.Show();
        }
    }
}
