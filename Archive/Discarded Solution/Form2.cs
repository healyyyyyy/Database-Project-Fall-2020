using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOTASchool
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentsBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox6.Text = openFileDialog1.FileName;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentsDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentsDataSet.Students);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentsBindingSource.EndEdit();
            studentsTableAdapter.Update(studentsDataSet.Students);
        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentsTableAdapter.Search(this.studentsDataSet.Students, param1ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            studentsTableAdapter.Search(studentsDataSet.Students, textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            studentsBindingSource.RemoveCurrent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            studentsBindingSource.MovePrevious();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            studentsBindingSource.MoveNext();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            studentsBindingSource.MoveFirst();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            studentsBindingSource.MoveLast();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(textBox6.Text))
            {
                pictureBox1.Image = Image.FromFile(textBox4.Text);
            }

        }
    }
}
