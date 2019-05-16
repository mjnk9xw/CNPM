using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLi_Admin
{
    public partial class FormDangNhap : Form
    {
        private FormQuanLi fQL;
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bt_DangNhap_Click(object sender, EventArgs e)
        {
            string tk = tx_TaiKhoan.Text;
            string pass = tx_MatKhau.Text;
            if (tk == "admin" && pass == "admin")
            {
                //    // call form quản lí
                tx_TaiKhoan.Clear();
                tx_MatKhau.Clear();
                fQL = new FormQuanLi();
                fQL.ShowDialog();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản , mật khẩu không chính xác");
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
