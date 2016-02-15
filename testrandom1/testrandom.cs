/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 15/2/2559
 * Time: 9:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace testrandom
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
	
		//TextBox[,] point = new TextBox[2,2];

		
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
				
			  double[] score = new double[10];
            String result = "";
            string grade = "";
            int count = 1;

            score[0] = double.Parse(textBox60.Text);
            score[1] = double.Parse(textBox59.Text);
            score[2] = double.Parse(textBox58.Text);
            score[3] = double.Parse(textBox57.Text);
            score[4] = double.Parse(textBox56.Text);
            score[5] = double.Parse(textBox55.Text);
            score[6] = double.Parse(textBox54.Text);
            score[7] = double.Parse(textBox53.Text);
            score[8] = double.Parse(textBox52.Text);
            score[9] = double.Parse(textBox51.Text);

            foreach (double s in score)
            {
                if (s >= 80 && s <= 100)
                {
                    grade = "A";
                }
                else if (s >= 75 && s <= 79)
                {
                    grade = "B+";
                }
                else if (s >= 70 && s <= 74)
                {
                    grade = "B";
                }
                else if (s >= 65 && s <= 69)
                {
                    grade = "C+";
                }
                else if (s >= 60 && s <= 64)
                {
                    grade = "C";
                }
                else if (s >= 55 && s <= 59)
                {
                    grade = "D+";
                }
                else if (s >= 50 && s <= 54)
                {
                    grade = "D";
                }
                else if (s >= 0 && s <= 49)
                {
                    grade = "F";
                }
                result += "คนที่ " + count + " ได้เกรด " + grade.ToString() + "\r\n";

                count++;
            }


			
            MessageBox.Show(result);
		}
		void Label16Click(object sender, EventArgs e)
		{
	
		}

		void Button2Click(object sender, EventArgs e)
		{
            TextBox[] boxes1 = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10 };
            TextBox[] boxes2 = { textBox11, textBox12, textBox13, textBox14, textBox15, textBox16, textBox17, textBox18, textBox19, textBox20 };
            TextBox[] boxes3 = { textBox21, textBox22, textBox23, textBox24, textBox25, textBox26, textBox27, textBox28, textBox29, textBox30 };
            TextBox[] boxes4 = { textBox31, textBox32, textBox33, textBox34, textBox35, textBox36, textBox37, textBox38, textBox39, textBox40 };
            TextBox[] boxes5 = { textBox41, textBox42, textBox43, textBox44, textBox45, textBox46, textBox47, textBox48, textBox49, textBox50 };
            TextBox[] boxes6 = { textBox51, textBox52, textBox53, textBox54, textBox55, textBox56, textBox57, textBox58, textBox59, textBox60 };

            Random ran = new Random();
            double r1;

            foreach (var tb in boxes1)
            {
                r1 = ran.NextDouble() * (15 - 0) + 0; //random 0 - 15  (*(max-min)+min)
                string str = String.Format("{0:F2}", r1);
                tb.Text = str;
            }

            foreach (var tb in boxes2)
            {
                r1 = ran.NextDouble() * (5 - 0) + 0; //random 0 - 5  (*(max-min)+min)
                string str = String.Format("{0:F2}", r1);
                tb.Text = str;
            }

            foreach (var tb in boxes3)
            {
                r1 = ran.NextDouble() * (15 - 0) + 0; //random 0 - 15  (*(max-min)+min)
                string str = String.Format("{0:F2}", r1);
                tb.Text = str;
            }

            foreach (var tb in boxes4)
            {
                r1 = ran.NextDouble() * (30 - 0) + 0; //random 0 - 30  (*(max-min)+min)
                string str = String.Format("{0:F2}", r1);
                tb.Text = str;
            }

            foreach (var tb in boxes5)
            {
                r1 = ran.NextDouble() * (35 - 0) + 0; //random 0 - 35  (*(max-min)+min)
                string str = String.Format("{0:F2}", r1);
                tb.Text = str;
            }

            // คนที่ 1
            double total1 = double.Parse(textBox1.Text);
            double total11 = double.Parse(textBox11.Text);
            double total21 = double.Parse(textBox21.Text);
            double total31 = double.Parse(textBox31.Text);
            double total41 = double.Parse(textBox41.Text);

            double t1 = total1 + total11 + total21 + total31 + total41;
            textBox51.Text = t1.ToString();
            //-----------------------------------------------------------

            // คนที่ 2
            double total2 = double.Parse(textBox2.Text);
            double total12 = double.Parse(textBox12.Text);
            double total22 = double.Parse(textBox22.Text);
            double total32 = double.Parse(textBox32.Text);
            double total42 = double.Parse(textBox42.Text);

            double t2 = total2 + total12 + total22 + total32 + total42;
            textBox52.Text = t2.ToString();
            //-----------------------------------------------------------

            // คนที่ 3
            double total3 = double.Parse(textBox3.Text);
            double total13 = double.Parse(textBox13.Text);
            double total23 = double.Parse(textBox23.Text);
            double total33 = double.Parse(textBox33.Text);
            double total43 = double.Parse(textBox43.Text);

            double t3 = total3 + total13 + total23 + total33 + total43;
            textBox53.Text = t3.ToString();
            //-----------------------------------------------------------

            // คนที่ 4
            double total4 = double.Parse(textBox4.Text);
            double total14 = double.Parse(textBox14.Text);
            double total24 = double.Parse(textBox24.Text);
            double total34 = double.Parse(textBox34.Text);
            double total44 = double.Parse(textBox44.Text);

            double t4 = total4 + total14 + total24 + total34 + total44;
            textBox54.Text = t4.ToString();
            //-----------------------------------------------------------

            // คนที่ 5
            double total5 = double.Parse(textBox5.Text);
            double total15 = double.Parse(textBox15.Text);
            double total25 = double.Parse(textBox25.Text);
            double total35 = double.Parse(textBox35.Text);
            double total45 = double.Parse(textBox45.Text);

            double t5 = total5 + total15 + total25 + total35 + total45;
            textBox55.Text = t5.ToString();
            //-----------------------------------------------------------

            // คนที่ 6
            double total6 = double.Parse(textBox6.Text);
            double total16 = double.Parse(textBox16.Text);
            double total26 = double.Parse(textBox26.Text);
            double total36 = double.Parse(textBox36.Text);
            double total46 = double.Parse(textBox46.Text);

            double t6 = total6 + total16 + total26 + total36 + total46;
            textBox56.Text = t6.ToString();
            //-----------------------------------------------------------

            // คนที่ 7
            double total7 = double.Parse(textBox7.Text);
            double total17 = double.Parse(textBox17.Text);
            double total27 = double.Parse(textBox27.Text);
            double total37 = double.Parse(textBox37.Text);
            double total47 = double.Parse(textBox47.Text);

            double t7 = total7 + total17 + total27 + total37 + total47;
            textBox57.Text = t7.ToString();
            //-----------------------------------------------------------

            // คนที่ 8
            double total8 = double.Parse(textBox8.Text);
            double total18 = double.Parse(textBox18.Text);
            double total28 = double.Parse(textBox28.Text);
            double total38 = double.Parse(textBox38.Text);
            double total48 = double.Parse(textBox48.Text);

            double t8 = total8 + total18 + total28 + total38 + total48;
            textBox58.Text = t8.ToString();
            //-----------------------------------------------------------

            // คนที่ 9
            double total9 = double.Parse(textBox9.Text);
            double total19 = double.Parse(textBox19.Text);
            double total29 = double.Parse(textBox29.Text);
            double total39 = double.Parse(textBox39.Text);
            double total49 = double.Parse(textBox49.Text);

            double t9 = total9 + total19 + total29 + total39 + total49;
            textBox59.Text = t9.ToString();
            //-----------------------------------------------------------

            // คนที่ 10
            double total10 = double.Parse(textBox10.Text);
            double total20 = double.Parse(textBox20.Text);
            double total30 = double.Parse(textBox30.Text);
            double total40 = double.Parse(textBox40.Text);
            double total50 = double.Parse(textBox50.Text);

            double t10 = total10 + total20 + total30 + total40 + total50;
            textBox60.Text = t10.ToString();
			
			
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		
	}
}
