using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectv44
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inp = textbox1.Text;
            if (inp.IndexOf("T") == 0)
            {
                if (textbox2.Text == "1234")
                {
                    Form6 f6 = new Form6();
                    this.Hide();
                    f6.ShowDialog();
                    this.Close();
                }
            }
            else if (inp.IndexOf("S") == 0)
            {
                if (textbox2.Text == "asdf")
                {
                    Form11 f11 = new Form11();
                    this.Hide();
                    f11.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                string msg = "Invalid username/password combination";
                string title = "Error";
                MessageBox.Show(msg, title);
            }
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
