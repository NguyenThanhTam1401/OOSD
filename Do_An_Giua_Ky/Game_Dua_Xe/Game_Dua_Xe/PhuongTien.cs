using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Dua_Xe
{
    public class PhuongTien:PictureBox
    {
        public PhuongTien()
        {
            this.BackColor = Color.Silver;
            this.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public int Speed { get; set; }

        public void ReLocation()
        {
            Random random = new Random();
            int x = random.Next(10, 260);
            int y = random.Next(-300, -20);
            this.Location = new Point(x, y);
        }
        public new virtual void Move()
        {
            this.Top += this.Speed;
        }
        public bool IsIntersect(Control control)
        {
            if (this.Bounds.IntersectsWith(control.Bounds))
                return true;
            return false;
        }
        
    }
}
