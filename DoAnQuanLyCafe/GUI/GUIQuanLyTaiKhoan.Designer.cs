using System.Windows.Forms;

namespace DoAnQuanLyCafe.GUI
{
    partial class GUIQuanLyTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvTaiKhoan = new System.Windows.Forms.ListView();
            this.colTenTaiKhoan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMatKhau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaLoaiTaiKhoan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnTTCN = new System.Windows.Forms.Panel();
            this.lblTTCN = new System.Windows.Forms.Label();
            this.rbtnCancel = new System.Windows.Forms.RadioButton();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.cbbNgay = new System.Windows.Forms.ComboBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.txtCccd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbAnhDaiDien = new System.Windows.Forms.PictureBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.pnTTTK = new System.Windows.Forms.Panel();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblTTTK = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblMaTK = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.pnbtnAction = new System.Windows.Forms.Panel();
            this.pnbtnSelection = new System.Windows.Forms.Panel();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.pnTTLB = new System.Windows.Forms.Panel();
            this.lblTTLB = new System.Windows.Forms.Label();
            this.txtThuong = new System.Windows.Forms.TextBox();
            this.txtLuongNgay = new System.Windows.Forms.TextBox();
            this.txtSoNgay = new System.Windows.Forms.TextBox();
            this.lblThuong = new System.Windows.Forms.Label();
            this.lblLuongNgay = new System.Windows.Forms.Label();
            this.lblSoNgay = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnTTCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhDaiDien)).BeginInit();
            this.pnTTTK.SuspendLayout();
            this.pnbtnAction.SuspendLayout();
            this.pnbtnSelection.SuspendLayout();
            this.pnTTLB.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvTaiKhoan
            // 
            this.lvTaiKhoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTenTaiKhoan,
            this.colMatKhau,
            this.colMaLoaiTaiKhoan});
            this.lvTaiKhoan.FullRowSelect = true;
            this.lvTaiKhoan.GridLines = true;
            this.lvTaiKhoan.HideSelection = false;
            this.lvTaiKhoan.Location = new System.Drawing.Point(17, 47);
            this.lvTaiKhoan.Name = "lvTaiKhoan";
            this.lvTaiKhoan.Size = new System.Drawing.Size(415, 398);
            this.lvTaiKhoan.TabIndex = 0;
            this.lvTaiKhoan.UseCompatibleStateImageBehavior = false;
            this.lvTaiKhoan.View = System.Windows.Forms.View.Details;
            this.lvTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.lvTaiKhoan_SelectedIndexChanged);
            // 
            // colTenTaiKhoan
            // 
            this.colTenTaiKhoan.Text = "Tên Tài Khoản";
            this.colTenTaiKhoan.Width = 120;
            // 
            // colMatKhau
            // 
            this.colMatKhau.Text = "Mật Khẩu";
            this.colMatKhau.Width = 120;
            // 
            // colMaLoaiTaiKhoan
            // 
            this.colMaLoaiTaiKhoan.Text = "Mã Loại Tài Khoản";
            this.colMaLoaiTaiKhoan.Width = 120;
            // 
            // pnTTCN
            // 
            this.pnTTCN.Controls.Add(this.lblTTCN);
            this.pnTTCN.Controls.Add(this.rbtnCancel);
            this.pnTTCN.Controls.Add(this.rbtnNu);
            this.pnTTCN.Controls.Add(this.rbtnNam);
            this.pnTTCN.Controls.Add(this.cbbNam);
            this.pnTTCN.Controls.Add(this.cbbThang);
            this.pnTTCN.Controls.Add(this.cbbNgay);
            this.pnTTCN.Controls.Add(this.txtSdt);
            this.pnTTCN.Controls.Add(this.txtDiaChi);
            this.pnTTCN.Controls.Add(this.txtHoVaTen);
            this.pnTTCN.Controls.Add(this.txtCccd);
            this.pnTTCN.Controls.Add(this.label6);
            this.pnTTCN.Controls.Add(this.label5);
            this.pnTTCN.Controls.Add(this.label4);
            this.pnTTCN.Controls.Add(this.label3);
            this.pnTTCN.Controls.Add(this.label2);
            this.pnTTCN.Controls.Add(this.label1);
            this.pnTTCN.Enabled = false;
            this.pnTTCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTTCN.Location = new System.Drawing.Point(716, 747);
            this.pnTTCN.Name = "pnTTCN";
            this.pnTTCN.Size = new System.Drawing.Size(966, 203);
            this.pnTTCN.TabIndex = 22;
            // 
            // lblTTCN
            // 
            this.lblTTCN.AutoSize = true;
            this.lblTTCN.Location = new System.Drawing.Point(431, 12);
            this.lblTTCN.Name = "lblTTCN";
            this.lblTTCN.Size = new System.Drawing.Size(185, 25);
            this.lblTTCN.TabIndex = 38;
            this.lblTTCN.Text = "Thông Tin Cá Nhân";
            // 
            // rbtnCancel
            // 
            this.rbtnCancel.AutoSize = true;
            this.rbtnCancel.Location = new System.Drawing.Point(353, 169);
            this.rbtnCancel.Name = "rbtnCancel";
            this.rbtnCancel.Size = new System.Drawing.Size(143, 29);
            this.rbtnCancel.TabIndex = 37;
            this.rbtnCancel.TabStop = true;
            this.rbtnCancel.Text = "radioButton1";
            this.rbtnCancel.UseVisualStyleBackColor = true;
            this.rbtnCancel.Visible = false;
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Location = new System.Drawing.Point(242, 166);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(58, 29);
            this.rbtnNu.TabIndex = 36;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nu";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Location = new System.Drawing.Point(119, 169);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(74, 29);
            this.rbtnNam.TabIndex = 23;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // cbbNam
            // 
            this.cbbNam.DropDownHeight = 70;
            this.cbbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.IntegralHeight = false;
            this.cbbNam.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930",
            "1929",
            "1928",
            "1927",
            "1926",
            "1925",
            "1924",
            "1923",
            "1922"});
            this.cbbNam.Location = new System.Drawing.Point(822, 160);
            this.cbbNam.MaxDropDownItems = 5;
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(109, 33);
            this.cbbNam.TabIndex = 35;
            // 
            // cbbThang
            // 
            this.cbbThang.DropDownHeight = 70;
            this.cbbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.IntegralHeight = false;
            this.cbbThang.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbbThang.Location = new System.Drawing.Point(707, 160);
            this.cbbThang.MaxDropDownItems = 5;
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(107, 33);
            this.cbbThang.TabIndex = 34;
            // 
            // cbbNgay
            // 
            this.cbbNgay.DropDownHeight = 70;
            this.cbbNgay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNgay.FormattingEnabled = true;
            this.cbbNgay.IntegralHeight = false;
            this.cbbNgay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbbNgay.Location = new System.Drawing.Point(621, 160);
            this.cbbNgay.MaxDropDownItems = 5;
            this.cbbNgay.Name = "cbbNgay";
            this.cbbNgay.Size = new System.Drawing.Size(79, 33);
            this.cbbNgay.TabIndex = 33;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(619, 116);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(230, 30);
            this.txtSdt.TabIndex = 32;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(619, 71);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(230, 30);
            this.txtDiaChi.TabIndex = 31;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(118, 116);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(230, 30);
            this.txtHoVaTen.TabIndex = 30;
            // 
            // txtCccd
            // 
            this.txtCccd.Location = new System.Drawing.Point(118, 66);
            this.txtCccd.Name = "txtCccd";
            this.txtCccd.Size = new System.Drawing.Size(230, 30);
            this.txtCccd.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "NTNS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cccd";
            // 
            // pbAnhDaiDien
            // 
            this.pbAnhDaiDien.Location = new System.Drawing.Point(572, 16);
            this.pbAnhDaiDien.Name = "pbAnhDaiDien";
            this.pbAnhDaiDien.Size = new System.Drawing.Size(294, 338);
            this.pbAnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnhDaiDien.TabIndex = 23;
            this.pbAnhDaiDien.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(289, 9);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(99, 38);
            this.btnHuy.TabIndex = 33;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(49, 9);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(112, 38);
            this.btnXacNhan.TabIndex = 32;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(289, 9);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 48);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(167, 9);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 48);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(49, 9);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 48);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(17, 16);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(415, 22);
            this.txtTimKiem.TabIndex = 38;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // pnTTTK
            // 
            this.pnTTTK.Controls.Add(this.txtMaNV);
            this.pnTTTK.Controls.Add(this.lblMaNV);
            this.pnTTTK.Controls.Add(this.lblTTTK);
            this.pnTTTK.Controls.Add(this.txtChucVu);
            this.pnTTTK.Controls.Add(this.txtMaTK);
            this.pnTTTK.Controls.Add(this.txtMatKhau);
            this.pnTTTK.Controls.Add(this.txtTaiKhoan);
            this.pnTTTK.Controls.Add(this.lblChucVu);
            this.pnTTTK.Controls.Add(this.lblMaTK);
            this.pnTTTK.Controls.Add(this.lblMatKhau);
            this.pnTTTK.Controls.Add(this.lblTaiKhoan);
            this.pnTTTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTTTK.Location = new System.Drawing.Point(913, 16);
            this.pnTTTK.Name = "pnTTTK";
            this.pnTTTK.Size = new System.Drawing.Size(366, 338);
            this.pnTTTK.TabIndex = 39;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(156, 61);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(175, 30);
            this.txtMaNV.TabIndex = 41;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(19, 61);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(73, 25);
            this.lblMaNV.TabIndex = 40;
            this.lblMaNV.Text = "Mã NV";
            // 
            // lblTTTK
            // 
            this.lblTTTK.AutoSize = true;
            this.lblTTTK.Location = new System.Drawing.Point(94, 25);
            this.lblTTTK.Name = "lblTTTK";
            this.lblTTTK.Size = new System.Drawing.Size(198, 25);
            this.lblTTTK.TabIndex = 39;
            this.lblTTTK.Text = "Thông Tin Tài Khoản";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(156, 281);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(175, 30);
            this.txtChucVu.TabIndex = 7;
            // 
            // txtMaTK
            // 
            this.txtMaTK.Location = new System.Drawing.Point(156, 228);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(175, 30);
            this.txtMaTK.TabIndex = 6;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(156, 170);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(175, 30);
            this.txtMatKhau.TabIndex = 5;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(156, 115);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(175, 30);
            this.txtTaiKhoan.TabIndex = 4;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(19, 286);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(85, 25);
            this.lblChucVu.TabIndex = 3;
            this.lblChucVu.Text = "Chức vụ";
            // 
            // lblMaTK
            // 
            this.lblMaTK.AutoSize = true;
            this.lblMaTK.Location = new System.Drawing.Point(19, 233);
            this.lblMaTK.Name = "lblMaTK";
            this.lblMaTK.Size = new System.Drawing.Size(60, 25);
            this.lblMaTK.TabIndex = 2;
            this.lblMaTK.Text = "Mã tk";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(19, 173);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(93, 25);
            this.lblMatKhau.TabIndex = 1;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Location = new System.Drawing.Point(19, 115);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(99, 25);
            this.lblTaiKhoan.TabIndex = 0;
            this.lblTaiKhoan.Text = "Tài khoản";
            // 
            // pnbtnAction
            // 
            this.pnbtnAction.Controls.Add(this.btnXoa);
            this.pnbtnAction.Controls.Add(this.btnThem);
            this.pnbtnAction.Controls.Add(this.btnSua);
            this.pnbtnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnbtnAction.Location = new System.Drawing.Point(17, 451);
            this.pnbtnAction.Name = "pnbtnAction";
            this.pnbtnAction.Size = new System.Drawing.Size(459, 91);
            this.pnbtnAction.TabIndex = 40;
            // 
            // pnbtnSelection
            // 
            this.pnbtnSelection.Controls.Add(this.btnHuy);
            this.pnbtnSelection.Controls.Add(this.btnXacNhan);
            this.pnbtnSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnbtnSelection.Location = new System.Drawing.Point(17, 578);
            this.pnbtnSelection.Name = "pnbtnSelection";
            this.pnbtnSelection.Size = new System.Drawing.Size(426, 78);
            this.pnbtnSelection.TabIndex = 41;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(66, 675);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(112, 45);
            this.btnQuayLai.TabIndex = 34;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // pnTTLB
            // 
            this.pnTTLB.Controls.Add(this.lblTTLB);
            this.pnTTLB.Controls.Add(this.txtThuong);
            this.pnTTLB.Controls.Add(this.txtLuongNgay);
            this.pnTTLB.Controls.Add(this.txtSoNgay);
            this.pnTTLB.Controls.Add(this.lblThuong);
            this.pnTTLB.Controls.Add(this.lblLuongNgay);
            this.pnTTLB.Controls.Add(this.lblSoNgay);
            this.pnTTLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTTLB.Location = new System.Drawing.Point(1327, 16);
            this.pnTTLB.Name = "pnTTLB";
            this.pnTTLB.Size = new System.Drawing.Size(355, 338);
            this.pnTTLB.TabIndex = 40;
            // 
            // lblTTLB
            // 
            this.lblTTLB.AutoSize = true;
            this.lblTTLB.Location = new System.Drawing.Point(97, 25);
            this.lblTTLB.Name = "lblTTLB";
            this.lblTTLB.Size = new System.Drawing.Size(213, 25);
            this.lblTTLB.TabIndex = 40;
            this.lblTTLB.Text = "Thông Tin Lương Bổng";
            // 
            // txtThuong
            // 
            this.txtThuong.Location = new System.Drawing.Point(164, 192);
            this.txtThuong.Name = "txtThuong";
            this.txtThuong.Size = new System.Drawing.Size(175, 30);
            this.txtThuong.TabIndex = 7;
            // 
            // txtLuongNgay
            // 
            this.txtLuongNgay.Location = new System.Drawing.Point(164, 137);
            this.txtLuongNgay.Name = "txtLuongNgay";
            this.txtLuongNgay.Size = new System.Drawing.Size(175, 30);
            this.txtLuongNgay.TabIndex = 6;
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.Location = new System.Drawing.Point(253, 80);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.Size = new System.Drawing.Size(86, 30);
            this.txtSoNgay.TabIndex = 5;
            // 
            // lblThuong
            // 
            this.lblThuong.AutoSize = true;
            this.lblThuong.Location = new System.Drawing.Point(23, 195);
            this.lblThuong.Name = "lblThuong";
            this.lblThuong.Size = new System.Drawing.Size(80, 25);
            this.lblThuong.TabIndex = 3;
            this.lblThuong.Text = "Thưởng";
            // 
            // lblLuongNgay
            // 
            this.lblLuongNgay.AutoSize = true;
            this.lblLuongNgay.Location = new System.Drawing.Point(23, 142);
            this.lblLuongNgay.Name = "lblLuongNgay";
            this.lblLuongNgay.Size = new System.Drawing.Size(115, 25);
            this.lblLuongNgay.TabIndex = 2;
            this.lblLuongNgay.Text = "Lương ngày";
            // 
            // lblSoNgay
            // 
            this.lblSoNgay.AutoSize = true;
            this.lblSoNgay.Location = new System.Drawing.Point(23, 83);
            this.lblSoNgay.Name = "lblSoNgay";
            this.lblSoNgay.Size = new System.Drawing.Size(224, 25);
            this.lblSoNgay.TabIndex = 1;
            this.lblSoNgay.Text = "Số ngày làm trong tháng";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(306, 676);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 44);
            this.button1.TabIndex = 42;
            this.button1.Text = "Tiếp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GUIQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1711, 996);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnTTLB);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.pnbtnSelection);
            this.Controls.Add(this.pnbtnAction);
            this.Controls.Add(this.pnTTTK);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.pbAnhDaiDien);
            this.Controls.Add(this.pnTTCN);
            this.Controls.Add(this.lvTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUIQuanLyTaiKhoan";
            this.Text = "GUIQuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.GUIQuanLyTaiKhoan_Load);
            this.pnTTCN.ResumeLayout(false);
            this.pnTTCN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhDaiDien)).EndInit();
            this.pnTTTK.ResumeLayout(false);
            this.pnTTTK.PerformLayout();
            this.pnbtnAction.ResumeLayout(false);
            this.pnbtnSelection.ResumeLayout(false);
            this.pnTTLB.ResumeLayout(false);
            this.pnTTLB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvTaiKhoan;
        private ColumnHeader colTenTaiKhoan;
        private ColumnHeader colMatKhau;
        private ColumnHeader colMaLoaiTaiKhoan;
        private Panel pnTTCN;
        private RadioButton rbtnCancel;
        private RadioButton rbtnNu;
        private RadioButton rbtnNam;
        private ComboBox cbbNam;
        private ComboBox cbbThang;
        private ComboBox cbbNgay;
        private TextBox txtSdt;
        private TextBox txtDiaChi;
        private TextBox txtHoVaTen;
        private TextBox txtCccd;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pbAnhDaiDien;
        private Button btnHuy;
        private Button btnXacNhan;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTimKiem;
        private Panel pnTTTK;
        private Label lblMaTK;
        private Label lblMatKhau;
        private Label lblTaiKhoan;
        private TextBox txtChucVu;
        private TextBox txtMaTK;
        private TextBox txtMatKhau;
        private TextBox txtTaiKhoan;
        private Label lblChucVu;
        private Panel pnbtnAction;
        private Panel pnbtnSelection;
        private Button btnQuayLai;
        private Panel pnTTLB;
        private TextBox txtThuong;
        private TextBox txtLuongNgay;
        private TextBox txtSoNgay;
        private Label lblThuong;
        private Label lblLuongNgay;
        private Label lblSoNgay;
        private Label lblTTCN;
        private Label lblTTTK;
        private Label lblTTLB;
        private TextBox txtMaNV;
        private Label lblMaNV;
        private Button button1;
    }
}