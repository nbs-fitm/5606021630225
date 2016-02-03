using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                             
            int point; //ประกาศตัวแปร point เป็นจำนวนเต็ม
               point=int.Parse(textBox1.Text);   //ให้ point มีค่าเท่ากับค่าที่เราจะกรอกบน textbox1

               if (point >= 80 && point <= 100)
               {
                   //ถ้าpoint มีค่า 80-100 
                   //ให้แสดงกล่องข้อความบอกว่าคุณได้เกรด Good
                   textBox2.Text = ("Good");
               }

               else if (point >= 60 && point <= 79)
               {
                   //ถ้าpoint มีค่า 80-100 
                   //ให้แสดงกล่องข้อความบอกว่าคุณได้เกรด Good
                   textBox2.Text = ("Pass");
               }

               else if (point >= 0 && point <= 59)
               {
                   //ถ้าpoint มีค่า 80-100 
                   //ให้แสดงกล่องข้อความบอกว่าคุณได้เกรด Good
                   textBox2.Text = ("Fail");
               }

               else textBox2.Text = ("Error"); 
       
       
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
