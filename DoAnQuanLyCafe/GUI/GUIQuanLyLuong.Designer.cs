using System.Windows.Forms;

namespace DoAnQuanLyCafe.GUI
{
    partial class GUIQuanLyLuong
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
            this.lvNhanVien = new System.Windows.Forms.ListView();
            this.colMaNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoNgayLam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnbtnAction = new System.Windows.Forms.Panel();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.btnSuaLuong = new System.Windows.Forms.Button();
            this.pnbtnSelection = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.pnTTLB = new System.Windows.Forms.Panel();
            this.lblTTLB = new System.Windows.Forms.Label();
            this.txtThuong = new System.Windows.Forms.TextBox();
            this.txtLuongNgay = new System.Windows.Forms.TextBox();
            this.txtSoNgay = new System.Windows.Forms.TextBox();
            this.lblThuong = new System.Windows.Forms.Label();
            this.lblLuongNgay = new System.Windows.Forms.Label();
            this.lblSoNgay = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.pnbtnAction.SuspendLayout();
            this.pnbtnSelection.SuspendLayout();
            this.pnTTLB.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvNhanVien
            // 
            this.lvNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaNhanVien,
            this.colSoNgayLam});
            this.lvNhanVien.FullRowSelect = true;
            this.lvNhanVien.GridLines = true;
            this.lvNhanVien.HideSelection = false;
            this.lvNhanVien.Location = new System.Drawing.Point(14, 44);
            this.lvNhanVien.Name = "lvNhanVien";
            this.lvNhanVien.Size = new System.Drawing.Size(278, 263);
            this.lvNhanVien.TabIndex = 1;
            this.lvNhanVien.UseCompatibleStateImageBehavior = false;
            this.lvNhanVien.View = System.Windows.Forms.View.Details;
            this.lvNhanVien.SelectedIndexChanged += new System.EventHandler(this.lvNhanVien_SelectedIndexChanged);
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.Text = "Mã Nhân Viên";
            this.colMaNhanVien.Width = 120;
            // 
            // colSoNgayLam
            // 
            this.colSoNgayLam.Text = "Số Ngày Làm";
            this.colSoNgayLam.Width = 120;
            // 
            // pnbtnAction
            // 
            this.pnbtnAction.Controls.Add(this.btnTinhLuong);
            this.pnbtnAction.Controls.Add(this.btnSuaLuong);
            this.pnbtnAction.Location = new System.Drawing.Point(14, 314);
            this.pnbtnAction.Name = "pnbtnAction";
            this.pnbtnAction.Size = new System.Drawing.Size(279, 39);
            this.pnbtnAction.TabIndex = 41;
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Location = new System.Drawing.Point(15, 9);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(115, 25);
            this.btnTinhLuong.TabIndex = 29;
            this.btnTinhLuong.Text = "Tính Lương";
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // btnSuaLuong
            // 
            this.btnSuaLuong.Location = new System.Drawing.Point(152, 9);
            this.btnSuaLuong.Name = "btnSuaLuong";
            this.btnSuaLuong.Size = new System.Drawing.Size(112, 25);
            this.btnSuaLuong.TabIndex = 30;
            this.btnSuaLuong.Text = "Sửa Lương";
            this.btnSuaLuong.UseVisualStyleBackColor = true;
            this.btnSuaLuong.Click += new System.EventHandler(this.btnSuaThongTin_Click);
            // 
            // pnbtnSelection
            // 
            this.pnbtnSelection.Controls.Add(this.btnHuy);
            this.pnbtnSelection.Controls.Add(this.btnXacNhan);
            this.pnbtnSelection.Location = new System.Drawing.Point(14, 359);
            this.pnbtnSelection.Name = "pnbtnSelection";
            this.pnbtnSelection.Size = new System.Drawing.Size(279, 39);
            this.pnbtnSelection.TabIndex = 42;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(152, 9);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 25);
            this.btnHuy.TabIndex = 33;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(15, 9);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(115, 25);
            this.btnXacNhan.TabIndex = 32;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(29, 405);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(115, 25);
            this.btnQuayLai.TabIndex = 43;
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
            this.pnTTLB.Location = new System.Drawing.Point(299, 13);
            this.pnTTLB.Name = "pnTTLB";
            this.pnTTLB.Size = new System.Drawing.Size(345, 417);
            this.pnTTLB.TabIndex = 44;
            // 
            // lblTTLB
            // 
            this.lblTTLB.AutoSize = true;
            this.lblTTLB.Location = new System.Drawing.Point(97, 25);
            this.lblTTLB.Name = "lblTTLB";
            this.lblTTLB.Size = new System.Drawing.Size(143, 16);
            this.lblTTLB.TabIndex = 40;
            this.lblTTLB.Text = "Thông Tin Lương Bổng";
            // 
            // txtThuong
            // 
            this.txtThuong.Location = new System.Drawing.Point(123, 195);
            this.txtThuong.Name = "txtThuong";
            this.txtThuong.Size = new System.Drawing.Size(175, 22);
            this.txtThuong.TabIndex = 7;
            // 
            // txtLuongNgay
            // 
            this.txtLuongNgay.Location = new System.Drawing.Point(123, 138);
            this.txtLuongNgay.Name = "txtLuongNgay";
            this.txtLuongNgay.Size = new System.Drawing.Size(175, 22);
            this.txtLuongNgay.TabIndex = 6;
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.Location = new System.Drawing.Point(213, 79);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.Size = new System.Drawing.Size(86, 22);
            this.txtSoNgay.TabIndex = 5;
            // 
            // lblThuong
            // 
            this.lblThuong.AutoSize = true;
            this.lblThuong.Location = new System.Drawing.Point(23, 198);
            this.lblThuong.Name = "lblThuong";
            this.lblThuong.Size = new System.Drawing.Size(53, 16);
            this.lblThuong.TabIndex = 3;
            this.lblThuong.Text = "Thưởng";
            // 
            // lblLuongNgay
            // 
            this.lblLuongNgay.AutoSize = true;
            this.lblLuongNgay.Location = new System.Drawing.Point(23, 142);
            this.lblLuongNgay.Name = "lblLuongNgay";
            this.lblLuongNgay.Size = new System.Drawing.Size(77, 16);
            this.lblLuongNgay.TabIndex = 2;
            this.lblLuongNgay.Text = "Lương ngày";
            // 
            // lblSoNgay
            // 
            this.lblSoNgay.AutoSize = true;
            this.lblSoNgay.Location = new System.Drawing.Point(23, 83);
            this.lblSoNgay.Name = "lblSoNgay";
            this.lblSoNgay.Size = new System.Drawing.Size(151, 16);
            this.lblSoNgay.TabIndex = 1;
            this.lblSoNgay.Text = "Số ngày làm trong tháng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(14, 13);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(278, 22);
            this.txtTimKiem.TabIndex = 45;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // GUIQuanLyLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 441);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.pnTTLB);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.pnbtnSelection);
            this.Controls.Add(this.pnbtnAction);
            this.Controls.Add(this.lvNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUIQuanLyLuong";
            this.Text = "GUIQuanLyLuong";
            this.pnbtnAction.ResumeLayout(false);
            this.pnbtnSelection.ResumeLayout(false);
            this.pnTTLB.ResumeLayout(false);
            this.pnTTLB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvNhanVien;
        private ColumnHeader colMaNhanVien;
        private ColumnHeader colSoNgayLam;
        private Panel pnbtnAction;
        private Button btnTinhLuong;
        private Button btnSuaLuong;
        private Panel pnbtnSelection;
        private Button btnHuy;
        private Button btnXacNhan;
        private Button btnQuayLai;
        private Panel pnTTLB;
        private Label lblTTLB;
        private TextBox txtThuong;
        private TextBox txtLuongNgay;
        private TextBox txtSoNgay;
        private Label lblThuong;
        private Label lblLuongNgay;
        private Label lblSoNgay;
        private TextBox txtTimKiem;
    }
}