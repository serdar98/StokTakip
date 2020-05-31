using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    class AddProvider
    {
        Product product = new Product();
        Staff staff = new Staff();
        public void addProduct(frmProduct frmProduct)
        {
            product.ProductName = frmProduct.txtProductName.Text.Trim();
            product.ProductCategory = frmProduct.txtProductCategory.Text.Trim();
            product.ProductPiece = frmProduct.txtProductPiece.Text.Trim();
            product.ProductPrice = Convert.ToDecimal(frmProduct.txtProductPrice.Text.Trim());
            using (StockTracingEntities stockTracing = new StockTracingEntities())
            {
                if (product.ProductID == 0)
                    stockTracing.Product.Add(product);
                else
                    stockTracing.Entry(product).State = EntityState.Modified;
                stockTracing.SaveChanges();
            }

            ClearProduct(frmProduct);
            PopulateDataGridViewProduct(frmProduct);
            MessageBox.Show("Ürün Kayıt Başarılı", "Bilgi");
        }
        public void addStaff(frmStaff frmStaff)
        {
            staff.StaffName = frmStaff.txtStaffName.Text.Trim();
            staff.StaffSurname = frmStaff.txtStaffSurname.Text.Trim();
            staff.StaffGender = frmStaff.txtStaffGender.Text.Trim();
            staff.StaffTelephone = frmStaff.txtStaffTelephone.Text.Trim();
            staff.StaffSalary = Convert.ToDecimal(frmStaff.txtStaffSalary.Text.Trim());
            using (StockTracingEntities stockTracing = new StockTracingEntities())
            {
                if (staff.StaffID == 0)
                    stockTracing.Staff.Add(staff);
                else
                    stockTracing.Entry(staff).State = EntityState.Modified;
                stockTracing.SaveChanges();
            }

            ClearStaff(frmStaff);
            PopulateDataGridViewStaff(frmStaff);
            MessageBox.Show("Personel Kaydedildi", "Bilgi");
        }
        public void PopulateDataGridViewProduct(frmProduct frmProduct)
        {
            frmProduct.dgvListProduct.AutoGenerateColumns = false;
            using (StockTracingEntities stockTracing = new StockTracingEntities())
            {
                 frmProduct.dgvListProduct.DataSource = stockTracing.Product.ToList<Product>();
            }

        }
        public void PopulateDataGridViewStaff(frmStaff frmStaff)
        {
            frmStaff.dgvListStaff.AutoGenerateColumns = false;
            using (StockTracingEntities stockTracing = new StockTracingEntities())
            {
                frmStaff.dgvListStaff.DataSource = stockTracing.Staff.ToList<Staff>();
            }

        }
        public void ClearProduct(frmProduct frmProduct)
        {
                frmProduct.txtProductName.Clear();
                frmProduct.txtProductCategory.Clear();
                frmProduct.txtProductPiece.Clear();
                frmProduct.txtProductPrice.Clear();

                frmProduct.btnAddProduct.Text = "Ürün Ekle";
                frmProduct.btnDeleteProduct.Enabled = false;
                product.ProductID = 0;
        }
        public void ClearStaff(frmStaff frmStaff)
        {
                frmStaff.txtStaffName.Clear();
                frmStaff.txtStaffSurname.Clear();
                frmStaff.txtStaffGender.Clear();
                frmStaff.txtStaffTelephone.Clear();
                frmStaff.txtStaffSalary.Clear();

                frmStaff.btnAddStaff.Text = "Personel Ekle";
                frmStaff.btnDeleteStaff.Enabled = false;
                staff.StaffID = 0;
        }
        
    }
}
