using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Tạo và hiển thị Form đăng nhập dưới dạng hộp thoại kiểm tra (ShowDialog)
            Form_dangnhap fLogin = new Form_dangnhap();

            // Nếu Form đăng nhập trả về kết quả là OK (Đăng nhập thành công)
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                // 2. Chạy ứng dụng chính với FormMain là Form chủ đạo
                Application.Run(new FormMain());
            }
        }
    }
}
