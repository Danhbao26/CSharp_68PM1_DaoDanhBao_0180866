using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu từ TextBox
            string username = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();

            // 2. Kiểm tra dữ liệu trống
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Kiểm tra thông tin đăng nhập (Ví dụ fix cứng hoặc check DB)
            if (username == "0180866@st.huce.edu.vn" && password == "0180866")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tại đây bạn có thể mở Form chính của ứng dụng
                // MainMenu formMain = new MainMenu();
                // formMain.Show();
                // this.Hide(); 
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_password.Clear();
                txt_username.Focus();
            }
        }
    }
}
