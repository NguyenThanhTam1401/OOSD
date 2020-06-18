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
    public partial class frmAccountInfo : Form
    {
        public frmAccountInfo()
        {
            InitializeComponent();
            uC_AccountInfo1.BringToFront();
            button1.ForeColor = Color.White;
            button1.BackColor = Color.FromArgb(81, 36, 103);

            button2.ForeColor = Color.FromArgb(81, 36, 103);
            button2.BackColor = Color.White;
            button3.ForeColor = Color.FromArgb(81, 36, 103);
            button3.BackColor = Color.White;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            uC_AccountInfo1.BringToFront();
            button1.ForeColor = Color.White;
            button1.BackColor = Color.FromArgb(81, 36, 103);
            panel2.Top = button1.Top;
            panel2.Height = button1.Height;

            button2.ForeColor = Color.FromArgb(81, 36, 103);
            button2.BackColor = Color.White;
            button3.ForeColor = Color.FromArgb(81, 36, 103);
            button3.BackColor = Color.White;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            uC_EditAccount1.BringToFront();

            button2.ForeColor = Color.White;
            button2.BackColor = Color.FromArgb(81, 36, 103);
            panel2.Top = button2.Top;
            panel2.Height = button2.Height;

            button1.ForeColor = Color.FromArgb(81, 36, 103);
            button1.BackColor = Color.White;
            button3.ForeColor = Color.FromArgb(81, 36, 103);
            button3.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uC_EditAccount1_Load(object sender, EventArgs e)
        {

        }
    }
}
