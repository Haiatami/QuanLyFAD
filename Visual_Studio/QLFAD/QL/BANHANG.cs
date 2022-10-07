using System;
using System.Linq;

namespace QL
{
    public partial class BANHANG : Form
    {
        public BANHANG()
        {
            InitializeComponent();
        }

        private void btBan_Click(object sender, EventArgs e)
        {
            BAN ban = new BAN();
            ban.ShowDialog();
        }
    }
}
