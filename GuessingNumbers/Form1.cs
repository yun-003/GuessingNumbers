using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingNumbers
{
    public partial class GuessingNumber : Form
    {
        public GuessingNumber()
        {
            InitializeComponent();
        }

        string num1, num2, num3, num4;
        int A = 0, B = 0;
        bool bg = false;


        private void button1_Click(object sender, EventArgs e)
        {
            string txt = input.Text;

            if(txt.Length == 4 && bg)
            {
                string n1 = txt.Substring(0, 1);
                string n2 = txt.Substring(1, 1);
                string n3 = txt.Substring(2, 1);
                string n4 = txt.Substring(3, 1);

                if(n1 == n2 || n1 == n3 || n2 == n4 || n2 == n3 || n2 == n4 || n3 == n4
                    || n1 == "0" || n2 == "0" || n3 == "0" || n4 == "0")
                    input.Text = "error";
                else
                {
                    // A
                    if (n1 == num1)
                        A++;
                    if (n2 == num2)
                        A++;
                    if (n3 == num3)
                        A++;
                    if (n4 == num4)
                        A++;

                    // B
                    if (n1 == num2 || n1 == num3 || n1 == num4)
                        B++;
                    if (n2 == num1 || n2 == num3 || n2 == num4)
                        B++;
                    if (n3 == num2 || n3 == num1 || n3 == num4)
                        B++;
                    if (n4 == num2 || n4 == num3 || n4 == num1)
                        B++;

                    if (output.Text == "")
                        output.Text = "  " + input.Text + "       " + "A:" + A + " \t" + "B:" + B + "\n";
                    else
                        output.Text += "  " + input.Text + "       " + "A:" + A + " \t" + "B:" + B + "\n";

                    //bg = false;

                    if (A == 4)
                        output.Text += "     " + "bingo！！！" + "     ";

                    A = 0;
                    B = 0;
                }
            }
            else
            {
                input.Text = "error";
            }
        }

        private void ans_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = "";
            num2 = "";
            num3 = "";
            num4 = "";
            A = 0;
            B = 0;
            input.Text = "";
            output.Text = "";
            ans.Text = "答案：";
            bg = false;
        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void output_Click(object sender, EventArgs e)
        {

        }

        private void begin_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            num1 = rd.Next(1, 10).ToString();
            num2 = rd.Next(1, 10).ToString();
            while(num1 == num2) 
                num2 = rd.Next(1, 10).ToString();
            num3 = rd.Next(1, 10).ToString();
            while(num1 == num2 || num2 == num3 || num1 == num3)
                num3 = rd.Next(1, 10).ToString();
            num4 = rd.Next(1, 10).ToString();
            while (num1 == num2 || num1 == num3 || num1 == num4 || num2 == num3
                || num2 == num4 || num3 == num4)
                num4 = rd.Next(1, 10).ToString();

            if(ans.Text == "答案：")
                ans.Text += num1 + num2 + num3 + num4;
            else
                ans.Text = "答案：" + num1 + num2 + num3 + num4;

            bg = true;
        }
    }
}
