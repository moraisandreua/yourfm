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

            // @designacao AS VARCHAR(80),@descricao AS VARCHAR(80),@userid AS INT, @foto AS VARCHAR(256)
            superMain.cnn.Open();
            SqlCommand sqlCmd = new SqlCommand("createPlaylist", superMain.cnn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@designacao", SqlDbType.Int).Value = nome;
            sqlCmd.Parameters.AddWithValue("@descricao", SqlDbType.Int).Value = desc;
            sqlCmd.Parameters.AddWithValue("@userid", SqlDbType.Int).Value = userID;
            sqlCmd.Parameters.AddWithValue("@foto", SqlDbType.Int).Value = foto;
            SqlDataReader dr = sqlCmd.ExecuteReader();

            superMain.cnn.Close();
            superMain.addOwnPlaylistsDropbox();
        }
    }
}
