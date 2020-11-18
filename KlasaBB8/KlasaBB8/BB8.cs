using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
namespace KlasaBB8
{
    class BB_8
    {
        Random x1 = new Random();
        Random y1 = new Random();
        int a;
        Point o;
        

        public   BB_8(Point o, int a)
        {
            this.o = o;
            this.a = a;
            
        }

        public void Crtaj(Graphics g,Color boja)
        {
            Pen olovka = new Pen(Color.Black, 3);
            SolidBrush cetka1 = new SolidBrush(Color.Black);
            SolidBrush cetka2 = new SolidBrush(Color.White);
            SolidBrush cetka3 = new SolidBrush(boja);
            g.FillPie(cetka2, o.X - a / 4, o.Y - a / 4, a / 2, a / 2, 180, 180);
            g.DrawPie(olovka, o.X - a / 4, o.Y - a / 4, a / 2, a / 2, 180, 180);
            g.DrawLine(olovka, o.X - a / 4, o.Y, o.X + a / 4, o.Y);
            g.FillEllipse(cetka1, o.X - a / 16, o.Y - 3 * a / 16, a / 8, a / 8);
            g.FillEllipse(cetka2, o.X - a / 2, o.Y, a, a);
            g.DrawEllipse(olovka, o.X - a / 2, o.Y, a, a);
            g.FillEllipse(cetka3, o.X - a / 4, o.Y + a / 4, a / 2, a / 2);
            g.DrawEllipse(olovka, o.X - a / 4, o.Y + a / 4, a / 2, a / 2);
            g.DrawLine(olovka, o.X, o.Y - a / 4, o.X, o.Y - 3 * a / 8);
        }
        public void PomeriDesno()
        {
 
            o.X += 10;
          
        }
        public void PomeriLevo()
        {

            o.X -= 10;
        }
    }
}
