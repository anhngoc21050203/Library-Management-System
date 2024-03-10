using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Library_Management_System.Payment
{
    public partial class FrmPayment : Form
    {
        public FrmPayment()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void sach11_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        public void AddItem(string name, double cost, Image image)
        {
            flowLayoutPanel1.Controls.Add(new Sach1()
            {
                Title = name,
                Cost = cost, 
                Icon = image
            });
        }

        private void FrmPayment_Shown(object sender, EventArgs e)
        {
            AddItem("");
        }
    }
}
