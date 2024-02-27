using Library_Management_System.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class frmLibrary : Form
    {
        public frmLibrary()
        {
            InitializeComponent();
        }

        

        

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You chac chan muon dang xuat???", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                
                this.Close();
                this.Hide();

                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
                
            }
        }

        

        private void btnProduct_Click(object sender, EventArgs e)
        {
            //panelShowbook.Left = btnProduct.Left = 50; 
            uc_ShowProduct1.Visible = true;
            uc_ShowProduct1.BringToFront();
        }

        private void frmLibrary_Load(object sender, EventArgs e)
        {
            uc_ShowProduct1.Visible =false;
            btnProduct.PerformClick();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            uc_ShowProduct1.Visible=false;
        }
    }
}
