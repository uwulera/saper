using System;
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
        //protected override void Dispose(bool disposing)
        //{
        //    if (exitFromMenu)
        //    {
        //        if (disposing && (components != null))
        //        {
        //            components.Dispose();
        //        }
        //        base.Dispose(disposing);
        //    }
        //    else
        //    {
        //        DialogResult res = MessageBox.Show("", "Завершити гру?", MessageBoxButtons.YesNo);
        //        if (res == DialogResult.Yes)
        //        {
        //            if (disposing && (components != null))
        //            {
        //                components.Dispose();
        //            }
        //            base.Dispose(disposing);
        //        }
        //    }
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.newPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loverPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profiPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 246);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(348, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paramToolStripMenuItem
            // 
            this.paramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPlayToolStripMenuItem,
            this.toolStripSeparator2,
            this.newPlayerToolStripMenuItem,
            this.loverPlayerToolStripMenuItem,
            this.profiPlayerToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.paramToolStripMenuItem.Name = "paramToolStripMenuItem";
            this.paramToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.paramToolStripMenuItem.Text = "Параметры игры";
            // 
            // newPlayToolStripMenuItem
            // 
            this.newPlayToolStripMenuItem.Name = "newPlayToolStripMenuItem";
            this.newPlayToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.newPlayToolStripMenuItem.Text = "Начать сначала";
            this.newPlayToolStripMenuItem.Click += new System.EventHandler(this.newPlayToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(198, 6);
            // 
            // newPlayerToolStripMenuItem
            // 
            this.newPlayerToolStripMenuItem.Checked = true;
            this.newPlayerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.newPlayerToolStripMenuItem.Name = "newPlayerToolStripMenuItem";
            this.newPlayerToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.newPlayerToolStripMenuItem.Text = "Новичок";
            this.newPlayerToolStripMenuItem.Click += new System.EventHandler(this.newPlayerToolStripMenuItem_Click);
            // 
            // loverPlayerToolStripMenuItem
            // 
            this.loverPlayerToolStripMenuItem.Name = "loverPlayerToolStripMenuItem";
            this.loverPlayerToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.loverPlayerToolStripMenuItem.Text = "Любитель";
            this.loverPlayerToolStripMenuItem.Click += new System.EventHandler(this.loverPlayerToolStripMenuItem_Click);
            // 
            // profiPlayerToolStripMenuItem
            // 
            this.profiPlayerToolStripMenuItem.Name = "profiPlayerToolStripMenuItem";
            this.profiPlayerToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.profiPlayerToolStripMenuItem.Text = "Профессионал";
            this.profiPlayerToolStripMenuItem.Click += new System.EventHandler(this.profiPlayerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 274);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem newPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loverPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profiPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private EventHandler параметрыToolStripMenuItem_Click;

        public EventHandler Form1_Load { get; private set; }
    }
}

