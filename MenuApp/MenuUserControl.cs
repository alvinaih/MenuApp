﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuApp
{
    public partial class MenuUserControl : UserControl
    {
        public MenuUserControl()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Kabelo kabs = new Kabelo();
            kabs.Show();
            this.Hide();
          
        }
    }
}
