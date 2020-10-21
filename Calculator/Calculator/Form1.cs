using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double a,result=0;
        bool click = false;
        char oper = '+';
        public Calculator()
        {
            InitializeComponent();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (click)
            {
                textBox1.Text = "0";
            }
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "1";
                }
                else
                {
                    textBox1.Text += "1";
                }
                click = false;
        }

        private void button15_Click(object sender, EventArgs e) 
        {
            if (click)
            {
                textBox1.Text = "0";
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
            click = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (click)
            {
                textBox1.Text = "0";
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
            click = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (click)
            {
                textBox1.Text = "0";
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
            click = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (click)
            {
                textBox1.Text = "0";
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
            click = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (click)
            {
                textBox1.Text = "0";
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
            click = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (click)
            {
                textBox1.Text = "0";
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
            click = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (click)
            {
                textBox1.Text = "0";
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
            click = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (click)
            {
                textBox1.Text = "0";
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
            click = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            switch(oper)
            {
                case '+':result +=a;break;
                case '-':result -=a;break;
                case '*':result *=a;break;
                case '/':result /=a;break;
                default: MessageBox.Show("გთხოვთ მიუთთოთ ოპერაცია"); return;
            }
            oper = '+';
            click = true;
            textBox1.Text = result.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = 0;
            oper = '+';
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            switch (oper)
            {
                case '+': result += a; break;
                case '-': result -= a; break;
                case '*': result *= a; break;
                case '/': result /= a; break;
                case '^': result = Math.Pow(result,a); break;          
                default: MessageBox.Show("გთხოვთ მიუთთოთ ოპერაცია"); return;
            }
            textBox1.Text = result.ToString();
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " ")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            if (textBox1.Text.Length == 0)
                textBox1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            switch (oper)
            {
                case '+': result += a; break;
                case '-': result -= a; break;
                case '*': result *= a; break;
                case '/': result /= a; break;
                default: MessageBox.Show("გთხოვთ მიუთთოთ ოპერაცია"); return;
            }
            oper = '*';
            click = true;
            textBox1.Text = result.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            switch (oper)
            {
                case '+': result += a; break;
                case '-': result -= a; break;
                case '*': result *= a; break;
                case '/': result /= a; break;
                default: MessageBox.Show("გთხოვთ მიუთთოთ ოპერაცია"); return;
            }
            oper = '-';
            click = true;
            textBox1.Text = result.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            switch (oper)
            {
                case '+': result += a; break;
                case '-': result -= a; break;
                case '*': result *= a; break;
                case '/': result /= a; break;
                default: MessageBox.Show("გთხოვთ მიუთთოთ ოპერაცია"); return;
            }
            oper = '/';
            click = true;
            textBox1.Text = result.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") 
            {
                textBox1.Text += "0";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                    textBox1.Text = textBox1.Text + ".";             
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) >= 0)
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Sqrt(a));
            }
            else
                MessageBox.Show("უარყოფითიდან ფესვი არ ამოდის");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double k;
            k = Convert.ToDouble(textBox1.Text);
            k = k * -1;
            textBox1.Text = Convert.ToString(k);      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            switch (oper)
            {
                case '+': result += a; break;
                case '-': result -= a; break;
                case '*': result *= a; break;
                case '/': result /= a; break;
                case '^': result = Math.Pow(result,a); break;
                default: MessageBox.Show("გთხოვთ მიუთთოთ ოპერაცია"); return;
            }
            oper = '^';
            click = true;
            textBox1.Text = result.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            result = 1 / Convert.ToDouble(textBox1.Text);
            textBox1.Text = result.ToString();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
