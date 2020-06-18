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
    public partial class UC_Administrator : UserControl
    {
        public UC_Administrator()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmFoodManager frmFoodManager = new frmFoodManager();
            frmFoodManager.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmStatistical frmStatistical = new frmStatistical();
            frmStatistical.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAccountInfo frmAccountInfo = new frmAccountInfo();
            frmAccountInfo.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmFoodManager frm = new frmFoodManager();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmStatistical frm = new frmStatistical();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmAccount frm = new frmAccount();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmVoucher frm = new frmVoucher();
            frm.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frmTable frm = new frmTable();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmEmployeer frm = new frmEmployeer();
            frm.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            frmWorking frm = new frmWorking();
            frm.ShowDialog();

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            frmWorkStatiscal frm = new frmWorkStatiscal();
            frm.ShowDialog();
        }
    }
}
