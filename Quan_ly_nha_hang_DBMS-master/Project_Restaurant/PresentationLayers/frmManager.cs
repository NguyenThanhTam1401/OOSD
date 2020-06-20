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



        private void uC_Administrator1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            panelmove.Height = btnAdmin.Height;
            panelmove.Top = btnAdmin.Top;
            btnAdmin.ForeColor = Color.FromArgb(81, 36, 103);
            btnAdmin.BackColor = Color.White;
            uC_Administrator1.BringToFront();




            btnInfo.BackColor = Color.FromArgb(81, 36, 103);
            btnInfo.ForeColor = Color.White;
            btnTableManager.BackColor = Color.FromArgb(81, 36, 103);
            btnTableManager.ForeColor = Color.White;
            btnLogOut.BackColor = Color.FromArgb(81, 36, 103);
            btnLogOut.ForeColor = Color.White;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            panelmove.Height = btnInfo.Height;
            panelmove.Top = btnInfo.Top;
            btnInfo.ForeColor = Color.FromArgb(81, 36, 103);
            btnInfo.BackColor = Color.White;
            frmAccountInfo frmAccountInfo = new frmAccountInfo();
            frmAccountInfo.ShowDialog();

            btnAdmin.BackColor = Color.FromArgb(81, 36, 103);
            btnAdmin.ForeColor = Color.White;
            btnTableManager.BackColor = Color.FromArgb(81, 36, 103);
            btnTableManager.ForeColor = Color.White;
            btnLogOut.BackColor = Color.FromArgb(81, 36, 103);
            btnLogOut.ForeColor = Color.White;
        }

        private void btnTableManager_Click(object sender, EventArgs e)
        {
            panelmove.Height = btnTableManager.Height;
            panelmove.Top = btnTableManager.Top;
            btnTableManager.ForeColor = Color.FromArgb(81, 36, 103);
            btnTableManager.BackColor = Color.White;


            btnAdmin.BackColor = Color.FromArgb(81, 36, 103);
            btnAdmin.ForeColor = Color.White;
            btnInfo.BackColor = Color.FromArgb(81, 36, 103);
            btnInfo.ForeColor = Color.White;
            btnLogOut.BackColor = Color.FromArgb(81, 36, 103);
            btnLogOut.ForeColor = Color.White;
            frmTableManager frm = new frmTableManager();
            frm.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            panelmove.Height = btnLogOut.Height;
            panelmove.Top = btnLogOut.Top;
            btnLogOut.ForeColor = Color.FromArgb(81, 36, 103);
            btnLogOut.BackColor = Color.White;


            btnAdmin.BackColor = Color.FromArgb(81, 36, 103);
            btnAdmin.ForeColor = Color.White;
            btnInfo.BackColor = Color.FromArgb(81, 36, 103);
            btnInfo.ForeColor = Color.White;
            btnTableManager.BackColor = Color.FromArgb(81, 36, 103);
            btnTableManager.ForeColor = Color.White;

            Application.Exit();

            DialogResult dl = MessageBox.Show("Đăng xuất tài khoản?",
"Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                Form1.Account = null;
                this.Close();
            }
        }

        private void frmManager_Load(object sender, EventArgs e)
        {
            if(Form1.Account.IsAdmin == 1)
            {
                btnAdmin.PerformClick();
            }
            else
            {
                btnAdmin.Enabled = false;
                uC_Administrator1.Enabled = false;
                btnTableManager.PerformClick();
            }
        }
    }
}
