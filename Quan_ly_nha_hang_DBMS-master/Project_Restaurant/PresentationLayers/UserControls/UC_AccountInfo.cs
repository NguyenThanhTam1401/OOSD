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

namespace Project_Restaurant.PresentationLayers.UserControls
{
    public partial class UC_AccountInfo : UserControl
    {
        private Account Account;
        public UC_AccountInfo()
        {
            InitializeComponent();
            this.Account = Form1.Account;
            timer1.Interval = 100;
            timer1.Start();
            LoadData();
        }

        private void LoadData()
        {
            tbxUsername.Text = Account.User;
            tbxName.Text = Account.Ten;
            tbxId.Text = Account.Id.ToString();
            tbxIdentity.Text = Account.IdentityCard;
            tbxGender.Text = Account.Sex;
            tbxPhone.Text = Account.PhoneNumber;
            tbxPosition.Text = Account.Work;
            tbxBirthDay.Text = Account.DateOfBirth.ToShortDateString();
            tbxStartDate.Text = Account.StartDay.ToShortDateString();
            tbxShift.Text = Account.Shift.ToString();
            tbxAddress.Text = Account.Address;
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
