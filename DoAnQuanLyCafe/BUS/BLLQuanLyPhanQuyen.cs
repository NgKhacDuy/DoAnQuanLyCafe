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
    internal class BLLQuanLyPhanQuyen
    {
        DAOQuanLyPhanQuyen DAOQLPQ = new DAOQuanLyPhanQuyen();

        public ArrayList getAllChucNang()
        {
            return DAOQLPQ.getAllChucNang();
        }

        public bool CapNhatPhanQuyen(DTOChucNang cn) 
        {
            return DAOQLPQ.CapNhatPhanQuyen(cn);
        }
    }
}
