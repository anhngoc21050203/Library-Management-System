﻿using System;
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
    public partial class Sach1 : UserControl
    {
        private string _title;
        private double _cost;
        public event EventHandler OnSelect = null;
        public Sach1()
        {
            InitializeComponent();

        }

        private void Sach1_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        public string Title{get => lblTitle.Text; set => lblTitle.Text = value; }
        public double Cost { get => _cost; set { _cost = value; lblCost.Text = _cost.ToString("C2"); } }
        public Image Icon { get => lblImage.Image; set => lblImage.Image = value; }

    }
}
