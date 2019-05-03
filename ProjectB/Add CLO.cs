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
    public partial class Add_CLO : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DQ8VIPT\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");

        public Add_CLO()
        {
            InitializeComponent();
        }

        private void Add_CLO_Load(object sender, EventArgs e)
        {
            btnAddCLO.Text = "Add";
            if (Class1.id != -1)
            {
                btnAddCLO.Text = "Edit";
                con.Open();
                string query = "Select * from Clo WHERE Id=" + Class1.id;
                SqlCommand sqlCommand = new SqlCommand(query, con);
                SqlDataReader read = sqlCommand.ExecuteReader();
                while (read.Read())
                {
                    //txtCLOName.Text = read["CLO Name"].ToString();


                }
                con.Close();
            }
        }


        private void btnAddCLO_Click(object sender, EventArgs e)
            {
                if (Class1.id != -1)
                {
                    con.Open();
                    string query = "UPDATE Clo set Name= '" + txtCLOName.Text.ToString() + "' , DateCreated= '" + DateTime.Now + "', DateUpdated= '" + DateTime.Now + "' WHERE Id = '" + Class1.id + "'";

                    SqlCommand sqlCmd = new SqlCommand(query, con); //ProjectB.exe!ProjectB.Register_Student.button1_Click(object sender, System.EventArgs e) Line 32	C#

                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Updataion Successful!");
                    con.Close();
                    Class1.id = -1;

                }
                else
                {
                    con.Open();
                    string query = "INSERT INTO Clo(Name, DateCreated, DateUpdated) VALUES ('" + txtCLOName.Text.ToString() + "','" + DateTime.Now + "','" + DateTime.Now + "')";

                    SqlCommand sqlCmd = new SqlCommand(query, con); //ProjectB.exe!ProjectB.Register_Student.button1_Click(object sender, System.EventArgs e) Line 32	C#

                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Addition of CLO Successful!");
                    con.Close();

                }


            }

            private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                Manage_CLOs i = new Manage_CLOs();
                this.Hide();
                i.Show();
            }

        private void txtCLOName_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
