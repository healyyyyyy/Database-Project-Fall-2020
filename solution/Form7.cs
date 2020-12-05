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
    public partial class Form7 : Form
    {
        SqlConnection con7 = new SqlConnection("Data source=DESKTOP-L70SR75; Initial Catalog=Students; Integrated Security=True");
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentsDataSet.course_warding' table. You can move, or remove it, as needed.
            this.course_wardingTableAdapter.Fill(this.studentsDataSet.course_warding);

            try
            {
                con7.Open();
                SqlCommand sc = new SqlCommand("select (Student_Name) from student", con7);
                SqlDataReader reader7;
                reader7 = sc.ExecuteReader();
                DataTable dt7 = new DataTable();
                dt7.Columns.Add("Student_Name", typeof(string));
                dt7.Load(reader7);
                comboBox1.ValueMember = "Student_Name";
                comboBox1.DataSource = dt7;
                con7.Close();
            }
            catch (Exception)
            {

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            coursewardingBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coursewardingBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            coursewardingBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure want to remove this student?",
                                     "Drop from class",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                coursewardingBindingSource.RemoveCurrent();
                coursewardingBindingSource.EndEdit();
                course_wardingTableAdapter.Update(studentsDataSet.course_warding);
            }
            else
            {
                //do nothing
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to update this record?",
                                     "Add/Update record",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                coursewardingBindingSource.EndEdit();
                course_wardingTableAdapter.Update(studentsDataSet.course_warding);
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234")
            {
                button2.Enabled = true;
                button6.Enabled = true;
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
