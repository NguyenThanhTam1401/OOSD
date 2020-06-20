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
    public partial class UC_Supplier : UserControl
    {
        private List<Supplier> lstSupplier;
        private BLSupplier blSupplier;
        private bool IsAddition;
        private string error;
        public UC_Supplier()
        {
            InitializeComponent();
            lstSupplier = new List<Supplier>();
            blSupplier = new BLSupplier();
            LoadData();
        }

        private void LoadData()
        {
            tbxId.ReadOnly = true;
            tbxAddress.ReadOnly = true;
            tbxPhone.ReadOnly = true;
            tbxSupplier.ReadOnly = true;

            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnCancel.Enabled = false;

            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnExit.Enabled = true;

            try
            {
                dgvMain.DataSource = blSupplier.GetListSupplier();
            }
            catch
            {
                MessageBox.Show("Error getting data from database!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            IsAddition = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnExit.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;

            tbxSupplier.ReadOnly = false;
            tbxAddress.ReadOnly = false;
            tbxPhone.ReadOnly = false;

            tbxSupplier.Focus();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Are you sure???", "Warning!",
MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                if (!blSupplier.DeleteSupplier(Convert.ToInt32(tbxId.Text), ref error))
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Xóa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxSupplier.ResetText();
                tbxAddress.ResetText();
                tbxPhone.ResetText();
                tbxSupplier.Focus();
                LoadData();
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            IsAddition = false;
            btnAdd.Enabled = false;
            btnExit.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;

            tbxSupplier.ReadOnly = false;
            tbxAddress.ReadOnly = false;
            tbxPhone.ReadOnly = false;
            tbxSupplier.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsAddition)
            {
                if (tbxSupplier.Text.Trim() == "" || tbxAddress.Text.Trim() == "" || tbxPhone.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!blSupplier.AddSupplier(tbxSupplier.Text.Trim(), tbxPhone.Text.Trim(), tbxAddress.Text.Trim(), ref error))
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnCancel.PerformClick();
                    LoadData();
                    tbxSupplier.Focus();
                }

            }
            else
            {
                if (!blSupplier.UpdateSupplier(Convert.ToInt32(tbxId.Text), tbxSupplier.Text.Trim(), tbxPhone.Text.Trim(), tbxAddress.Text.Trim(), ref error))
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Update Success!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxSupplier.ReadOnly = true;
                    tbxAddress.ReadOnly = true;
                    tbxPhone.ReadOnly = true;
                    LoadData();
                    tbxSupplier.Focus();
                }

            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnExit.Enabled = true;

            tbxSupplier.ReadOnly = true;
            tbxAddress.ReadOnly = true;
            tbxPhone.ReadOnly = true;
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvMain.CurrentCell.RowIndex;

            tbxId.Text = dgvMain.Rows[r].Cells[0].Value.ToString();
            tbxSupplier.Text = dgvMain.Rows[r].Cells[1].Value.ToString();
            tbxPhone.Text = dgvMain.Rows[r].Cells[2].Value.ToString();
            tbxAddress.Text = dgvMain.Rows[r].Cells[3].Value.ToString();
        }
    }
}
