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
            panel1.Controls.Clear();
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
                    
                    panel1.Controls.Add(pb);
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

            for (int x = 1; x <= 15; x++)
            {
                PictureBox pb = new PictureBox();
                pb.Width = (int) pictureSize;
                pb.Height = (int) pictureSize;

                double left = (x * 20) + ((x - 1) * pictureSize);
                int top = 0;

                pb.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                pb.Location = new Point((int)left, top);
                pb.BackColor = Color.AliceBlue;
                panel2.Controls.Add(pb);
            }
        }
    }
}
