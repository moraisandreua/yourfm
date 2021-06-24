using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows;
using System.Data.SqlClient;
using System.Data;

namespace YourFmNew
{
    public partial class Main : Vip.CustomForm.FormBase
    {
        public SqlConnection cnn;
        Title titleBarBtn = null;
        int titleBarBtn_left = 0;
        int titleBarBtn_top = 0;
        bool playing = false;
        int currentPlaylingId=0;
        int currentOpenedId = 0;
         
        string original_username = null;
        // user's info
        public string username=null;
        string nome=null;
        string foto=null;
        public int userID=0;
        public string user_type=null;

        private void setSize()
        {
            if(titleBarBtn != null){
                titleBarBtn.Size = new Size(this.Size.Width - 100, 41);
                titleBarBtn.Location = new Point(this.Location.X + titleBarBtn_left, this.Location.Y + titleBarBtn_top);
            }
        }

        public Main()
        {
            InitializeComponent();
            cnn = new SqlConnection("Data Source=localhost;DataBase=yourfm;Integrated Security=True"); //  DataBase=yourfm;User ID=UserName;Password=Password
            //cnn.Open();

            titleBarBtn = new Title(this);
            setSize();
            titleBarBtn.Show();
            titleBarBtn.Owner = this;
        }

        private void createTileBar()
        {
            titleBarBtn.showControls();
        }

        private void createLogin()
        {
            Login lg = new Login(this);
            lg.Name = "loginPanel";
            lg.Size = new Size(this.Size.Width, this.Size.Height);
            lg.Location = new Point(0, 0);
            lg.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.Controls.Add(lg);
            lg.BringToFront();
        }

        public void loggedIn(string username, string nome, string foto, int userID, string user_type)
        {
            this.username = username;
            this.nome = nome;
            this.foto = foto;
            this.userID = userID;
            this.user_type = user_type;

            // set user's info
            label3.Text = username;
            label4.Text = nome;
            try
            {
                pictureBox2.Load(foto);
            }catch(Exception e)
            {
                pictureBox2.Image = Properties.Resources.user_default;
            }

            // check if it is a station
            if (user_type=="station")
            {
                Control[] controls = this.Controls.Find("homeController", true);
                Home h = (Home)controls[0];

                h.showBtnAddShow();
            }

            this.username = username;
            this.original_username = username;

            Login lg = (Login) Controls.Find("loginPanel", true)[0];
            this.Controls.Remove(lg);
            createTileBar();


        }

        private void Form2_Move(object sender, EventArgs e)
        {
            setSize();
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                this.Location = new Point(0, 0);
                setSize();
            }
            else if (this.WindowState==FormWindowState.Normal)
            {
                setSize();
            }
        }

        private void Main_ResizeBegin(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            createProfile();
            createHome();
            createSearch();
            createLibrary();
            createChat();
            createShow();
            createShowManage();
            createPlaylist();
            createPlaylist_form();
            createAddEpisode();
            createAddShow();

            openHome();
            createLogin();
        }

        private void createHome()
        {
            Home h = new Home(this);
            h.Name = "homeController";
            h.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            h.Size = new Size(629, 693);
            h.Location = new Point(400, 0);

            this.Controls.Add(h);
        }

        private void openHome()
        {
            Control[] controls = this.Controls.Find("homeController", true);
            Home h = (Home) controls[0];

            h.BringToFront();
        }

        private void createSearch()
        {
            Search s = new Search(this);
            s.Name = "searchController";
            s.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            s.Size = new Size(629, 693);
            s.Location = new Point(400, 0);

            this.Controls.Add(s);
        }

        private void openSearch()
        {
            Control[] controls = this.Controls.Find("searchController", true);
            Search s = (Search) controls[0];

            s.BringToFront();
        }

        private void createPlaylist_form()
        {
            AddPlaylist ap = new AddPlaylist(this);
            ap.Name = "addplaylistController";
            ap.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            ap.Size = new Size(629, 693);
            ap.Location = new Point(400, 0);

            this.Controls.Add(ap);
        }

