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
    public partial class GUIDanhMuc : Form
    {
        DataTable table = new DataTable();
        BUS.BUSDanhMuc BUSDanhMuc = new BUSDanhMuc();
        public GUIDanhMuc()
        {
            InitializeComponent();
            loadCategory();
        }

        

        public void loadCategory()
        {
            table.Clear();
            table = BUSDanhMuc.getListCategory();
            dgvDanhMuc.DataSource = table;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (BUSDanhMuc.checkDuplicate(txtTenDanhMuc.Text))
                MessageBox.Show("Tên danh mục bị trùng");
            else
            {
                BUSDanhMuc.insertCategory(txtTenDanhMuc.Text);
                MessageBox.Show("Thêm thành công");
            }
            
            loadCategory();
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhMuc.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvDanhMuc.CurrentRow.Selected = true;
                txtMaDanhMuc.Text = dgvDanhMuc.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenDanhMuc.Text = dgvDanhMuc.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (BUSDanhMuc.checkDuplicate(txtTenDanhMuc.Text))
                    MessageBox.Show("Tên danh mục bị trùng");
                else
                {
                    BUSDanhMuc.updateCategory(int.Parse(txtMaDanhMuc.Text), txtTenDanhMuc.Text);
                    MessageBox.Show("Sửa thành công");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadCategory();
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            dgvDanhMuc.DataSource = BUSDanhMuc.findByName(txtTimKiem.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            loadCategory();
        }
    }
}
