namespace Library_Management_System.Payment
{
    partial class Sach1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sach1));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblCost);
            this.guna2Panel1.Controls.Add(this.lblTitle);
            this.guna2Panel1.Controls.Add(this.lblImage);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(644, 120);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Click += new System.EventHandler(this.guna2Panel1_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(123, 72);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(45, 28);
            this.lblCost.TabIndex = 2;
            this.lblCost.Text = "10$";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(124, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(75, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Tên sách";
            // 
            // lblImage
            // 
            this.lblImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblImage.ErrorImage = null;
            this.lblImage.Image = ((System.Drawing.Image)(resources.GetObject("lblImage.Image")));
            this.lblImage.ImageRotate = 0F;
            this.lblImage.InitialImage = null;
            this.lblImage.Location = new System.Drawing.Point(3, 3);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(98, 114);
            this.lblImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lblImage.TabIndex = 0;
            this.lblImage.TabStop = false;
            this.lblImage.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // Sach1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Sach1";
            this.Size = new System.Drawing.Size(650, 126);
            this.Load += new System.EventHandler(this.Sach1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Guna.UI2.WinForms.Guna2PictureBox lblImage;
        public System.Windows.Forms.Label lblCost;
        public System.Windows.Forms.Label lblTitle;
    }
}
