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


namespace GUI
{
    public partial class DangNhap : Form
    {
        BUS_TAIKHOAN taikhoan_bul = new BUS_TAIKHOAN();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            if (txt_taikhoan.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa điền tên tài khoản.";
                // MessageBox.Show("Chưa điền tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_taikhoan.Focus();
            }
            else if (txt_matkhau.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa điền mật khẩu.";
                //  MessageBox.Show("Chưa điền mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_matkhau.Focus();
            }
            else
            {
                DTO_TAIKHOAN taikhoan_public = new DTO_TAIKHOAN();
                taikhoan_public.TENTK = txt_taikhoan.Text;
                taikhoan_public.MATKHAU = txt_matkhau.Text;
                int trangthaitaikhoan = 0;
                trangthaitaikhoan = taikhoan_bul.check_dangnhap(taikhoan_public);

                if (trangthaitaikhoan == 1)
                {
                    QuanLy dk = new QuanLy();
                    this.Hide();
                    dk.ShowDialog();
                    
                }
                else if (trangthaitaikhoan == 0)
                {
                    lbtrangthai.ForeColor = Color.Red;
                    lbtrangthai.Text = "Sai tên tài khoản hoặc mật khẩu.";
                    txt_taikhoan.Focus();
                    // MessageBox.Show("Sai tên tài khoản hoặc mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // txt_taikhoan.Focus();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                txt_matkhau.UseSystemPasswordChar = true;
            }
            else
            {
                txt_matkhau.UseSystemPasswordChar = false;
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            DialogResult thong_bao;
            thong_bao = (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (thong_bao == DialogResult.Yes)
                Application.Exit();
        }

        private void bt_dangki_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            //mở ra trang đăng ký
            
            //Đóng lại 
            this.Hide();
            dk.ShowDialog();
        }
    }
}
