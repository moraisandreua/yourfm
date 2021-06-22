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
    public partial class Home : UserControl
    {

        Main superMain = null;
        int currentPage = 1;

        public Home(Main super)
        {
            InitializeComponent();
            this.superMain = super;
        }

        public void showBtnAddShow()
        {
            darkButton1.Visible = true;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            loadStations();
        }

        private void Home_SizeChanged(object sender, EventArgs e)
        {
            loadStations();
        }

        private void loadStations()
        {
            flowLayoutPanel1.Controls.Clear();
            int width = panel1.Width; // -20px left // -20px right // -20px * 4
            int availableWidth = width - 20 - 20 - 80;
            double pictureWidth = availableWidth / 5;

            getStations(pictureWidth, currentPage); // currentPage é um parametro da class que identifica a página atual da paginação
        }

        void openChat(int id, string nome, string username, string foto)
        {
            superMain.openChat(id, nome, username, foto); 
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            superMain.openAddShow();
        }

        private Object[] getStations(double pictureWidth, int page = 1)
        {
            superMain.cnn.Open();
            SqlCommand sqlCmd = new SqlCommand("estacaoList", superMain.cnn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@PageNumber", SqlDbType.Int).Value = page;
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
                    pb.Width = (int)pictureWidth;
                    pb.Height = (int)pictureWidth;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    try
                    {
                        pb.Load(foto_station);
                    }catch(Exception e)
                    {
                        pb.Image = Properties.Resources.image_not_found;
                    }

                    double left = (x * 20) + ((x - 1) * pictureWidth);
                    double top = (x * 20);

                    pb.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                    pb.Location = new Point((int)left, (int)top);
                    pb.BackColor = Color.AliceBlue;

                    pb.Click += new EventHandler((sender, e) => openChat(id_station, nome_station, username_station, foto_station));
                    pb.Cursor = System.Windows.Forms.Cursors.Hand;

                    flowLayoutPanel1.Controls.Add(pb);
                    x++;
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }
            superMain.cnn.Close();
            return null;
        }
    }
}
