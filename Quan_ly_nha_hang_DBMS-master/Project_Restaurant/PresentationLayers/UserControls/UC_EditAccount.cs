using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Restaurant.Models;
using Project_Restaurant.BusinessLayers;

namespace Project_Restaurant.UserControls
{
    public partial class UC_EditAccount : UserControl
    {
        private Account account;
        private BLAccount bLAccout;
        private string error;
        public UC_EditAccount()
        {
            InitializeComponent();
            this.account = Form1.Account;
            bLAccout = new BLAccount();
            LoadData();
        }

        private void LoadData()
        {
            tbxName.Text = account.Ten;
            tbxIdentity.Text = account.IdentityCard;
            tbxGender.Text = account.Sex;
            tbxPhone.Text = account.PhoneNumber;
            dtBirthDay.Value = account.DateOfBirth;
            tbxAddress.Text = account.Address;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbxNewPass.ResetText();
            tbxOldPass.ResetText();
            tbxConfirm.ResetText();
            tbxName.ResetText();
            tbxIdentity.ResetText();
            tbxGender.ResetText();
            tbxPhone.ResetText();
            tbxAddress.ResetText();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckData())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!",
                "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbxOldPass.Text.Trim() != this.account.PassWord)
            {
                MessageBox.Show("Mật khẩu cũ sai, vui lòng nhập lại!",
                "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(tbxNewPass.Text.Trim() != tbxConfirm.Text.Trim())
            {
                MessageBox.Show("Xác nhận mật khẩu mới không chính xác vui lòng nhập lại!",
                "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UpdateInformation())
            {
                Form1.Account = this.account = bLAccout.GetAccount(this.account.User, this.tbxNewPass.Text.Trim());
                btnDelete.PerformClick();
                LoadData();
                MessageBox.Show("Cập nhật thành công!\nHãy ghi nhớ tài khoản và mật khẩu của bạn, nếu quên, hãy liên hệ quản trị viên của bạn!",
                "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show(error, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool CheckData()
        {
            if (tbxNewPass.Text.Trim() == "" || tbxOldPass.Text.Trim() == "" || tbxConfirm.Text.Trim() == "" ||
                tbxName.Text.Trim() == "" || tbxIdentity.Text.Trim() == "" || tbxGender.Text.Trim() == "" ||
                tbxPhone.Text.Trim() == "" || tbxAddress.Text.Trim() == "")
                return false;

            return true;
        }

        private bool UpdateInformation()
        {
            return bLAccout.ChangeInfo(this.account.User, tbxOldPass.Text.Trim(), tbxNewPass.Text.Trim(),
                this.account.Id, tbxName.Text.Trim(), tbxGender.Text.Trim(), tbxIdentity.Text.Trim(),
                tbxAddress.Text.Trim(), tbxPhone.Text.Trim(), dtBirthDay.Value.ToShortDateString(), ref error);
        }
    }
}
