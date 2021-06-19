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
    public partial class Playlist : UserControl
    {
        // may also work with gEnReS
        int id = 0;
        Main superMain = null;

        public Playlist(Main super)
        {
            superMain = super;
            InitializeComponent();
        }

        public Playlist()
        {
            InitializeComponent();
        }

        public void setID(int id) {
            this.id = id;
        }

        private void Playlist_Load(object sender, EventArgs e)
        {
            //loadShows();   
        }

        public void loadShows(bool playlist, Object genre)
        {
            superMain.cnn.Open();
            SqlCommand sqlCmd = null;

            if (!playlist)
            {
                

            }
            else
            {
                int genreID = (int)genre;
                // TODO: load another Store Procedure
            }

            String genreName = (String)genre;
            MessageBox.Show(genreName);
            sqlCmd = new SqlCommand("selectedGenero", superMain.cnn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@selGeneroNome", SqlDbType.Text).Value = genreName;

            SqlDataReader dr = sqlCmd.ExecuteReader();

            int pictureSize = 90;
            int top = 0;

            // MessageBox.Show(dr.FieldCount.ToString()); // mostra "3", o que está certo
            if (dr.HasRows)
            {
                int x = 0;
                while (dr.Read())
                {
                    string nome_track = dr.GetString(0);
                    string desc_track = dr.GetString(1);
                    string foto_track = dr.GetString(2);

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
                    pb.Load(foto_track);
                    //pb.Click += new EventHandler(); // to-do: "play" track
                    pnl.Controls.Add(pb);

                    Label nome = new Label();
                    nome.Text = nome_track;
                    nome.Location = new Point(100, 30);
                    nome.Width = panel1.Width;
                    nome.Height = 90;
                    nome.ForeColor = Color.White;
                    nome.Font = new Font("Segoe UI", 10, FontStyle.Bold); //Segoe UI; 18pt; style=Bold
                    pnl.Controls.Add(nome);

                    panel1.Controls.Add(pnl);
                    top += 100;
                    x++;
                }
            }
            superMain.cnn.Close();
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
