﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tregubovhome_Snake
{
    public partial class form_Logo : Form
    {
        public form_Logo()
        {
            InitializeComponent();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            formGame frm = new formGame();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
