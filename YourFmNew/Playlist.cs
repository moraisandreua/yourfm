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
    public partial class Playlist : UserControl
    {
        int id = 0;
        public Playlist()
        {
            InitializeComponent();
        }

        public void setID(int id) {
            this.id = id;
        }

        private void Playlist_Load(object sender, EventArgs e)
        {
            loadShows();   
        }

        private void loadShows()
        {
            int pictureSize = 90;
            int top = 0;
            for (int x = 1; x <= 15; x++)
            {
                Panel pnl = new Panel();
                pnl.Height = pictureSize;
                pnl.Width = this.Width;
                pnl.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
                pnl.Location = new Point(0, top);
                pnl.Name = "tracks";

                PictureBox pb = new PictureBox();
                pb.Width = (int)pictureSize;
                pb.Height = (int)pictureSize;
                pb.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                pb.Location = new Point(0, 0);
                pb.BackColor = Color.AliceBlue;
                //pb.Click += new EventHandler(); //
                pnl.Controls.Add(pb);

                Label nome = new Label();
                nome.Text = "Nome do programa";
                nome.Location = new Point(100, 30);
                nome.Width = panel1.Width;
                nome.Height = 90;
                nome.ForeColor = Color.White;
                nome.Font = new Font("Segoe UI", 10, FontStyle.Bold); //Segoe UI; 18pt; style=Bold
                pnl.Controls.Add(nome);

                panel1.Controls.Add(pnl);
                top += 100;
            }
        }

        private void clearTracks()
        {
            Control[] controls = this.Controls.Find("tracks", true);
            foreach(Control x in controls)
            {
                Panel ptd = (Panel)x;
                this.Controls.Remove(ptd);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
