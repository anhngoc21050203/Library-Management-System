using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Product
{
    public partial class uc_ShowProduct : UserControl
    {
        public uc_ShowProduct()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Add_prodct addproduct = new Add_prodct();
            addproduct.ShowDialog();
        }
    }
}
