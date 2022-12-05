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
    public partial class GUIHoaDon : Form
    {
        DataTable table = new DataTable();
        BUS.BUSHoaDon BUSBill = new BUSHoaDon();
        public GUIHoaDon()
        {
            InitializeComponent();
            loadHoaDon();
            loadCTHoaDon();
        }

        public void loadHoaDon()
        {
            table.Clear();
            table = BUSBill.getListHoaDon();
            dgvBill.DataSource = table;
        }

        public void loadCTHoaDon()
        {
            table.Clear();
            table=BUSBill.getListCTHoaDon();
            dataGridView1.DataSource= table;
        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

            dgvBill.DataSource = BUSBill.getHoaDonFromDate(dateFirst_HoaDon.ToString(),dateSecond_HoaDon.ToString());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadHoaDon();
        }
    }
}
