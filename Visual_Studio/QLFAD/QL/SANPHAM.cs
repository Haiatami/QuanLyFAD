using System;
using System.Linq;

namespace QL
{
    public partial class SANPHAM : Form
    {
        public SANPHAM()
        {
            InitializeComponent();
        }

        private void btDanhmuc_Click(object sender, EventArgs e)
        {
            DANHMUC danhmuc = new DANHMUC();
            danhmuc.ShowDialog();
        }
    }
}
