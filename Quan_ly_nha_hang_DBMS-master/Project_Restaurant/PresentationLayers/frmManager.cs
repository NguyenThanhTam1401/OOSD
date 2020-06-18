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
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelmove.Height = button2.Height;
            panelmove.Top = button2.Top;
            button2.ForeColor = Color.FromArgb(81, 36, 103);
            button2.BackColor = Color.White;
            uC_Administrator1.BringToFront();




            button3.BackColor = Color.FromArgb(81, 36, 103);
            button3.ForeColor = Color.White;
            button4.BackColor = Color.FromArgb(81, 36, 103);
            button4.ForeColor = Color.White;
            button5.BackColor = Color.FromArgb(81, 36, 103);
            button5.ForeColor = Color.White;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            panelmove.Height = button3.Height;
            panelmove.Top = button3.Top;
            button3.ForeColor = Color.FromArgb(81, 36, 103);
            button3.BackColor = Color.White;
            frmAccountInfo frmAccountInfo = new frmAccountInfo();
            frmAccountInfo.ShowDialog();

            button2.BackColor = Color.FromArgb(81, 36, 103);
            button2.ForeColor = Color.White;
            button4.BackColor = Color.FromArgb(81, 36, 103);
            button4.ForeColor = Color.White;
            button5.BackColor = Color.FromArgb(81, 36, 103);
            button5.ForeColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            panelmove.Height = button4.Height;
            panelmove.Top = button4.Top;
            button4.ForeColor = Color.FromArgb(81, 36, 103);
            button4.BackColor = Color.White;


            button2.BackColor = Color.FromArgb(81, 36, 103);
            button2.ForeColor = Color.White;
            button3.BackColor = Color.FromArgb(81, 36, 103);
            button3.ForeColor = Color.White;
            button5.BackColor = Color.FromArgb(81, 36, 103);
            button5.ForeColor = Color.White;
            frmTableManager frm = new frmTableManager();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelmove.Height = button5.Height;
            panelmove.Top = button5.Top;
            button5.ForeColor = Color.FromArgb(81, 36, 103);
            button5.BackColor = Color.White;


            button2.BackColor = Color.FromArgb(81, 36, 103);
            button2.ForeColor = Color.White;
            button3.BackColor = Color.FromArgb(81, 36, 103);
            button3.ForeColor = Color.White;
            button4.BackColor = Color.FromArgb(81, 36, 103);
            button4.ForeColor = Color.White;
        }

        private void uC_Administrator1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
