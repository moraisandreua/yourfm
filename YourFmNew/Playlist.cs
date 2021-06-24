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

        public void loadShows(bool playlist, Object id)
        {
            panel1.Controls.Clear();
            superMain.cnn.Open();
            SqlCommand sqlCmd = null;

            if (!playlist)
            {
                String genreName = (String)id; // nome do genero
                label1.Text = genreName;
                sqlCmd = new SqlCommand("selectedGenero", superMain.cnn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@selGeneroNome", SqlDbType.Text).Value = genreName;
            }
            else
            {
                int playlistID = (int)id; // id da playlist
                sqlCmd = new SqlCommand("playlistProgramas", superMain.cnn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = playlistID;


                // get the playlist's name
                SqlCommand sqlCmd_details = new SqlCommand("detailsPlaylist", superMain.cnn);
                sqlCmd_details.CommandType = CommandType.StoredProcedure;
                sqlCmd_details.Parameters.AddWithValue("@id", SqlDbType.Int).Value = playlistID;
                SqlDataReader dr_details = sqlCmd_details.ExecuteReader();
                if (dr_details.HasRows)
                {
                    while (dr_details.Read())
                    {
                        string nome_playlist = dr_details.GetString(1);
                        label1.Text = nome_playlist;
                        
                    }
                }
                dr_details.Close();
            }

            SqlDataReader dr = sqlCmd.ExecuteReader();

            int pictureSize = 90;
            int top = 0;

            if (dr.HasRows)
            {

                int x = 0;
                while (dr.Read())
                {
                    string nome_track = dr.GetString(0);
                    string desc_track = dr.GetString(1);
                    string foto_track = dr.GetString(2);
                    int id_track = dr.GetInt32(3);

                    Panel pnl = new Panel();
                    pnl.Height = pictureSize;
                    pnl.Width = this.Width;
                    pnl.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
                    pnl.Location = new Point(0, top);
                    pnl.Name = "tracks";
                    pnl.Click += new EventHandler((sender, e) => play(id_track));

                    PictureBox pb = new PictureBox();
                    pb.Width = (int)pictureSize;
                    pb.Height = (int)pictureSize;
                    pb.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                    pb.Location = new Point(0, 0);
                    pb.BackColor = Color.AliceBlue;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Click += new EventHandler((sender, e) => play(id_track));
                    pb.Load(foto_track);
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

        private void play(int programaID)
        {
            superMain.setCurrentPlay(programaID);
        }
    }
}
