using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLyCafe.DTO;
using DoAnQuanLyCafe.BUS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DoAnQuanLyCafe.GUI
{
    public partial class GUIKiemKho : Form
    {
        private DataTable dt = new DataTable();
        private ArrayList arrKho = new ArrayList();
        private BUS.BLLKiemKho BLL = new BUS.BLLKiemKho();
        public GUIKiemKho()
        {
            InitializeComponent();
            loadListView();
        }
        private void lsvNguyenLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNguyenLieu.SelectedItems.Count > 0)
            {
                tbxMaNL.Text = lsvNguyenLieu.SelectedItems[0].SubItems[0].Text;
                tbxTenNL.Text = lsvNguyenLieu.SelectedItems[0].SubItems[1].Text;
                tbxSoLuong.Text = lsvNguyenLieu.SelectedItems[0].SubItems[2].Text;
                tbxDonVi.Text = lsvNguyenLieu.SelectedItems[0].SubItems[3].Text;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            //Check hợp lệ
            if (tbxMaNL.Text == "" || tbxTenNL.Text == "" || tbxDonVi.Text == "")
            {
                MessageBox.Show("Dữ liệu không được bỏ trống !");
            }
            else if (CheckHopLe())
            {
                MessageBox.Show("Mã nguyên liệu không được trùng !");
            }
            else
            {
                try
                {
                    //Insert Database
                    DTO.DTOKiemKho DTO = new DTO.DTOKiemKho();
                    BUS.BLLKiemKho BLL = new BUS.BLLKiemKho();
                    if (int.Parse(tbxMaNL.Text) > 0)
                    {
                        DTO.setMaNL(int.Parse(tbxMaNL.Text));
                        DTO.setTenNL(tbxTenNL.Text);
                        DTO.setDonVi(tbxDonVi.Text);
                        MessageBox.Show(BLL.insertData(DTO));
                        loadListView();
                        Reset();
                    }
                    else MessageBox.Show("Mã nguyên liệu không được âm !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            //Check hợp lệ
            if (tbxMaNL.Text == "" || tbxTenNL.Text == "" || tbxDonVi.Text == "")
            {
                MessageBox.Show("Dữ liệu không được bỏ trống !");
            }
            else
            {
                try
                {
                    //Changes Database
                    DTO.DTOKiemKho DTO = new DTO.DTOKiemKho();
                    BUS.BLLKiemKho BLL = new BUS.BLLKiemKho();
                    int TonKho;
                    if (tbxSoLuong.Text == "")
                    {
                        TonKho = int.Parse(lsvNguyenLieu.SelectedItems[0].SubItems[2].Text);
                    }
                    else if (int.Parse(tbxSoLuong.Text) >= 0)
                    {
                        TonKho = int.Parse(tbxSoLuong.Text);
                    }
                    else
                    {
                        MessageBox.Show("Số lượng không được âm ! Trả về mặc định ");
                        TonKho = int.Parse(lsvNguyenLieu.SelectedItems[0].SubItems[2].Text);
                    }
                    if (int.Parse(tbxMaNL.Text) > 0 || (tbxMaNL.Text == lsvNguyenLieu.SelectedItems[0].SubItems[0].Text))
                    {
                        DTO.setMaNL(int.Parse(tbxMaNL.Text));
                        DTO.setTenNL(tbxTenNL.Text);
                        DTO.setDonVi(tbxDonVi.Text);
                        DTO.setTonKho(TonKho);
                        MessageBox.Show(BLL.updateData(DTO));
                        Reset();
                        loadListView();
                    }
                    else MessageBox.Show("Mã nguyên liệu không hợp lệ!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tbxMaNL.Text == "" || tbxTenNL.Text == "" || tbxDonVi.Text == "")
            {
                MessageBox.Show("Dữ liệu không được bỏ trống !");
            }
            else
            {
                try
                {
                    //Delete Data
                    DTO.DTOKiemKho DTO = new DTO.DTOKiemKho();

                    if (int.Parse(tbxMaNL.Text) > 0)
                    {
                        DTO.setMaNL(int.Parse(tbxMaNL.Text));
                        MessageBox.Show(BLL.deleteData(DTO));
                        Reset();
                        loadListView();
                    }
                    else MessageBox.Show("Mã nguyên liệu không hợp lệ!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            loadListView();
            Reset();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //Check hợp lệ
            try
            {
                //Changes Database
                DTO.DTOKiemKho DTO = new DTO.DTOKiemKho();
                BUS.BLLKiemKho BLL = new BUS.BLLKiemKho();
                int TonKho;
                if (tbxSoLuong.Text == "")
                {
                    TonKho = int.Parse(lsvNguyenLieu.SelectedItems[0].SubItems[2].Text);
                }
                else if (int.Parse(tbxSoLuong.Text) >= 0)
                {
                    TonKho = int.Parse(tbxSoLuong.Text);
                }
                else
                {
                    MessageBox.Show("Số lượng không được âm !");
                    TonKho = int.Parse(lsvNguyenLieu.SelectedItems[0].SubItems[2].Text);
                }
                if (int.Parse(tbxMaNL.Text) > 0 || (tbxMaNL.Text == lsvNguyenLieu.SelectedItems[0].SubItems[0].Text))
                {
                    DTO.setMaNL(int.Parse(tbxMaNL.Text));
                    DTO.setTonKho(TonKho);
                    MessageBox.Show(BLL.updateTonKho(DTO));
                    Reset();
                    loadListView();
                }
                else MessageBox.Show("Mã nguyên liệu không hợp lệ!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public bool CheckHopLe()
        {
            foreach (ListViewItem lvi in lsvNguyenLieu.Items)
                if (lvi.SubItems[0].Text == tbxMaNL.Text)
                    return true;
            return false;
        }

        public void Reset()
        {
            tbxMaNL.Text = "";
            tbxTenNL.Text = "";
            tbxSoLuong.Text = "";
            tbxDonVi.Text = "";
        }
        public void loadListView()
        {

            lsvNguyenLieu.Items.Clear();
            arrKho = BLL.getAllNguyenLieu();
            dt = BLL.getListViewTable();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lsvNguyenLieu.Items.Add(item);
            }
        }

        private void tbxTimKiem_TextChanged(object sender, EventArgs e)
        {
            lsvNguyenLieu.Items.Clear();
            foreach (DTO.DTOKiemKho kho in arrKho)
            {
                string find = kho.getTenNL();
                if (kho.getTenNL().ToLower().Contains(tbxTimKiem.Text))
                {
                    string[] row = {
                            kho.getMaNL().ToString(),
                            kho.getTenNL(),
                            kho.getTonKho().ToString(),
                            kho.getDonVi().ToString()
                        };
                    ListViewItem lvi = new ListViewItem(row);
                    lsvNguyenLieu.Items.Add(lvi);
                }
            }
        }
    }
}
