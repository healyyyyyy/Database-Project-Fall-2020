using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectv44
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you wish to log-out?",
                                     "Exit",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                this.Hide();
                f1.ShowDialog();
                this.Close();
            }
            else
            {
                //do nothing
            }
        }
    }
}
