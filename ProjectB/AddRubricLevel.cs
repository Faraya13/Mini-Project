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
    public partial class AddRubricLevel : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DQ8VIPT\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");

        public AddRubricLevel()
        {
            InitializeComponent();
        }

        private void AddRubricLevel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet.Rubric);

        }

        private void btnAddRubricLevel_Click(object sender, EventArgs e)
        {
            if (Class1.id != -1)
            {
                con.Open();
                string query = "UPDATE RubricLevel set Details= '" + txtDetails.Text.ToString() + "', RubricId='" + Convert.ToInt32(comboBox1.SelectedValue) + "',MeasurementLevel='" + Convert.ToInt32(txtMeasurement.Text) + "' WHERE Id='" + Class1.id + "'";
                SqlCommand sqlCmd = new SqlCommand(query, con);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Updataion Successful!");
                con.Close();
                Class1.id = -1;

            }
            else
            {
                string query = "Insert into RubricLevel(RubricId,Details,MeasurementLevel) Values('" + Convert.ToInt32(comboBox1.SelectedValue) + "','" + txtDetails.Text.ToString() + "','" + Convert.ToInt32(txtMeasurement.Text) + "')";
                con.Open();
                //string query = "INSERT INTO RubricLevel(RubricId,Details, MeasurementLevel) VALUES ('" + Convert.ToInt32(comboBox1.SelectedValue.ToString()) + "','" + txtDetails.Text.ToString() + "','" + Convert.ToInt32(txtMeasurement.Text) + "')";
                SqlCommand sqlCmd = new SqlCommand(query, con);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Addition of Rubric Successful!");
                con.Close();

            }
        }

        private void txtMeasurement_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (txtMeasurement.Text == "")
            {

            }
            else if(!(int.TryParse(txtMeasurement.Text,out n)))
            {
                txtMeasurement.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Manage_Rubric_Level manage_Rubric_Level = new Manage_Rubric_Level();
            manage_Rubric_Level.Show();
        }
    }
}
