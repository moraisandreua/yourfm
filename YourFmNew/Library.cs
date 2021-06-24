using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourFmNew
{
    public partial class Library : UserControl
    {
        Main super=null;
        public Library(Main s)
        {
            InitializeComponent();
            this.super = s;
        }

        private void loadShows()
        {
            panel1.Controls.Clear();
            int pictureSize = 200;

            for (int x = 1; x <= 15; x++)
            {
                PictureBox pb = new PictureBox();
                pb.Width = (int)pictureSize;
                pb.Height = (int)pictureSize;

                double left = (x * 20) + ((x - 1) * pictureSize);
                int top = 0;

                pb.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                pb.Location = new Point((int)left, top);
                pb.BackColor = Color.AliceBlue;
                panel1.Controls.Add(pb);
            }
        }

        private void loadStations()
        {
            panel2.Controls.Clear();
            int pictureSize = 200;

            for (int x = 1; x <= 15; x++)
            {
                PictureBox pb = new PictureBox();
                pb.Width = (int)pictureSize;
                pb.Height = (int)pictureSize;

                double left = (x * 20) + ((x - 1) * pictureSize);
                int top = 0;

                pb.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                pb.Location = new Point((int)left, top);
                pb.BackColor = Color.AliceBlue;
                panel2.Controls.Add(pb);
            }
        }

        public void loadPlaylists()
        {
            panel3.Controls.Clear();
            int pictureSize = 200;

            super.cnn.Open();

            // GET station programs
            SqlCommand sqlCmd = new SqlCommand("listUserPlaylists", super.cnn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@userid", SqlDbType.Int).Value = super.userID;
            SqlDataReader dr = sqlCmd.ExecuteReader();

            if (dr.HasRows)
            {
                int x = 0;
                while (dr.Read())
                {
                    int id_playlist = dr.GetInt32(0);
                    string nome_playlist = dr.GetString(1);
                    string foto_playlist = dr.GetString(2);

                    PictureBox pb = new PictureBox();
                    pb.Width = (int)pictureSize;
                    pb.Height = (int)pictureSize;
                    pb.SizeMode=PictureBoxSizeMode.StretchImage;

                    double left = (x * 20) + ((x - 1) * pictureSize);
                    int top = 0;

                    pb.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                    pb.Location = new Point((int)left, top);
                    pb.BackColor = Color.AliceBlue;
                    pb.Click += new EventHandler((sender, e) => openPlaylist(id_playlist));
                    try
                    {
                        pb.Load(foto_playlist);
                    }
                    catch(Exception e)
                    {
                        pb.Image = Properties.Resources.image_not_found;
                    }
                    pb.Load(foto_playlist);
                    panel3.Controls.Add(pb);

                    x++;
                }
            }

            super.cnn.Close();
        }

        private void openPlaylist(int id)
        {
            super.openPlaylist(id, true);
        }

        private void Library_Load(object sender, EventArgs e)
        {
            loadShows();
            loadStations();
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            super.openPlaylist_form();
        }
    }
}
