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
    public partial class AddPlaylist : UserControl
    {
        Main superMain = null;
        public AddPlaylist(Main super)
        {
            InitializeComponent();
            superMain = super;
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            string nome = darkTextBox1.Text;
            string desc = darkTextBox2.Text;
            string foto = darkTextBox3.Text;
            int userID = superMain.userID;

            

        }
    }
}
