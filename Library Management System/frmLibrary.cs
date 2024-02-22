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
    }
}
