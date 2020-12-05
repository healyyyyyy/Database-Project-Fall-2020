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
    public partial class Form5 : Form
    {
        SqlConnection con5 = new SqlConnection("Data source=DESKTOP-L70SR75; Initial Catalog=Students; Integrated Security=True");
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentsDataSet.course_ganking' table. You can move, or remove it, as needed.
            this.course_gankingTableAdapter.Fill(this.studentsDataSet.course_ganking);

            try
            {
                con5.Open();
                SqlCommand sc = new SqlCommand("select (Student_Name) from student", con5);
                SqlDataReader reader5;
                reader5 = sc.ExecuteReader();
                DataTable dt5 = new DataTable();
                dt5.Columns.Add("Student_Name", typeof(string));
                dt5.Load(reader5);
                comboBox1.ValueMember = "Student_Name";
                comboBox1.DataSource = dt5;
                con5.Close();
            }
            catch (Exception)
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to update this record?",
                                     "Add/Update record",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                coursegankingBindingSource.EndEdit();
                course_gankingTableAdapter.Update(studentsDataSet.course_ganking);
            }
            else
            {
                //do nothing
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            coursegankingBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            coursegankingBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            coursegankingBindingSource.MoveNext();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure want to remove this student?",
                                     "Drop from class",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                coursegankingBindingSource.RemoveCurrent();
                coursegankingBindingSource.EndEdit();
                course_gankingTableAdapter.Update(studentsDataSet.course_ganking);
            }
            else
            {
                //do nothing
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button5.Enabled = true;
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
