using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCalculatorLib
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            new Thread(ThreadRun).Start();
            new Thread(ThreadRun1).Start();
        }
        public void ThreadRun()
        {
            int i = 0;
            while (true)
            {
                Thread.Sleep(500);
                i++;
                if (this.InvokeRequired)
                {
                    this?.Invoke(new Action(() => { if (uiTextBox1 != null) { uiTextBox1.Text = "Invoke 用法" + i; } }));

                }
            }
        }

        public void ThreadRun1()
        {
            int i = 0;
            while (true)
            {
                Thread.Sleep(500);
                i++;
                if (this.InvokeRequired)
                {
                    this?.BeginInvoke(new Action(() => { if (uiTextBox2 != null) { uiTextBox2.Text = "BeginInvoke 用法" + i; } }));

                }
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.uiButton1.Enabled = false;
            MessageBox.Show("sunnyui");
            DelegateObj delegateObj = new DelegateObj(TestW);
            delegateObj.BeginInvoke("hello ", null, null);
            
        }
        private volatile Boolean doingTest;
        private delegate void DelegateObj(String str);

        private void TestW(String str)
        {
            int i = 0;
            while (i<10)
            {
                Thread.Sleep(3000);
                Console.WriteLine(str + i++);
            }
            /// System.InvalidOperationException:“线程间操作无效: 从不是创建控件“uiButton1”的线程访问它。”
            /// this.uiButton1.Enabled = true;
            uiButton1.Invoke(new Action(() => uiButton1.Enabled = true));
        }
    }

}
