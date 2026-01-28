namespace QLCustomers
{
    partial class QLyForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvKhachHang = new DataGridView();
            txtMaKH = new TextBox();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtTenDN = new TextBox();
            txtDiaChi = new TextBox();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtMatKhau = new TextBox();
            txtEmail = new TextBox();
            dtNgaySinh = new DateTimePicker();
            label9 = new Label();
            picAvatar = new PictureBox();
            label10 = new Label();
            btnChonAnh = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            txtTimKiem = new TextBox();
            btnTim = new Button();
            label11 = new Label();
            btnXuatExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(22, 54);
            dgvKhachHang.Margin = new Padding(5);
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersVisible = false;
            dgvKhachHang.RowHeadersWidth = 62;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(972, 225);
            dgvKhachHang.TabIndex = 0;
            dgvKhachHang.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(170, 294);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(237, 31);
            txtMaKH.TabIndex = 1;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(170, 331);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(237, 31);
            txtHoTen.TabIndex = 2;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(170, 368);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(237, 31);
            txtSDT.TabIndex = 3;
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(552, 331);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(302, 31);
            txtTenDN.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(170, 405);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(237, 31);
            txtDiaChi.TabIndex = 5;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(170, 455);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(75, 29);
            rdoNam.TabIndex = 6;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(251, 455);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(61, 29);
            rdoNu.TabIndex = 7;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 294);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 8;
            label1.Text = "Mã KH:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 331);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 9;
            label2.Text = "Họ và tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 368);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 10;
            label3.Text = "Số Điện Thoại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 405);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 11;
            label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 454);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 12;
            label5.Text = "Giới Tính:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(413, 331);
            label6.Name = "label6";
            label6.Size = new Size(133, 25);
            label6.TabIndex = 13;
            label6.Text = "Tên đăng nhập:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(413, 368);
            label7.Name = "label7";
            label7.Size = new Size(90, 25);
            label7.TabIndex = 14;
            label7.Text = "Mật khẩu:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(413, 405);
            label8.Name = "label8";
            label8.Size = new Size(58, 25);
            label8.TabIndex = 15;
            label8.Text = "Email:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(552, 368);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(302, 31);
            txtMatKhau.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(552, 405);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(302, 31);
            txtEmail.TabIndex = 17;
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.Location = new Point(552, 294);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new Size(300, 31);
            dtNgaySinh.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(413, 294);
            label9.Name = "label9";
            label9.Size = new Size(95, 25);
            label9.TabIndex = 19;
            label9.Text = "Ngày sinh:";
            // 
            // picAvatar
            // 
            picAvatar.Location = new Point(552, 442);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(150, 137);
            picAvatar.TabIndex = 20;
            picAvatar.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(416, 457);
            label10.Name = "label10";
            label10.Size = new Size(0, 25);
            label10.TabIndex = 21;
            label10.Click += label10_Click;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(742, 442);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(112, 34);
            btnChonAnh.TabIndex = 22;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightSkyBlue;
            btnThem.Location = new Point(10, 583);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 23;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.BlanchedAlmond;
            btnSua.Location = new Point(138, 583);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 24;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Location = new Point(271, 583);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 25;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SandyBrown;
            btnThoat.Location = new Point(882, 583);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 26;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(170, 12);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(666, 31);
            txtTimKiem.TabIndex = 27;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(842, 12);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(112, 34);
            btnTim.TabIndex = 28;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(76, 12);
            label11.Name = "label11";
            label11.Size = new Size(88, 25);
            label11.TabIndex = 29;
            label11.Text = "Tìm kiếm:";
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Location = new Point(763, 582);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(112, 34);
            btnXuatExcel.TabIndex = 30;
            btnXuatExcel.Text = "Xuất";
            btnXuatExcel.UseVisualStyleBackColor = true;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // QLyForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.anh;
            ClientSize = new Size(1008, 621);
            Controls.Add(btnXuatExcel);
            Controls.Add(label11);
            Controls.Add(btnTim);
            Controls.Add(txtTimKiem);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnChonAnh);
            Controls.Add(label10);
            Controls.Add(picAvatar);
            Controls.Add(label9);
            Controls.Add(dtNgaySinh);
            Controls.Add(txtEmail);
            Controls.Add(txtMatKhau);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rdoNu);
            Controls.Add(rdoNam);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTenDN);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaKH);
            Controls.Add(dgvKhachHang);
            Name = "QLyForm";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKhachHang;
        private TextBox txtMaKH;
        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtTenDN;
        private TextBox txtDiaChi;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtMatKhau;
        private TextBox txtEmail;
        private DateTimePicker dtNgaySinh;
        private Label label9;
        private PictureBox picAvatar;
        private Label label10;
        private Button btnChonAnh;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private TextBox txtTimKiem;
        private Button btnTim;
        private Label label11;
        private Button btnXuatExcel;
    }
}
