﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorDialog_concept
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_bg_Click(object sender, EventArgs e)
        {
            DialogResult dial_res = colorDialog1.ShowDialog();
            if (dial_res == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void btn_fc_Click(object sender, EventArgs e)
        {
            DialogResult dial_res = colorDialog1.ShowDialog();
            if (dial_res == DialogResult.OK)
            {
                this.ForeColor = colorDialog1.Color;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
