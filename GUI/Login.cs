using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Globalization;

namespace GUI
{
    public partial class Login : Form
    {
        BUS_NhanVien busEmployee = new BUS_NhanVien();

        private bool isPasswordHidden = true;
        public Login()
        {
            InitializeComponent();
            txtMatKhau.PasswordChar = '*'; // Ẩn mật khẩu
        }

        public void btnLogic_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != "" && txtMatKhau.Text != "")
            {
                //xử lý 
                string tk= txtTaiKhoan.Text.Trim();
                string mk= txtMatKhau.Text.Trim();
                if (busEmployee.checkAccount(tk, mk) == true)
                {
                    Main form = new Main(busEmployee.findAccountName(tk, mk),busEmployee.findAccountID(tk,mk));
                    //string nameEmployee = busEmployee.findAccountName(tk, mk);
                    Mediator.NameEmployee = busEmployee.findAccountID(tk, mk) + ": " + busEmployee.findAccountName(tk, mk); // Lưu giá trị vào Mediator
                    // Hiển thị form mới
                    form.Show();

                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai!!!\nVui lòng nhập lại", "Báo lỗi", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isPasswordHidden)
            {
                txtMatKhau.PasswordChar = '\0'; // Hiển thị mật khẩu
                btShowHidePass.Text = "Hide";
                isPasswordHidden = false;
            }
            else
            {
                txtMatKhau.PasswordChar = '*'; // Ẩn mật khẩu
                btShowHidePass.Text = "Show";
                isPasswordHidden = true;
            }
        }
    }
}
