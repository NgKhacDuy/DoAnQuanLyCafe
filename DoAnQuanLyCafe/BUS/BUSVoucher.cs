using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyCafe.BUS
{
    public class BUSVoucher
    {
        DataTable listVoucher = new DataTable();
        private DAO.DAOVoucher DAOVoucher = new DAO.DAOVoucher();

        public BUSVoucher()
        {
        }

        public void docListVoucher()
        {
            listVoucher=DAOVoucher.getVoucher();
        }
        public DataTable getListVoucher()
        {
            docListVoucher();
            return listVoucher;
        }

        public void insertVoucher(int id, string dateStart, string dateEnd, float percent, string tenVoucher)
        {
            try
            {
                DAOVoucher.insertVoucher(id,dateStart,dateEnd,percent,tenVoucher);
            }

            catch(Exception ex)
            {

            }
        }

        public void deleteVoucher(int id)
        {
            try
            {
                DAOVoucher.deleteVoucher(id);
            }

            catch (Exception ex)
            {

            }
        }

        public void updateVoucher(int id, string dateStart, string dateEnd, float percent, string tenVoucher)
        {
            try
            {
                DAOVoucher.updateVoucher(id,dateStart,dateEnd,percent,tenVoucher);
            }

            catch (Exception ex)
            {

            }
        }

        public DataTable searchVoucherFromDate(string dateStart, string dateEnd)
        {
            DataTable listVoucher = new DataTable();
            try
            {
                listVoucher= DAOVoucher.searchVoucherFromDate(dateStart,dateEnd);
                return listVoucher;
            }

            catch
            {

            }
            return null;
        }

        public DataTable searchVoucherFromName(string name)
        {
            DataTable listVoucher = new DataTable();
            try
            {
                listVoucher= DAOVoucher.searchVoucherFromName(name);
                return listVoucher;
            }

            catch
            {

            }
            return null;
        }

        public bool checkVoucher(int id)
        {
            try
            {
                if(DAOVoucher.checkVoucher(id))
                    return true;
                else
                    return false;
            }

            catch(Exception ex)
            {

            }
            return false;
        }

        public float getPercent(int id)
        {
            try
            {
                if (checkVoucher(id))
                    return DAOVoucher.getPercent(id);
            }

            catch(Exception ex)
            {

            }
            return 0;
        }
    }
}
