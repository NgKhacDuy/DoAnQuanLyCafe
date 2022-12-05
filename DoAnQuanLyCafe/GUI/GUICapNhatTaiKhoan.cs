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
    public partial class GUICapNhatTaiKhoan : Form
    {
        private BUSCapNhatTaiKhoan BLLCapnhattaikhoan = new BUSCapNhatTaiKhoan();
        private int trangthaiaction = 0;
        private bool trangthaixemmkc = true;
        private bool trangthaixemmkm = true;
        private bool trangthaixemnlmkm = true;
        private string gioitinh = "";
        private string imagelocation = "";

        public GUICapNhatTaiKhoan(string taikhoan)
        {
            InitializeComponent();
            SetInfo(taikhoan);
            SetMacDinh();
        }

        private void SetInfo(string taikhoan)
        {
            txtTaiKhoan.Text = taikhoan;
            ArrayList arrTK = BLLCapnhattaikhoan.getAllTaiKhoan();
            foreach(DTOTaiKhoan item in arrTK)
            {
                if (item.getTentaikhoan() == taikhoan)
                {
                    txtMatKhauCu.Text = item.getMatkhau();
                    break;
                }
            }
            ArrayList arrNV = BLLCapnhattaikhoan.getAllNhanVien();
            foreach (DTONhanVien item in arrNV)
            {
                if (item.getTentaikhoan() == taikhoan)
                {
                    try
                    {
                        pbTTCN.ImageLocation = item.getAnhdaidien();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    txtMaNV.Text = item.getManhanvien().ToString();
                    txtCCCD.Text = item.getCccd();
                    txtHoVaTen.Text = item.getHovaten();
                    if(item.getGioitinh() == "Nam")
                    {
                        rbtnNam.Checked = true;
                    }
                    else
                    {
                        rbtnNu.Checked = true;
                    }
                    txtSDT.Text = item.getSoienthoai();
                    txtDiaChi.Text = item.getDiachi();
                    string[] ssplit = item.getNtns().Split('/');
                    cbbNgay.SelectedIndex = Convert.ToInt32(ssplit[0]) - 1;
                    cbbThang.SelectedIndex = Convert.ToInt32(ssplit[1]) - 1;
                    cbbNam.SelectedIndex = 2022 - Convert.ToInt32(ssplit[2]);
                    break;
                }
            }
        } 

        private void SetMacDinh()
        {
            txtMatKhauMoi.Enabled = false;
            txtMatKhauMoi.Text = "";
            txtNhapLai.Enabled = false;
            txtNhapLai.Text = "";

            pnbtnAction.Enabled = true;

            pnSelection.Enabled = false;

            pnTTCN.Enabled = false;

            btnContinue.Enabled = true;
            btnDangXuat.Enabled = true;

            SetInfo(txtTaiKhoan.Text);

            btnDoiMatKhau.TabIndex = 0;
            btnTTCN.TabIndex = 1;
            btnContinue.TabIndex = 2;
            btnDangXuat.TabIndex = 3;
        }

        private void SetDoiMatKhauAction()
        {
            txtMatKhauMoi.Enabled = true;
            txtNhapLai.Enabled = true;

            pnbtnAction.Enabled = false;

            pnSelection.Enabled = true;

            btnContinue.Enabled = false;
            btnDangXuat.Enabled = false;

            txtMatKhauCu.Focus();
            txtMatKhauMoi.TabIndex = 0;
            txtNhapLai.TabIndex = 1;
            btnXacNhan.TabIndex = 2;
            btnHuy.TabIndex = 3;
            
            trangthaiaction = 1;
        }

        private bool CheckDoiMatKhauAction()
        {
            if(txtMatKhauMoi.Text.Trim() == "")
            {
                MessageBox.Show("Mat Khau Moi Khong Duoc Bo Trong!");
                txtMatKhauMoi.Focus();
                return false;
            }
            if(txtNhapLai.Text.Trim() == "")
            {
                MessageBox.Show("Nhap Lai Mat Khau Moi Khong Duoc Bo Trong!");
                txtNhapLai.Focus();
                return false;
            }
            if(txtMatKhauMoi.Text != txtNhapLai.Text)
            {
                MessageBox.Show("Mat Khau Nhap Lai Khong Trung Khop!");
                txtNhapLai.Focus();
                return false;
            }
            return true;
        }

        private void SetCNTTAction()
        {
            txtMatKhauMoi.Enabled = false;
            txtNhapLai.Enabled = false;

            pnbtnAction.Enabled = false;

            pnSelection.Enabled = true;

            pnTTCN.Enabled = true;

            btnContinue.Enabled = false;
            btnDangXuat.Enabled = false;

            txtCCCD.Focus();
            txtCCCD.TabIndex = 0;
            txtHoVaTen.TabIndex = 1;
            rbtnNam.TabIndex = 2;
            rbtnNu.TabIndex = 3;
            txtSDT.TabIndex = 4;
            txtDiaChi.TabIndex = 5;
            cbbNgay.TabIndex = 6;
            cbbThang.TabIndex = 7;
            cbbNam.TabIndex = 8;
            btnBrowse.TabIndex = 9;
            btnXacNhan.TabIndex = 10;
            btnHuy.TabIndex = 11;

            trangthaiaction = 2;
        }

        private bool isNamNhuan(int nam) 
        {
            return nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0);
        }

        private bool CheckNTNS()
        {
            int ngay = cbbNgay.SelectedIndex + 1;
            int thang = cbbThang.SelectedIndex + 1;
            int nam = 2022 - cbbNam.SelectedIndex;
            switch (thang)
            {
                case 2:  {
                        if (isNamNhuan(nam))
                        {
                            if (ngay > 29)
                                return false;
                        }
                        else
                            if (ngay > 28)
                            return false;
                        break;
                    }
                case 1:  {
                        if (ngay > 31)
                            return false;
                        break;
                    }
                case 3:
                    {
                        if (ngay > 31)
                            return false;
                        break;
                    }
                case 5:
                    {
                        if (ngay > 31)
                            return false;
                        break;
                    }
                case 7:
                    {
                        if (ngay > 31)
                            return false;
                        break;
                    }
                case 8:
                    {
                        if (ngay > 31)
                            return false;
                        break;
                    }
                case 10:
                    {
                        if (ngay > 31)
                            return false;
                        break;
                    }
                case 12:
                    {
                        if (ngay > 31)
                            return false;
                        break;
                    }
                case 4:  {
                        if (ngay > 30)
                            return false;
                        break;
                    }
                case 6:  {
                        if (ngay > 30)
                            return false;
                        break;
                    }
                case 9:  {
                        if (ngay > 30)
                            return false;
                        break;
                    }
                case 11:  {
                        if (ngay > 30)
                            return false;
                        break;
                    }
            }
            return true;
        }

        private bool CheckCNTTAction()
        {
            if(txtCCCD.Text.Trim() == "")
            {
                MessageBox.Show("Can Cuoc Cong Dan Khong Duoc De Trong!");
                txtCCCD.Focus();
                return false;
            }
            if (txtHoVaTen.Text.Trim() == "")
            {
                MessageBox.Show("Ho Va Ten Khong Duoc De Trong!");
                txtHoVaTen.Focus();
                return false;
            }
            if (gioitinh == "")
            {
                MessageBox.Show("Gioi Tinh Khong Duoc De Trong!");
                rbtnNam.Focus();
                return false;
            }
            if (txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("So Dien Thoai Khong Duoc De Trong!");
                txtSDT.Focus();
                return false;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Dia Chi Khong Duoc De Trong!");
                txtDiaChi.Focus();
                return false;
            }
            if (!CheckNTNS())
            {
                MessageBox.Show("Nhap Ngay Thang Nam Sinh Khong Hop Le!");
                cbbNgay.Focus();
                return false;
            }
            return true;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            SetDoiMatKhauAction();
        }

        private void btnTTCN_Click(object sender, EventArgs e)
        {
            SetCNTTAction();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(trangthaiaction == 1)
            {
                if(CheckDoiMatKhauAction())
                {
                    ArrayList arrTK = BLLCapnhattaikhoan.getAllTaiKhoan();
                    DTOTaiKhoan tk = new DTOTaiKhoan();
                    foreach (DTOTaiKhoan item in arrTK)
                    {
                        if (item.getTentaikhoan() == txtTaiKhoan.Text)
                        {
                            tk = item;
                            break;
                        }
                    }
                    tk.setMatkhau(txtMatKhauMoi.Text);
                    txtMatKhauCu.Text = txtMatKhauMoi.Text;
                    MessageBox.Show(BLLCapnhattaikhoan.CapNhatTaiKhoan(tk));
                    SetMacDinh();
                }
            }
            else
            {
                if(CheckCNTTAction())
                {
                    string thang = "";
                    if(cbbThang.SelectedIndex + 1 < 10)
                    {
                        thang = "0" + (cbbThang.SelectedIndex + 1).ToString();
                    }
                    string ntns = (cbbNgay.SelectedIndex + 1).ToString() + "/" +
                                  thang + "/" +
                                  (2022 - cbbNam.SelectedIndex).ToString();
                    DTONhanVien nv = new DTONhanVien();
                    nv.setManhanvien(Convert.ToInt32(txtMaNV.Text));
                    nv.setCccd(txtCCCD.Text);
                    nv.setHovaten(txtHoVaTen.Text);
                    nv.setGioitinh(gioitinh);
                    nv.setNtns(ntns);
                    nv.setDiachi(txtDiaChi.Text);
                    nv.setSodienthoai(txtSDT.Text);
                    nv.setTentaikhoan(txtTaiKhoan.Text);
                    nv.setAnhdaidien(imagelocation);
                    MessageBox.Show(BLLCapnhattaikhoan.CapNhatTTCN(nv));
                    SetMacDinh();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetMacDinh();
        }

        private void btnXemMKC_Click(object sender, EventArgs e)
        {
            if(trangthaixemmkc)
            {
                txtMatKhauCu.PasswordChar = default;
                trangthaixemmkc = false;
            }
            else
            {
                txtMatKhauCu.PasswordChar = '*';
                trangthaixemmkc = true;
            }
        }

        private void btnXemMKM_Click(object sender, EventArgs e)
        {
            if (trangthaixemmkm)
            {
                txtMatKhauMoi.PasswordChar = default;
                trangthaixemmkm = false;
            }
            else
            {
                txtMatKhauMoi.PasswordChar = '*';
                trangthaixemmkc = true;
            }
        }

        private void btnXemNLMKM_Click(object sender, EventArgs e)
        {
            if (trangthaixemnlmkm)
            {
                txtNhapLai.PasswordChar = default;
                trangthaixemnlmkm = false;
            }
            else
            {
                txtNhapLai.PasswordChar = '*';
                trangthaixemnlmkm = true;
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            GUILogin GUILg = new GUILogin();
            GUILg.Show();
            this.Dispose();
        }

        private void rbtnNam_CheckedChanged(object sender, EventArgs e)
        {
            gioitinh = "Nam";
        }

        private void rbtnNu_CheckedChanged(object sender, EventArgs e)
        {
            gioitinh = "Nu";
        }
        
        private void btnContinue_Click(object sender, EventArgs e)
        {
            GUIQuanLyTaiKhoan GUIQLTK = new GUIQuanLyTaiKhoan();
            GUIQLTK.Show();
        }
        
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                imagelocation = ofd.FileName.ToString();
                pbTTCN.ImageLocation = imagelocation;
            }
        }
    }
}
