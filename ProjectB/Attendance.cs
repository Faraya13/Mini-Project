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
    public partial class Attendance : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DQ8VIPT\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");
        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select * from Student Where Status = 5";
            SqlCommand sqlCommand = new SqlCommand(query,con);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
