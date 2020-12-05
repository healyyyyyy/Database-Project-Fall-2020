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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data source=DESKTOP-L70SR75; Initial Catalog=Students; Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentsDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentsDataSet.student);

            try
            {
                con.Open();
                SqlCommand sc = new SqlCommand("select (Student_Name) from student", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Student_Name", typeof(string));
                dt.Load(reader);
                DataTable dt2 = dt.Copy();
                allytext.ValueMember = "Student_Name";
                allytext.DataSource = dt;
                rivaltext.ValueMember = "Student_Name";
                rivaltext.DataSource = dt2;
                con.Close();
            }
            catch (Exception)
            {

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (namelabel.Enabled == false)
                namelabel.Enabled = true;
            nametext.Enabled = true;
            if (majorlabel.Enabled == false)
                majorbox.Enabled = true;
            majorlabel.Enabled = true;
            if (allylabel.Enabled == false)
                allytext.Enabled = true;
            allylabel.Enabled = true;
            if (rivallabel.Enabled == false)
                rivaltext.Enabled = true;
            rivallabel.Enabled = true;
            if (piclabel.Enabled == false)
                piclabel.Enabled = true;
            pictext.Enabled = true;
            if (textBox1.Enabled == false)
                textBox1.Enabled = true;
            label1.Enabled = true;
            if (button5.Enabled == false)
                button5.Enabled = true;

            studentBindingSource.AddNew();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to update this record?",
                                     "Add/Update record",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                studentBindingSource.EndEdit();
                studentTableAdapter.Update(studentsDataSet.student);
            }
            else
            {
                //do nothing
            }
            

            if (namelabel.Enabled == true)
            {
                namelabel.Enabled = false;
                nametext.Clear();
                nametext.Enabled = false;
            }
            if (majorlabel.Enabled == true)
            {
                majorbox.Enabled = false;
                majorbox.SelectedIndex = -1;
                majorlabel.Enabled = false;
            }
            if (allylabel.Enabled == true)
            {
                allytext.Enabled = false;
                allylabel.Enabled = false;
                allytext.ResetText();
            }
            if (rivallabel.Enabled == true)
            {
                rivaltext.Enabled = false;
                rivallabel.Enabled = false;
            }
            if (piclabel.Enabled == true)
            {
                piclabel.Enabled = false;
                pictext.Enabled = false;
                pictext.Clear();
            }

            if (textBox1.Enabled == true)
            {
                textBox1.Clear();
                textBox1.Enabled = false;
                label1.Enabled = false;
            }

            if (button5.Enabled == true)
                button5.Enabled = false;
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.ShowDialog();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void rivaltext_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictext.Text = openFileDialog1.FileName;
        }

        private void pictext_TextChanged(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(pictext.Text))
            {
                pictureBox1.Image = Image.FromFile(pictext.Text);
            }
            if (pictext.Text == "")
                pictureBox1.Hide();
            else
                pictureBox1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void nametext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
