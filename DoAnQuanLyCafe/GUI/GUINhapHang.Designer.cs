using System.Windows.Forms;

namespace DoAnQuanLyCafe.GUI
{
    partial class GUINhapHang
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.pnChildAction = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.pnSelection = new System.Windows.Forms.Panel();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.pnAction = new System.Windows.Forms.Panel();
            this.btnQLNL = new System.Windows.Forms.Button();
            this.btnMuaHang = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.txtTenNL = new System.Windows.Forms.TextBox();
            this.lblTenNL = new System.Windows.Forms.Label();
            this.lblTTNL = new System.Windows.Forms.Label();
            this.txtMaNL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBienLai = new System.Windows.Forms.Label();
            this.lvBienLai = new System.Windows.Forms.ListView();
            this.colMaNLBL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenNLBL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonViBL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNLTK = new System.Windows.Forms.Label();
            this.lvNLK = new System.Windows.Forms.ListView();
            this.colMaNL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenNL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTonKho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonVi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.pnChildAction.SuspendLayout();
            this.pnSelection.SuspendLayout();
            this.pnAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(14, 13);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(315, 22);
            this.txtTimKiem.TabIndex = 23;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // pnChildAction
            // 
            this.pnChildAction.Controls.Add(this.btnThem);
            this.pnChildAction.Controls.Add(this.btnSua);
            this.pnChildAction.Controls.Add(this.btnXoa);
            this.pnChildAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnChildAction.Location = new System.Drawing.Point(1329, 383);
            this.pnChildAction.Name = "pnChildAction";
            this.pnChildAction.Size = new System.Drawing.Size(270, 186);
            this.pnChildAction.TabIndex = 43;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(66, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(149, 37);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(66, 64);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(149, 42);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(66, 127);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(149, 39);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // pnSelection
            // 
            this.pnSelection.Controls.Add(this.btnXacNhan);
            this.pnSelection.Controls.Add(this.btnHuy);
            this.pnSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnSelection.Location = new System.Drawing.Point(17, 699);
            this.pnSelection.Name = "pnSelection";
            this.pnSelection.Size = new System.Drawing.Size(344, 92);
            this.pnSelection.TabIndex = 42;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(13, 15);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(152, 46);
            this.btnXacNhan.TabIndex = 17;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(176, 15);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(152, 46);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // pnAction
            // 
            this.pnAction.Controls.Add(this.btnQLNL);
            this.pnAction.Controls.Add(this.btnMuaHang);
            this.pnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnAction.Location = new System.Drawing.Point(17, 595);
            this.pnAction.Name = "pnAction";
            this.pnAction.Size = new System.Drawing.Size(344, 95);
            this.pnAction.TabIndex = 41;
            // 
            // btnQLNL
            // 
            this.btnQLNL.Location = new System.Drawing.Point(13, 17);
            this.btnQLNL.Name = "btnQLNL";
            this.btnQLNL.Size = new System.Drawing.Size(152, 42);
            this.btnQLNL.TabIndex = 19;
            this.btnQLNL.Text = "Quản Lý Nguyên Liệu";
            this.btnQLNL.UseVisualStyleBackColor = true;
            this.btnQLNL.Click += new System.EventHandler(this.btnQLNL_Click);
            // 
            // btnMuaHang
            // 
            this.btnMuaHang.Location = new System.Drawing.Point(176, 17);
            this.btnMuaHang.Name = "btnMuaHang";
            this.btnMuaHang.Size = new System.Drawing.Size(152, 42);
            this.btnMuaHang.TabIndex = 21;
            this.btnMuaHang.Text = "Mua Hàng";
            this.btnMuaHang.UseVisualStyleBackColor = true;
            this.btnMuaHang.Click += new System.EventHandler(this.btnMuaHang_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(30, 797);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(152, 47);
            this.btnQuayLai.TabIndex = 40;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // txtDonVi
            // 
            this.txtDonVi.Enabled = false;
            this.txtDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonVi.Location = new System.Drawing.Point(1490, 255);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(114, 30);
            this.txtDonVi.TabIndex = 39;
            // 
            // lblDonVi
            // 
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonVi.Location = new System.Drawing.Point(1329, 258);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(71, 25);
            this.lblDonVi.TabIndex = 38;
            this.lblDonVi.Text = "Đơn Vị";
            // 
            // txtTenNL
            // 
            this.txtTenNL.Enabled = false;
            this.txtTenNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNL.Location = new System.Drawing.Point(1490, 211);
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.Size = new System.Drawing.Size(114, 30);
            this.txtTenNL.TabIndex = 35;
            // 
            // lblTenNL
            // 
            this.lblTenNL.AutoSize = true;
            this.lblTenNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNL.Location = new System.Drawing.Point(1328, 214);
            this.lblTenNL.Name = "lblTenNL";
            this.lblTenNL.Size = new System.Drawing.Size(162, 25);
            this.lblTenNL.TabIndex = 34;
            this.lblTenNL.Text = "Tên Nguyên Liệu";
            // 
            // lblTTNL
            // 
            this.lblTTNL.AutoSize = true;
            this.lblTTNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTNL.Location = new System.Drawing.Point(1353, 130);
            this.lblTTNL.Name = "lblTTNL";
            this.lblTTNL.Size = new System.Drawing.Size(217, 25);
            this.lblTTNL.TabIndex = 33;
            this.lblTTNL.Text = "Thông Tin Nguyên Liệu";
            // 
            // txtMaNL
            // 
            this.txtMaNL.Enabled = false;
            this.txtMaNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNL.Location = new System.Drawing.Point(1490, 169);
            this.txtMaNL.Name = "txtMaNL";
            this.txtMaNL.Size = new System.Drawing.Size(114, 30);
            this.txtMaNL.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1329, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mã Nguyên Liệu";
            // 
            // lblBienLai
            // 
            this.lblBienLai.AutoSize = true;
            this.lblBienLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienLai.Location = new System.Drawing.Point(613, 118);
            this.lblBienLai.Name = "lblBienLai";
            this.lblBienLai.Size = new System.Drawing.Size(167, 25);
            this.lblBienLai.TabIndex = 30;
            this.lblBienLai.Text = "Biên lai mua hàng";
            // 
            // lvBienLai
            // 
            this.lvBienLai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaNLBL,
            this.colTenNLBL,
            this.colSoLuong,
            this.colDonViBL,
            this.colDonGia,
            this.colTong});
            this.lvBienLai.FullRowSelect = true;
            this.lvBienLai.GridLines = true;
            this.lvBienLai.HideSelection = false;
            this.lvBienLai.Location = new System.Drawing.Point(611, 158);
            this.lvBienLai.Name = "lvBienLai";
            this.lvBienLai.Size = new System.Drawing.Size(473, 371);
            this.lvBienLai.TabIndex = 29;
            this.lvBienLai.UseCompatibleStateImageBehavior = false;
            this.lvBienLai.View = System.Windows.Forms.View.Details;
            this.lvBienLai.SelectedIndexChanged += new System.EventHandler(this.lvBienLai_SelectedIndexChanged);
            // 
            // colMaNLBL
            // 
            this.colMaNLBL.Text = "Mã NL";
            this.colMaNLBL.Width = 50;
            // 
            // colTenNLBL
            // 
            this.colTenNLBL.Text = "Tên Nguyên Liệu";
            this.colTenNLBL.Width = 100;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số Lượng";
            this.colSoLuong.Width = 65;
            // 
            // colDonViBL
            // 
            this.colDonViBL.Text = "Đơn Vị";
            // 
            // colDonGia
            // 
            this.colDonGia.Text = "Đơn Giá";
            // 
            // colTong
            // 
            this.colTong.Text = "Tổng Tiền";
            this.colTong.Width = 70;
            // 
            // lblNLTK
            // 
            this.lblNLTK.AutoSize = true;
            this.lblNLTK.Location = new System.Drawing.Point(14, 99);
            this.lblNLTK.Name = "lblNLTK";
            this.lblNLTK.Size = new System.Drawing.Size(136, 16);
            this.lblNLTK.TabIndex = 28;
            this.lblNLTK.Text = "Nguyên liệu trong kho";
            // 
            // lvNLK
            // 
            this.lvNLK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaNL,
            this.colTenNL,
            this.colTonKho,
            this.colDonVi});
            this.lvNLK.FullRowSelect = true;
            this.lvNLK.GridLines = true;
            this.lvNLK.HideSelection = false;
            this.lvNLK.Location = new System.Drawing.Point(14, 118);
            this.lvNLK.Name = "lvNLK";
            this.lvNLK.Size = new System.Drawing.Size(315, 402);
            this.lvNLK.TabIndex = 27;
            this.lvNLK.UseCompatibleStateImageBehavior = false;
            this.lvNLK.View = System.Windows.Forms.View.Details;
            this.lvNLK.SelectedIndexChanged += new System.EventHandler(this.lvNLK_SelectedIndexChanged);
            // 
            // colMaNL
            // 
            this.colMaNL.Text = "Mã NL";
            this.colMaNL.Width = 50;
            // 
            // colTenNL
            // 
            this.colTenNL.Text = "Tên Nguyên Liệu";
            this.colTenNL.Width = 100;
            // 
            // colTonKho
            // 
            this.colTonKho.Text = "Tồn Kho";
            // 
            // colDonVi
            // 
            this.colDonVi.Text = "Đơn Vị";
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Số lượng tăng dần",
            "Số lượng giảm dần",
            "Theo mã nguyên liệu"});
            this.cbbTimKiem.Location = new System.Drawing.Point(14, 44);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(315, 24);
            this.cbbTimKiem.TabIndex = 44;
            this.cbbTimKiem.SelectedIndexChanged += new System.EventHandler(this.cbbTimKiem_SelectedIndexChanged);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(766, 536);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(317, 22);
            this.txtTongTien.TabIndex = 46;
            this.txtTongTien.Text = "0";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(611, 539);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(102, 25);
            this.lblTongTien.TabIndex = 45;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(1490, 296);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(114, 30);
            this.txtSoLuong.TabIndex = 48;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(1329, 301);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(97, 25);
            this.lblSoLuong.TabIndex = 47;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(1490, 338);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(114, 30);
            this.txtDonGia.TabIndex = 50;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(1329, 341);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(83, 25);
            this.lblDonGia.TabIndex = 49;
            this.lblDonGia.Text = "Đơn Giá";
            // 
            // GUINhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1693, 949);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.cbbTimKiem);
            this.Controls.Add(this.pnChildAction);
            this.Controls.Add(this.pnSelection);
            this.Controls.Add(this.pnAction);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.txtDonVi);
            this.Controls.Add(this.lblDonVi);
            this.Controls.Add(this.txtTenNL);
            this.Controls.Add(this.lblTenNL);
            this.Controls.Add(this.lblTTNL);
            this.Controls.Add(this.txtMaNL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBienLai);
            this.Controls.Add(this.lvBienLai);
            this.Controls.Add(this.lblNLTK);
            this.Controls.Add(this.lvNLK);
            this.Controls.Add(this.txtTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUINhapHang";
            this.Text = "GUINhapHang";
            this.pnChildAction.ResumeLayout(false);
            this.pnSelection.ResumeLayout(false);
            this.pnAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTimKiem;
        private Panel pnChildAction;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Panel pnSelection;
        private Button btnXacNhan;
        private Button btnHuy;
        private Panel pnAction;
        private Button btnQLNL;
        private Button btnMuaHang;
        private Button btnQuayLai;
        private TextBox txtDonVi;
        private Label lblDonVi;
        private TextBox txtTenNL;
        private Label lblTenNL;
        private Label lblTTNL;
        private TextBox txtMaNL;
        private Label label1;
        private Label lblBienLai;
        private ListView lvBienLai;
        private ColumnHeader colMaNLBL;
        private ColumnHeader colTenNLBL;
        private ColumnHeader colSoLuong;
        private ColumnHeader colDonViBL;
        private Label lblNLTK;
        private ListView lvNLK;
        private ColumnHeader colMaNL;
        private ColumnHeader colTenNL;
        private ColumnHeader colTonKho;
        private ColumnHeader colDonVi;
        private ComboBox cbbTimKiem;
        private TextBox txtTongTien;
        private Label lblTongTien;
        private TextBox txtSoLuong;
        private Label lblSoLuong;
        private TextBox txtDonGia;
        private Label lblDonGia;
        private ColumnHeader colDonGia;
        private ColumnHeader colTong;
    }
}