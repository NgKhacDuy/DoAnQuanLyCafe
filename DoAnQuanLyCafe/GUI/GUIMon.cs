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
    public partial class GUIMon : Form
    {
        DataTable table = new DataTable();
        BUS.BUSMon BUSFood = new BUSMon();
        GUI.Main Mainmain = new Main();
        public GUIMon()
        {
            InitializeComponent();
            loadFood();
            txtName.Focus();
        }
        public void loadFood()
        {
            table.Clear();
            table = BUSFood.getListFood();
            dgvFood.DataSource = table;
            cbbIDDanhMuc.DataSource = BUSFood.getAllNameCategory();
            cbbIDDanhMuc.DisplayMember = "Name";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            /*if (BUSFood.checkDuplicate(txtTenDanhMuc.Text))
                MessageBox.Show("Tên danh mục bị trùng");
            */
            
            BUSFood.insertFood(txtName.Text,int.Parse(txtIDDanhMuc.Text),int.Parse(txtPrice.Text));
            MessageBox.Show("Thêm thành công");
            loadFood();
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFood.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvFood.CurrentRow.Selected = true;
                txtID.Text = dgvFood.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvFood.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtIDDanhMuc.Text = dgvFood.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrice.Text = dgvFood.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                BUSFood.updateFood(int.Parse(txtID.Text),txtName.Text, int.Parse(txtIDDanhMuc.Text), int.Parse(txtPrice.Text));
                MessageBox.Show("Sửa thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadFood();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                BUSFood.deleteFood(int.Parse(txtID.Text));
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadFood();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            dgvFood.DataSource = BUSFood.findByName(txtSearch.Text);
        }

        private void cbbIDDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void cbbIDDanhMuc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtIDDanhMuc.Text = BUSFood.findIDbyName(cbbIDDanhMuc.GetItemText(cbbIDDanhMuc.SelectedItem)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mainmain.loadForm(new GUIDanhMuc());
            new GUIDanhMuc().Show();
            this.Dispose();
        }
    }
}
