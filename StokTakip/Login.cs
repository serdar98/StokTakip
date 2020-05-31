using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace StokTakip
{
    public partial class frmLogin : Form
    {
        LoginControl loginControl = new LoginControl();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginControl.Login(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Programı kapatmak istediğinizden emin misiniz?", "Bilgi", MessageBoxButtons.YesNo);


            if (result==DialogResult.Yes)
            {
                Application.Exit(); 
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
