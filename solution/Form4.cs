using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectv44
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            this.Hide();
            f7.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            this.Hide();
            f8.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            this.Hide();
            f9.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            this.Hide();
            f10.ShowDialog();
            this.Close();
        }
    }
}
