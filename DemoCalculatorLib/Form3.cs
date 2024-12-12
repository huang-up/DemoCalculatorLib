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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            // 初始化离屏位图
            offScreenBitmap = new Bitmap(panel1.Width, panel1.Height);
            offScreenGraphics = Graphics.FromImage(offScreenBitmap);

            // 设置背景色
            offScreenGraphics.Clear(Color.White);

            // 初始化绘制内容
            Redraw();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Declares the Graphics object and sets it to the Graphics object  
            // supplied in the PaintEventArgs.  
            Graphics graphic = e.Graphics;
            // Insert code to paint the form here.  
            /*System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Tomato);
            myPen.Color = System.Drawing.Color.PeachPuff;

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(myBrush, new Rectangle(0, 0, 200, 300));
            myBrush.Dispose();
            formGraphics.Dispose();*/

            /*Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            this.DrawRectangle(this.panel1);
            graphic.DrawLine(pen, 20, 10, 300, 100);
            this.DrawEllipse(this.panel1);*/
            this.DrawSolidRectangle(this.panel1);
            this.DrawSolidEllipse(this.panel1);
            this.DrawString(this.panel1);
        }

        /// <summary>
        /// 绘制实心矩形
        /// </summary>
        private void DrawSolidRectangle(Panel that)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = that.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(400, 100, 200, 300));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void DrawSolidEllipse(Panel that)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = that.CreateGraphics();
            formGraphics.FillEllipse(myBrush, new Rectangle(100, 100, 200, 200));
            myBrush.Dispose();
            formGraphics.Dispose();
        }
        /// <summary>
        /// 绘制文本
        /// </summary>
        public void DrawString(Panel that)
        {
            System.Drawing.Graphics formGraphics = that.CreateGraphics();
            string drawString = "Sample Text";
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 16);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            float x = 150.0F;
            float y = 50.0F;
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            formGraphics.DrawString(drawString, drawFont, drawBrush, 0, 0, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();
            formGraphics.Dispose();
        }


        private bool isDragging = false;
        private Point dragStartPoint = new Point();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragStartPoint = e.Location;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // 示例：简单地将整个Panel内容拖动
                panel1.Left += e.X - dragStartPoint.X;
                panel1.Top += e.Y - dragStartPoint.Y;

                // 重置起点
                dragStartPoint = e.Location;
            }
            // 你可以在这里添加更多的交互逻辑
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }


        private Bitmap offScreenBitmap;
        private Graphics offScreenGraphics;

        private void Redraw()
        {
            // 清除离屏位图
            offScreenGraphics.Clear(Color.White);

            // 在这里添加你的绘图代码
            Pen pen = new Pen(Color.Black, 2);
            Rectangle rect = new Rectangle(50, 50, 200, 100);
            offScreenGraphics.DrawRectangle(pen, rect);

            // 将离屏位图绘制到Panel上
            panel1.Invalidate();
        }
    }
}