        public void openPlaylist_form()
        {
            Control[] controls = this.Controls.Find("addplaylistController", true);
            AddPlaylist ap = (AddPlaylist)controls[0];

            ap.BringToFront();
        }

        private void createLibrary()
        {
            Library l = new Library(this);
            l.Name = "libraryController";
            l.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            l.Size = new Size(629, 693);
            l.Location = new Point(400, 0);

            this.Controls.Add(l);
        }

        private void openLibrary()
        {
            Control[] controls = this.Controls.Find("libraryController", true);
            Library l = (Library)controls[0];

            l.BringToFront();
            l.loadPlaylists();
        }

        private void createChat()
        {
            Chat c = new Chat(this);
            c.Name = "chatController";
            c.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            c.Size = new Size(629, 693);
            c.Location = new Point(400, 0);

            this.Controls.Add(c);
        }

        public void openChat(int id, string nome, string username, string foto)
        {
            Control[] controls = this.Controls.Find("chatController", true);
            Chat c = (Chat)controls[0];

            c.BringToFront();
            c.loadStation(id, nome, username, foto);
            addProgramsToSideBar(id);
            currentOpenedId = id;
        }

        private void createShow()
        {
            Show s = new Show(this);
            s.Name = "showController";
            s.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            s.Size = new Size(629, 693);
            s.Location = new Point(400, 0);

            this.Controls.Add(s);
        }

        public void openShow()
        {
            Control[] controls = this.Controls.Find("showController", true);
            Show s = (Show)controls[0];

            s.BringToFront();
        }

        private void createShowManage()
        {
            ShowManage sm = new ShowManage(this);
            sm.Name = "showManageController";
            sm.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            sm.Size = new Size(629, 693);
            sm.Location = new Point(400, 0);

            this.Controls.Add(sm);
        }

        public void openShowManage()
        {
            Control[] controls = this.Controls.Find("showManageController", true);
            ShowManage sm = (ShowManage)controls[0];

            sm.BringToFront();
        }

