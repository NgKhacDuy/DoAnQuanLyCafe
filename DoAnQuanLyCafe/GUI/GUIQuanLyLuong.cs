using DoAnQuanLyCafe.BUS;
using DoAnQuanLyCafe.DTO;
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

namespace DoAnQuanLyCafe.GUI
{
    public partial class GUIQuanLyLuong : Form
    {
        private BLLQuanLyLuong BLLQLL = new BLLQuanLyLuong();
        private ArrayList arrNV = new ArrayList();
        private int manhanvien = 0;
        private int trangthaiaction = 0;

        public GUIQuanLyLuong()
        {
            InitializeComponent();
            SetMacDinh();
            LoadListView();
        }

        private void LoadListView()
        {
            lvNhanVien.Items.Clear();
            arrNV = BLLQLL.getALlNhanVien();
            foreach (DTONhanVien nv in arrNV)
            {
                string[] row = {
                    nv.getManhanvien().ToString(),
                    nv.getSongaylam().ToString()
                };
                ListViewItem lvi = new ListViewItem(row);
                lvNhanVien.Items.Add(lvi);
            }
        }

        private void SetMacDinh()
        {
            txtTimKiem.Enabled = true;
            lvNhanVien.Enabled = true;
            pnbtnAction.Enabled = true;
            pnbtnSelection.Enabled = false;
            btnQuayLai.Enabled = true;
            pnTTLB.Enabled = false;
        }

