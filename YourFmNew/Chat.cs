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
    public partial class Chat : UserControl
    {
        Main superMain = null;
        int station_id = 0;
        public Chat(Main super)
        {
            superMain = super;
            InitializeComponent();
        }

        public void loadStation(int id, string nome, string username, string foto)
        {
            this.station_id = id;
            superMain.setNameStation(nome, username, foto);

            loadChat(id);
        }

        private void loadChat(int id)
        {
            // GET chat
            superMain.cnn.Open();
            listBox1.Items.Clear();
            SqlCommand sqlCmd = new SqlCommand("listMensagensEstacao", superMain.cnn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@estacaoid", SqlDbType.Int).Value = id;
            SqlDataReader dr = sqlCmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string username_mensagem = dr.GetString(0);
                    string mensagem_mensagem = dr.GetString(1);

                    listBox1.Items.Add(username_mensagem + ": " + mensagem_mensagem);
                }
            }
            superMain.cnn.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                superMain.cnn.Open();
                string mensagem = textBox1.Text;

                SqlCommand sqlCmd = new SqlCommand("addMensagem", superMain.cnn);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@userid", SqlDbType.Int).Value = superMain.userID;
                sqlCmd.Parameters.AddWithValue("@mensagem", SqlDbType.Text).Value = mensagem;
                sqlCmd.Parameters.AddWithValue("@estacaoid", SqlDbType.Int).Value = station_id;
                SqlDataReader dr = sqlCmd.ExecuteReader();
                superMain.cnn.Close();

                loadChat(station_id);

                textBox1.Text = "";
                
            }
        }
    }
}
