using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projectv44
{
    public partial class Form8 : Form
    {
        SqlConnection con8 = new SqlConnection("Data source=DESKTOP-L70SR75; Initial Catalog=Students; Integrated Security=True");
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentsDataSet.course_lane' table. You can move, or remove it, as needed.
            this.course_laneTableAdapter.Fill(this.studentsDataSet.course_lane);

            try
            {
                con8.Open();
                SqlCommand sc = new SqlCommand("select (Student_Name) from student", con8);
                SqlDataReader reader8;
                reader8 = sc.ExecuteReader();
                DataTable dt8 = new DataTable();
                dt8.Columns.Add("Student_Name", typeof(string));
                dt8.Load(reader8);
                comboBox1.ValueMember = "Student_Name";
                comboBox1.DataSource = dt8;
                con8.Close();
            }
            catch (Exception)
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to update this record?",
                                     "Add/Update record",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                courselaneBindingSource.EndEdit();
                course_laneTableAdapter.Update(studentsDataSet.course_lane);
            }
            else
            {
                //do nothing
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure want to remove this student?",
                                     "Drop from class",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                courselaneBindingSource.RemoveCurrent();
                courselaneBindingSource.EndEdit();
                course_laneTableAdapter.Update(studentsDataSet.course_lane);
            }
            else
            {
                //do nothing
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            courselaneBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            courselaneBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            courselaneBindingSource.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234")
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid Password", "Error");
            }
        }
    }
}
