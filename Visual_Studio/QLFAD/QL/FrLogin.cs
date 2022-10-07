using System.Data;
using System.Data.SqlClient;
using BUL;
using DAL;
using PUBLIC;
namespace QL
{
    public partial class FrLogin : Form
    {
        SqlConnection conn;
        public FrLogin()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {

           
                FrMain frMain = new FrMain();
            this.Hide();
                frMain.ShowDialog();
            
        }

        private void FrLogin_Load(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}