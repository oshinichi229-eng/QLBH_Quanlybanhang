namespace QLBH_QUANLYBANHANG.form
{
    partial class LoignForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoignForm));

            pnl_dangnhap = new Panel();
            btn_xemmatkhau = new Button();
            img_mắt = new ImageList(components);
            txt_matkhau = new TextBox();
            lbl_Matkhau = new Label();
            txt_tendangnhap = new TextBox();
            lbl_tendangnhap = new Label();
            lbl_quenmatkhau = new LinkLabel();
            btn_Dangnhap = new Button();
            btn_dangki = new Button();
            pic_dangnhap = new PictureBox();
            pic_matkhau = new PictureBox();

            pnl_dangky = new Panel();
            btn_quaylai = new Button();
            pic_khoa = new PictureBox();
            pic_dangky = new PictureBox();
            btn_Dangky = new Button();
            txt_matkhau2 = new TextBox();
            lbl_matkhau2 = new Label();
            list_vaitro = new ListBox();
            lbl_vaitro = new Label();
            txt_Sodienthoai = new TextBox();
            lbl_sdt = new Label();
            txt_tendangky = new TextBox();
            lbl_tendangky = new Label();

            pnl_dangnhap.SuspendLayout();
            pnl_dangky.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_dangnhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_matkhau).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_khoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_dangky).BeginInit();
            SuspendLayout();
            // 
            // pnl_dangnhap
            // 
            pnl_dangnhap.Controls.Add(btn_xemmatkhau);
            pnl_dangnhap.Controls.Add(txt_matkhau);
            pnl_dangnhap.Controls.Add(lbl_Matkhau);
            pnl_dangnhap.Controls.Add(txt_tendangnhap);
            pnl_dangnhap.Controls.Add(lbl_tendangnhap);
            pnl_dangnhap.Controls.Add(lbl_quenmatkhau);
            pnl_dangnhap.Controls.Add(btn_Dangnhap);
            pnl_dangnhap.Controls.Add(btn_dangki);
            pnl_dangnhap.Controls.Add(pic_dangnhap);
            pnl_dangnhap.Controls.Add(pic_matkhau);
            pnl_dangnhap.Dock = DockStyle.Fill;
            pnl_dangnhap.Location = new Point(0, 0);
            pnl_dangnhap.Name = "pnl_dangnhap";
            pnl_dangnhap.Size = new Size(605, 277);
            pnl_dangnhap.TabIndex = 11;
            // 
            // btn_xemmatkhau
            // 
            btn_xemmatkhau.BackColor = Color.White;
            btn_xemmatkhau.ForeColor = Color.White;
            btn_xemmatkhau.ImageIndex = 0;
            btn_xemmatkhau.ImageList = img_mắt;
            btn_xemmatkhau.Location = new Point(455, 133);
            btn_xemmatkhau.Name = "btn_xemmatkhau";
            btn_xemmatkhau.Size = new Size(27, 23);
            btn_xemmatkhau.TabIndex = 10;
            btn_xemmatkhau.UseVisualStyleBackColor = false;
            btn_xemmatkhau.Click += btn_xemmatkhau_Click;
            // 
            // img_mắt
            // 
            img_mắt.ColorDepth = ColorDepth.Depth32Bit;
            img_mắt.ImageStream = (ImageListStreamer)resources.GetObject("img_mắt.ImageStream");
            img_mắt.TransparentColor = Color.Transparent;
            img_mắt.Images.SetKeyName(0, "icon mắt.png");
            // 
            // txt_matkhau
            // 
            txt_matkhau.Location = new Point(206, 132);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.Size = new Size(276, 25);
            txt_matkhau.TabIndex = 3;
            txt_matkhau.UseSystemPasswordChar = true;
            // 
            // lbl_Matkhau
            // 
            lbl_Matkhau.Location = new Point(77, 134);
            lbl_Matkhau.Name = "lbl_Matkhau";
            lbl_Matkhau.Size = new Size(103, 19);
            lbl_Matkhau.TabIndex = 2;
            lbl_Matkhau.Text = "Mật khẩu:";
            // 
            // txt_tendangnhap
            // 
            txt_tendangnhap.Location = new Point(206, 93);
            txt_tendangnhap.Multiline = true;
            txt_tendangnhap.Name = "txt_tendangnhap";
            txt_tendangnhap.Size = new Size(275, 23);
            txt_tendangnhap.TabIndex = 1;
            // 
            // lbl_tendangnhap
            // 
            lbl_tendangnhap.AutoSize = true;
            lbl_tendangnhap.ForeColor = Color.Black;
            lbl_tendangnhap.Location = new Point(77, 92);
            lbl_tendangnhap.Name = "lbl_tendangnhap";
            lbl_tendangnhap.Size = new Size(103, 19);
            lbl_tendangnhap.TabIndex = 0;
            lbl_tendangnhap.Text = "Tên đăng nhập:";
            // 
            // lbl_quenmatkhau
            // 
            lbl_quenmatkhau.AutoSize = true;
            lbl_quenmatkhau.Location = new Point(367, 175);
            lbl_quenmatkhau.Name = "lbl_quenmatkhau";
            lbl_quenmatkhau.Size = new Size(114, 19);
            lbl_quenmatkhau.TabIndex = 4;
            lbl_quenmatkhau.TabStop = true;
            lbl_quenmatkhau.Text = "Quên mật khẩu...";
            // 
            // btn_Dangnhap
            // 
            btn_Dangnhap.Location = new Point(77, 215);
            btn_Dangnhap.Name = "btn_Dangnhap";
            btn_Dangnhap.Size = new Size(130, 40);
            btn_Dangnhap.TabIndex = 5;
            btn_Dangnhap.Text = "Đăng nhập";
            btn_Dangnhap.UseVisualStyleBackColor = true;
            btn_Dangnhap.Click += btn_Dangnhap_Click;
            // 
            // btn_dangki
            // 
            btn_dangki.Location = new Point(351, 215);
            btn_dangki.Name = "btn_dangki";
            btn_dangki.Size = new Size(130, 40);
            btn_dangki.TabIndex = 6;
            btn_dangki.Text = "Đăng ký";
            btn_dangki.UseVisualStyleBackColor = true;
            btn_dangki.Click += btn_dangki_Click;
            // 
            // pic_dangnhap
            // 
            pic_dangnhap.Image = Properties.Resources.icon_dang_nhap;
            pic_dangnhap.Location = new Point(186, 93);
            pic_dangnhap.Name = "pic_dangnhap";
            pic_dangnhap.Size = new Size(21, 23);
            pic_dangnhap.SizeMode = PictureBoxSizeMode.Zoom;
            pic_dangnhap.TabIndex = 7;
            pic_dangnhap.TabStop = false;
            // 
            // pic_matkhau
            // 
            pic_matkhau.Image = Properties.Resources.mật_khẩu;
            pic_matkhau.Location = new Point(186, 132);
            pic_matkhau.Name = "pic_matkhau";
            pic_matkhau.Size = new Size(21, 24);
            pic_matkhau.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_matkhau.TabIndex = 8;
            pic_matkhau.TabStop = false;
            // 
            // pnl_dangky
            // 
            pnl_dangky.Controls.Add(btn_quaylai);
            pnl_dangky.Controls.Add(pic_khoa);
            pnl_dangky.Controls.Add(pic_dangky);
            pnl_dangky.Controls.Add(btn_Dangky);
            pnl_dangky.Controls.Add(txt_matkhau2);
            pnl_dangky.Controls.Add(lbl_matkhau2);
            pnl_dangky.Controls.Add(list_vaitro);
            pnl_dangky.Controls.Add(lbl_vaitro);
            pnl_dangky.Controls.Add(txt_Sodienthoai);
            pnl_dangky.Controls.Add(lbl_sdt);
            pnl_dangky.Controls.Add(txt_tendangky);
            pnl_dangky.Controls.Add(lbl_tendangky);
            pnl_dangky.Dock = DockStyle.Fill;
            pnl_dangky.Location = new Point(0, 0);
            pnl_dangky.Name = "pnl_dangky";
            pnl_dangky.Size = new Size(605, 277);
            pnl_dangky.TabIndex = 12;
            // 
            // btn_quaylai
            // 
            btn_quaylai.Location = new Point(12, 3);
            btn_quaylai.Name = "btn_quaylai";
            btn_quaylai.Size = new Size(75, 23);
            btn_quaylai.TabIndex = 23;
            btn_quaylai.Text = "Quay lại";
            btn_quaylai.UseVisualStyleBackColor = true;
            btn_quaylai.Click += btn_quaylai_Click;
            // 
            // pic_khoa
            // 
            pic_khoa.Image = Properties.Resources.mật_khẩu;
            pic_khoa.Location = new Point(188, 183);
            pic_khoa.Name = "pic_khoa";
            pic_khoa.Size = new Size(21, 24);
            pic_khoa.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_khoa.TabIndex = 22;
            pic_khoa.TabStop = false;
            // 
            // pic_dangky
            // 
            pic_dangky.Image = Properties.Resources.icon_dang_nhap;
            pic_dangky.Location = new Point(188, 67);
            pic_dangky.Name = "pic_dangky";
            pic_dangky.Size = new Size(21, 26);
            pic_dangky.SizeMode = PictureBoxSizeMode.Zoom;
            pic_dangky.TabIndex = 21;
            pic_dangky.TabStop = false;
            // 
            // btn_Dangky
            // 
            btn_Dangky.Location = new Point(260, 225);
            btn_Dangky.Name = "btn_Dangky";
            btn_Dangky.Size = new Size(130, 40);
            btn_Dangky.TabIndex = 20;
            btn_Dangky.Text = "Đăng ký";
            btn_Dangky.UseVisualStyleBackColor = true;
            // 
            // txt_matkhau2
            // 
            txt_matkhau2.Location = new Point(208, 183);
            txt_matkhau2.Name = "txt_matkhau2";
            txt_matkhau2.Size = new Size(275, 25);
            txt_matkhau2.TabIndex = 19;
            // 
            // lbl_matkhau2
            // 
            lbl_matkhau2.AutoSize = true;
            lbl_matkhau2.Location = new Point(79, 189);
            lbl_matkhau2.Name = "lbl_matkhau2";
            lbl_matkhau2.Size = new Size(71, 19);
            lbl_matkhau2.TabIndex = 18;
            lbl_matkhau2.Text = "Mật khẩu:";
            // 
            // list_vaitro
            // 
            list_vaitro.FormattingEnabled = true;
            list_vaitro.Items.AddRange(new object[] { "Nhân Viên", "Quản Lý", "Admin" });
            list_vaitro.Location = new Point(188, 152);
            list_vaitro.Name = "list_vaitro";
            list_vaitro.Size = new Size(295, 21);
            list_vaitro.TabIndex = 17;
            // 
            // lbl_vaitro
            // 
            lbl_vaitro.AutoSize = true;
            lbl_vaitro.Location = new Point(79, 151);
            lbl_vaitro.Name = "lbl_vaitro";
            lbl_vaitro.Size = new Size(52, 19);
            lbl_vaitro.TabIndex = 16;
            lbl_vaitro.Text = "Vai trò:";
            // 
            // txt_Sodienthoai
            // 
            txt_Sodienthoai.ForeColor = SystemColors.ScrollBar;
            txt_Sodienthoai.Location = new Point(188, 109);
            txt_Sodienthoai.Name = "txt_Sodienthoai";
            txt_Sodienthoai.Size = new Size(295, 25);
            txt_Sodienthoai.TabIndex = 15;
            txt_Sodienthoai.Text = "0123456789";
            // 
            // lbl_sdt
            // 
            lbl_sdt.AutoSize = true;
            lbl_sdt.Location = new Point(79, 109);
            lbl_sdt.Name = "lbl_sdt";
            lbl_sdt.Size = new Size(92, 19);
            lbl_sdt.TabIndex = 14;
            lbl_sdt.Text = "Số điện thoại:";
            // 
            // txt_tendangky
            // 
            txt_tendangky.Location = new Point(208, 68);
            txt_tendangky.Name = "txt_tendangky";
            txt_tendangky.Size = new Size(275, 25);
            txt_tendangky.TabIndex = 13;
            // 
            // lbl_tendangky
            // 
            lbl_tendangky.Location = new Point(79, 67);
            lbl_tendangky.Name = "lbl_tendangky";
            lbl_tendangky.Size = new Size(103, 19);
            lbl_tendangky.TabIndex = 12;
            lbl_tendangky.Text = "Tên đăng ký:";
            // 
            // LoignForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(605, 277);
            Controls.Add(pnl_dangnhap);
            Controls.Add(pnl_dangky);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoignForm";
            Text = "Quản lý cửa hàng_Đăng nhập";
            pnl_dangnhap.ResumeLayout(false);
            pnl_dangnhap.PerformLayout();
            pnl_dangky.ResumeLayout(false);
            pnl_dangky.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_dangnhap).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_matkhau).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_khoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_dangky).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_tendangnhap;
        private TextBox txt_tendangnhap;
        private Label lbl_Matkhau;
        private TextBox txt_matkhau;
        private LinkLabel lbl_quenmatkhau;
        private Button btn_Dangnhap;
        private Button btn_dangki;
        private PictureBox pic_dangnhap;
        private PictureBox pic_matkhau;
        private Button btn_xemmatkhau;
        private ImageList img_mắt;
        private Panel pnl_dangnhap;
        private Panel pnl_dangky;
        private Button btn_quaylai;
        private PictureBox pic_khoa;
        private PictureBox pic_dangky;
        private Button btn_Dangky;
        private TextBox txt_matkhau2;
        private Label lbl_matkhau2;
        private ListBox list_vaitro;
        private Label lbl_vaitro;
        private TextBox txt_Sodienthoai;
        private Label lbl_sdt;
        private TextBox txt_tendangky;
        private Label lbl_tendangky;
    }
}