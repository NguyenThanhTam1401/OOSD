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
    public partial class UC_FoodManager : UserControl
    {
        private List<FoodType> lstFoodType;
        private BLFoodType blFoodType;
        private BLFood blFood;
        private bool IsAddition;
        private string error;
        public UC_FoodManager()
        {
            InitializeComponent();

            lstFoodType = new List<FoodType>();
            blFoodType = new BLFoodType();
            blFood = new BLFood();

            LoadData();
        }

        private void LoadData()
        {
            
            tbxId.ReadOnly = true;
            tbxName.ReadOnly = true;
            tbxPrice.ReadOnly = true;
           
            cbxFoodType.Enabled = false;
            tbxFoodType.ReadOnly = true;

            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnCancel.Enabled = false;

            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnExit.Enabled = true;

            tbxFoodType.Show();
            cbxFoodType.Hide();

            cbxFoodType.DisplayMember = "TypeName";
            lstFoodType = blFoodType.GetListTypeFood();

            cbxFoodType.DataSource = lstFoodType;

            dgvMain.DataSource = blFood.GetListFood();

            try
            {

            }
            catch
            {
                MessageBox.Show("Error getting data from database!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            IsAddition = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnExit.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;

            tbxName.ReadOnly = false;
            tbxPrice.ReadOnly = false;
            cbxFoodType.Enabled = true;

            tbxFoodType.Hide();
            cbxFoodType.Show();

            tbxName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Are you sure???", "Warning!",
MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                if (!blFood.DeleteFood(Convert.ToInt32(tbxId.Text), ref error))
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Xóa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxFoodType.ResetText();
                lbid.ResetText();
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            IsAddition = false;
            btnAdd.Enabled = false;
            btnExit.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;

            tbxFoodType.ReadOnly = false;
            tbxName.ReadOnly = false;
            tbxPrice.ReadOnly = false;
            cbxFoodType.Enabled = true;

            tbxFoodType.Hide();
            cbxFoodType.Show();

            tbxName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(tbxPrice.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập giá hợp lệ!", "Thông báo!",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IsAddition)
            {
                if (tbxName.Text.Trim() == "" || tbxPrice.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                if (!blFood.AddFood(tbxName.Text.Trim(), CategoryId, Convert.ToDouble(tbxPrice.Text.Trim()), ref error))
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnCancel.PerformClick();
                    LoadData();
                    tbxFoodType.Focus();
                }

            }
            else
            {
                if (!blFood.UpdateFood(Convert.ToInt32(tbxId.Text), tbxName.Text.Trim(), CategoryId, Convert.ToDouble(tbxPrice.Text.Trim()), ref error))
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Update Success!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxFoodType.ReadOnly = true;
                    cbxFoodType.AllowDrop = false;
                    LoadData();
                    tbxFoodType.Focus();
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnExit.Enabled = true;

            tbxFoodType.ReadOnly = true;
            tbxName.ReadOnly = true;
            tbxPrice.ReadOnly = true;
            cbxFoodType.Enabled = false;

            tbxFoodType.Show();
            cbxFoodType.Hide();
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvMain.CurrentCell.RowIndex;

            tbxId.Text = dgvMain.Rows[r].Cells[0].Value.ToString();
            tbxName.Text = dgvMain.Rows[r].Cells[1].Value.ToString();
            tbxFoodType.Text = dgvMain.Rows[r].Cells[4].Value.ToString();
            tbxPrice.Text = dgvMain.Rows[r].Cells[2].Value.ToString();
        }

        private int CategoryId;
        private void cbxFoodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CategoryId = lstFoodType[cbxFoodType.SelectedIndex].IDType;
            }
            catch { }
        }
    }
    
}
