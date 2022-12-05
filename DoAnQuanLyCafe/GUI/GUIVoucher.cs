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
    public partial class GUIVoucher : Form
    {
        DataTable table = new DataTable();
        BUS.BUSVoucher BUSVoucher = new BUS.BUSVoucher();
        public GUIVoucher()
        {
            InitializeComponent();
            loadList();
        }

        public void loadList()
        {
            table.Clear();
            table = BUSVoucher.getListVoucher();
            dataGridView1.DataSource = table;

        }

        private void GUIVoucher_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                dataGridView1.CurrentRow.Selected=true;
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                dtpDateStart.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpDateEnd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                numPercent.Value = decimal.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                txtTenVoucher.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                BUSVoucher.insertVoucher(int.Parse(txtID.Text), dtpDateStart.Text, dtpDateEnd.Text,(float)numPercent.Value, txtTenVoucher.Text);
                MessageBox.Show("Thêm thành công");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadList();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1.DataSource = BUSVoucher.searchVoucherFromName(txtSearchName.Text);
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUSVoucher.searchVoucherFromDate(dtpTimKiemStart.Text,dtpTimKiemEnd.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadList();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                BUSVoucher.updateVoucher(int.Parse(txtID.Text), dtpDateStart.Text, dtpDateEnd.Text, (float)numPercent.Value, txtTenVoucher.Text);
                MessageBox.Show("Sửa thành công");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                BUSVoucher.deleteVoucher(int.Parse(txtID.Text));
                MessageBox.Show("Xóa thành công");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadList();
        }
    }
}
