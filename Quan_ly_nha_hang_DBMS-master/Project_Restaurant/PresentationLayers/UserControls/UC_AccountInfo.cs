using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Restaurant.UserControls
{
    public partial class UC_AccountInfo : UserControl
    {
        public UC_AccountInfo()
        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int value = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            value++;
            Random rd = new Random();
            if (value % 2 == 0)
            {
                panel3.BackColor = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
            }
            panel1.BackColor = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
            if (value % 3 == 0)
            {
                panel2.BackColor = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
            }
        }

    }
}
