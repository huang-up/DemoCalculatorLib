
namespace DemoCalculatorLib
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.拷贝ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.级联ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.并排ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.堆栈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.桌面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.窗口ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.文件ToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.拷贝ToolStripMenuItem,
            this.粘贴ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 拷贝ToolStripMenuItem
            // 
            this.拷贝ToolStripMenuItem.Name = "拷贝ToolStripMenuItem";
            this.拷贝ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.拷贝ToolStripMenuItem.Text = "拷贝";
            this.拷贝ToolStripMenuItem.Click += new System.EventHandler(this.拷贝ToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // 窗口ToolStripMenuItem
            // 
            this.窗口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.级联ToolStripMenuItem,
            this.并排ToolStripMenuItem,
            this.堆栈ToolStripMenuItem,
            this.桌面ToolStripMenuItem});
            this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
            this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.窗口ToolStripMenuItem.Text = "窗口";
            // 
            // 级联ToolStripMenuItem
            // 
            this.级联ToolStripMenuItem.Name = "级联ToolStripMenuItem";
            this.级联ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.级联ToolStripMenuItem.Text = "级联";
            this.级联ToolStripMenuItem.Click += new System.EventHandler(this.级联ToolStripMenuItem_Click);
            // 
            // 并排ToolStripMenuItem
            // 
            this.并排ToolStripMenuItem.Name = "并排ToolStripMenuItem";
            this.并排ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.并排ToolStripMenuItem.Text = "并排";
            this.并排ToolStripMenuItem.Click += new System.EventHandler(this.并排ToolStripMenuItem_Click);
            // 
            // 堆栈ToolStripMenuItem
            // 
            this.堆栈ToolStripMenuItem.Name = "堆栈ToolStripMenuItem";
            this.堆栈ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.堆栈ToolStripMenuItem.Text = "堆栈";
            this.堆栈ToolStripMenuItem.Click += new System.EventHandler(this.堆栈ToolStripMenuItem_Click);
            // 
            // 桌面ToolStripMenuItem
            // 
            this.桌面ToolStripMenuItem.Name = "桌面ToolStripMenuItem";
            this.桌面ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.桌面ToolStripMenuItem.Text = "桌面";
            this.桌面ToolStripMenuItem.Click += new System.EventHandler(this.桌面ToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 拷贝ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 级联ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 并排ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 堆栈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 桌面ToolStripMenuItem;
    }
}