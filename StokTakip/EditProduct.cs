using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace StokTakip
{
    public partial class frmProduct : Form
    {
        AddProvider addProvider = new AddProvider();
        Product product = new Product();
        public frmProduct()
        {
            InitializeComponent();
        }
        private void staffToolMenu_Click(object sender, EventArgs e)
        {
            frmStaff staff = new frmStaff();

            if (txtUserType.Text == "Admin")
            {
                ((Form)staff).Controls["txtUserType"].Text =txtUserType.Text;
                ((Form)staff).Controls["txtUser"].Text = txtUser.Text;

                staff.Controls["txtUser"].BackColor = Color.LightSkyBlue;
                staff.Controls["txtUserType"].BackColor = Color.LightSkyBlue;
                staff.Controls["pnlStaff"].Visible = true;
            }
            else if (txtUserType.Text == "Personel")
            {
                ((Form)staff).Controls["txtUserType"].Text = txtUserType.Text;
                ((Form)staff).Controls["txtUser"].Text = txtUser.Text;

                staff.Controls["txtUser"].BackColor = Color.LightGreen;
                staff.Controls["txtUserType"].BackColor = Color.LightGreen;
                staff.Controls["dgvListStaff"].Location = new Point(10, 50);
                staff.Controls["dgvListStaff"].Size = new Size(650,400);
                staff.Controls["lblUser"].Location = new Point(670,43);
                staff.Controls["txtUser"].Location = new Point(800,43);
                staff.Controls["lblUserType"].Location = new Point(670, 89);
                staff.Controls["txtUserType"].Location = new Point(800, 89);

            }
                
            this.Hide();
            staff.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }
        private void frmProduct_Load(object sender, EventArgs e)
        {
            addProvider.ClearProduct(this);
            addProvider.PopulateDataGridViewProduct(this);
            InputLimit();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            addProvider.ClearProduct(this);
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
           addProvider.addProduct(this);
        }
        private void dgvListProduct_DoubleClick(object sender, EventArgs e)
        {
            DGVListProduct();
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }
        
        
        public void DGVListProduct()
        {
            
            if (dgvListProduct.CurrentRow.Index != -1)
            {
                product.ProductID = Convert.ToInt32(dgvListProduct.CurrentRow.Cells["ProductID"].Value);
                using (StockTracingEntities stockTracing = new StockTracingEntities())
                {
                    product = stockTracing.Product.Where(x => x.ProductID == product.ProductID).FirstOrDefault();

                    txtProductName.Text = product.ProductName;
                    txtProductCategory.Text = product.ProductCategory;
                    txtProductPiece.Text = product.ProductPiece;
                    txtProductPrice.Text = product.ProductPrice.ToString();
                }

                btnAddProduct.Text = "Ürünü Güncelle";
                btnDeleteProduct.Enabled = true;
            }
        }
       
        private void DeleteProduct()
        {
            if (MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz ?", "ÜRÜNÜ SİL", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (StockTracingEntities stockTracing = new StockTracingEntities())
                {
                    var entry = stockTracing.Entry(product);

                    if (entry.State == EntityState.Detached)
                        stockTracing.Product.Attach(product);

                    stockTracing.Product.Remove(product);
                    stockTracing.SaveChanges();
                    addProvider.PopulateDataGridViewProduct(this);
                    addProvider.ClearProduct(this);
                    MessageBox.Show("Ürün silme işlemi başarılı");
                }
            }
        }
        private void InputLimit()
        {
            txtProductName.MaxLength = 15;
            txtProductCategory.MaxLength = 15;
            txtProductPiece.MaxLength = 6;
            txtProductPrice.MaxLength = 4;

        }

        private void txtProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtProductCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtProductPiece_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }      
}
