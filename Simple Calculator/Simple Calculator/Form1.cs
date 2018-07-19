using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        String optr;
        decimal tb;
        decimal tb1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tb = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = " ";
            optr = "+";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.Font = new Font("Times New Roman",28);
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.Text = "0";
            this.button1.Text = "7";
            this.button2.Text = "8";
            this.button3.Text = "9";
            this.button4.Text = "4";
            this.button5.Text = "5";
            this.button6.Text = "6";
            this.button7.Text = "1";
            this.button8.Text = "2";
            this.button9.Text = "3";
            this.button10.Text = "0";
            this.button11.Text = ".";
            this.button12.Text = "C";
            this.button13.Text = "+";
            this.button14.Text = "-";
            this.button15.Text = "*";
            this.button16.Text = "/";
            this.button17.Text = "=";
            this.textBox1.ReadOnly = true;
            this.textBox1.MaxLength = 10;
            this.Text = "Simple Calculator";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.textBox1.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.textBox1.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            this.textBox1.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            this.textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            this.textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            this.textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            this.textBox1.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            this.textBox1.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
            this.textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (this.textBox1.Text.Contains(".") == false)
            {
                this.textBox1.Text += ".";

            }
            
            
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
           
            tb = Convert.ToDecimal(textBox1.Text);
            this.textBox1.Text = "";
            optr = "*";
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
            tb = Convert.ToDecimal(textBox1.Text);
            this.textBox1.Text = "";
            optr = "/";
          
        }

        private void button14_Click(object sender, EventArgs e)
        {
           
            tb = Convert.ToDecimal(textBox1.Text);

            this.textBox1.Text = "";
            optr = "-";
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tb1 = Convert.ToDecimal(textBox1.Text);
            
            if (optr == "+")
            {
                this.textBox1.Text = "";
              this.textBox1.Text += Convert.ToString(tb + tb1);
              optr = "";
              
            
            
            }
            if (optr == "-")
            {
                this.textBox1.Text = " ";
               
                this.textBox1.Text += Convert.ToString(tb - tb1);
                optr = "";

            
            }
            if (optr == "*")
            {
                this.textBox1.Text = " ";
                this.textBox1.Text += Convert.ToString(tb * tb1);
                    optr = "";
            }
            if (optr == "/")
            {
                this.textBox1.Text = " ";
                this.textBox1.Text += Convert.ToString(tb / tb1);
                optr = "";
            }
            
        }
    }
}
