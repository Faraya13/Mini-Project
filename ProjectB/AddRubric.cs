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
    public partial class AddRubric : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DQ8VIPT\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");
        public AddRubric()
        {
            InitializeComponent();
        }

        private void AddRubric_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter.Fill(this.projectBDataSet.Clo);
            btnAddRubric.Text = "Add";
            if (Class1.id != -1)
            {
                btnAddRubric.Text = "Edit";
                con.Open();
                string query = "Select * from Rubric WHERE Id=" + Class1.id;
                SqlCommand sqlCommand = new SqlCommand(query, con);
                SqlDataReader read = sqlCommand.ExecuteReader();
                while (read.Read())
                {
                    //txtCLOName.Text = read["CLO Name"].ToString();


                }
                con.Close();
            }
        }

        private void btnAddRubric_Click(object sender, EventArgs e)
        {
            if (Class1.id != -1)
            {
                con.Open();
                string query = "UPDATE Rubric set Details= '" + txtdetails.Text.ToString() + "',CloId='"+ Convert.ToInt32(comboCloId.SelectedValue) + "' ";
                SqlCommand sqlCmd = new SqlCommand(query, con); 
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Updataion Successful!");
                con.Close();
                Class1.id = -1;
            }
            else
            {
                con.Open();
                string query = "INSERT INTO Rubric(Details, CloId) VALUES ('" + txtdetails.Text.ToString() + "','" + Convert.ToInt32(comboCloId.SelectedValue) + "')";
                SqlCommand sqlCmd = new SqlCommand(query, con);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Addition of Rubric Successful!");
                con.Close();

            }
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Manage_Rubric f = new Manage_Rubric();
            this.Hide();
            f.Show();
        }
    }
}
