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
    public partial class ShowManage : UserControl
    {
        Main superMain = null;

        private List<Episodio> listaEpisodios = new List<Episodio>();
        public ShowManage(Main super)
        {
            superMain = super;
            InitializeComponent();
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Episodio ep = new Episodio(episodioNomeTxt.Text, episodioInicioTxt.Text, episodioFimTxt.Text, episodioFotoTxt.Text);
            listaEpisodios.Add(ep);

            int x = 0;
            foreach (Episodio e_ in listaEpisodios)
            {
                PictureBox pb = new PictureBox();
                pb.Location = new Point(x * 125, 0);
                pb.Width = 120;
                pb.Height = 120;
                pb.Load(e_.getFoto());
                pb.SizeMode = PictureBoxSizeMode.StretchImage;

                panel1.Controls.Add(pb);
                x++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = programTitleTxt.Text;
            string desc = programTitleTxt.Text;
            string foto = programSaveBtn.Text;
            string classificacao = "a";
            int programID = 0;

            // add program
            superMain.cnn.Open();
            SqlCommand sqlCmd_show = new SqlCommand("createPrograma", superMain.cnn);
            sqlCmd_show.CommandType = CommandType.StoredProcedure;
            sqlCmd_show.Parameters.AddWithValue("@userid", SqlDbType.Int).Value = superMain.userID;
            sqlCmd_show.Parameters.AddWithValue("@nome", SqlDbType.Text).Value = nome;
            sqlCmd_show.Parameters.AddWithValue("@descricao", SqlDbType.Text).Value = nome;
            sqlCmd_show.Parameters.AddWithValue("@classificacao", SqlDbType.Text).Value = classificacao;
            sqlCmd_show.Parameters.AddWithValue("@foto", SqlDbType.Text).Value = foto;
            SqlDataReader dr_show = sqlCmd_show.ExecuteReader();
            superMain.cnn.Close();

            // get show id
            superMain.cnn.Open();
            SqlCommand sqlCmd_show_id = new SqlCommand("SELECT TOP(1) id FROM programa WHERE estacao=@userid ORDER BY id DESC", superMain.cnn);
            sqlCmd_show_id.CommandType = CommandType.Text;
            sqlCmd_show_id.Parameters.AddWithValue("@userid", SqlDbType.Int).Value = superMain.userID;
            SqlDataReader dr_show_id = sqlCmd_show_id.ExecuteReader();
            if (dr_show_id.HasRows)
            {
                while (dr_show_id.Read())
                {
                    programID = dr_show_id.GetInt32(0);
                }
            }
            superMain.cnn.Close();

            // add episode to show
           
            foreach (Episodio ep in listaEpisodios)
            {
                //programTitleTxt.Text="@id_programa="+ programID+ ", @titulo='"+ ep.nome+ "', @data_ini='"+ ep.inicio+"', @data_fim='" + ep.fim+"', @foto='" +ep.foto+"'";
                superMain.cnn.Open();
                SqlCommand sqlCmd_episode = new SqlCommand("addEpisodio", superMain.cnn);
                sqlCmd_episode.CommandType = CommandType.StoredProcedure;
                sqlCmd_episode.Parameters.AddWithValue("@id_programa", SqlDbType.Int).Value = programID;
                sqlCmd_episode.Parameters.AddWithValue("@titulo", SqlDbType.Text).Value = ep.nome;
                sqlCmd_episode.Parameters.AddWithValue("@data_ini", SqlDbType.Text).Value = ep.inicio;
                sqlCmd_episode.Parameters.AddWithValue("@data_fim", SqlDbType.Text).Value = ep.fim;
                sqlCmd_episode.Parameters.AddWithValue("@foto", SqlDbType.Text).Value = ep.foto;
                SqlDataReader dr_episode = sqlCmd_episode.ExecuteReader();
                superMain.cnn.Close();
            }

        }
    }

    public class Episodio
    {
        public string nome;
        public string inicio;
        public string fim;
        public string foto;

        public Episodio(string nome, string inicio, string fim, string foto)
        {
            this.nome = nome;
            this.inicio = inicio;
            this.fim = fim;
            this.foto = foto;
        }

        public string getFoto()
        {
            return this.foto;
        }
    }
}
