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
    public partial class Kabelo : Form
    {
        public Kabelo()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuUserControl frm1 = new MenuUserControl();
            frm1.Show();
            this.Hide();
          //("show error")  Form1 frm = new Form1();
            //frm.Hide();
        }
    }
}
