using System.Windows.Forms;

namespace Saper
{
    partial class Form1
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
            if (exitFromMenu)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            else
            {
                DialogResult res = MessageBox.Show("", "Завершити гру?", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    if (disposing && (components != null))
                    {
                        components.Dispose();
                    }
                    base.Dispose(disposing);
                }
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.додатковоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаГраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.новачокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аматорToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.професіоналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заданоКористувачемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.виToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.c = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатковоToolStripMenuItem,
            this.c});
            this.menuStrip1.Location = new System.Drawing.Point(0, 169);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(249, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // додатковоToolStripMenuItem
            // 
            this.додатковоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаГраToolStripMenuItem,
            this.toolStripSeparator2,
            this.новачокToolStripMenuItem,
            this.аматорToolStripMenuItem,
            this.професіоналToolStripMenuItem,
            this.заданоКористувачемToolStripMenuItem,
            this.toolStripSeparator1,
            this.виToolStripMenuItem});
            this.додатковоToolStripMenuItem.Name = "додатковоToolStripMenuItem";
            this.додатковоToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.додатковоToolStripMenuItem.Text = "Гра";
            // 
            // новаГраToolStripMenuItem
            // 
            this.новаГраToolStripMenuItem.Name = "новаГраToolStripMenuItem";
            this.новаГраToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.новаГраToolStripMenuItem.Text = "Нова гра    ctrl+N";
            this.новаГраToolStripMenuItem.Click += new System.EventHandler(this.новаГраToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
            // 
            // новачокToolStripMenuItem
            // 
            this.новачокToolStripMenuItem.Checked = true;
            this.новачокToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.новачокToolStripMenuItem.Name = "новачокToolStripMenuItem";
            this.новачокToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.новачокToolStripMenuItem.Text = "Новачок";
            this.новачокToolStripMenuItem.Click += new System.EventHandler(this.новачокToolStripMenuItem_Click);
            // 
            // аматорToolStripMenuItem
            // 
            this.аматорToolStripMenuItem.Name = "аматорToolStripMenuItem";
            this.аматорToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.аматорToolStripMenuItem.Text = "Аматор";
            this.аматорToolStripMenuItem.Click += new System.EventHandler(this.аматорToolStripMenuItem_Click);
            // 
            // професіоналToolStripMenuItem
            // 
            this.професіоналToolStripMenuItem.Name = "професіоналToolStripMenuItem";
            this.професіоналToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.професіоналToolStripMenuItem.Text = "Професіонал";
            this.професіоналToolStripMenuItem.Click += new System.EventHandler(this.професіоналToolStripMenuItem_Click);
            // 
            // заданоКористувачемToolStripMenuItem
            // 
            this.заданоКористувачемToolStripMenuItem.Name = "заданоКористувачемToolStripMenuItem";
            this.заданоКористувачемToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.заданоКористувачемToolStripMenuItem.Text = "Особливі";
            this.заданоКористувачемToolStripMenuItem.Click += new System.EventHandler(this.заданоКористувачемToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // виToolStripMenuItem
            // 
            this.виToolStripMenuItem.Name = "виToolStripMenuItem";
            this.виToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.виToolStripMenuItem.Text = "Вихід         Alt+F4";
            this.виToolStripMenuItem.Click += new System.EventHandler(this.виToolStripMenuItem_Click);
            // 
            // c
            // 
            this.c.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.довідкаToolStripMenuItem,
            this.проПрограмуToolStripMenuItem});
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(60, 20);
            this.c.Text = "Довідка";
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.довідкаToolStripMenuItem.Text = "Довідка";
            this.довідкаToolStripMenuItem.Click += new System.EventHandler(this.довідкаToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 193);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сапер";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem додатковоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem c;
        private System.Windows.Forms.ToolStripMenuItem новаГраToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem новачокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аматорToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem професіоналToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem виToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заданоКористувачемToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;



    }
}

