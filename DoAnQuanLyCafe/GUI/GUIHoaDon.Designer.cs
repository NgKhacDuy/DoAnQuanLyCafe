using System.Windows.Forms;

namespace DoAnQuanLyCafe.GUI
{
    partial class GUIHoaDon
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
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.btnXem_HoaDon = new System.Windows.Forms.Button();
            this.dateFirst_HoaDon = new System.Windows.Forms.DateTimePicker();
            this.dateSecond_HoaDon = new System.Windows.Forms.DateTimePicker();
            this.btnReset_HoaDon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset_CT_HoaDon = new System.Windows.Forms.Button();
            this.btnXem_CT_HoaDon = new System.Windows.Forms.Button();
            this.dateSecond_CT_HoaDon = new System.Windows.Forms.DateTimePicker();
            this.dateFirst_CT_HoaDon = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AllowUserToResizeColumns = false;
            this.dgvBill.AllowUserToResizeRows = false;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBill.Location = new System.Drawing.Point(3, 731);
            this.dgvBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 29;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(849, 262);
            this.dgvBill.TabIndex = 0;
            this.dgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellClick);
            // 
            // btnXem_HoaDon
            // 
            this.btnXem_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem_HoaDon.Location = new System.Drawing.Point(354, 387);
            this.btnXem_HoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXem_HoaDon.Name = "btnXem_HoaDon";
            this.btnXem_HoaDon.Size = new System.Drawing.Size(105, 50);
            this.btnXem_HoaDon.TabIndex = 1;
            this.btnXem_HoaDon.Text = "Xem";
            this.btnXem_HoaDon.UseVisualStyleBackColor = true;
            this.btnXem_HoaDon.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dateFirst_HoaDon
            // 
            this.dateFirst_HoaDon.CustomFormat = "yyyy/MM/dd";
            this.dateFirst_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFirst_HoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFirst_HoaDon.Location = new System.Drawing.Point(12, 399);
            this.dateFirst_HoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateFirst_HoaDon.Name = "dateFirst_HoaDon";
            this.dateFirst_HoaDon.Size = new System.Drawing.Size(250, 34);
            this.dateFirst_HoaDon.TabIndex = 2;
            // 
            // dateSecond_HoaDon
            // 
            this.dateSecond_HoaDon.CustomFormat = "yyyy/MM/dd";
            this.dateSecond_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSecond_HoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateSecond_HoaDon.Location = new System.Drawing.Point(530, 399);
            this.dateSecond_HoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateSecond_HoaDon.Name = "dateSecond_HoaDon";
            this.dateSecond_HoaDon.Size = new System.Drawing.Size(250, 34);
            this.dateSecond_HoaDon.TabIndex = 3;
            // 
            // btnReset_HoaDon
            // 
            this.btnReset_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset_HoaDon.Location = new System.Drawing.Point(354, 461);
            this.btnReset_HoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset_HoaDon.Name = "btnReset_HoaDon";
            this.btnReset_HoaDon.Size = new System.Drawing.Size(105, 50);
            this.btnReset_HoaDon.TabIndex = 4;
            this.btnReset_HoaDon.Text = "Reset";
            this.btnReset_HoaDon.UseVisualStyleBackColor = true;
            this.btnReset_HoaDon.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBill);
            this.groupBox1.Controls.Add(this.btnReset_HoaDon);
            this.groupBox1.Controls.Add(this.btnXem_HoaDon);
            this.groupBox1.Controls.Add(this.dateSecond_HoaDon);
            this.groupBox1.Controls.Add(this.dateFirst_HoaDon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 996);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnReset_CT_HoaDon);
            this.groupBox2.Controls.Add(this.btnXem_CT_HoaDon);
            this.groupBox2.Controls.Add(this.dateSecond_CT_HoaDon);
            this.groupBox2.Controls.Add(this.dateFirst_CT_HoaDon);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(861, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(850, 996);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHD";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TongTien";
            this.Column2.HeaderText = "Tổng tiền";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayGio";
            this.Column3.HeaderText = "Ngày";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaBan";
            this.Column4.HeaderText = "Mã bàn";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // btnReset_CT_HoaDon
            // 
            this.btnReset_CT_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset_CT_HoaDon.Location = new System.Drawing.Point(377, 467);
            this.btnReset_CT_HoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset_CT_HoaDon.Name = "btnReset_CT_HoaDon";
            this.btnReset_CT_HoaDon.Size = new System.Drawing.Size(105, 50);
            this.btnReset_CT_HoaDon.TabIndex = 8;
            this.btnReset_CT_HoaDon.Text = "Reset";
            this.btnReset_CT_HoaDon.UseVisualStyleBackColor = true;
            // 
            // btnXem_CT_HoaDon
            // 
            this.btnXem_CT_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem_CT_HoaDon.Location = new System.Drawing.Point(377, 393);
            this.btnXem_CT_HoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXem_CT_HoaDon.Name = "btnXem_CT_HoaDon";
            this.btnXem_CT_HoaDon.Size = new System.Drawing.Size(105, 50);
            this.btnXem_CT_HoaDon.TabIndex = 5;
            this.btnXem_CT_HoaDon.Text = "Xem";
            this.btnXem_CT_HoaDon.UseVisualStyleBackColor = true;
            // 
            // dateSecond_CT_HoaDon
            // 
            this.dateSecond_CT_HoaDon.CustomFormat = "yyyy/MM/dd";
            this.dateSecond_CT_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSecond_CT_HoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateSecond_CT_HoaDon.Location = new System.Drawing.Point(553, 405);
            this.dateSecond_CT_HoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateSecond_CT_HoaDon.Name = "dateSecond_CT_HoaDon";
            this.dateSecond_CT_HoaDon.Size = new System.Drawing.Size(250, 34);
            this.dateSecond_CT_HoaDon.TabIndex = 7;
            // 
            // dateFirst_CT_HoaDon
            // 
            this.dateFirst_CT_HoaDon.CustomFormat = "yyyy/MM/dd";
            this.dateFirst_CT_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFirst_CT_HoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFirst_CT_HoaDon.Location = new System.Drawing.Point(35, 405);
            this.dateFirst_CT_HoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateFirst_CT_HoaDon.Name = "dateFirst_CT_HoaDon";
            this.dateFirst_CT_HoaDon.Size = new System.Drawing.Size(250, 34);
            this.dateFirst_CT_HoaDon.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 731);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(844, 262);
            this.dataGridView1.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHD";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã hóa đơn";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TongTien";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tổng tiền";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NgayGio";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaBan";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã bàn";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // GUIHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1711, 996);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GUIHoaDon";
            this.Text = "GUIBill";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvBill;
        private Button btnXem_HoaDon;
        private DateTimePicker dateFirst_HoaDon;
        private DateTimePicker dateSecond_HoaDon;
        private Button btnReset_HoaDon;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnReset_CT_HoaDon;
        private Button btnXem_CT_HoaDon;
        private DateTimePicker dateSecond_CT_HoaDon;
        private DateTimePicker dateFirst_CT_HoaDon;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}