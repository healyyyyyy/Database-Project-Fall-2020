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
    public partial class Form3 : Form
    {
        SqlConnection con2 = new SqlConnection("Data source=DESKTOP-L70SR75; Initial Catalog=Students; Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentsDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentsDataSet.student);

            try
            {
                con2.Open();
                SqlCommand sc = new SqlCommand("select (Student_Name) from student", con2);
                SqlDataReader reader2;
                reader2 = sc.ExecuteReader();
                DataTable dt3 = new DataTable();
                dt3.Columns.Add("Student_Name", typeof(string));
                dt3.Load(reader2);
                DataTable dt4 = dt3.Copy();
                comboBox1.ValueMember = "Student_Name";
                comboBox1.DataSource = dt3;
                comboBox2.ValueMember = "Student_Name";
                comboBox2.DataSource = dt4;
                con2.Close();
            }
            catch (Exception)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            studentBindingSource.MoveNext();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            studentBindingSource.EndEdit();
            studentTableAdapter.Update(studentsDataSet.student);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            studentTableAdapter.Search(studentsDataSet.student, textBox7.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            studentBindingSource.RemoveCurrent();
            studentBindingSource.EndEdit();
            studentTableAdapter.Update(studentsDataSet.student);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            studentBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            studentBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            studentBindingSource.MoveLast();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(textBox6.Text))
            {
                pictureBox1.Image = Image.FromFile(textBox6.Text);
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox6.Text = openFileDialog1.FileName;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentTableAdapter.Search(this.studentsDataSet.student, param1ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
