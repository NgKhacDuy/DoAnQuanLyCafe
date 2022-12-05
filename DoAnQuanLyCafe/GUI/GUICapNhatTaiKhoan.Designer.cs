using System.Windows.Forms;

namespace DoAnQuanLyCafe.GUI
{
    partial class GUICapNhatTaiKhoan
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
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.pnTTTK = new System.Windows.Forms.Panel();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.btnXemNLMKM = new System.Windows.Forms.Button();
            this.btnXemMKM = new System.Windows.Forms.Button();
            this.btnXemMKC = new System.Windows.Forms.Button();
            this.lblTTTK = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.txtNhapLai = new System.Windows.Forms.TextBox();
            this.lblMatKhauCu = new System.Windows.Forms.Label();
            this.lblNhapLai = new System.Windows.Forms.Label();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.pnbtnAction = new System.Windows.Forms.Panel();
            this.btnTTCN = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.pnSelection = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.pnTTCN = new System.Windows.Forms.Panel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pbTTCN = new System.Windows.Forms.PictureBox();
            this.rbtnCancel = new System.Windows.Forms.RadioButton();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.cbbNgay = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblNTNS = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblHoVaTen = new System.Windows.Forms.Label();
            this.lblTTCN = new System.Windows.Forms.Label();
            this.pnTTTK.SuspendLayout();
            this.pnbtnAction.SuspendLayout();
            this.pnSelection.SuspendLayout();
            this.pnTTCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTTCN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Location = new System.Drawing.Point(41, 900);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(146, 45);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(41, 829);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(146, 43);
            this.btnContinue.TabIndex = 100;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // pnTTTK
            // 
            this.pnTTTK.Controls.Add(this.txtMaNV);
            this.pnTTTK.Controls.Add(this.lblMaNV);
            this.pnTTTK.Controls.Add(this.btnXemNLMKM);
            this.pnTTTK.Controls.Add(this.btnXemMKM);
            this.pnTTTK.Controls.Add(this.btnXemMKC);
            this.pnTTTK.Controls.Add(this.lblTTTK);
            this.pnTTTK.Controls.Add(this.txtTaiKhoan);
            this.pnTTTK.Controls.Add(this.txtMatKhauCu);
            this.pnTTTK.Controls.Add(this.txtMatKhauMoi);
            this.pnTTTK.Controls.Add(this.lblTaiKhoan);
            this.pnTTTK.Controls.Add(this.txtNhapLai);
            this.pnTTTK.Controls.Add(this.lblMatKhauCu);
            this.pnTTTK.Controls.Add(this.lblNhapLai);
            this.pnTTTK.Controls.Add(this.lblMatKhauMoi);
            this.pnTTTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTTTK.Location = new System.Drawing.Point(18, 13);
            this.pnTTTK.Name = "pnTTTK";
            this.pnTTTK.Size = new System.Drawing.Size(628, 375);
            this.pnTTTK.TabIndex = 147;
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(285, 50);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(114, 34);
            this.txtMaNV.TabIndex = 136;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(18, 50);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(85, 29);
            this.lblMaNV.TabIndex = 137;
            this.lblMaNV.Text = "Mã NV";
            // 
            // btnXemNLMKM
            // 
            this.btnXemNLMKM.Location = new System.Drawing.Point(473, 271);
            this.btnXemNLMKM.Name = "btnXemNLMKM";
            this.btnXemNLMKM.Size = new System.Drawing.Size(29, 25);
            this.btnXemNLMKM.TabIndex = 130;
            this.btnXemNLMKM.UseVisualStyleBackColor = true;
            this.btnXemNLMKM.Click += new System.EventHandler(this.btnXemNLMKM_Click);
            // 
            // btnXemMKM
            // 
            this.btnXemMKM.Location = new System.Drawing.Point(473, 214);
            this.btnXemMKM.Name = "btnXemMKM";
            this.btnXemMKM.Size = new System.Drawing.Size(29, 25);
            this.btnXemMKM.TabIndex = 129;
            this.btnXemMKM.UseVisualStyleBackColor = true;
            this.btnXemMKM.Click += new System.EventHandler(this.btnXemMKM_Click);
            // 
            // btnXemMKC
            // 
            this.btnXemMKC.Location = new System.Drawing.Point(473, 153);
            this.btnXemMKC.Name = "btnXemMKC";
            this.btnXemMKC.Size = new System.Drawing.Size(29, 25);
            this.btnXemMKC.TabIndex = 128;
            this.btnXemMKC.UseVisualStyleBackColor = true;
            this.btnXemMKC.Click += new System.EventHandler(this.btnXemMKC_Click);
            // 
            // lblTTTK
            // 
            this.lblTTTK.AutoSize = true;
            this.lblTTTK.Location = new System.Drawing.Point(203, 1);
            this.lblTTTK.Name = "lblTTTK";
            this.lblTTTK.Size = new System.Drawing.Size(240, 29);
            this.lblTTTK.TabIndex = 131;
            this.lblTTTK.Text = "Thông Tin Tài Khoản";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTaiKhoan.Enabled = false;
            this.txtTaiKhoan.Location = new System.Drawing.Point(285, 96);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(114, 34);
            this.txtTaiKhoan.TabIndex = 127;
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtMatKhauCu.Enabled = false;
            this.txtMatKhauCu.Location = new System.Drawing.Point(285, 148);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.PasswordChar = '*';
            this.txtMatKhauCu.Size = new System.Drawing.Size(114, 34);
            this.txtMatKhauCu.TabIndex = 126;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(285, 209);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(114, 34);
            this.txtMatKhauMoi.TabIndex = 124;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Location = new System.Drawing.Point(18, 99);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(123, 29);
            this.lblTaiKhoan.TabIndex = 135;
            this.lblTaiKhoan.Text = "Tài Khoản";
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.Location = new System.Drawing.Point(285, 266);
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.PasswordChar = '*';
            this.txtNhapLai.Size = new System.Drawing.Size(114, 34);
            this.txtNhapLai.TabIndex = 125;
            // 
            // lblMatKhauCu
            // 
            this.lblMatKhauCu.AutoSize = true;
            this.lblMatKhauCu.Location = new System.Drawing.Point(18, 157);
            this.lblMatKhauCu.Name = "lblMatKhauCu";
            this.lblMatKhauCu.Size = new System.Drawing.Size(149, 29);
            this.lblMatKhauCu.TabIndex = 134;
            this.lblMatKhauCu.Text = "Mật Khẩu Cũ";
            // 
            // lblNhapLai
            // 
            this.lblNhapLai.AutoSize = true;
            this.lblNhapLai.Location = new System.Drawing.Point(18, 271);
            this.lblNhapLai.Name = "lblNhapLai";
            this.lblNhapLai.Size = new System.Drawing.Size(261, 29);
            this.lblNhapLai.TabIndex = 132;
            this.lblNhapLai.Text = "Nhập Lại Mật Khẩu Mới";
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.Location = new System.Drawing.Point(18, 214);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(159, 29);
            this.lblMatKhauMoi.TabIndex = 133;
            this.lblMatKhauMoi.Text = "Mật Khẩu Mới";
            // 
            // pnbtnAction
            // 
            this.pnbtnAction.Controls.Add(this.btnTTCN);
            this.pnbtnAction.Controls.Add(this.btnDoiMatKhau);
            this.pnbtnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnbtnAction.Location = new System.Drawing.Point(12, 562);
            this.pnbtnAction.Name = "pnbtnAction";
            this.pnbtnAction.Size = new System.Drawing.Size(421, 78);
            this.pnbtnAction.TabIndex = 148;
            // 
            // btnTTCN
            // 
            this.btnTTCN.Location = new System.Drawing.Point(246, 11);
            this.btnTTCN.Name = "btnTTCN";
            this.btnTTCN.Size = new System.Drawing.Size(123, 39);
            this.btnTTCN.TabIndex = 127;
            this.btnTTCN.Text = "Cập Nhật TTCN";
            this.btnTTCN.UseVisualStyleBackColor = true;
            this.btnTTCN.Click += new System.EventHandler(this.btnTTCN_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(16, 11);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(179, 39);
            this.btnDoiMatKhau.TabIndex = 126;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // pnSelection
            // 
            this.pnSelection.Controls.Add(this.btnHuy);
            this.pnSelection.Controls.Add(this.btnXacNhan);
            this.pnSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnSelection.Location = new System.Drawing.Point(12, 691);
            this.pnSelection.Name = "pnSelection";
            this.pnSelection.Size = new System.Drawing.Size(421, 105);
            this.pnSelection.TabIndex = 149;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(246, 17);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(123, 42);
            this.btnHuy.TabIndex = 129;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(16, 17);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(140, 42);
            this.btnXacNhan.TabIndex = 128;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // pnTTCN
            // 
            this.pnTTCN.Controls.Add(this.btnBrowse);
            this.pnTTCN.Controls.Add(this.pbTTCN);
            this.pnTTCN.Controls.Add(this.rbtnCancel);
            this.pnTTCN.Controls.Add(this.cbbNam);
            this.pnTTCN.Controls.Add(this.cbbThang);
            this.pnTTCN.Controls.Add(this.cbbNgay);
            this.pnTTCN.Controls.Add(this.txtDiaChi);
            this.pnTTCN.Controls.Add(this.txtSDT);
            this.pnTTCN.Controls.Add(this.rbtnNu);
            this.pnTTCN.Controls.Add(this.rbtnNam);
            this.pnTTCN.Controls.Add(this.txtHoVaTen);
            this.pnTTCN.Controls.Add(this.txtCCCD);
            this.pnTTCN.Controls.Add(this.lblNTNS);
            this.pnTTCN.Controls.Add(this.lblDiaChi);
            this.pnTTCN.Controls.Add(this.lblSDT);
            this.pnTTCN.Controls.Add(this.lblCCCD);
            this.pnTTCN.Controls.Add(this.lblGioiTinh);
            this.pnTTCN.Controls.Add(this.lblHoVaTen);
            this.pnTTCN.Controls.Add(this.lblTTCN);
            this.pnTTCN.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnTTCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTTCN.Location = new System.Drawing.Point(1221, 0);
            this.pnTTCN.Name = "pnTTCN";
            this.pnTTCN.Size = new System.Drawing.Size(490, 996);
            this.pnTTCN.TabIndex = 150;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(198, 284);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(106, 48);
            this.btnBrowse.TabIndex = 165;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbTTCN
            // 
            this.pbTTCN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTTCN.Location = new System.Drawing.Point(146, 63);
            this.pbTTCN.Name = "pbTTCN";
            this.pbTTCN.Size = new System.Drawing.Size(208, 205);
            this.pbTTCN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTTCN.TabIndex = 164;
            this.pbTTCN.TabStop = false;
            // 
            // rbtnCancel
            // 
            this.rbtnCancel.AutoSize = true;
            this.rbtnCancel.Location = new System.Drawing.Point(370, 606);
            this.rbtnCancel.Name = "rbtnCancel";
            this.rbtnCancel.Size = new System.Drawing.Size(109, 33);
            this.rbtnCancel.TabIndex = 162;
            this.rbtnCancel.TabStop = true;
            this.rbtnCancel.Text = "Cancel";
            this.rbtnCancel.UseVisualStyleBackColor = true;
            this.rbtnCancel.Visible = false;
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
            this.cbbNam.Location = new System.Drawing.Point(368, 840);
            this.cbbNam.MaxDropDownItems = 5;
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbbNam.Size = new System.Drawing.Size(99, 37);
            this.cbbNam.TabIndex = 155;
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
            this.cbbThang.Location = new System.Drawing.Point(262, 840);
            this.cbbThang.MaxDropDownItems = 5;
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbbThang.Size = new System.Drawing.Size(99, 37);
            this.cbbThang.TabIndex = 154;
            // 
            // cbbNgay
            // 
            this.cbbNgay.DisplayMember = "(none)";
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
            this.cbbNgay.Location = new System.Drawing.Point(197, 840);
            this.cbbNgay.MaxDropDownItems = 5;
            this.cbbNgay.Name = "cbbNgay";
            this.cbbNgay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbbNgay.Size = new System.Drawing.Size(58, 37);
            this.cbbNgay.TabIndex = 153;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(197, 745);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(114, 34);
            this.txtDiaChi.TabIndex = 152;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(198, 701);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(114, 34);
            this.txtSDT.TabIndex = 151;
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Location = new System.Drawing.Point(289, 607);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(65, 33);
            this.rbtnNu.TabIndex = 150;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            this.rbtnNu.CheckedChanged += new System.EventHandler(this.rbtnNu_CheckedChanged);
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Location = new System.Drawing.Point(186, 607);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(85, 33);
            this.rbtnNam.TabIndex = 149;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            this.rbtnNam.CheckedChanged += new System.EventHandler(this.rbtnNam_CheckedChanged);
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(189, 525);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(114, 34);
            this.txtHoVaTen.TabIndex = 148;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(189, 477);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(114, 34);
            this.txtCCCD.TabIndex = 147;
            // 
            // lblNTNS
            // 
            this.lblNTNS.AutoSize = true;
            this.lblNTNS.Location = new System.Drawing.Point(24, 843);
            this.lblNTNS.Name = "lblNTNS";
            this.lblNTNS.Size = new System.Drawing.Size(165, 29);
            this.lblNTNS.TabIndex = 163;
            this.lblNTNS.Text = "DD/MM/YYYY";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(26, 748);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(91, 29);
            this.lblDiaChi.TabIndex = 159;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(25, 704);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(167, 29);
            this.lblSDT.TabIndex = 158;
            this.lblSDT.Text = "Số Điện Thoại";
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(29, 485);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(160, 29);
            this.lblCCCD.TabIndex = 157;
            this.lblCCCD.Text = "CCCD/CMND";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(26, 610);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(111, 29);
            this.lblGioiTinh.TabIndex = 156;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.AutoSize = true;
            this.lblHoVaTen.Location = new System.Drawing.Point(29, 528);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(127, 29);
            this.lblHoVaTen.TabIndex = 161;
            this.lblHoVaTen.Text = "Họ Và Tên";
            // 
            // lblTTCN
            // 
            this.lblTTCN.AutoSize = true;
            this.lblTTCN.Location = new System.Drawing.Point(141, 14);
            this.lblTTCN.Name = "lblTTCN";
            this.lblTTCN.Size = new System.Drawing.Size(223, 29);
            this.lblTTCN.TabIndex = 160;
            this.lblTTCN.Text = "Thông Tin Cá Nhân";
            // 
            // GUICapNhatTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1711, 996);
            this.Controls.Add(this.pnTTCN);
            this.Controls.Add(this.pnSelection);
            this.Controls.Add(this.pnbtnAction);
            this.Controls.Add(this.pnTTTK);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnDangXuat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUICapNhatTaiKhoan";
            this.Text = "Form1";
            this.pnTTTK.ResumeLayout(false);
            this.pnTTTK.PerformLayout();
            this.pnbtnAction.ResumeLayout(false);
            this.pnSelection.ResumeLayout(false);
            this.pnTTCN.ResumeLayout(false);
            this.pnTTCN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTTCN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnDangXuat;
        private Button btnContinue;
        private Panel pnTTTK;
        private Button btnXemNLMKM;
        private Button btnXemMKM;
        private Button btnXemMKC;
        private Label lblTTTK;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhauCu;
        private TextBox txtMatKhauMoi;
        private Label lblTaiKhoan;
        private TextBox txtNhapLai;
        private Label lblMatKhauCu;
        private Label lblNhapLai;
        private Label lblMatKhauMoi;
        private Panel pnbtnAction;
        private Button btnTTCN;
        private Button btnDoiMatKhau;
        private Panel pnSelection;
        private Button btnHuy;
        private Button btnXacNhan;
        private Panel pnTTCN;
        private Button btnBrowse;
        private PictureBox pbTTCN;
        private RadioButton rbtnCancel;
        private ComboBox cbbNam;
        private ComboBox cbbThang;
        private ComboBox cbbNgay;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private RadioButton rbtnNu;
        private RadioButton rbtnNam;
        private TextBox txtHoVaTen;
        private TextBox txtCCCD;
        private Label lblNTNS;
        private Label lblDiaChi;
        private Label lblSDT;
        private Label lblCCCD;
        private Label lblGioiTinh;
        private Label lblHoVaTen;
        private Label lblTTCN;
        private TextBox txtMaNV;
        private Label lblMaNV;
    }
}