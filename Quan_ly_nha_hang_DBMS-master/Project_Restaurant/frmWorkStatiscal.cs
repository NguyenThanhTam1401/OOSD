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
    public partial class frmWorkStatiscal : Form
    {
        public frmWorkStatiscal()
        {
            InitializeComponent();
            uC_Work1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uC_Work1.BringToFront();

            panel2.Top = button1.Top;
            panel2.Height = button1.Height;
            button1.ForeColor = Color.White;
            button1.BackColor = Color.FromArgb(81, 36, 103);

            button2.ForeColor = Color.FromArgb(81, 36, 103);
            button2.BackColor = Color.White;
            button3.ForeColor = Color.FromArgb(81, 36, 103);
            button3.BackColor = Color.White;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            uC_WorkTime1.BringToFront();
            panel2.Top = button2.Top;
            panel2.Height = button2.Height;
            button2.ForeColor = Color.White;
            button2.BackColor = Color.FromArgb(81, 36, 103);

            button1.ForeColor = Color.FromArgb(81, 36, 103);
            button1.BackColor = Color.White;
            button3.ForeColor = Color.FromArgb(81, 36, 103);
            button3.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
