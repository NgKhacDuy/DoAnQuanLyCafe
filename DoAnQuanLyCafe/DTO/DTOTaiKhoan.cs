using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyCafe.DTO
{
    internal class DTOTaiKhoan
    {
        private String tentaikhoan;
        private String matkhau;
        private int maloaitaikhoan;

        public string getTentaikhoan()
        {
            return tentaikhoan;
        }
        public string getMatkhau()
        {
            return matkhau;
        }
        public int getMaLoaiTaiKhoan()
        {
            return maloaitaikhoan;
        }

        public void setTentaikhoan(string tentaikhoan) 
        {
            this.tentaikhoan = tentaikhoan;
        }
        public void setMatkhau(string matkhau)
        {
            this.matkhau = matkhau;
        }
        public void setMaLoaiTaiKhoan(int maloaitaikhoan)
        {
            this.maloaitaikhoan = maloaitaikhoan;
        }

        public DTOTaiKhoan() { }
        public DTOTaiKhoan(string tentaikhoan, string matkhau, int maloaitaikhoan)
        {
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
            this.maloaitaikhoan = maloaitaikhoan;
        }
    }
}
