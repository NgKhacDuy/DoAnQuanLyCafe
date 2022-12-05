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
    public partial class GUIQuanLyTaiKhoan : Form
    {
        private BLLQuanLyTaiKhoan BLLQLTK = new BLLQuanLyTaiKhoan();
        private ArrayList arrTK = new ArrayList();
        private ArrayList arrNV = new ArrayList();
        private ArrayList arrLoaiTK = new ArrayList();
        private int trangthaiaction = 0;

        public GUIQuanLyTaiKhoan()
        {
            InitializeComponent();
            SetMacDinh();
            LoadListView();
        }

        private void LoadListView()
        {
            lvTaiKhoan.Items.Clear();
            arrTK = BLLQLTK.getAllTaiKhoan();
            foreach (DTOTaiKhoan tk in arrTK)
            {
                string[] row = {
                    tk.getTentaikhoan(),
                    tk.getMatkhau(),
                    tk.getMaLoaiTaiKhoan().ToString()
                };
                ListViewItem lvi = new ListViewItem(row);
                lvTaiKhoan.Items.Add(lvi);
            }
            arrNV = BLLQLTK.getALlNhanVien();
            arrLoaiTK = BLLQLTK.getAllLoaiTK();
        }

        private void SetMacDinh()
        {
            txtTimKiem.Enabled = true;
            lvTaiKhoan.Enabled = true;
            pnbtnAction.Enabled = true;
            pnbtnSelection.Enabled = false;
            btnQuayLai.Enabled = true;
            pnTTTK.Enabled = false;
            pnTTLB.Enabled = false;
            rbtnCancel.Select();
        }

        private void ResetAllText()
        {
            txtTimKiem.Text = "";
            lvTaiKhoan.SelectedItems.Clear();
            pbAnhDaiDien.Image = null;
            txtMaNV.Text = "";
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtMaTK.Text = "";
            txtChucVu.Text = "";

            txtCccd.Text = "";
            txtHoVaTen.Text = "";
            rbtnCancel.Select();
            txtDiaChi.Text = "";
            txtSdt.Text = "";
            cbbNgay.SelectedIndex = 0;
            cbbThang.SelectedIndex = 0;
            cbbNam.SelectedIndex = 0;

            txtSoNgay.Text = "";
            txtLuongNgay.Text = "";
            txtThuong.Text = "";
        }

        private bool CheckTTTK()
        {
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("MÃ NHÂN VIÊN KHÔNG ĐƯỢC ĐỂ TRỐNG!");
                txtMaNV.Focus();
                return false;
            }
            int manhanvien = -1;
            try
            {
                manhanvien = Convert.ToInt32(txtMaNV.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (manhanvien == -1)
            {
                MessageBox.Show("MÃ NHÂN VIÊN PHẢI LÀ 1 SỐ NGUYÊN!");
                txtMaNV.Focus();
                return false;
            }
            bool checkDaCoMaNhanVien = false;
            foreach (DTONhanVien nv in arrNV)
            {
                if (nv.getManhanvien() == manhanvien)
                    checkDaCoMaNhanVien = true;
            }
            if (checkDaCoMaNhanVien)
            {
                MessageBox.Show("MÃ NHÂN VIÊN ĐÃ TỒN TẠI!");
                txtMaNV.Focus();
                return false;
            }
            if (txtTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("TÊN TÀI KHOẢN KHÔNG ĐƯỢC ĐỂ TRỐNG!");
                txtTaiKhoan.Focus();
                return false;
            }
            foreach (DTOTaiKhoan tk in arrTK)
            {
                if (tk.getTentaikhoan() == txtTaiKhoan.Text)
                {
                    MessageBox.Show("TÊN TÀI KHOẢN ĐÃ TỒN TẠI!");
                    txtTaiKhoan.Focus();
                    return false;
                }
            }
            if (txtMaTK.Text.Trim() == "")
            {
                MessageBox.Show("MÃ LOẠI TÀI KHOẢN KHÔNG ĐƯỢC ĐỂ TRỐNG!");
                txtMaTK.Focus();
                return false;
            }
            int maloaitk = -1;
            try
            {
                maloaitk = Convert.ToInt32(txtMaTK.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (maloaitk == -1)
            {
                MessageBox.Show("MÃ LOẠI TÀI KHOẢN PHẢI LÀ 1 SỐ NGUYÊN!");
                txtMaTK.Focus();
                return false;
            }
            bool checkKhongCoLoaiTaiKhoan = true;
            foreach (DTOLoaiTaiKhoan ltk in arrLoaiTK)
            {
                if (ltk.getMaLoaiTaiKhoan() == maloaitk)
                    checkKhongCoLoaiTaiKhoan = false;
            }
            if (checkKhongCoLoaiTaiKhoan)
            {
                MessageBox.Show("MÃ LOẠI TÀI KHOẢN KHÔNG TỒN TẠI!");
                txtMaTK.Focus();
                return false;
            }
            return true;
        }

        private bool CheckTTLB()
        {
            if (txtSoNgay.Text.Trim() == "")
            {
                MessageBox.Show("SỐ NGÀY LÀM KHÔNG ĐƯỢC DỂ TRỐNG!");
                txtSoNgay.Text = "0";
                txtSoNgay.Focus();
                return false;
            }
            int songay = -1;
            try
            {
                songay = Convert.ToInt32(txtSoNgay.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (songay == -1)
            {
                MessageBox.Show("SỐ NGÀY KHỞI TẠO PHẢI LÀ 1 SỐ NGUYÊN!");
                txtSoNgay.Text = "0";
                txtSoNgay.Focus();
                return false;
            }
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
                MessageBox.Show("LƯƠNG KHỞI TẠO KHÔNG HỢP LỆ!");
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
                MessageBox.Show("TIỀN THƯỞNG KHỞI TẠO KHÔNG HỢP LỆ!");
                txtThuong.Text = "0";
                txtThuong.Focus();
                return false;
            }
            return true;
        }

        private void SetActionThem()
        {
            txtTimKiem.Enabled = false;

            lvTaiKhoan.Enabled = false;

            pnbtnAction.Enabled = false;

            pnbtnSelection.Enabled = true;

            btnQuayLai.Enabled = false;

            pnTTTK.Enabled = true;

            lblMaNV.Enabled = true;
            txtMaNV.Enabled = true;
            lblTaiKhoan.Enabled = true;
            txtTaiKhoan.Enabled = true;
            lblMatKhau.Enabled = false;
            txtMatKhau.Enabled = false;
            lblMaTK.Enabled = true;
            txtMaTK.Enabled = true;
            lblChucVu.Enabled = false;
            txtChucVu.Enabled = false;

            pnTTLB.Enabled = true;

            lblSoNgay.Enabled = true;
            txtSoNgay.Enabled = true;
            lblLuongNgay.Enabled = true;
            txtLuongNgay.Enabled = true;
            lblThuong.Enabled = true;
            txtThuong.Enabled = true;

            ResetAllText();

            txtSoNgay.Text = "0";
            txtThuong.Text = "0";

            txtMaNV.Focus();

            txtMaNV.TabIndex = 0;
            txtTaiKhoan.TabIndex = 1;
            txtMaTK.TabIndex = 2;
            txtSoNgay.TabIndex = 3;
            txtLuongNgay.TabIndex = 4;
            txtThuong.TabIndex = 5;
            btnXacNhan.TabIndex = 6;
            btnHuy.TabIndex = 7;

            trangthaiaction = 1;
        }

        private bool CheckActionThem()
        {
            bool checkTTTK = CheckTTTK();
            bool checkTTLB = CheckTTLB();
            return checkTTTK && checkTTLB;
        }

        private void SetActionSua()
        {
            txtTimKiem.Enabled = false;

            lvTaiKhoan.Enabled = false;

            pnbtnAction.Enabled = false;

            pnbtnSelection.Enabled = true;

            btnQuayLai.Enabled = false;

            pnTTTK.Enabled = true;

            lblMaNV.Enabled = false;
            txtMaNV.Enabled = false;
            lblTaiKhoan.Enabled = false;
            txtTaiKhoan.Enabled = false;
            lblMatKhau.Enabled = true;
            txtMatKhau.Enabled = true;
            lblMaTK.Enabled = true;
            txtMaTK.Enabled = true;
            lblChucVu.Enabled = false;
            txtChucVu.Enabled = false;

            pnTTLB.Enabled = false;

            txtMatKhau.Focus();

            txtMatKhau.TabIndex = 0;
            txtMaTK.TabIndex = 1;
            btnXacNhan.TabIndex = 2;
            btnHuy.TabIndex = 3;

            trangthaiaction = 2;
        }

        private bool CheckActionSua()
        {
            if (txtMaTK.Text.Trim() == "")
            {
                MessageBox.Show("MÃ LOẠI TÀI KHOẢN KHÔNG ĐƯỢC ĐỂ TRỐNG!");
                txtMaTK.Focus();
                return false;
            }
            int maloaitk = -1;
            try
            {
                maloaitk = Convert.ToInt32(txtMaTK.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (maloaitk == -1)
            {
                MessageBox.Show("MÃ LOẠI TÀI KHOẢN PHẢI LÀ 1 SỐ NGUYÊN!");
                txtMaTK.Focus();
                return false;
            }
            bool checkKhongCoLoaiTaiKhoan = true;
            foreach (DTOLoaiTaiKhoan ltk in arrLoaiTK)
            {
                if (ltk.getMaLoaiTaiKhoan() == maloaitk)
                    checkKhongCoLoaiTaiKhoan = false;
            }
            if (checkKhongCoLoaiTaiKhoan)
            {
                MessageBox.Show("MÃ LOẠI TÀI KHOẢN KHÔNG TỒN TẠI!");
                txtMaTK.Focus();
                return false;
            }
            return true;
        }

        private void SetActionXoa()
        {
            txtTimKiem.Enabled = false;

            lvTaiKhoan.Enabled = false;

            pnbtnAction.Enabled = false;

            pnbtnSelection.Enabled = true;

            btnQuayLai.Enabled = false;

            pnTTTK.Enabled = false;

            pnTTLB.Enabled = false;

            btnXacNhan.Focus();

            btnXacNhan.TabIndex = 0;
            btnHuy.TabIndex = 1;

            trangthaiaction = 3;
        }

        private bool CheckActionXoa()
        {
            bool check = true;
            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa tài khoản " + txtTaiKhoan.Text + " ?" + "\nSẽ không thể hoàn tác sau khi xóa dữ liệu!",
                "Confirm Dialog",
                MessageBoxButtons.YesNo
            );
            if (dialogResult == DialogResult.No)
            {
                check = false;
            }
            return check;
        }

        private void lvTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count > 0)
            {
                string taikhoan = lvTaiKhoan.SelectedItems[0].SubItems[0].Text;
                foreach (DTONhanVien nv in arrNV)
                {
                    if (nv.getTentaikhoan() == taikhoan)
                    {
                        try
                        {
                            pbAnhDaiDien.ImageLocation = nv.getAnhdaidien();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        txtMaNV.Text = nv.getManhanvien().ToString();
                        txtCccd.Text = nv.getCccd();
                        txtHoVaTen.Text = nv.getHovaten();
                        if (nv.getGioitinh() == "Nam")
                        {
                            rbtnNam.Checked = true;
                        }
                        else
                        {
                            rbtnNu.Checked = true;
                        }
                        txtDiaChi.Text = nv.getDiachi();
                        txtSdt.Text = nv.getSoienthoai();
                        string[] ssplit = nv.getNtns().Split('/');
                        cbbNgay.SelectedIndex = Convert.ToInt32(ssplit[0]) - 1;
                        cbbThang.SelectedIndex = Convert.ToInt32(ssplit[1]) - 1;
                        cbbNam.SelectedIndex = 2022 - Convert.ToInt32(ssplit[2]);
                        txtSoNgay.Text = nv.getSongaylam().ToString();
                        txtLuongNgay.Text = nv.getLuongcoban().ToString();
                        txtThuong.Text = nv.getThuong().ToString();
                        break;
                    }
                }
                int matk = 0;
                foreach (DTOTaiKhoan tk in arrTK)
                {
                    if (tk.getTentaikhoan() == taikhoan)
                    {
                        txtTaiKhoan.Text = tk.getTentaikhoan();
                        txtMatKhau.Text = tk.getMatkhau();
                        txtMaTK.Text = tk.getMaLoaiTaiKhoan().ToString();
                        matk = tk.getMaLoaiTaiKhoan();
                        break;
                    }
                }
                foreach (DTOLoaiTaiKhoan ltk in arrLoaiTK)
                {
                    if (ltk.getMaLoaiTaiKhoan() == matk)
                    {
                        txtChucVu.Text = ltk.getTenLoaiTaiKhoan();
                        break;
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SetActionThem();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count > 0)
                SetActionSua();
            else
            {
                MessageBox.Show("CHƯA CHỌN TÀI KHOẢN ĐỂ SỬA!");
                lvTaiKhoan.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count > 0)
                SetActionXoa();
            else
            {
                MessageBox.Show("CHƯA CHỌN TÀI KHOẢN ĐỂ XÓA!");
                lvTaiKhoan.Focus();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (trangthaiaction == 1)
            {
                if (CheckActionThem())
                {
                    DTOTaiKhoan tk = new DTOTaiKhoan(txtTaiKhoan.Text, "1", Convert.ToInt32(txtMaTK.Text));
                    string snull = "null";
                    DTONhanVien nv = new DTONhanVien(Convert.ToInt32(txtMaNV.Text), snull, snull, "Nam", "01/01/2022", snull, snull, txtTaiKhoan.Text, snull, Convert.ToInt32(txtSoNgay.Text), Convert.ToDecimal(txtLuongNgay.Text), Convert.ToDecimal(txtThuong.Text));
                    if (BLLQLTK.ThemTaiKhoan(tk, nv))
                    {
                        MessageBox.Show("THÊM THÀNH CÔNG!\nMẬT KHẨU CỦA TÀI KHOẢN LÀ '1'");
                        SetMacDinh();
                        LoadListView();
                    }
                    else
                    {
                        MessageBox.Show("THÊM THẤT BẠI!");
                    }
                }
            }
            if (trangthaiaction == 2)
            {
                if (CheckActionSua())
                {
                    DTOTaiKhoan tk = new DTOTaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text, Convert.ToInt32(txtMaTK.Text));
                    if (BLLQLTK.SuaTaiKhoan(tk))
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
            if (trangthaiaction == 3)
            {
                if(CheckActionXoa())
                {
                    DTOTaiKhoan tk = new DTOTaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text, Convert.ToInt32(txtMaTK.Text));
                    if (BLLQLTK.XoaTaiKhoan(tk))
                    {
                        MessageBox.Show("XÓA THÀNH CÔNG!");
                        SetMacDinh();
                        LoadListView();
                    }
                    else
                    {
                        MessageBox.Show("XÓA THẤT BẠI!");
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
            //
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            lvTaiKhoan.Items.Clear();
            foreach (DTOTaiKhoan tk in arrTK)
            {
                if (tk.getTentaikhoan().Contains(txtTimKiem.Text))
                {
                    string[] row = {
                            tk.getTentaikhoan(),
                            tk.getMatkhau(),
                            tk.getMaLoaiTaiKhoan().ToString()
                        };
                    ListViewItem lvi = new ListViewItem(row);
                    lvTaiKhoan.Items.Add(lvi);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUIQuanLyLuong GUIQLL = new GUIQuanLyLuong();
            GUIQLL.Show();
        }

        private void GUIQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
