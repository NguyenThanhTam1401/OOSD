using Project_Restaurant.BusinessLayers;
using Project_Restaurant.Models;
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
    public partial class Form1 : Form
    {
        private BLAccount DangNhap;
        public static Account Account;
        public Form1()
        {
            InitializeComponent();
            DangNhap = new BLAccount();
            Account = new Account();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbxUsername.Text.Trim() == "" || tbxPass.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Username và Password!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxUsername.Focus();
                return;
            }

            Form1.Account = DangNhap.GetAccount(tbxUsername.Text.Trim(), tbxPass.Text.Trim());
            if(Form1.Account == null)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxUsername.Focus();
                return;
            }

            btnDelete.PerformClick();

            frmManager frmManager = new frmManager();
            frmManager.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbxUsername.ResetText();
            tbxPass.ResetText();
            tbxUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
    //        DialogResult dl = MessageBox.Show("Bạn có muốn thoát không?",
    //"Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    //        if (dl == DialogResult.Yes)
                this.Close();
        }

        private void tbxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbxPass.Focus();
        }

        private void tbxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
