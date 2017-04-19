using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasarım_Projesi
{
    class Stick:IDrawable,IChargable
    {
        public int s1 = 30, s2=120 ,s3=50, s4=12;
        public int x;
        public void draw(Graphics grp)
        {
            //Bakır cubuk
            grp.FillRectangle(Brushes.Teal, s1, s2, s3, s4);
        }

        public void charge(int ky)
        {            
            x = ky;
           // MessageBox.Show("charge calisti");
        }
    }
}
