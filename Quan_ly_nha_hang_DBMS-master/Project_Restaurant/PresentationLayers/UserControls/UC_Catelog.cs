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
    public partial class UC_Catelog : UserControl
    {
        private List<Supplier> lstSupplier;
        private BLFoodType blFoodType;
        private BLSupplier blSupplier;
        private bool IsAddition;
        private string error;
        public UC_Catelog()
        {
            InitializeComponent();

            lstSupplier = new List<Supplier>();
            blFoodType = new BLFoodType();
            blSupplier = new BLSupplier();

            LoadData();
        }

        private void LoadData()
        {
            tbxId.ReadOnly = true;
            tbxFoodType.ReadOnly = true;
            cbxSupplier.Enabled = false;
            tbxSupplier.Enabled = false;

            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnCancel.Enabled = false;

            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnExit.Enabled = true;

            tbxSupplier.Show();
            cbxSupplier.Hide();

            cbxSupplier.DisplayMember = "Name";
            lstSupplier = blSupplier.GetListSupplier();

            cbxSupplier.DataSource = lstSupplier;

            dgvMain.DataSource = blFoodType.GetListTypeFood();

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

            tbxFoodType.ReadOnly = false;
            cbxSupplier.Enabled = true;
            tbxSupplier.Hide();
            cbxSupplier.Show();

            tbxFoodType.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Are you sure???", "Warning!",
MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                if (!blFoodType.DeleteFoodType(Convert.ToInt32(tbxId.Text), ref error))
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Xóa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxFoodType.ResetText();
                tbxId.ResetText();
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
            cbxSupplier.AllowDrop = true;

            tbxSupplier.Hide();
            cbxSupplier.Show();

            tbxFoodType.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsAddition)
            {
                if (tbxFoodType.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!blFoodType.AddFoodType(tbxFoodType.Text.Trim(), IdSup,  ref error))
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
                if (!blFoodType.UpdateFoodType(Convert.ToInt32(tbxId.Text), tbxFoodType.Text.Trim(), IdSup, ref error))
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Update Success!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxFoodType.ReadOnly = true;
                    cbxSupplier.AllowDrop = false;
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
            cbxSupplier.Enabled = false;

            tbxSupplier.Show();
            cbxSupplier.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvMain.CurrentCell.RowIndex;

            tbxId.Text = dgvMain.Rows[r].Cells[0].Value.ToString();
            tbxFoodType.Text = dgvMain.Rows[r].Cells[1].Value.ToString();
            tbxSupplier.Text = dgvMain.Rows[r].Cells[3].Value.ToString();

            //MessageBox.Show("0: " + dgvMain.Rows[r].Cells[0].Value.ToString() + " - 1: " + dgvMain.Rows[r].Cells[1].Value.ToString() + " - 2: " + dgvMain.Rows[r].Cells[2].Value.ToString() + " - 3: " + dgvMain.Rows[r].Cells[3].Value.ToString());
        }

        private int IdSup = -1;
        private void cbxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                IdSup = lstSupplier[cbxSupplier.SelectedIndex].ID;
            }
            catch { }
        }
    }
}
