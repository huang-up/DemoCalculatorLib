using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCalculatorLib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text = txtResult.Text + " " + btn.Text + " ";
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text = txtResult.Text + " " + btn.Text + " ";
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text = txtResult.Text + " " + btn.Text + " ";
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text = txtResult.Text + " " + btn.Text + " ";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            txtResult.Text ="";
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            Single r; //r用于保存结果值
            string t = txtResult.Text; //t用于保存文本框中的算术表达式
            int space = t.IndexOf(" "); //用于搜索空格位置
            string s1 = t.Substring(0, space); //s1用于保存第一个运算数
            char op = Convert.ToChar(t.Substring(space + 1, 1)); //op用于保存运算符
            string s2 = t.Substring(space + 3); //s2用于保存第二个运算数
            Single arg1 = Convert.ToSingle(s1);
            Single arg2 = Convert.ToSingle(s2);

            switch (op)
            {
                case '+':
                    r = arg1 + arg2;
                    break;
                case '-':
                    r = arg1 - arg2;
                    break;
                case '*':
                    r = arg1 * arg2;
                    break;
                case '/':
                    if (arg2 == 0)
                    {
                        throw new ApplicationException();
                    }
                    else
                    {
                        r = arg1 / arg2;
                        break;
                    }
                    break;
                default:
                    throw new ApplicationException();
            }

            txtResult.Text = r.ToString();
            listView1.Items.Add(t + " = " + r);
        }
    }
}
