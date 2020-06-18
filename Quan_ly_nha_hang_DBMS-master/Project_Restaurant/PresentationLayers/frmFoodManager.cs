using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Restaurant
{
    public partial class frmFoodManager : Form
    {
        public frmFoodManager()
        {
            InitializeComponent();
            uC_FoodManager1.BringToFront();
            button1.ForeColor = Color.FromArgb(81, 36, 103);
            button1.BackColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;
            button1.ForeColor = Color.FromArgb(81, 36, 103);
            button1.BackColor = Color.White;
            uC_FoodManager1.BringToFront();

            button2.BackColor = Color.FromArgb(81, 36, 103);
            button2.ForeColor = Color.White;
            button3.BackColor = Color.FromArgb(81, 36, 103);
            button3.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button2.Height;
            sidepanel.Top = button2.Top;
            button2.ForeColor = Color.FromArgb(81, 36, 103);
            button2.BackColor = Color.White;
            uC_Catelog1.BringToFront();

            button1.BackColor = Color.FromArgb(81, 36, 103);
            button1.ForeColor = Color.White;
            button3.BackColor = Color.FromArgb(81, 36, 103);
            button3.ForeColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button3.Height;
            sidepanel.Top = button3.Top;
            button3.ForeColor = Color.FromArgb(81, 36, 103);
            button3.BackColor = Color.White;
            

            button1.BackColor = Color.FromArgb(81, 36, 103);
            button1.ForeColor = Color.White;
            button2.BackColor = Color.FromArgb(81, 36, 103);
            button2.ForeColor = Color.White;
        }
    }
}
