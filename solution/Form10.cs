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
    public partial class Form10 : Form
    {
        SqlConnection con10 = new SqlConnection("Data source=DESKTOP-L70SR75; Initial Catalog=Students; Integrated Security=True");
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.ShowDialog();
            this.Close();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentsDataSet.course_late' table. You can move, or remove it, as needed.
            this.course_lateTableAdapter.Fill(this.studentsDataSet.course_late);

            try
            {
                con10.Open();
                SqlCommand sc = new SqlCommand("select (Student_Name) from student", con10);
                SqlDataReader reader10;
                reader10 = sc.ExecuteReader();
                DataTable dt10 = new DataTable();
                dt10.Columns.Add("Student_Name", typeof(string));
                dt10.Load(reader10);
                comboBox1.ValueMember = "Student_Name";
                comboBox1.DataSource = dt10;
                con10.Close();
            }
            catch (Exception)
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            courselateBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            courselateBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            courselateBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure want to remove this student?",
                                     "Drop from class",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                courselateBindingSource.RemoveCurrent();
                courselateBindingSource.EndEdit();
                course_lateTableAdapter.Update(studentsDataSet.course_late);
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
                courselateBindingSource.EndEdit();
                course_lateTableAdapter.Update(studentsDataSet.course_late);
            }
            else
            {
                //do nothing
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
