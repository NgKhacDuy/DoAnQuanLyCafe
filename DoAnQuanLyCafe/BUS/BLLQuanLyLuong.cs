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
    internal class BLLQuanLyLuong
    {
        DAOQuanLyLuong DAOQLL = new DAOQuanLyLuong();

        public ArrayList getALlNhanVien()
        {
            return DAOQLL.getALlNhanVien();
        }

        public bool TinhLuong(DTONhanVien nv)
        {
            return DAOQLL.TinhLuong(nv);
        }

        public bool SuaLuong(DTONhanVien nv)
        {
            return DAOQLL.SuaLuong(nv);
        }
    }
}
