using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahteez_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int counter = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int check1 = 0;
            int check2 = 0;
            int check3 = 0;
            int check4 = 0;
            int check5 = 0;
            Random num = new Random();
            int[] pick5 = new int[5];
            

            if (textBox6.Text != "Held")
            {
                for (int n = 0; n < pick5.Length; n++)
                {
                    check1 = num.Next(1, 7);
                    while (!(pick5.Contains(check1)))
                    {
                        pick5[n] = check1;

                    }
                    textBox1.Text = (check1.ToString());
                }
            }
            if (textBox7.Text != "Held")
            {
                for (int n = 0; n < pick5.Length; n++)
                {
                    check2 = num.Next(1, 7);
                    while (!(pick5.Contains(check2)))
                    {
                        pick5[n] = check2;

                    }
                    textBox2.Text = (check2.ToString());
                }
            }
            if (textBox8.Text != "Held")
            {
                for (int n = 0; n < pick5.Length; n++)
                {
                    check3 = num.Next(1, 7);
                    while (!(pick5.Contains(check3)))
                    {
                        pick5[n] = check3;

                    }
                    textBox3.Text = (check3.ToString());
                }
            }
            if (textBox9.Text != "Held")
            {
                for (int n = 0; n < pick5.Length; n++)
                {
                    check4 = num.Next(1, 7);
                    while (!(pick5.Contains(check4)))
                    {
                        pick5[n] = check4;

                    }
                    textBox4.Text = (check4.ToString());
                }
            }
            if (textBox10.Text != "Held")
            {
                for (int n = 0; n < pick5.Length; n++)
                {
                    check5 = num.Next(1, 7);
                    while (!(pick5.Contains(check5)))
                    {
                        pick5[n] = check5;

                    }
                    textBox5.Text = (check5.ToString());
                }
            }
            counter++;
            if (counter == 3)
                button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "Held")
                textBox6.Text = "";
            else
                textBox6.Text = "Held";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "Held")
                textBox7.Text = "";
            else
                textBox7.Text = "Held";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "Held")
                textBox8.Text = "";
            else
                textBox8.Text = "Held";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox9.Text == "Held")
                textBox9.Text = "";
            else
                textBox9.Text = "Held";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "Held")
                textBox10.Text = "";
            else
                textBox10.Text = "Held";
        }
    }
}
