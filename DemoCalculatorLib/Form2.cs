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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newMDIChild = new Form3();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void 拷贝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Determine the active child form.  
            Form activeChild = this.ActiveMdiChild;

            // If there is an active child form, find the active control, which  
            // in this example should be a RichTextBox.  
            if (activeChild != null)
            {
                try
                {
                    RichTextBox theBox = (RichTextBox)activeChild.ActiveControl;
                    if (theBox != null)
                    {
                        // Put the selected text on the Clipboard.  
                        Clipboard.SetDataObject(theBox.SelectedText);

                    }
                }
                catch
                {
                    MessageBox.Show("You need to select a RichTextBox.");
                }
            }
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Determine the active child form.  
            /*Form activeChild = this.ParentForm.ActiveMdiChild;*/
            Form activeChild = this.ActiveMdiChild;

            // If there is an active child form, find the active control, which  
            // in this example should be a RichTextBox.  
            if (activeChild != null)
            {
                try
                {
                    RichTextBox theBox = (RichTextBox)activeChild.ActiveControl;
                    if (theBox != null)
                    {
                        // Create a new instance of the DataObject interface.  
                        IDataObject data = Clipboard.GetDataObject();
                        // If the data is text, then set the text of the
                        // RichTextBox to the text in the clipboard.  
                        if (data.GetDataPresent(DataFormats.Text))
                        {
                            theBox.SelectedText = data.GetData(DataFormats.Text).ToString();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("You need to select a RichTextBox.");
                }
            }
        }

        private void 级联ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void 并排ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void 堆栈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void 桌面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.ArrangeIcons);
        }
    }
}
