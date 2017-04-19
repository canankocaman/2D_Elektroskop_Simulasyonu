using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasarım_Projesi
{
    class Elektroskop:IDrawable,IChargable
    {
        public int x1 = 150, y1 = 220, x2=155, y2=260, x3=145, y3=260;
        
        Pen firca = new Pen(System.Drawing.Color.Black, 3);

        public void draw(Graphics grp)
        {
            //Daire
            grp.FillEllipse(Brushes.AliceBlue, 100, 200, 100, 100);
            grp.DrawEllipse(firca, 100, 200, 100, 100);

            //Sağ kol
            grp.DrawLine(firca, x1, y1, x2, y2);
            //Sol kol
            grp.DrawLine(firca, x1, y1, x3, y3);
            //Dik çizgi
            grp.DrawLine(firca, 150, 160, 150, 221);
            //Topuz
            grp.FillEllipse(Brushes.LightBlue, 135, 135, 30, 30);

            //grp.FillEllipse(Brushes.Red, x, y, 50, 50);
            //grp.FillRectangle(Brushes.Blue, 100, 100, 20, 20);
            // grp.DrawEllipse(firca, 400,200,100,100);

        }

        public void charge(int ky)
        {

            if (ky == (int)Keys.Left)
            {
                
            }
            if (ky == (int)Keys.Right)
            {
              
            }
        }


     }
}