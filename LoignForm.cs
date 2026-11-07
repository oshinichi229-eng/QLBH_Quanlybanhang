using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLBH_QUANLYBANHANG.form
{
    public partial class LoignForm : Form
    {
        public LoignForm()
        {
            InitializeComponent();

            // Mặc định khi vừa mở form: Hiện panel đăng nhập, ẩn panel đăng ký
            pnl_dangnhap.Visible = true;
            pnl_dangky.Visible = false;

            // Chủ động gắn sự kiện cho các nút để đảm bảo chạy chính xác
            btn_dangki.Click += btn_dangki_Click;
            btn_quaylai.Click += btn_quaylai_Click;
        }

        // 1. Khi bấm nút Đăng ký ở màn hình đăng nhập
        private void btn_dangki_Click(object? sender, EventArgs e)
        {
            pnl_dangnhap.Visible = false; // Ẩn khung đăng nhập
            pnl_dangky.Visible = true;    // HIỆN khung đăng ký lên
            pnl_dangky.BringToFront();    // Đưa khung đăng ký lên lớp trên cùng
        }

        // 2. Khi bấm nút Quay lại ở màn hình đăng ký
        private void btn_quaylai_Click(object? sender, EventArgs e)
        {
            pnl_dangky.Visible = false;   // Ẩn khung đăng ký
            pnl_dangnhap.Visible = true;  // HIỆN lại khung đăng nhập
            pnl_dangnhap.BringToFront();  // Đưa khung đăng nhập lên lớp trên cùng
        }

        // 3. Xử lý ẩn/hiện mật khẩu ở form đăng nhập
        private void btn_Dangnhap_Click(object sender, EventArgs e)
        {

        }

        private bool Hienthimatkhau = false;

        private void btn_xemmatkhau_Click(object? sender, EventArgs e)
        {
            Hienthimatkhau = !Hienthimatkhau;
            if (Hienthimatkhau)
            {
                txt_matkhau.UseSystemPasswordChar = false;
                btn_xemmatkhau.ImageIndex = 1; // Mở mắt
            }
            else
            {
                txt_matkhau.UseSystemPasswordChar = true;
                btn_xemmatkhau.ImageIndex = 0; // Đóng mắt
            }
        }
    }
}
