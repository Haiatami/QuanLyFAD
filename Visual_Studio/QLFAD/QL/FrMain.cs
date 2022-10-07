using System;
using System.Linq;

namespace QL
{
    public partial class FrMain : Form
    {
        public FrMain()
        {
            InitializeComponent();
        }

        private void btBanhang_Click(object sender, EventArgs e)
        {
            BANHANG ban = new BANHANG();
            this.Hide();
            ban.ShowDialog();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            FrLogin login = new FrLogin();
            this.Hide();
            login.ShowDialog();
        }

        private void FrMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btQuanlynhanvien_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            this.Hide();
            nv.ShowDialog();
        }

        private void btQuanlysanpham_Click(object sender, EventArgs e)
        {
            SANPHAM sn = new SANPHAM();
            this.Hide();
            sn.ShowDialog();
        }
    }
}
