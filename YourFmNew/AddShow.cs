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
    public partial class AddShow : UserControl
    {
        Main superMain = null;
        public AddShow(Main super)
        {
            superMain = super;
            InitializeComponent();
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            string nome = darkTextBox1.Text;
            string description = darkTextBox1.Text;
            int classificacao = 3;
            string foto = darkTextBox1.Text;

            superMain.cnn.Open();
            SqlCommand sqlCmd = new SqlCommand("createPrograma", superMain.cnn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@userid", SqlDbType.Int).Value = superMain.userID;
            sqlCmd.Parameters.AddWithValue("@nome", SqlDbType.Text).Value = nome;
            sqlCmd.Parameters.AddWithValue("@descricao", SqlDbType.Text).Value = description;
            sqlCmd.Parameters.AddWithValue("@classificacao", SqlDbType.Int).Value = classificacao;
            sqlCmd.Parameters.AddWithValue("@foto", SqlDbType.Text).Value = foto;

            SqlDataReader dr = sqlCmd.ExecuteReader();

            superMain.cnn.Close();
        }
    }
}
