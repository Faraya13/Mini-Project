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
    public partial class Manage_Rubric_Level : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DQ8VIPT\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");

        public Manage_Rubric_Level()
        {
            InitializeComponent();
        }

        private void Manage_Rubric_Level_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.RubricLevel' table. You can move, or remove it, as needed.
            this.rubricLevelTableAdapter.Fill(this.projectBDataSet.RubricLevel);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void btnAddRubricLevel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRubricLevel addRubricLevel = new AddRubricLevel();
            addRubricLevel.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Edit")
            {
                Class1.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                this.Hide();
                AddRubricLevel add_Rubric_Level = new AddRubricLevel();
                add_Rubric_Level.Show();
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                int stdId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("Do you want to delete " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM RubricLevel WHERE Id  = '" + stdId + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    this.rubricLevelTableAdapter.Fill(this.projectBDataSet.RubricLevel);
                }
            }
        }
    }
}