        private bool CheckTTLB()
        {
            if (txtLuongNgay.Text.Trim() == "")
            {
                MessageBox.Show("LƯƠNG CƠ BẢN KHÔNG ĐƯỢC ĐỂ TRỐNG!");
                txtLuongNgay.Focus();
                return false;
            }
            decimal luongngay = -1;
            try
            {
                luongngay = Convert.ToDecimal(txtLuongNgay.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (luongngay == -1)
            {
                MessageBox.Show("LƯƠNG CƠ BẢN KHÔNG HỢP LỆ!");
                txtLuongNgay.Text = "0";
                txtLuongNgay.Focus();
                return false;
            }
            if (txtThuong.Text.Trim() == "")
            {
                MessageBox.Show("TIỀN THƯỞNG KHÔNG ĐƯỢC ĐỂ TRỐNG!");
                txtThuong.Text = "0";
                txtThuong.Focus();
                return false;
            }
            decimal thuong = -1;
            try
            {
                thuong = Convert.ToDecimal(txtThuong.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (thuong == -1)
            {
                MessageBox.Show("TIỀN THƯỞNG KHÔNG HỢP LỆ!");
                txtThuong.Text = "0";
                txtThuong.Focus();
                return false;
            }
            return true;
        }

        private void SetActionTinhLuong()
        {
            txtTimKiem.Enabled = false;
            lvNhanVien.Enabled = false;
            pnbtnAction.Enabled = false;
            pnbtnSelection.Enabled = true;
            btnQuayLai.Enabled = false;
            pnTTLB.Enabled = false;

            btnXacNhan.Focus();

            btnXacNhan.TabIndex = 0;
            btnHuy.TabIndex = 1;

            trangthaiaction = 1;
        }

        private bool CheckActionTinhLuong()
        {
            bool check = true;
            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc chắn muốn tính lương của nhân viên mã " + manhanvien.ToString() + " ?" + "\nSẽ không thể hoàn tác sau khi đã thay đổi dữ liệu!",
                "Confirm Dialog",
                MessageBoxButtons.YesNo
            );
            if (dialogResult == DialogResult.No)
            {
                check = false;
            }
            return check;
        }

        private void SetActionSuaLuong()
        {
            txtTimKiem.Enabled = false;
            lvNhanVien.Enabled = false;
            pnbtnAction.Enabled = false;
            pnbtnSelection.Enabled = true;
            btnQuayLai.Enabled = false;
            pnTTLB.Enabled = true;

            lblSoNgay.Enabled = false;
            txtSoNgay.Enabled = false;
            lblLuongNgay.Enabled = true;
            txtLuongNgay.Enabled = true;
            lblThuong.Enabled = true;
            txtThuong.Enabled = true;

            txtLuongNgay.Focus();

            txtLuongNgay.TabIndex = 0;
            txtThuong.TabIndex = 1;
            btnXacNhan.TabIndex = 2;
            btnHuy.TabIndex = 3;

            trangthaiaction = 2;
        }

        public bool CheckActionSua()
        {
            return CheckTTLB();
        }

        private decimal TinhTien()
        {
            int songay = Convert.ToInt32(txtSoNgay.Text);
            decimal luongngay = Convert.ToDecimal(txtLuongNgay.Text);
            decimal thuong = Convert.ToDecimal(txtThuong.Text);
            return luongngay * songay + thuong;
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count > 0)
                SetActionTinhLuong();
            else
            {
                MessageBox.Show("CHƯA CHỌN TÀI KHOẢN ĐỂ TÍNH LƯƠNG!");
                lvNhanVien.Focus();
            }
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count > 0)
                SetActionSuaLuong();
            else
            {
                MessageBox.Show("CHƯA CHỌN TÀI KHOẢN ĐỂ SỬA LƯƠNG!");
                lvNhanVien.Focus();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(trangthaiaction == 1)
            {
                if(CheckActionTinhLuong())
                {
                    string snull = "null";
                    DTONhanVien nv = new DTONhanVien(manhanvien, snull, snull, snull, snull, snull, snull, snull, snull, Convert.ToInt32(txtSoNgay.Text), Convert.ToDecimal(txtLuongNgay.Text), Convert.ToDecimal(txtThuong.Text));
                    if (BLLQLL.TinhLuong(nv))
                    {
                        MessageBox.Show("TÍNH LƯƠNG THÀNH CÔNG\nLƯƠNG CỦA NHÂN VIÊN MÃ " + manhanvien.ToString() + " = " + TinhTien().ToString());
                        SetMacDinh();
                        LoadListView();
                    }
                    else
                    {
                        MessageBox.Show("TÍNH LƯƠNG THẤT BẠI!");
                    }
                }
            }
            if(trangthaiaction == 2)
            {
                if (CheckActionSua())
                {
                    string snull = "null";
                    DTONhanVien nv = new DTONhanVien(manhanvien, snull, snull, snull, snull, snull, snull, snull, snull, Convert.ToInt32(txtSoNgay.Text), Convert.ToDecimal(txtLuongNgay.Text), Convert.ToDecimal(txtThuong.Text));
                    if (BLLQLL.SuaLuong(nv))
                    {
                        MessageBox.Show("SỬA THÀNH CÔNG!");
                        SetMacDinh();
                        LoadListView();
                    }
                    else
                    {
                        MessageBox.Show("SỬA THẤT BẠI!");
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

        }

        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                int manhanvien = Convert.ToInt32(lvNhanVien.SelectedItems[0].SubItems[0].Text);
                this.manhanvien = manhanvien;
                foreach (DTONhanVien nv in arrNV)
                {
                    if (nv.getManhanvien() == manhanvien)
                    {
                        txtSoNgay.Text = nv.getSongaylam().ToString();
                        txtLuongNgay.Text = nv.getLuongcoban().ToString();
                        txtThuong.Text = nv.getThuong().ToString();
                        break;
                    }
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            lvNhanVien.Items.Clear();
            foreach (DTONhanVien nv in arrNV)
            {
                if (nv.getManhanvien().ToString().Contains(txtTimKiem.Text))
                {
                    string[] row = {
                            nv.getManhanvien().ToString(),
                            nv.getSongaylam().ToString(),
                        };
                    ListViewItem lvi = new ListViewItem(row);
                    lvNhanVien.Items.Add(lvi);
                }
            }
        }
    }
}
