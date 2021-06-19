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
    public partial class Login : UserControl
    {
        Main superMain = null;
        public Login(Main super)
        {
            InitializeComponent();
            superMain = super;
        }

        private void modernButton1_Click(object sender, EventArgs e)
        {

        }

        private void darkButton1_Click(object sender, EventArgs e)
        {


            String username = textBox1.Text;
            String password = textBox2.Text;
            // TODO: all the verifications

            superMain.cnn.Open();
            SqlCommand sqlCmd = new SqlCommand("doLogin", superMain.cnn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@username", SqlDbType.Text).Value = username;
            sqlCmd.Parameters.AddWithValue("@password", SqlDbType.Text).Value = password;

            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.HasRows)
            {
                int x = 0;
                while (dr.Read())
                    x++;

                if (x > 1)
                    MessageBox.Show("Erro, pardoname");
                else
                    superMain.loggedIn();
            }
            else
            {
                MessageBox.Show("Combinação username:password is incorrect");
            }
            superMain.cnn.Close();
            
        }

        private void darkButton3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void darkButton2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void darkButton4_Click(object sender, EventArgs e)
        {
            String username = textBox4.Text;
            String password = textBox3.Text;
            String email = textBox5.Text;
            String nome = textBox6.Text;
            String data_nasc = textBox7.Text;
            String foto = textBox8.Text;
            String tipoUser = darkComboBox1.Text;

            superMain.cnn.Open();
            SqlCommand sqlCmd = new SqlCommand("doRegisto", superMain.cnn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@username", SqlDbType.Text).Value = username;
            sqlCmd.Parameters.AddWithValue("@password", SqlDbType.Text).Value = password;
            sqlCmd.Parameters.AddWithValue("@email", SqlDbType.Text).Value = email;
            sqlCmd.Parameters.AddWithValue("@data_nasc", SqlDbType.DateTime).Value = DateTime.Parse(data_nasc);
            sqlCmd.Parameters.AddWithValue("@nome", SqlDbType.Text).Value = nome;
            sqlCmd.Parameters.AddWithValue("@foto", SqlDbType.Text).Value = foto;
            sqlCmd.Parameters.AddWithValue("@tipoUser", SqlDbType.Text).Value = tipoUser.ToLower();

            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.HasRows)
            {
                int x = 0;
                while (dr.Read()) 
                    x++;

                if(x>1)
                    MessageBox.Show("Erro, pardoname");
                else
                {
                    MessageBox.Show("Registado, yupi");
                    panel2.Visible = false;
                    panel1.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Erro, pardoname");
            }
            superMain.cnn.Close();

        }

        private void darkComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
