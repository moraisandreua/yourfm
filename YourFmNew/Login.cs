using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourFmNew
{
    public partial class Login : UserControl
    {
        Main super = null;
        public Login(Main super)
        {
            InitializeComponent();
            this.super = super;
        }

        private void modernButton1_Click(object sender, EventArgs e)
        {

        }

        private void darkButton1_Click(object sender, EventArgs e)
        {

            // TODO: all the verifications
            super.loggedIn();
        }

        private void darkButton3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void darkButton2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }
    }
}
