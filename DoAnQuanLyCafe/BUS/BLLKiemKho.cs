using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQuanLyCafe.DAO;
namespace DoAnQuanLyCafe.BUS
{
    internal class BLLKiemKho
    {
        DAO.DAOKiemKho DAO = new DAO.DAOKiemKho();
        public DataTable getListViewTable()
        {
            return DAO.getListViewTable();
        }
        public string insertData(DTO.DTOKiemKho DTO)
        {
            if (DAO.insertData(DTO))
                return "Thêm mới thành công !";
            else
                return "Thêm mới thất bại !";
        }
        public string updateData(DTO.DTOKiemKho DTO)
        {
            if (DAO.updateData(DTO))
            {
                return "Sửa thông tin nguyên liệu thành công !";
            }
            else return "Sửa thông tin nguyên liệu thất bại !";
        }
        public string updateTonKho(DTO.DTOKiemKho DTO)
        {
            if (DAO.updateTonKho(DTO))
            {
                return "Cập nhật số lượng thành công !";
            }
            else return "Cập nhật số lượng thất bại !";
        }
        public string deleteData(DTO.DTOKiemKho DTO)
        {
            if (DAO.deleteData(DTO))
            {
                return "Xóa thành công !";
            }
            else return "Xóa thất bại !";
        }
        public ArrayList getAllNguyenLieu()
        {
            return DAO.getAllNguyenLieu();
        }
    }
}
