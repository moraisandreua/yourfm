using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows;

namespace YourFmNew
{
    public partial class Main : Vip.CustomForm.FormBase
    {
        Title titleBarBtn = null;
        int titleBarBtn_left = 0;
        int titleBarBtn_top = 0;
        bool playing = false;

        private void setSize()
        {
            titleBarBtn.Location = new Point(this.Location.X + titleBarBtn_left, this.Location.Y + titleBarBtn_top);
            titleBarBtn.Size = new Size(this.Size.Width - 100, 41);
        }

        public Main()
        {
            InitializeComponent();
            titleBarBtn = new Title(this);
            setSize();
            titleBarBtn.Show();
            titleBarBtn.Owner = this;
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
            createProfile("username");
            createHome();
            createSearch();
            createLibrary();
            createChat();
            createShow();
            createShowManage();

            openHome();
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
            Search s = new Search();
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

        private void createLibrary()
        {
            Library l = new Library();
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
        }

        private void createChat()
        {
            Chat c = new Chat();
            c.Name = "chatController";
            c.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            c.Size = new Size(629, 693);
            c.Location = new Point(400, 0);

            this.Controls.Add(c);
        }

        public void openChat()
        {
            Control[] controls = this.Controls.Find("chatController", true);
            Chat c = (Chat)controls[0];

            c.BringToFront();
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
            ShowManage sm = new ShowManage();
            sm.Name = "showManageController";
            sm.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            sm.Size = new Size(629, 693);
            sm.Location = new Point(400, 0);

            this.Controls.Add(sm);
        }

        public void openShowManage()
        {
            Control[] controls = this.Controls.Find("showManageController", true);
            Show sm = (Show)controls[0];

            sm.BringToFront();
        }

        private void createProfile(String username)
        {
            // TODO: set name
            // TODO: set username
            // TODO: set hosted shows
            panel1.HorizontalScroll.Maximum = 0;
            for (int i=0; i<4; i++)
            {
                // size: 365; 142
                Panel p = new Panel();
                p.Location = new Point(0, (int) (142*i));
                p.Size = new Size(365, 142);
                p.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                p.MouseEnter += new EventHandler(hoverPanel);
                p.MouseLeave += new EventHandler(outPanel);

                PictureBox pb = new PictureBox();
                pb.Size = new Size(100,100);
                pb.Location = new Point(9,21);
                pb.BackColor = Color.AliceBlue;

                Label l1 = new Label();
                l1.Text = "Nome do programa";
                l1.ForeColor = Color.White;
                l1.Font = new Font(new FontFamily("Segoe UI"), (float) 12.0, FontStyle.Bold, GraphicsUnit.Point); //Segoe UI; 12pt; style=Bold
                l1.Location = new Point(115, 33);
                l1.Size = new Size(365, 32);

                Label l2 = new Label();
                l2.Text = "username da estação";
                l2.ForeColor = Color.White;
                l2.Font = new Font(new FontFamily("Segoe UI"), (float)10.0, FontStyle.Regular, GraphicsUnit.Point); //Segoe UI; 12pt; style=Bold
                l2.Location = new Point(117, 77);

                p.Controls.Add(pb);
                p.Controls.Add(l1);
                p.Controls.Add(l2);
                panel1.Controls.Add(p);
            }
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
            openChat();
        }
    }
}