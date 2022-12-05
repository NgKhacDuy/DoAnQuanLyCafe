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
    internal class BLLQuanLyTaiKhoan
    {
        DAOQuanLyTaiKhoan DAOQLTK = new DAOQuanLyTaiKhoan();

        public ArrayList getAllTaiKhoan()
        {
            return DAOQLTK.getAllTaiKhoan();
        }
        public ArrayList getALlNhanVien()
        {
            return DAOQLTK.getALlNhanVien();
        }

        public ArrayList getAllLoaiTK()
        {
            return DAOQLTK.getAllLoaiTK();
        }

        public bool ThemTaiKhoan(DTOTaiKhoan tk, DTONhanVien nv)
        {
            return DAOQLTK.ThemTaiKhoan(tk, nv);
        }

        public bool SuaTaiKhoan(DTOTaiKhoan tk)
        {
            return DAOQLTK.SuaTaiKhoan(tk);
        }

        public bool XoaTaiKhoan(DTOTaiKhoan tk)
        {
            return DAOQLTK.XoaTaiKhoan(tk);
        }
    }
}
