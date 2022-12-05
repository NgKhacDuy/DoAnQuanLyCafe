using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQuanLyCafe.DAO;

namespace DoAnQuanLyCafe.BUS
{
    public class BUSHoaDon
    {
        private DataTable listHoaDon = null;
        private DataTable listCTHoaDon = null;
        private DAO.DAOHoaDon DAOHoaDon = new DAOHoaDon();

        public BUSHoaDon()
        {

        }

        public void docListCTHoaDon()
        {
            listCTHoaDon = DAOHoaDon.getCTHoaDon();

        }

        public void docListHoaDon()
        {
            listHoaDon = DAOHoaDon.getHoaDon();
        }

        public DataTable getListHoaDon()
        {
            docListHoaDon();
            return listHoaDon;
        }

        public DataTable getListCTHoaDon()
        {
            docListCTHoaDon();
            return listCTHoaDon;
        }

        public DataTable getHoaDonFromDate(string first, string second)
        {
            DataTable listBill = new DataTable();
            listBill=DAOHoaDon.getHoaDonFromDate(first,second);
            return listBill;
        }

        public void insertHoaDon(int tongTien, string date, int MaBan)
        {
            try
            {
                DAOHoaDon.insertHoaDon(tongTien, date, MaBan);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
