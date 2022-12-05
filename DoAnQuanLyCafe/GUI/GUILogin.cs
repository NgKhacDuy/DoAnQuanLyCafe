using DoAnQuanLyCafe.BUS;
using DoAnQuanLyCafe.DTO;
using DoAnQuanLyCafe.GUI;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DoAnQuanLyCafe.GUI
{
    public partial class GUILogin : Form
    {
        //GUICapNhatTaiKhoan GUIcntk = new GUICapNhatTaiKhoan("null");
        BLLLogin BLLlogin = new BLLLogin();
        string taikhoannhap;
        String matkhaunhap;

        public GUILogin()
        {
            InitializeComponent();
            taikhoannhap = txtTaiKhoan.Text;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Main main = new Main();

            taikhoannhap = txtTaiKhoan.Text;
            matkhaunhap = txtMatKhau.Text;
            if (taikhoannhap.Trim().Equals("") || matkhaunhap.Trim().Equals(""))
            {
                MessageBox.Show("Ten tai khoan hoac mat khau khong duoc de trong!");            
            }
            else
            {
                String message = "null";
                int trangthai = BLLlogin.checkDangNhap(taikhoannhap, matkhaunhap);
                switch (trangthai)
                {
                    case 0: {
                            message = "Tai Khoan Khong Ton Tai!";
                            break;
                        }
                    case 1: {
                            message = "Sai Tai Khoan Hoac Mat Khau!";
                            break;
                        }
                    case 2:
                        {
                            message = "Dang Nhap Thanh Cong!";
                            break;
                        }
                    case 3:
                        {
                            message = "Dang Nhap Thanh Cong!";
                            break;
                        }
                }
                MessageBox.Show(message);
                if (trangthai == 2)
                {
                    //GUIcntk = new GUICapNhatTaiKhoan(taikhoannhap);
                    //GUIcntk.Show();
                    this.Close();
                    //System.Diagnostics.Process.GetCurrentProcess().Kill();
                    main.Show();
                }
                if (trangthai == 3)
                    this.Close();
                    //System.Diagnostics.Process.GetCurrentProcess().Kill();
                    main = new Main();
                    main.Show();
                taikhoannhap = getTKNhap();
            }

        }

        bool trangthaixem = true;
        private void btnXem_Click(object sender, EventArgs e)
        {
            if(trangthaixem)
            {
                trangthaixem = false;
                txtMatKhau.PasswordChar = default;
            }
            else
            {
                trangthaixem = true;
                txtMatKhau.PasswordChar = '*';
            }
        }

        public string getTKNhap()
        {
            return taikhoannhap;
        }
    }
}