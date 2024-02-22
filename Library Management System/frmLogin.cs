using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
                txtUsername.Font = new Font(txtUsername.Font.FontFamily, txtUsername.Font.Size + 2);
            }
        }

        

        private void pictureBoxFacb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/danhbaayeuuminhemthoia");
        }

        

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            // Minimize cửa sổ
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaxsize_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem cửa sổ đã ở trạng thái Maximized hay không
            /*if (this.WindowState == FormWindowState.Normal)
            {
                // Nếu không, chuyển cửa sổ sang trạng thái Maximized
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                // Nếu đã Maximized, chuyển về trạng thái Normal (Restore)
                this.WindowState = FormWindowState.Normal;
            } */
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Tạo kết nối
                using (SqlConnection conn = new SqlConnection("data source=DANH_BAA\\SQLEXPRESS; database=Library Store;integrated security=True; "))
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo truy vấn SQL với tham số
                    string query = "SELECT * FROM LoginUser WHERE username = @username AND password = @password";

                    // Tạo đối tượng Command
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm các tham số và gán giá trị
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                        // Thực thi truy vấn và điền dữ liệu vào DataSet
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        // Kiểm tra xem DataSet có chứa dữ liệu không
                        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {

                            frmLibrary frmLibrary = new frmLibrary();
                            frmLibrary.ShowDialog();
                            // Thực hiện các thao tác sau khi đăng nhập thành công
                        }
                        else
                        {
                            MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txtPassword_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtPassword.Clear();
            txtPassword.PasswordChar = '*';
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
