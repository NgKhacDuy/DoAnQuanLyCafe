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
    public partial class GUIVoucherInput : Form
    {
        BUS.BUSVoucher BUSVoucher = new BUS.BUSVoucher();
        float percent = 0;
        public GUIVoucherInput()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            percent = 0;
            if (BUSVoucher.checkVoucher(int.Parse(txtVoucherInput.Text)))
            {
                MessageBox.Show("Voucher tồn tại\nVoucher giảm "+ BUSVoucher.getPercent(int.Parse(txtVoucherInput.Text))+ "%\nĐã áp dụng Voucher");
                percent = BUSVoucher.getPercent(int.Parse(txtVoucherInput.Text));
            }
            else
                MessageBox.Show("Voucher không tồn tại");
            this.Dispose();
        }

        public float getPercent()
        {
            return percent;
        }
    }
}
