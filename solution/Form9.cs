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
    public partial class Form9 : Form
    {
        SqlConnection con9 = new SqlConnection("Data source=DESKTOP-L70SR75; Initial Catalog=Students; Integrated Security=True");
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentsDataSet.course_mid' table. You can move, or remove it, as needed.
            this.course_midTableAdapter.Fill(this.studentsDataSet.course_mid);

            try
            {
                con9.Open();
                SqlCommand sc = new SqlCommand("select (Student_Name) from student", con9);
                SqlDataReader reader9;
                reader9 = sc.ExecuteReader();
                DataTable dt9 = new DataTable();
                dt9.Columns.Add("Student_Name", typeof(string));
                dt9.Load(reader9);
                comboBox1.ValueMember = "Student_Name";
                comboBox1.DataSource = dt9;
                con9.Close();
            }
            catch (Exception)
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            coursemidBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            coursemidBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            coursemidBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure want to remove this student?",
                                     "Drop from class",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                coursemidBindingSource.RemoveCurrent();
                coursemidBindingSource.EndEdit();
                course_midTableAdapter.Update(studentsDataSet.course_mid);
            }
            else
            {
                //do nothing
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to update this record?",
                                     "Add/Update record",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                coursemidBindingSource.EndEdit();
                course_midTableAdapter.Update(studentsDataSet.course_mid);
            }
            else
            {
                //do nothing
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
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
