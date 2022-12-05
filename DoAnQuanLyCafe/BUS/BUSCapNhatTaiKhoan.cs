using DoAnQuanLyCafe.DAO;
using DoAnQuanLyCafe.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyCafe.BUS
{
    internal class BUSCapNhatTaiKhoan
    {
        private DAOCapNhatTaiKhoan DAOCapnhattaikhoan = new DAOCapNhatTaiKhoan();
        public ArrayList getAllTaiKhoan()
        {
            return DAOCapnhattaikhoan.getAllTaiKhoan();
        }

        public ArrayList getAllNhanVien()
        {
            return DAOCapnhattaikhoan.getALlNhanVien();
        }

        public string CapNhatTaiKhoan(DTOTaiKhoan tk)
        {
            if(DAOCapnhattaikhoan.CapNhatTaiKhoan(tk))
            {
                return "Cap Nhat Tai Khoan Thanh Cong!";
            }
            return "Cap Nhat Tai Khoan That Bai!";
        }

        public string CapNhatTTCN(DTONhanVien nv)
        {
            if(DAOCapnhattaikhoan.CapNhatTTCN(nv))
            {
                return "Cap Nhat TTCN Thanh Cong!";
            }
            return "Cap Nhat TTCN That Bai!";
        }
    }
}
