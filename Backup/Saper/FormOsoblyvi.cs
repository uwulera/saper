﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Saper
{
    public partial class FormOsoblyvi : Form
    {
        public FormOsoblyvi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.GetFromOsoblyvi(trackBarHeight.Value, trackBarWidth.Value, trackBarMineCount.Value);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackBarHeight_Scroll(object sender, EventArgs e)
        {
            trackBarMineCount.Maximum = trackBarHeight.Value * trackBarWidth.Value;
            label1.Text = "Висота: " + trackBarHeight.Value;
            label2.Text = "Кількість мін: " + trackBarMineCount.Value;

        }

        private void trackBarWidth_Scroll(object sender, EventArgs e)
        {
            trackBarMineCount.Maximum = trackBarHeight.Value * trackBarWidth.Value;
            label3.Text = "Ширина: " + trackBarWidth.Value;
            label2.Text = "Кількість мін: " + trackBarMineCount.Value;

        }

        private void trackBarMineCount_Scroll(object sender, EventArgs e)
        {
            label2.Text = "Кількість мін: " + trackBarMineCount.Value;
        }
    }
}
