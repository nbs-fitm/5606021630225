using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String day;
            day = textBox1.Text;

            switch (day) {

                case "จันทร์":
                    MessageBox.Show("วันนี้วัน "+day+" สีเหลือง");
                    this.BackColor = Color.Yellow;
                    break;
                case "อังคาร":
                    MessageBox.Show("วันนี้วัน " + day + " สีชมพู");
                    this.BackColor = Color.Pink;
                    break;
                case "พุธ":
                    MessageBox.Show("วันนี้วัน " + day + " สีเขียว");
                    this.BackColor = Color.Green;
                    break;
                case "พฤหัสษดี":
                    MessageBox.Show("วันนี้วัน " + day + " สีส้ม");
                    this.BackColor = Color.Orange;
                    break;
                case "ศุกร์":
                    MessageBox.Show("วันนี้วัน " + day + " สีฟ้า");
                    this.BackColor = Color.Blue;
                    break;
                case "เสาร์":
                    MessageBox.Show("วันนี้วัน " + day + " สีม่วง");
                    this.BackColor = Color.Purple;
                    break;
                case "อาทิตย์":
                    MessageBox.Show("วันนี้วัน " + day + " สีแดง");
                    this.BackColor = Color.Red;
                    break;

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
