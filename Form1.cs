using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        double x, y;
        string z;
        public static double sayi = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            textBox1.ResetText();
            z = "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            if (z == "+")
            {
                y = Convert.ToInt32(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = Convert.ToString(x + y);
            }
            if (z == "-")
            {
                y = Convert.ToInt32(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = Convert.ToString(x - y);
            }
            if (z == "*")
            {
                y = Convert.ToInt32(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = Convert.ToString(x * y);
            }
            if (z == "/")
            {
                y = Convert.ToInt32(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = Convert.ToString(x / y);
            }
            if (z == "usth")
            {
                y = Convert.ToInt32(textBox1.Text);
                textBox1.ResetText();
                textBox1.Text = Convert.ToString(Math.Pow(x, y));
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            textBox1.ResetText();
            z = "-";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                x = Convert.ToInt32(textBox1.Text);
                textBox1.ResetText();
                z = ("*");
            }
           
        }

        private void button20_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            textBox1.ResetText();
            z = "/";
        }
    

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        

        public Form1()
        {
            InitializeComponent();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[0-9]"))
            {
                textBox1.Text = "";
                label1.Text = "lütfen sayı giriniz";
            }
            else
            {
                label1.Text = "";
            }
        }

    }
}
