using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KlasaBB8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color boja;
        Random r = new Random();
        int x = 0;
        Graphics g;
        BB_8 b;
        Point o;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {           
            b.Crtaj(g, boja);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            x = 1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x == 1)
            {
                b.PomeriDesno();
                Refresh();
            }
            if (x == 2)
            {
                b.PomeriLevo();
                Refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 600;
            Height = 600;
            int x = ClientRectangle.Width;
            int y = ClientRectangle.Height;
            o = new Point(ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            g = CreateGraphics();
            boja= Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            b = new BB_8(o, 100);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            x = 2;
        }
    }
}
