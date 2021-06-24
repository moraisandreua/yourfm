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
    public partial class Search : UserControl
    {
        Main superMain = null;

        public Search(Main super)
        {
            superMain = super;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {
            loadGenres();
            loadStations();
        }

        private void loadGenres() {
            panel_genres.Controls.Clear();
            int pictureSize = 200;

            superMain.cnn.Open();
            SqlCommand sqlCmd = new SqlCommand("generoList", superMain.cnn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@PageNumber", SqlDbType.Int).Value = 1;
            sqlCmd.Parameters.AddWithValue("@RowsPerPage", SqlDbType.Int).Value = 15;
            SqlDataReader dr = sqlCmd.ExecuteReader();

            if (dr.HasRows){
                int x = 0;
                while (dr.Read()){
                    string nome = dr.GetString(0);
                    object foto = dr.GetValue(1);
                    
                    PictureBox pb = new PictureBox();
                    pb.Width = (int)pictureSize;
                    pb.Height = (int)pictureSize;

                    double left = (x * 20) + ((x - 1) * pictureSize);
                    int top = 0;

                    pb.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                    pb.Location = new Point((int)left, top);
                    pb.BackColor = Color.AliceBlue;
                    pb.Click += new EventHandler((sender, e) => openGenre(nome, false));
                    pb.Cursor = Cursors.Hand;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    if (foto != DBNull.Value){
                        pb.Load((string)foto);
                    }
                    
                    panel_genres.Controls.Add(pb);
                    x++;
                }
            }
            superMain.cnn.Close();
        }

        void openGenre(string genreName, bool isPlaylist) //Object p, EventArgs e
        {
            superMain.openPlaylist(genreName, isPlaylist);
        }

        private void loadStations()
        {
            panel2.Controls.Clear();
            int pictureSize = 200;

            superMain.cnn.Open();
            SqlCommand sqlCmd = new SqlCommand("estacaoList", superMain.cnn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@PageNumber", SqlDbType.Int).Value = 1;
            sqlCmd.Parameters.AddWithValue("@RowsPerPage", SqlDbType.Int).Value = 15;
            SqlDataReader dr = sqlCmd.ExecuteReader();

            if (dr.HasRows)
            {
                int x = 0;
                while (dr.Read())
                {
                    int id_station = dr.GetInt32(0);
                    string nome_station = dr.GetString(1);
                    string foto_station = dr.GetString(2);
                    string username_station = dr.GetString(4);

                    PictureBox pb = new PictureBox();
                    pb.Width = (int)pictureSize;
                    pb.Height = (int)pictureSize;

                    double left = (x * 20) + ((x - 1) * pictureSize);
                    int top = 0;

                    pb.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                    pb.Location = new Point((int)left, top);
                    pb.BackColor = Color.AliceBlue;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    try
                    {
                        pb.Load((string)foto_station);
                    }catch(Exception e) {
                        pb.Image = Properties.Resources.image_not_found;
                    }
                       
                    pb.Click += new EventHandler((sender, e) => superMain.openChat(id_station, nome_station, username_station, foto_station));
                    panel2.Controls.Add(pb);
                    x++;
                }
            }
            superMain.cnn.Close();
        }

        public void searchBoxTrigger(String texto)
        {
            panel_search.Controls.Clear();
            panel_genres.Visible = false;
            panel2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            label5.Visible = true;
            panel_search.Visible = true;

            superMain.cnn.Open();

            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM dbo.doSearch(@searchQuery, @resultNumber)", superMain.cnn);

            sqlCmd.Parameters.AddWithValue("@searchQuery", SqlDbType.Text).Value = texto;
            sqlCmd.Parameters.AddWithValue("@resultNumber ", SqlDbType.Int).Value = 3;
            SqlDataReader dr = sqlCmd.ExecuteReader();

            int pictureSize = 90;
            int top = 0;
            if (dr.HasRows)
            {
                int x = 0;
                while(dr.Read())
                {
                    int id_track = dr.GetInt32(0); // pode ser user, playlist, programa ou genero
                    string nome_track = dr.GetString(1);
                    string type_track = dr.GetString(2);
                    string foto_track = dr.GetString(3);

                    Panel pnl = new Panel();
                    pnl.Height = pictureSize;
                    pnl.Width = this.Width;
                    pnl.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
                    pnl.Location = new Point(0, top);
                    pnl.Name = "tracks";
                    //pnl.Click += new EventHandler((sender, e) => play(id_track));

                    PictureBox pb = new PictureBox();
                    pb.Width = (int)pictureSize;
                    pb.Height = (int)pictureSize;
                    pb.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                    pb.Location = new Point(0, 0);
                    pb.BackColor = Color.AliceBlue;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Click += new EventHandler((sender, e) => open(id_track, type_track, nome_track));
                    try
                    {
                        pb.Load(foto_track);
                    }
                    catch (Exception e)
                    {
                        pb.Image = Properties.Resources.image_not_found;
                    }
                    
                    pnl.Controls.Add(pb);

                    Label nome = new Label();
                    nome.Text = nome_track;
                    nome.Location = new Point(200, 30);
                    //nome.Width = panel4.Width;
                    nome.Height = 90;
                    nome.ForeColor = Color.White;
                    nome.Font = new Font("Segoe UI", 10, FontStyle.Bold); //Segoe UI; 18pt; style=Bold
                    pnl.Controls.Add(nome);

                    Label type = new Label();
                    type.Text = type_track;
                    type.Location = new Point(100, 30);
                    //type.Width = panel4.Width;
                    type.Height = 90;
                    type.ForeColor = Color.Gray;
                    type.Font = new Font("Segoe UI", 10, FontStyle.Regular); //Segoe UI; 18pt; style=Bold
                    pnl.Controls.Add(type);

                    panel_search.Controls.Add(pnl);
                    top += 100;
                    x++;
                }
            }

            superMain.cnn.Close();
        }

        private void open(int id, string type, string genreName="")
        {
            switch (type)
            {
                case "programa": superMain.setCurrentPlay(id); break;
                case "user": superMain.setCurrentPlay(id); break;
                case "genero": superMain.openPlaylist(genreName, false); break;
                case "playlist": superMain.openPlaylist(id, true); break;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
