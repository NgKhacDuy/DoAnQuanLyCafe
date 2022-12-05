using DoAnQuanLyCafe.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyCafe.GUI
{
    public partial class GUIBan : Form
    {
        BUSBan bus = new BUSBan();
        public GUIBan()
        {
            InitializeComponent();
            loadBan();
        }

        public void loadBan()
        {
            dataGridView1.DataSource = bus.getTableDataTable();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bus.insertTable(txtTenBan.Text);
            MessageBox.Show("Thêm thành công");
            loadBan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bus.updateTable(int.Parse(txtMaBan.Text), txtTenBan.Text);
            MessageBox.Show("Sửa thành công");
            loadBan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bus.deleteTable(int.Parse(txtMaBan.Text));
            MessageBox.Show("Xóa thành công");
            loadBan();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value !=null){
                dataGridView1.CurrentCell.Selected = true;
                txtMaBan.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenBan.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1.DataSource=bus.findByName(txtSearch.Text);
        }
    }
}
