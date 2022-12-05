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
    internal class BLLNhapHang
    {
        DAONhapHang DAONH = new DAONhapHang();

        public ArrayList getAllNguyenLieu()
        {
            return DAONH.getAllNguyenLieu();
        }

        public bool NhapHang(DTOBienLai bl, ArrayList arrctbl, ArrayList arrnl)
        {
            return DAONH.NhapHang(bl, arrctbl, arrnl);
        }
    }
}
