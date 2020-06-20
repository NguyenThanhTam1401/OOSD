using Project_Restaurant.UserControls;
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
    public partial class frmFoodManager : Form
    {
        public frmFoodManager()
        {
            InitializeComponent();
            uC_FoodManager1.BringToFront();
            btnFood.ForeColor = Color.FromArgb(81, 36, 103);
            btnFood.BackColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }





        private void btnFood_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnFood.Height;
            sidepanel.Top = btnFood.Top;
            btnFood.ForeColor = Color.FromArgb(81, 36, 103);
            btnFood.BackColor = Color.White;
            uC_FoodManager1.BringToFront();

            btnCategory.BackColor = Color.FromArgb(81, 36, 103);
            btnCategory.ForeColor = Color.White;
            btnSupplier.BackColor = Color.FromArgb(81, 36, 103);
            btnSupplier.ForeColor = Color.White;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnCategory.Height;
            sidepanel.Top = btnCategory.Top;
            btnCategory.ForeColor = Color.FromArgb(81, 36, 103);
            btnCategory.BackColor = Color.White;
            uC_Catelog1.BringToFront();

            btnFood.BackColor = Color.FromArgb(81, 36, 103);
            btnFood.ForeColor = Color.White;
            btnSupplier.BackColor = Color.FromArgb(81, 36, 103);
            btnSupplier.ForeColor = Color.White;
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            uc_Supplier.BringToFront();
            sidepanel.Height = btnSupplier.Height;
            sidepanel.Top = btnSupplier.Top;
            btnSupplier.ForeColor = Color.FromArgb(81, 36, 103);
            btnSupplier.BackColor = Color.White;


            btnFood.BackColor = Color.FromArgb(81, 36, 103);
            btnFood.ForeColor = Color.White;
            btnCategory.BackColor = Color.FromArgb(81, 36, 103);
            btnCategory.ForeColor = Color.White;
        }

        private void uc_Supplier_Load(object sender, EventArgs e)
        {

        }
    }
}
