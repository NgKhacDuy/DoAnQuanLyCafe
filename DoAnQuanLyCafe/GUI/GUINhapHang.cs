using DoAnQuanLyCafe.BUS;
using DoAnQuanLyCafe.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyCafe.GUI
{
    public partial class GUINhapHang : Form
    {
        private BLLNhapHang BLLNH = new BLLNhapHang();
        private ArrayList arrNL = new ArrayList();
        private int trangthaiaction = 0;

        public GUINhapHang()
        {
            InitializeComponent();
            LoadListView();
            SetMacDinh();
        }

        private void LoadListView()
        {
            lvNLK.Items.Clear();
            arrNL = BLLNH.getAllNguyenLieu();
            foreach (DTONguyenLieu nl in arrNL)
            {
                string[] row = {
                    nl.getMaNL().ToString(),
                    nl.getTenNL(),
                    nl.getTonKho().ToString(),
                    nl.getDonVi()
                };
                ListViewItem lvi = new ListViewItem(row);
                lvNLK.Items.Add(lvi);
            }
        }

        private void SetMacDinh()
        {
            lvNLK.Enabled = false;
            lvBienLai.Enabled = false;
            pnAction.Enabled = true;
            pnSelection.Enabled = false;
            btnQuayLai.Enabled = true;
            txtSoLuong.Enabled = false;
            txtDonGia.Enabled = false;
            pnChildAction.Enabled = false;
            ResetAllText();
        }

        private void ResetAllText()
        {
            txtTimKiem.Text = "";
            cbbTimKiem.SelectedItem = null;
            lvBienLai.Items.Clear();
            txtMaNL.Text = "";
            txtTenNL.Text = "";
            txtDonVi.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
        }

        private bool CheckActionThem()
        {
            if (txtMaNL.Text == "")
            {
                MessageBox.Show("BẠN CHƯA CHỌN SẢN PHẨM NÀO CẦN MUA!");
                return false;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("BẠN CHƯA NHẬP SỐ LƯỢNG SẢN PHẨM CẦN MUA!");
                txtSoLuong.Focus();
                return false;
            }
            int soluong = -1;
            try
            {
                soluong = Convert.ToInt32(txtSoLuong.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            if (soluong <= 0)
            {
                MessageBox.Show("SỐ LƯỢNG PHẢI LÀ 1 SỐ NGUYÊN VÀ LỚN HƠN 0!");
                txtSoLuong.Text = "1";
                txtSoLuong.Focus();
                return false;
            }
            if (txtDonGia.Text == "")
            {
                MessageBox.Show("BẠN CHƯA NHẬP ĐƠN GIÁ SẢN PHẨN CẦN MUA!");
                txtDonGia.Focus();
                return false;
            }
            decimal dongia = -1;
            try
            {
                dongia = Convert.ToDecimal(txtDonGia.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            if (dongia <= 0)
            {
                MessageBox.Show("ĐƠN GIÁ PHẢI LÀ 1 SỐ NGUYÊN VÀ LỚN HƠN 0!");
                txtDonGia.Text = "1";
                txtDonGia.Focus();
                return false;
            }
            return true;
        }

        private bool CheckActionSua()
        {
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("BẠN CHƯA NHẬP SỐ LƯỢNG SẢN PHẨM CẦN MUA!");
                txtSoLuong.Focus();
                return false;
            }
            int soluong = -1;
            try
            {
                soluong = Convert.ToInt32(txtSoLuong.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            if (soluong <= -1)
            {
                MessageBox.Show("SỐ LƯỢNG PHẢI LÀ 1 SỐ NGUYÊN VÀ LỚN HƠN 0!");
                txtSoLuong.Text = "1";
                txtSoLuong.Focus();
                return false;
            }
            if (txtDonGia.Text == "")
            {
                MessageBox.Show("BẠN CHƯA NHẬP ĐƠN GIÁ SẢN PHẨN CẦN MUA!");
                txtDonGia.Focus();
                return false;
            }
            decimal dongia = -1;
            try
            {
                dongia = Convert.ToDecimal(txtDonGia.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            if (dongia <= 0)
            {
                MessageBox.Show("ĐƠN GIÁ PHẢI LÀ 1 SỐ NGUYÊN VÀ LỚN HƠN 0!");
                txtDonGia.Text = "1";
                txtDonGia.Focus();
                return false;
            }
            return true;
        }

        private void SetActionMuaHang()
        {
            lvNLK.Enabled = true;
            lvBienLai.Enabled = true;
            pnAction.Enabled = false;
            pnSelection.Enabled = true;
            btnQuayLai.Enabled = false;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;
            pnChildAction.Enabled = true;

            txtSoLuong.Focus();

            txtSoLuong.TabIndex = 0;
            txtDonGia.TabIndex = 1;
            btnThem.TabIndex = 2;
            btnSua.TabIndex = 3;
            btnXoa.TabIndex = 4;
            btnXacNhan.TabIndex = 5;
            btnHuy.TabIndex = 6;

            trangthaiaction = 2;
        }

        private bool CheckActionMuaHang()
        {
            if(txtTongTien.Text == "0")
            {
                MessageBox.Show("BẠN CHƯA MUA HÀNG, HÃY CHỌN SẢN PHẨM ĐỂ MUA!");
                return false;
            }
            bool check = true;
            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc mua đơn hàng này chưa, tổng tiền là: " + txtTongTien.Text,
                "Confirm Dialog",
                MessageBoxButtons.YesNo
            );
            if (dialogResult == DialogResult.No)
            {
                check = false;
            }
            return check;
        }

        private void SetTongTien()
        {
            decimal tongtien = 0;
            for(int i = 0; i<lvBienLai.Items.Count; i++)
            {
                decimal tien = Convert.ToDecimal(lvBienLai.Items[i].SubItems[5].Text);
                tongtien += tien;
            }
            txtTongTien.Text = tongtien.ToString();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            lvNLK.Items.Clear();
            foreach (DTONguyenLieu nl in arrNL)
            {
                if (nl.getMaNL().ToString().Contains(txtTimKiem.Text))
                {
                    string[] row = {
                        nl.getMaNL().ToString(),
                        nl.getTenNL(),
                        nl.getTonKho().ToString(),
                        nl.getDonVi()
                    };
                    ListViewItem lvi = new ListViewItem(row);
                    lvNLK.Items.Add(lvi);
                }
            }
        }

        private void SwapListViewItems(int i, int j)
        {
            string manl = lvNLK.Items[i].SubItems[0].Text;
            string tennl = lvNLK.Items[i].SubItems[1].Text;
            string soluong = lvNLK.Items[i].SubItems[2].Text;
            string donvi = lvNLK.Items[i].SubItems[3].Text;

            lvNLK.Items[i].SubItems[0].Text = lvNLK.Items[j].SubItems[0].Text;
            lvNLK.Items[i].SubItems[1].Text = lvNLK.Items[j].SubItems[1].Text;
            lvNLK.Items[i].SubItems[2].Text = lvNLK.Items[j].SubItems[2].Text;
            lvNLK.Items[i].SubItems[3].Text = lvNLK.Items[j].SubItems[3].Text;

            lvNLK.Items[j].SubItems[0].Text = manl;
            lvNLK.Items[j].SubItems[1].Text = tennl;
            lvNLK.Items[j].SubItems[2].Text = soluong;
            lvNLK.Items[j].SubItems[3].Text = donvi;
        }

        private void cbbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbTimKiem.SelectedIndex == 0)
            {
                for(int i = 0; i<lvNLK.Items.Count-1; i++)
                {
                    for (int j = 0; j < lvNLK.Items.Count; j++)
                    {
                        int tonkho1 = Convert.ToInt32(lvNLK.Items[i].SubItems[2].Text);
                        int tonkho2 = Convert.ToInt32(lvNLK.Items[j].SubItems[2].Text);
                        if(tonkho1 > tonkho2)
                        {
                            SwapListViewItems(i, j);
                        }
                    }
                }
            }
            if (cbbTimKiem.SelectedIndex == 1)
            {
                for (int i = 0; i < lvNLK.Items.Count - 1; i++)
                {
                    for (int j = 0; j < lvNLK.Items.Count; j++)
                    {
                        int tonkho1 = Convert.ToInt32(lvNLK.Items[i].SubItems[2].Text);
                        int tonkho2 = Convert.ToInt32(lvNLK.Items[j].SubItems[2].Text);
                        if (tonkho1 < tonkho2)
                        {
                            SwapListViewItems(i, j);
                        }
                    }
                }
            }
            if (cbbTimKiem.SelectedIndex == 2)
            {
                for (int i = 0; i < lvNLK.Items.Count - 1; i++)
                {
                    for (int j = 0; j < lvNLK.Items.Count; j++)
                    {
                        int manl1 = Convert.ToInt32(lvNLK.Items[i].SubItems[0].Text);
                        int manl2 = Convert.ToInt32(lvNLK.Items[j].SubItems[0].Text);
                        if (manl1 > manl2)
                        {
                            SwapListViewItems(i, j);
                        }
                    }
                }
            }
        }

        private void lvNLK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNLK.SelectedItems.Count > 0)
            {
                txtMaNL.Text = lvNLK.SelectedItems[0].SubItems[0].Text;
                txtTenNL.Text = lvNLK.SelectedItems[0].SubItems[1].Text;
                txtDonVi.Text = lvNLK.SelectedItems[0].SubItems[3].Text;
                txtSoLuong.Text = "";
                txtDonGia.Text = "";
            }
        }

        private void lvBienLai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBienLai.SelectedItems.Count > 0)
            {
                txtMaNL.Text = lvBienLai.SelectedItems[0].SubItems[0].Text;
                txtTenNL.Text = lvBienLai.SelectedItems[0].SubItems[1].Text;
                txtSoLuong.Text = lvBienLai.SelectedItems[0].SubItems[2].Text;
                txtDonVi.Text = lvBienLai.SelectedItems[0].SubItems[3].Text;
                txtDonGia.Text = lvBienLai.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void btnQLNL_Click(object sender, EventArgs e)
        {
            // KICH HOAT GUI KHO CUA HOA
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            SetActionMuaHang();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(trangthaiaction == 2)
            {
                if(CheckActionMuaHang())
                {
                    DTOBienLai bl = new DTOBienLai(0, Convert.ToDecimal(txtTongTien.Text), DateTime.Now);
                    ArrayList arrctbl = new ArrayList();
                    ArrayList arrnl = new ArrayList();
                    for (int i=0; i<lvBienLai.Items.Count; i++)
                    {
                        DTOChiTietBienLai ctbl = new DTOChiTietBienLai(0, Convert.ToInt32(lvBienLai.Items[i].SubItems[0].Text), Convert.ToInt32(lvBienLai.Items[i].SubItems[2].Text));
                        arrctbl.Add(ctbl);
                        DTONguyenLieu nl = new DTONguyenLieu(Convert.ToInt32(lvBienLai.Items[i].SubItems[0].Text), "", Convert.ToInt32(lvBienLai.Items[i].SubItems[2].Text), "");
                        arrnl.Add(nl);
                    }
                    if(BLLNH.NhapHang(bl, arrctbl, arrnl))
                    {
                        MessageBox.Show("MUA HÀNG THÀNH CÔNG!");
                        SetMacDinh();
                        LoadListView();
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetMacDinh();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            //BACK TO GUI
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckActionThem())
            {
                bool hasitem = false;
                for (int i = 0; i < lvBienLai.Items.Count; i++)
                {
                    if (lvBienLai.Items[i].SubItems[0].Text == txtMaNL.Text)
                    {
                        lvBienLai.Items[i].SubItems[2].Text = (Convert.ToInt32(txtSoLuong.Text) + Convert.ToInt32(lvBienLai.Items[i].SubItems[2].Text)).ToString();
                        lvBienLai.Items[i].SubItems[5].Text = (Convert.ToInt32(lvBienLai.Items[i].SubItems[2].Text) * Convert.ToDecimal(txtDonGia.Text)).ToString();
                        SetTongTien();
                        hasitem = true;
                    }
                }
                if(!hasitem)
                {
                    decimal tongtien = Convert.ToInt32(txtSoLuong.Text) * Convert.ToDecimal(txtDonGia.Text);
                    string[] row = {
                        txtMaNL.Text,
                        txtTenNL.Text,
                        txtSoLuong.Text,
                        txtDonVi.Text,
                        txtDonGia.Text,
                        tongtien.ToString()
                    };
                    ListViewItem lvi = new ListViewItem(row);
                    lvBienLai.Items.Add(lvi);
                }
                SetTongTien();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvBienLai.SelectedItems.Count > 0)
            {
                if (CheckActionSua())
                {
                    lvBienLai.SelectedItems[0].SubItems[2].Text = txtSoLuong.Text;
                    lvBienLai.SelectedItems[0].SubItems[4].Text = txtDonGia.Text;
                    decimal tongtien = Convert.ToInt32(txtSoLuong.Text) * Convert.ToDecimal(txtDonGia.Text);
                    lvBienLai.SelectedItems[0].SubItems[5].Text = tongtien.ToString();
                    SetTongTien();
                }
            }
            else
            {
                MessageBox.Show("BẠN CHƯA CHỌN DÒNG BIÊN LAI CẦN SỬA");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lvBienLai.SelectedItems.Count > 0)
            {
                lvBienLai.Items.RemoveAt(lvBienLai.SelectedIndices[0]);
                txtSoLuong.Text = "";
                txtDonGia.Text = "";
                SetTongTien();
            }
            else
            {
                MessageBox.Show("BẠN CHƯA CHỌN DÒNG BIÊN LAI CẦN XÓA");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = DateTime.Now.ToString();
            MessageBox.Show(s);
        }
    }
}
