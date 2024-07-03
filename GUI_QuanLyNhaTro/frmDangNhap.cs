using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using DTO;
using BUS_QuanLyNhaTro;

namespace GUI_QuanLyNhaTro
{
    public partial class frmDangNhap : Form
    {
        BUS_ChuSoHuu busCsh = new BUS_ChuSoHuu();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnLoginWithGoogle_Click(object sender, EventArgs e)
        {
           
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
            pnUsername.BackColor = Color.White;
            pnPassWord.BackColor = SystemColors.Control;
            txtPassWord.BackColor = SystemColors.Control;
        }

        private void txtPassWord_Click(object sender, EventArgs e)
        {
            txtPassWord.BackColor = Color.White;
            pnPassWord.BackColor = Color.White;
            txtUsername.BackColor = SystemColors.Control;
            pnUsername.BackColor = SystemColors.Control;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DTO_ChuSoHuu csh = new DTO_ChuSoHuu();
            csh.Email = txtUsername.Text;
            csh.MatKhau = txtPassWord.Text;
            if (busCsh.ChuSoHuuLogin(csh))
            {
                frmMain f1 = new frmMain();
                f1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công. Vui lòng nhập lại");
                txtUsername.Text = null;
                txtPassWord.Text = null;
                txtUsername.Focus();
            }
        }

        private void chkShowPassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassWord.Checked)
            {
                txtPassWord.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
            else
            {
                //Hides Textbox password
                txtPassWord.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
        }
    }
}
