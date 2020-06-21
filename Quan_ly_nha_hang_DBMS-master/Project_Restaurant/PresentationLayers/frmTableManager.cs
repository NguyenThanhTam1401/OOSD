using Project_Restaurant.BusinessLayers;
using Project_Restaurant.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Restaurant
{
    public partial class frmTableManager : Form
    {
        private BLBill blBill;
        private BLBillInfo blBillInfo;
        private BLFood blFood;
        private BLFoodType blFoodType;
        private BLVoucher blVoucher;
        private BLFoodTable blFoodTable;

        public static int IDTABLE = -1;
        public static double TotalPrice;

        public static List<OrderedViewModel> lstOrdered;

        private string error;
        public frmTableManager()
        {
            InitializeComponent();

            VariableInit();
            InitFrontEnd();
            LayBanaAn();
            LoadCategory();

        }

        private void VariableInit()
        {
            blBill = new BLBill();
            blBillInfo = new BLBillInfo();
            blFood = new BLFood();
            blFoodType = new BLFoodType();
            blVoucher = new BLVoucher();
            blFoodTable = new BLFoodTable();
        }


        void LayBanaAn()
        {
            lvLayer1.Items.Clear();
            lvLayer2.Items.Clear();
            List<Table> lstTable = blFoodTable.LayDanhSachbBanAn();
            lvLayer1.LargeImageList = ilTableState;
            lvLayer2.LargeImageList = ilTableState;
            foreach (Table item in lstTable)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = item.Name + "\n" + item.Status;
                lv.Tag = item;
                if (item.Status == "Trống")
                    lv.ImageIndex = 0;
                else
                {
                    lv.ImageIndex = 1;
                    lv.BackColor = Color.Red;
                }
                if (item.IDArea == 1)
                    lvLayer1.Items.Add(lv);
                else
                    lvLayer2.Items.Add(lv);
            }
            cbxTable.DataSource = lstTable;
            cbxTable.DisplayMember = "Name";
        }

        void ShowBill(int IDtable)
        {
            lvBill.Items.Clear();
            TotalPrice = 0;
            lstOrdered = blFood.GetListOrdered(IDtable);
            foreach (OrderedViewModel item in lstOrdered)
            {
                ListViewItem lwitem = new ListViewItem(item.Foodname);
                lwitem.SubItems.Add(item.Price.ToString());
                lwitem.SubItems.Add(item.Count.ToString());
                lwitem.SubItems.Add(item.TotalPrice.ToString());
                TotalPrice += item.TotalPrice;
                lvBill.Items.Add(lwitem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            tbxTotal.Text = TotalPrice.ToString("c", culture);
        }

        void LoadCategory()
        {
            List<FoodType> lsType = blFoodType.GetListTypeFood();
            cbxCategory.DataSource = lsType;
            cbxCategory.DisplayMember = "TypeName";
        }
        void LoadFood(int IDType)
        {
            List<Food> lsFood = blFood.GetListFood(IDType);
            lbxFoodName.DataSource = lsFood;
            lbxFoodName.DisplayMember = "FoodName";

            lbxPrice.DataSource = lsFood;
            lbxPrice.DisplayMember = "Price";
        }
        private void showErr()
        {
            MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void SwitchTable()
        {
            int srcidbill = blBill.GetUnCheckBillID(IDTABLE);
            List<Table> lst = new List<Table>();
            lst = blFoodTable.LayDanhSachbBanAn();
            int idtb = lst[cbxTable.SelectedIndex].ID;
            int desidbill = blBill.GetUnCheckBillID(idtb);

            if (srcidbill == desidbill)
                return;
            else if (desidbill == -1)
            {
                if (!blBill.InSertBill(idtb, Form1.Account.User, ref error))
                    showErr();
            }
            else if (srcidbill == -1)
            {
                MessageBox.Show("Vui lòng chọn bàn!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!blBill.ChuyenBan(IDTABLE, idtb, Form1.Account.User, ref error))
                showErr();

            LayBanaAn();
            ShowBill(desidbill);

            MessageBox.Show("Đã chuyển bàn!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region Các Button phụ
        private void InitFrontEnd()
        {

            btnSearch.ForeColor = Color.White;
            btnSearch.BackColor = Color.FromArgb(81, 36, 103);

            btnSwichTable.ForeColor = Color.FromArgb(81, 36, 103);
            btnSwichTable.BackColor = Color.White;
            btnAdditionFood.ForeColor = Color.FromArgb(81, 36, 103);
            btnAdditionFood.BackColor = Color.White;
            btnVoucher.ForeColor = Color.FromArgb(81, 36, 103);
            btnVoucher.BackColor = Color.White;
            btnCategory.ForeColor = Color.FromArgb(81, 36, 103);
            btnCategory.BackColor = Color.White;
            btnExit.ForeColor = Color.FromArgb(81, 36, 103);
            btnExit.BackColor = Color.White;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            panel5.Top = btnSearch.Top;
            panel5.Height = btnSearch.Height;
            btnSearch.ForeColor = Color.White;
            btnSearch.BackColor = Color.FromArgb(81, 36, 103);

            btnSwichTable.ForeColor = Color.FromArgb(81, 36, 103);
            btnSwichTable.BackColor = Color.White;
            btnAdditionFood.ForeColor = Color.FromArgb(81, 36, 103);
            btnAdditionFood.BackColor = Color.White;
            btnVoucher.ForeColor = Color.FromArgb(81, 36, 103);
            btnVoucher.BackColor = Color.White;
            btnCategory.ForeColor = Color.FromArgb(81, 36, 103);
            btnCategory.BackColor = Color.White;
            btnExit.ForeColor = Color.FromArgb(81, 36, 103);
            btnExit.BackColor = Color.White;
        }

        private void btnSwichTable_Click(object sender, EventArgs e)
        {
            panel5.Top = btnSwichTable.Top;
            panel5.Height = btnSwichTable.Height;
            btnSwichTable.ForeColor = Color.White;
            btnSwichTable.BackColor = Color.FromArgb(81, 36, 103);

            btnSearch.ForeColor = Color.FromArgb(81, 36, 103);
            btnSearch.BackColor = Color.White;
            btnAdditionFood.ForeColor = Color.FromArgb(81, 36, 103);
            btnAdditionFood.BackColor = Color.White;
            btnVoucher.ForeColor = Color.FromArgb(81, 36, 103);
            btnVoucher.BackColor = Color.White;
            btnCategory.ForeColor = Color.FromArgb(81, 36, 103);
            btnCategory.BackColor = Color.White;
            btnExit.ForeColor = Color.FromArgb(81, 36, 103);
            btnExit.BackColor = Color.White;
        }

        private void btnAdditionFood_Click(object sender, EventArgs e)
        {
            panel5.Top = btnAdditionFood.Top;
            panel5.Height = btnAdditionFood.Height;
            btnAdditionFood.ForeColor = Color.White;
            btnAdditionFood.BackColor = Color.FromArgb(81, 36, 103);

            btnSearch.ForeColor = Color.FromArgb(81, 36, 103);
            btnSearch.BackColor = Color.White;
            btnSwichTable.ForeColor = Color.FromArgb(81, 36, 103);
            btnSwichTable.BackColor = Color.White;
            btnVoucher.ForeColor = Color.FromArgb(81, 36, 103);
            btnVoucher.BackColor = Color.White;
            btnCategory.ForeColor = Color.FromArgb(81, 36, 103);
            btnCategory.BackColor = Color.White;
            btnExit.ForeColor = Color.FromArgb(81, 36, 103);
            btnExit.BackColor = Color.White;
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            panel5.Top = btnVoucher.Top;
            panel5.Height = btnVoucher.Height;
            btnVoucher.ForeColor = Color.White;
            btnVoucher.BackColor = Color.FromArgb(81, 36, 103);

            btnSearch.ForeColor = Color.FromArgb(81, 36, 103);
            btnSearch.BackColor = Color.White;
            btnSwichTable.ForeColor = Color.FromArgb(81, 36, 103);
            btnSwichTable.BackColor = Color.White;
            btnAdditionFood.ForeColor = Color.FromArgb(81, 36, 103);
            btnAdditionFood.BackColor = Color.White;
            btnCategory.ForeColor = Color.FromArgb(81, 36, 103);
            btnCategory.BackColor = Color.White;
            btnExit.ForeColor = Color.FromArgb(81, 36, 103);
            btnExit.BackColor = Color.White;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            panel5.Top = btnCategory.Top;
            panel5.Height = btnCategory.Height;
            btnCategory.ForeColor = Color.White;
            btnCategory.BackColor = Color.FromArgb(81, 36, 103);

            btnSearch.ForeColor = Color.FromArgb(81, 36, 103);
            btnSearch.BackColor = Color.White;
            btnSwichTable.ForeColor = Color.FromArgb(81, 36, 103);
            btnSwichTable.BackColor = Color.White;
            btnAdditionFood.ForeColor = Color.FromArgb(81, 36, 103);
            btnAdditionFood.BackColor = Color.White;
            btnVoucher.ForeColor = Color.FromArgb(81, 36, 103);
            btnVoucher.BackColor = Color.White;
            btnExit.ForeColor = Color.FromArgb(81, 36, 103);
            btnExit.BackColor = Color.White;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void lvLayer2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Table tb = (Table)lvLayer1.SelectedItems[0].Tag;
                int idtable = tb.ID;
                IDTABLE = tb.ID;
                lbTableNumber.Text = tb.Name;
                ShowBill(idtable);
            }
            catch { }
        }

        private void lvLayer1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Table tb = (Table)lvLayer1.SelectedItems[0].Tag;
                int idtable = tb.ID;
                IDTABLE = tb.ID;
                lbTableNumber.Text = tb.Name;
                ShowBill(idtable);
            }
            catch { }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            FoodType select = cb.SelectedItem as FoodType;
            id = select.IDType;
            LoadFood(id);
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            List<Food> lsFood = blFood.SearchFood(tbxSearch.Text.Trim());
            lbxFoodName.DataSource = lsFood;
            lbxFoodName.DisplayMember = "FoodName";

            lbxPrice.DataSource = lsFood;
            lbxPrice.DisplayMember = "Price";
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                SwitchTable();
        }
    }
}