        // for the right panel
        private void createProfile()
        {
            cnn.Open();
            SqlCommand sqlCmd = new SqlCommand("programasLocutor", cnn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@locutorId", SqlDbType.Int).Value = userID;
            SqlDataReader dr = sqlCmd.ExecuteReader();

            panel1.HorizontalScroll.Maximum = 0;
            if (dr.HasRows)
            {
                int x = 0;
                while (dr.Read())
                {
                    string nome_show = dr.GetString(0);
                    string descricao_show = dr.GetString(1);
                    string foto_show = dr.GetString(2);
                    string nome_estacao = dr.GetString(3);

                    Panel p = new Panel();
                    p.Location = new Point(0, (int)(142 * x));
                    p.Size = new Size(365, 142);
                    p.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                    p.MouseEnter += new EventHandler(hoverPanel);
                    p.MouseLeave += new EventHandler(outPanel);

                    PictureBox pb = new PictureBox();
                    pb.Size = new Size(100, 100);
                    pb.Location = new Point(9, 21);
                    pb.BackColor = Color.AliceBlue;
                    pb.Load(foto_show);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;

                    Label l1 = new Label();
                    l1.Text = nome_show;
                    l1.ForeColor = Color.White;
                    l1.Font = new Font(new FontFamily("Segoe UI"), (float)12.0, FontStyle.Bold, GraphicsUnit.Point); //Segoe UI; 12pt; style=Bold
                    l1.Location = new Point(115, 33);
                    l1.Size = new Size(365, 32);

                    Label l2 = new Label();
                    l2.Text = nome_estacao;
                    l2.ForeColor = Color.White;
                    l2.Font = new Font(new FontFamily("Segoe UI"), (float)10.0, FontStyle.Regular, GraphicsUnit.Point); //Segoe UI; 12pt; style=Bold
                    l2.Location = new Point(117, 77);

                    p.Controls.Add(pb);
                    p.Controls.Add(l1);
                    p.Controls.Add(l2);
                    panel1.Controls.Add(p);
                    x++;
                }
            }
            cnn.Close();
        }

        void createPlaylist()
        {
            Playlist sp = new Playlist(this);
            sp.Name = "showPlaylist";
            sp.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            sp.Size = new Size(629, 693);
            sp.Location = new Point(400, 0);

            this.Controls.Add(sp);
        }

        public void openPlaylist(string genreName, bool playlist)
        {
            Control[] controls = this.Controls.Find("showPlaylist", true);
            Playlist sp = (Playlist)controls[0];
            sp.BringToFront();
            sp.loadShows(playlist, genreName);
        }

        public void openPlaylist(int id, bool playlist)
        {
            Control[] controls = this.Controls.Find("showPlaylist", true);
            Playlist sp = (Playlist)controls[0];
            sp.BringToFront();
            sp.loadShows(playlist, id);
        }

        private void createAddShow()
        {
            ShowManage l = new ShowManage(this);
            l.Name = "AddShowController";
            l.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            l.Size = new Size(629, 693);
            l.Location = new Point(400, 0);

            this.Controls.Add(l);
        }

        public void openAddShow()
        {
            Control[] controls = this.Controls.Find("AddShowController", true);
            ShowManage l = (ShowManage)controls[0];

            l.BringToFront();
        }

        private void createAddEpisode()
        {
            AddEpisode l = new AddEpisode();
            l.Name = "AddEpisodeController";
            l.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            l.Size = new Size(629, 693);
            l.Location = new Point(400, 0);

            this.Controls.Add(l);
        }

        public void openAddEpisode()
        {
            Control[] controls = this.Controls.Find("AddEpisodeController", true);
            AddEpisode l = (AddEpisode)controls[0];

            l.BringToFront();
        }

        void hoverPanel(Object p, EventArgs e)
        {
            Panel p1 = (Panel) p;
            p1.BackColor = Color.FromArgb(50, 221, 221, 221);
        }

        void outPanel(Object p, EventArgs e)
        {
            Panel p1 = (Panel)p;
            p1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = nome;
            label3.Text = username;

            label5.Visible = true;
            panel1.Visible = true;
            openHome();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openSearch();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openLibrary();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            playing = !playing;

            if (playing)
            {
                button4.Image = Properties.Resources.pause_2;
            }
            else
            {
                button4.Image = Properties.Resources.play21;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            openShow();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // set right panel information
            //openChat(0);
        }

        public void setCurrentPlay(int programaID)
        {
            this.currentPlaylingId = programaID;
            cnn.Open();
            SqlCommand sqlCmd = new SqlCommand("detailsPrograma", cnn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = programaID; // to-do change this
            SqlDataReader dr = sqlCmd.ExecuteReader();

            if (dr.HasRows)
            {
                int x = 0;
                while (dr.Read())
                {
                    string nome_track = dr.GetString(0);
                    string foto_track = dr.GetString(3);
                    string username_track = dr.GetString(4);

                    label1.Text = nome_track;
                    label2.Text = username_track;
                    try
                    {
                        pictureBox1.Load(foto_track);
                    }catch(Exception e)
                    {
                        pictureBox1.Image = Properties.Resources.image_not_found;
                    }
                }
            }

            cnn.Close();
        }

        public void setNameStation(string station_name, string station_username, string foto)
        {
            label4.Text = station_name;
            label3.Text = station_username;

            if (station_username==original_username)
            {
                button7.Visible = false;
            }
            else
            {
                button7.Visible = true;
            }

            try
            {
                pictureBox2.Load(foto);
            }
            catch (Exception e)
            {
                pictureBox2.Image = Properties.Resources.user_default;
            }
        }

        public void addProgramsToSideBar(int id)
        {
            cnn.Open();

            // GET station programs
            SqlCommand sqlCmd = new SqlCommand("selectedEstacao", cnn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@selEstacaoId", SqlDbType.Int).Value = id;
            SqlDataReader dr = sqlCmd.ExecuteReader();

            panel1.Controls.Clear();
            if (dr.HasRows)
            {
                int x = 0;
                while (dr.Read())
                {
                    int id_program = dr.GetInt32(0);
                    string nome_program = dr.GetString(1);
                    string foto_program = dr.GetString(3);

                    Panel p = new Panel();
                    p.Location = new Point(0, (int)(142 * x));
                    p.Size = new Size(365, 142);
                    p.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                    p.MouseEnter += new EventHandler(hoverPanel);
                    p.MouseLeave += new EventHandler(outPanel);

                    PictureBox pb = new PictureBox();
                    pb.Size = new Size(100, 100);
                    pb.Location = new Point(9, 21);
                    pb.BackColor = Color.AliceBlue;
                    try
                    {
                        pb.Load(foto_program);
                    }
                    catch (Exception e)
                    {
                        pb.Image = Properties.Resources.image_not_found;
                    }
                    
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;

                    Label l1 = new Label();
                    l1.Text = nome_program;
                    l1.ForeColor = Color.White;
                    l1.Font = new Font(new FontFamily("Segoe UI"), (float)12.0, FontStyle.Bold, GraphicsUnit.Point); //Segoe UI; 12pt; style=Bold
                    l1.Location = new Point(115, 33);
                    l1.Size = new Size(365, 32);

                    Label l2 = new Label();
                    l2.Text = "this station";
                    l2.ForeColor = Color.White;
                    l2.Font = new Font(new FontFamily("Segoe UI"), (float)10.0, FontStyle.Regular, GraphicsUnit.Point); //Segoe UI; 12pt; style=Bold
                    l2.Location = new Point(117, 77);

                    p.Controls.Add(pb);
                    p.Controls.Add(l1);
                    p.Controls.Add(l2);
                    panel1.Controls.Add(p);
                    x++;
                }
            }
            cnn.Close();
        }

        public void addOwnPlaylistsDropbox()
        {
            cnn.Open();

            // GET station programs
            SqlCommand sqlCmd = new SqlCommand("listUserPlaylists", cnn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@userid", SqlDbType.Int).Value = this.userID;
            SqlDataReader dr = sqlCmd.ExecuteReader();

            darkComboBox1.Items.Clear();
            if (dr.HasRows)
            {
                int x = 0;
                while (dr.Read())
                {
                    int id_playlist = dr.GetInt32(0);
                    string nome_playlist = dr.GetString(1);

                    darkComboBox1.Items.Add(id_playlist.ToString() + " - " + nome_playlist);
                }
            }

            cnn.Close();
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            string option = darkComboBox1.Text;
            string[] components = option.Split(" - ");

            int id_playlist = int.Parse(components[0]);

            cnn.Open();
            SqlCommand sqlCmd = new SqlCommand("addProgramaToPlaylist", cnn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@playlistid", SqlDbType.Int).Value = id_playlist;
            sqlCmd.Parameters.AddWithValue("@programaid", SqlDbType.Int).Value = this.currentPlaylingId;
            sqlCmd.Parameters.AddWithValue("@userid", SqlDbType.Int).Value = this.userID;
            SqlDataReader dr = sqlCmd.ExecuteReader();
            cnn.Close();
            MessageBox.Show("Adicionado");
        }

        public void searchSearch(String termo)
        {
            Control[] controls = this.Controls.Find("searchController", true);
            Search s = (Search)controls[0];

            s.BringToFront();
            s.searchBoxTrigger(termo);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand sqlCmd = new SqlCommand("doFollow", cnn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@followedUserID", SqlDbType.Text).Value = currentOpenedId;
            sqlCmd.Parameters.AddWithValue("@followerUserID", SqlDbType.Int).Value = userID;
            SqlDataReader dr = sqlCmd.ExecuteReader();
            MessageBox.Show("Seguindo");
            cnn.Close();
        }
    }
}