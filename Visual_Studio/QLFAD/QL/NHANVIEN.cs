using DAL;
using System;
using System.Linq;

namespace QL
{
    public partial class NHANVIEN : Form
    {
        public NHANVIEN()
        {
            InitializeComponent();
            LoadAccountList();
        }
        void LoadAccountList()
        {
            string query = "select * from dbo.NHANVIEN,dbo.TAIKHOAN";
            DBConnect db = new DBConnect();
            dgNhanvien.DataSource = db.ExecuteQuery(query);

        }

        private void NHANVIEN_Load(object sender, EventArgs e)
        {

        }
    }
}
