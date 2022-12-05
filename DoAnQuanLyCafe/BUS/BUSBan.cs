using DoAnQuanLyCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyCafe.BUS
{
    public class BUSBan
    {
        private DAOBan DAOBan = new DAOBan();
        List<Button> list = new List<Button>();
        DataTable listTable = new DataTable();
        public void docListBan()
        {
            list = DAOBan.getTable();
        }

        public void docListBanDataTable()
        {
            listTable=DAOBan.getTableDataTable();
        }

        public List<Button> getTable()
        {
            docListBan();
            return list;
        }

        public DataTable getTableDataTable()
        {
            docListBanDataTable();
            return listTable;
        }

        public void insertTable(string name)
        {
            DAOBan.InsertTable(name);
        }

        public void updateTable(int id,string name)
        {
            DAOBan.UpdateTable(id,name);
        }

        public void deleteTable(int id)
        {
            DAOBan.DeleteTable(id);
        }

        public DataTable findByName(string name)
        {
            return DAOBan.findByName(name);
        }


    }
}
