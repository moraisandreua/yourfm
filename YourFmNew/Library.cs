﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourFmNew
{
    public partial class Library : UserControl
    {
        public Library()
        {
            InitializeComponent();
        }

        private void loadShows()
        {
            panel1.Controls.Clear();
            int pictureSize = 200;

            for (int x = 1; x <= 15; x++)
            {
                PictureBox pb = new PictureBox();
                pb.Width = (int)pictureSize;
                pb.Height = (int)pictureSize;

                double left = (x * 20) + ((x - 1) * pictureSize);
                int top = 0;

                pb.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                pb.Location = new Point((int)left, top);
                pb.BackColor = Color.AliceBlue;
                panel1.Controls.Add(pb);
            }
        }

        private void loadStations()
        {
            panel2.Controls.Clear();
            int pictureSize = 200;

            for (int x = 1; x <= 15; x++)
            {
                PictureBox pb = new PictureBox();
                pb.Width = (int)pictureSize;
                pb.Height = (int)pictureSize;

                double left = (x * 20) + ((x - 1) * pictureSize);
                int top = 0;

                pb.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                pb.Location = new Point((int)left, top);
                pb.BackColor = Color.AliceBlue;
                panel2.Controls.Add(pb);
            }
        }

        private void Library_Load(object sender, EventArgs e)
        {
            loadShows();
            loadStations();
        }
    }
}