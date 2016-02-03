using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int t1=int.Parse(textBox1.Text);

            int r, c; // r - row, c - column

            for (r = 1; r <=t1; r++)
            {                
                  
                for (c = 1; c <=t1; c++)
                {

                    textBox2.Text += c.ToString();
                }
                textBox2.Text += "\r\n";    
            }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int t1 = int.Parse(textBox1.Text);

            int r, c; // r - row, c - column

            for (r = 1; r <= t1; r++)
            {

                for (c = 1; c <= r; c++)
                {

                    textBox2.Text += c.ToString();
                }
                textBox2.Text += "\r\n";
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int t1 = int.Parse(textBox1.Text);

            int r, c; // r - row, c - column

            for (r = t1; r >=1 ; r--)
            {

                for (c = 1; c <= r ; c++)
                {

                    textBox2.Text += c.ToString();
                }
                textBox2.Text += "\r\n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
                
        } 

        
    }
}
