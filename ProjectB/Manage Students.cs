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
    public partial class Manage_Students : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DQ8VIPT\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");
        //SqlCommand cmd;
        //SqlDataReader reader;
   


        public Manage_Students()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Edit")
            {
                Class1.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                this.Hide();
                Register_Student registerStudent = new Register_Student();
                registerStudent.Show();
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                int stdId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("Do you want to delete " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM Student WHERE Id  = '" + stdId + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    this.studentTableAdapter.Fill(this.projectBDataSet.Student);
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 d = new Form1();
            this.Hide();
            d.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Register_Student s = new Register_Student();
            this.Hide();
            s.Show();
        }

        private void Manage_Students_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet.Student);

        }
    }
}
