using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pnlSide.Height = btnHome.Height;
            pnlSide.Top = btnHome.Top;
            homeUserControl1.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            pnlSide.Height = btnHome.Height;
            pnlSide.Top = btnHome.Top;
            homeUserControl1.BringToFront();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            pnlSide.Height = btnMenu.Height;
            pnlSide.Top = btnMenu.Top;
            menuUserControl1.BringToFront();
        }
    }
}
