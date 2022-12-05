using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyCafe.DTO
{
    internal class DTOLoaiTaiKhoan
    {
        private int maloaitaikhoan;
        private string tenloaitaikhoan;

        public DTOLoaiTaiKhoan() { }
        public DTOLoaiTaiKhoan(int maloaitaikhoan, string tenloaitaikhoan)
        {
            this.maloaitaikhoan = maloaitaikhoan;
            this.tenloaitaikhoan = tenloaitaikhoan;
        }

        public int getMaLoaiTaiKhoan()
        {
            return maloaitaikhoan;
        }
        public string getTenLoaiTaiKhoan()
        {
            return tenloaitaikhoan;
        }

        public void setMaLoaiTaiKhoan(int maloaitaikhoan)
        {
            this.maloaitaikhoan = maloaitaikhoan;
        }
        public void setTenLoaiTaiKhoan(string tenloaitaikhoan)
        {
            this.tenloaitaikhoan = tenloaitaikhoan;
        }  
    }
}
