using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class frmStaff : Form
    {
        Staff staff = new Staff();
        AddProvider addProvider = new AddProvider();
        
        public frmStaff()
        {
            InitializeComponent();
        }
        private void productToolMenu_Click(object sender, EventArgs e)
        {
            frmProduct product = new frmProduct();

            if (txtUserType.Text == "Admin")
            {
                ((Form)product).Controls["txtUserType"].Text = txtUserType.Text;
                ((Form)product).Controls["txtUser"].Text = txtUser.Text;

                product.Controls["txtUser"].BackColor = Color.LightSkyBlue;
                product.Controls["txtUserType"].BackColor = Color.LightSkyBlue;
                
            }
            else if (txtUserType.Text == "Personel")
            {
                ((Form)product).Controls["txtUserType"].Text = txtUserType.Text;
                ((Form)product).Controls["txtUser"].Text = txtUser.Text;

                product.Controls["txtUser"].BackColor = Color.LightGreen;
                product.Controls["txtUserType"].BackColor = Color.LightGreen;
            }

            this.Hide();
            product.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }
        private void dgvListStaff_DoubleClick(object sender, EventArgs e)
        {
            DGVListStaff();
        }
        private void frmStaff_Load(object sender, EventArgs e)
        { 
            addProvider.ClearStaff(this);
            addProvider.PopulateDataGridViewStaff(this);
            InputLimit();
        }
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            addProvider.addStaff(this);
        }
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            DeleteStaff();
        }
        private void btnCancelStaff_Click(object sender, EventArgs e)
        {
            addProvider.ClearStaff(this);
        }
       
        private void DGVListStaff()
        {
            if (dgvListStaff.CurrentRow.Index != -1)
            {
                staff.StaffID = Convert.ToInt32(dgvListStaff.CurrentRow.Cells["StaffID"].Value);
                using (StockTracingEntities stockTracing = new StockTracingEntities())
                {
                    staff = stockTracing.Staff.Where(x => x.StaffID == staff.StaffID).FirstOrDefault();

                    txtStaffName.Text = staff.StaffName;
                    txtStaffSurname.Text = staff.StaffSurname;
                    txtStaffGender.Text = staff.StaffGender;
                    txtStaffTelephone.Text = staff.StaffTelephone;
                    txtStaffSalary.Text = staff.StaffSalary.ToString();
                }
                btnAddStaff.Text = "Personeli Güncelle";

                if (txtUserType.Text == "Staff")
                {
                    btnDeleteStaff.Enabled = false;
                }
                else
                    btnDeleteStaff.Enabled = true;
            }
        }
       
        private void DeleteStaff()
        {
            if (MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz ?", "ÜRÜNÜ SİL", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (StockTracingEntities stockTracing = new StockTracingEntities())
                {
                    var entry = stockTracing.Entry(staff);

                    if (entry.State == EntityState.Detached)
                        stockTracing.Staff.Attach(staff);
                    stockTracing.Staff.Remove(staff);
                    stockTracing.SaveChanges();

                    addProvider.ClearStaff(this);
                    addProvider.PopulateDataGridViewStaff(this);

                    MessageBox.Show("Ürün silme işlemi başarılı");
                }
            }
        }
        private void InputLimit()
        {
            txtStaffName.MaxLength = 15;
            txtStaffSurname.MaxLength = 15;
            txtStaffGender.MaxLength = 5;
            txtStaffTelephone.MaxLength = 11;
            txtStaffSalary.MaxLength = 5;

        }
        private void CharControl(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
        private void NumberControl(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
