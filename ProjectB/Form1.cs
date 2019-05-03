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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DQ8VIPT\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

       
            Manage_Students frm = new Manage_Students();
            this.Hide();
            frm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage_CLOs fr = new Manage_CLOs();
            this.Hide();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manage_Rubric f = new Manage_Rubric();
            this.Hide();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_Rubric_Level manage_Rubric_Level = new Manage_Rubric_Level();
            manage_Rubric_Level.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageAssessments manageAssessments = new ManageAssessments();
            manageAssessments.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageAssessmentComponents manageAssessmentComponents = new ManageAssessmentComponents();
            manageAssessmentComponents.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageResult manageResult = new ManageResult();
            manageResult.Show();
            
        }
    }
}
