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

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ProjectB
{
    public partial class ManageResult : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DQ8VIPT\\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");

        public ManageResult()
        {
            InitializeComponent();
        }

        private void ManageResult_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet.StudentResult' table. You can move, or remove it, as needed.
            this.studentResultTableAdapter.Fill(this.projectBDataSet.StudentResult);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Class1.id.ToString());
            this.Hide();
            AddResult addResult = new AddResult();
            addResult.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Edit")
            {

                Class1.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                this.Hide();
                AddResult registerStudent = new AddResult();
                registerStudent.Show();
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {

                int clo_Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("Do you want to delete " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM StudentResult WHERE StudentId  = '" + clo_Id + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.studentResultTableAdapter.Fill(this.projectBDataSet.StudentResult);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                int assessmentComponentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
                int RubeicMeasurementId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
                string query = "Select Student.RegistrationNumber as Registration, CONCAT(Student.FirstName,' ', Student.LastName) as Name," +
                         " AssessmentComponent.Name as ComponentName, AssessmentComponent.TotalMarks as TotalMarks," +
                         " RubricLevel.Details as RubricDetails,RubricLevel.MeasurementLevel as MeasurementLevel,RubricLevel.RubricId as RubricId" +
                         " from Student JOIN StudentResult ON StudentResult.StudentId=Student.Id JOIN AssessmentComponent ON " +
                         "StudentResult.AssessmentComponentId=AssessmentComponent.Id Join RubricLevel ON StudentResult.RubricMeasurementId=RubricLevel.Id WHERE " +
                         "StudentResult.StudentId='" + Convert.ToInt32(studentId) + "' AND StudentResult.AssessmentComponentId='" + Convert.ToInt32(assessmentComponentId) + "' AND " +
                         "StudentResult.RubricMeasurementId='" + Convert.ToInt32(RubeicMeasurementId) + "'";
                SqlCommand command = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                string Name = "", Reg = "", Component = "", Rubric = "", MeasurementLevel = "";
                int Total = 0;
                int rb_Id = 0;
                while (reader.Read())
                {
                    Name = reader["Name"].ToString();
                    Reg = reader["Registration"].ToString();
                    Total = Convert.ToInt32(reader["TotalMarks"]);
                    Component = reader["ComponentName"].ToString();
                    Rubric = reader["RubricDetails"].ToString();
                    MeasurementLevel = reader["MeasurementLevel"].ToString();
                    rb_Id = Convert.ToInt32(reader["RubricId"]);
                }
                reader.Close();
                int ab = -1;
                SqlCommand q = new SqlCommand("Select MAX(MeasurementLevel) as MeasurementLevel From RubricLevel Where RubricId='" + Convert.ToInt32(rb_Id) + "'", con);
                SqlDataReader dataReader = q.ExecuteReader();
                while (dataReader.Read())
                {
                    ab = Convert.ToInt32(dataReader["MeasurementLevel"]);
                }
                dataReader.Close();
                Document document = new Document(iTextSharp.text.PageSize.LETTER, 10, 20, 42, 35);
                PdfWriter pdfWriter = PdfWriter.GetInstance(document, new FileStream(Reg + ".pdf", FileMode.Create));
                document.Open();
                Paragraph para = new Paragraph("Name: " + Name.ToString() + "\n\n Registration Number: " + Reg + "\n\n");
                PdfPTable table = new PdfPTable(5);
                string[] list = { "Component", "Rubric", "Component Marks", "Student Rubric Level", "Obtained Marks" };
                for (int i = 0; i < 5; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(list[i]));
                    cell.Colspan = 1;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                float obtain = (Convert.ToInt32(MeasurementLevel) / ab) * Total;
                string[] data = { Component, Rubric, Total.ToString(), MeasurementLevel, obtain.ToString() };
                for (int i = 0; i < 5; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(data[i]));
                    cell.Colspan = 1;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }
                document.Add(para);
                document.Add(table);
                document.Close();
                MessageBox.Show("Result generated!");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
