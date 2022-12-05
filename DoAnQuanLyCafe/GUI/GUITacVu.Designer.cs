using System.Windows.Forms;

namespace DoAnQuanLyCafe.GUI
{
    partial class GUITacVu
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
            this.panel_TacVu = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.numericPercentSale = new System.Windows.Forms.NumericUpDown();
            this.btnApplySale = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btn_Voucher = new System.Windows.Forms.Button();
            this.btn_Themmon = new System.Windows.Forms.Button();
            this.numericSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbbFood = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel_TacVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPercentSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_TacVu
            // 
            this.panel_TacVu.BackColor = System.Drawing.Color.RosyBrown;
            this.panel_TacVu.Controls.Add(this.label4);
            this.panel_TacVu.Controls.Add(this.numericPercentSale);
            this.panel_TacVu.Controls.Add(this.btnApplySale);
            this.panel_TacVu.Controls.Add(this.label3);
            this.panel_TacVu.Controls.Add(this.listView1);
            this.panel_TacVu.Controls.Add(this.txtPrice);
            this.panel_TacVu.Controls.Add(this.label2);
            this.panel_TacVu.Controls.Add(this.label1);
            this.panel_TacVu.Controls.Add(this.btn_ThanhToan);
            this.panel_TacVu.Controls.Add(this.txtTotal);
            this.panel_TacVu.Controls.Add(this.btn_Voucher);
            this.panel_TacVu.Controls.Add(this.btn_Themmon);
            this.panel_TacVu.Controls.Add(this.numericSoLuong);
            this.panel_TacVu.Controls.Add(this.cbbFood);
            this.panel_TacVu.Controls.Add(this.comboBox3);
            this.panel_TacVu.Controls.Add(this.cbbCategory);
            this.panel_TacVu.Controls.Add(this.flowLayoutPanel1);
            this.panel_TacVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_TacVu.Location = new System.Drawing.Point(0, 0);
            this.panel_TacVu.Name = "panel_TacVu";
            this.panel_TacVu.Size = new System.Drawing.Size(1711, 996);
            this.panel_TacVu.TabIndex = 2;
            this.panel_TacVu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_TacVu_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1000, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 54);
            this.label4.TabIndex = 17;
            this.label4.Text = "TÁC VỤ";
            // 
            // numericPercentSale
            // 
            this.numericPercentSale.BackColor = System.Drawing.Color.Bisque;
            this.numericPercentSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPercentSale.Location = new System.Drawing.Point(870, 778);
            this.numericPercentSale.Name = "numericPercentSale";
            this.numericPercentSale.Size = new System.Drawing.Size(99, 38);
            this.numericPercentSale.TabIndex = 7;
            this.numericPercentSale.ValueChanged += new System.EventHandler(this.numericPercentSale_ValueChanged);
            // 
            // btnApplySale
            // 
            this.btnApplySale.BackColor = System.Drawing.Color.Bisque;
            this.btnApplySale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplySale.Location = new System.Drawing.Point(715, 849);
            this.btnApplySale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApplySale.Name = "btnApplySale";
            this.btnApplySale.Size = new System.Drawing.Size(209, 41);
            this.btnApplySale.TabIndex = 15;
            this.btnApplySale.Text = "ÁP DỤNG % GIẢM GIÁ";
            this.btnApplySale.UseVisualStyleBackColor = false;
            this.btnApplySale.Click += new System.EventHandler(this.btnApplySale_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Bisque;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(987, 780);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "%";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(715, 413);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(730, 260);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món ăn                     ";
            this.columnHeader1.Width = 272;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá                          ";
            this.columnHeader3.Width = 175;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 186;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(725, 253);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(247, 30);
            this.txtPrice.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(722, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Giá Sản Phẩm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(719, 780);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Giảm giá";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.Bisque;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.Location = new System.Drawing.Point(1244, 849);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(218, 41);
            this.btn_ThanhToan.TabIndex = 9;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Bisque;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(955, 851);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(264, 38);
            this.txtTotal.TabIndex = 8;
            // 
            // btn_Voucher
            // 
            this.btn_Voucher.BackColor = System.Drawing.Color.Bisque;
            this.btn_Voucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voucher.Location = new System.Drawing.Point(1256, 193);
            this.btn_Voucher.Name = "btn_Voucher";
            this.btn_Voucher.Size = new System.Drawing.Size(183, 69);
            this.btn_Voucher.TabIndex = 5;
            this.btn_Voucher.Text = "Voucher";
            this.btn_Voucher.UseVisualStyleBackColor = false;
            this.btn_Voucher.Click += new System.EventHandler(this.btn_Voucher_Click);
            // 
            // btn_Themmon
            // 
            this.btn_Themmon.BackColor = System.Drawing.Color.Bisque;
            this.btn_Themmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Themmon.Location = new System.Drawing.Point(1081, 193);
            this.btn_Themmon.Name = "btn_Themmon";
            this.btn_Themmon.Size = new System.Drawing.Size(125, 69);
            this.btn_Themmon.TabIndex = 4;
            this.btn_Themmon.Text = "Thêm món";
            this.btn_Themmon.UseVisualStyleBackColor = false;
            this.btn_Themmon.Click += new System.EventHandler(this.btn_Themmon_Click);
            // 
            // numericSoLuong
            // 
            this.numericSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSoLuong.Location = new System.Drawing.Point(1081, 298);
            this.numericSoLuong.Name = "numericSoLuong";
            this.numericSoLuong.Size = new System.Drawing.Size(126, 30);
            this.numericSoLuong.TabIndex = 3;
            this.numericSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbbFood
            // 
            this.cbbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFood.FormattingEnabled = true;
            this.cbbFood.Location = new System.Drawing.Point(725, 298);
            this.cbbFood.Name = "cbbFood";
            this.cbbFood.Size = new System.Drawing.Size(247, 33);
            this.cbbFood.TabIndex = 2;
            this.cbbFood.Text = "--Chọn món--";
            this.cbbFood.SelectedIndexChanged += new System.EventHandler(this.cbbFood_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(1256, 296);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(183, 33);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.Text = "--Chọn bàn--";
            // 
            // cbbCategory
            // 
            this.cbbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(725, 163);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(247, 33);
            this.cbbCategory.TabIndex = 1;
            this.cbbCategory.Text = "--Chọn danh mục--";
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(464, 996);
            this.flowLayoutPanel1.TabIndex = 16;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // GUITacVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1711, 996);
            this.Controls.Add(this.panel_TacVu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUITacVu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Cafe";
            this.Load += new System.EventHandler(this.GUITacVu_Load);
            this.panel_TacVu.ResumeLayout(false);
            this.panel_TacVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPercentSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel_TacVu;
        private ComboBox cbbCategory;
        private Label label2;
        private Label label1;
        private Button btn_ThanhToan;
        private TextBox txtTotal;
        private NumericUpDown numericPercentSale;
        private Button btn_Voucher;
        private Button btn_Themmon;
        private NumericUpDown numericSoLuong;
        private ComboBox cbbFood;
        private ComboBox comboBox3;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private TextBox txtPrice;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label3;
        private SaveFileDialog saveFileDialog1;
        private Button btnApplySale;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label4;
    }
}