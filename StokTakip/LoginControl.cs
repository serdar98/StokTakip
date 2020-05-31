using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    class LoginControl
    {   
        SqlConnection connection = new SqlConnection("Data Source = .; Initial Catalog = StockTracing; Integrated Security = True");
        DataTable dataTable = new DataTable();
        

        public void Login(frmLogin login)
        {
            frmProduct product = new frmProduct();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from [User] Where Username='" + login.txtUsername.Text + "' and Password='" + login.txtPassword.Text + "' ", connection);
            
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış", "Hata");
            }
            else if (dataTable.Rows[0][3].ToString() == "Admin")
            {
                product.Show();
                login.Hide();

                ((Form)product).Controls["txtUserType"].Text = dataTable.Rows[0][3].ToString();
                ((Form)product).Controls["txtUser"].Text = dataTable.Rows[0][1].ToString();
                product.Controls["txtUser"].BackColor = Color.LightSkyBlue;
                product.Controls["txtUserType"].BackColor = Color.LightSkyBlue;

            }
            else if (dataTable.Rows[0][3].ToString() == "Staff")
            {
                login.Hide();
                product.Show();

                ((Form)product).Controls["txtUserType"].Text = "Personel";
                ((Form)product).Controls["txtUser"].Text = dataTable.Rows[0][1].ToString();
                product.Controls["txtUserType"].BackColor = Color.LightGreen;
                product.Controls["txtUser"].BackColor = Color.LightGreen;
            }
        }
    }
}
