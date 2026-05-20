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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //thay đổi nội dung panel
            UCQLSinhvien uCQLSinhvien = new UCQLSinhvien();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uCQLSinhvien);
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCQLSinhvien uCQLSinhvien = new UCQLSinhvien();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uCQLSinhvien);
        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCQLLophoc uCQLLophoc = new UCQLLophoc();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uCQLLophoc);
        }
    }
}
