using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCalculatorLib
{
    public class Class1 : ApplicationContext
    {
        private int formCount;
        private Form1 form1;
        private Form2 form2;
        /*private Form3 form3;*/
        public Class1()
        {
            formCount = 0;
            /// 显示计算器窗口
            /*form1 = new Form1();
            form1.Closed += new EventHandler(OnFormClosed);
            formCount++;
            form1.Show();*/
            

            form2 = new Form2();
            form2.Closed += new EventHandler(OnFormClosed);
            formCount++;

            // 显示双窗体
            form2.Show();
        }
        private void OnFormClosed(object sender, EventArgs e)
        {
            // 关闭所有窗体，退出主线程
            formCount--;
            if (formCount == 0)
            {
                ExitThread();
            }
        }
    }
}
