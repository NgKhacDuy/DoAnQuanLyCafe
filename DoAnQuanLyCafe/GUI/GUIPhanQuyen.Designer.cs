using System.Windows.Forms;

namespace DoAnQuanLyCafe.GUI
{
    partial class GUIPhanQuyen
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
            this.lvChucNang = new System.Windows.Forms.ListView();
            this.colMaChucNang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenChucNang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lvChucNang
            // 
            this.lvChucNang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaChucNang,
            this.colTenChucNang});
            this.lvChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvChucNang.FullRowSelect = true;
            this.lvChucNang.GridLines = true;
            this.lvChucNang.HideSelection = false;
            this.lvChucNang.Location = new System.Drawing.Point(12, 44);
            this.lvChucNang.MultiSelect = false;
            this.lvChucNang.Name = "lvChucNang";
            this.lvChucNang.Size = new System.Drawing.Size(420, 244);
            this.lvChucNang.TabIndex = 0;
            this.lvChucNang.UseCompatibleStateImageBehavior = false;
            this.lvChucNang.View = System.Windows.Forms.View.Details;
            this.lvChucNang.SelectedIndexChanged += new System.EventHandler(this.lvChucNang_SelectedIndexChanged);
            // 
            // colMaChucNang
            // 
            this.colMaChucNang.Text = "Mã Chức Năng";
            this.colMaChucNang.Width = 155;
            // 
            // colTenChucNang
            // 
            this.colTenChucNang.Text = "Tên Chức Năng";
            this.colTenChucNang.Width = 250;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(521, 249);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(155, 39);
            this.btnXacNhan.TabIndex = 14;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Bảng chức năng";
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb1.Location = new System.Drawing.Point(521, 29);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(184, 29);
            this.cb1.TabIndex = 16;
            this.cb1.Text = "Quản Lý (Admin)";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb2.Location = new System.Drawing.Point(521, 82);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(218, 29);
            this.cb2.TabIndex = 17;
            this.cb2.Text = "Nhân Viên Bán Hàng";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb3.Location = new System.Drawing.Point(521, 139);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(216, 29);
            this.cb3.TabIndex = 18;
            this.cb3.Text = "Nhân Viên Tài Chính";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb4.Location = new System.Drawing.Point(521, 194);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(167, 29);
            this.cb4.TabIndex = 19;
            this.cb4.Text = "Nhân Viên Kho";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // GUIPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 480);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.lvChucNang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUIPhanQuyen";
            this.Text = "GUIPhanQuyen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvChucNang;
        private ColumnHeader colMaChucNang;
        private ColumnHeader colTenChucNang;
        private Button btnXacNhan;
        private Label label1;
        private CheckBox cb1;
        private CheckBox cb2;
        private CheckBox cb3;
        private CheckBox cb4;
    }
}