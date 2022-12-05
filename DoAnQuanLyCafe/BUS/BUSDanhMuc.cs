using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQuanLyCafe.DAO;

namespace DoAnQuanLyCafe.BUS
{
    public class BUSDanhMuc
    {
        private DataTable listCategory = null;
        private DAO.DAODanhMuc DAODanhMuc = new DAODanhMuc();
        
        public BUSDanhMuc()
        {
            docListCategory();
        }
        
        public void docListCategory()

        {
            listCategory = DAODanhMuc.getDanhMuc();
        }

        public DataTable getListCategory()
        {
            
            docListCategory();
            return listCategory;
        }

        public void insertCategory(string name)
        {
            try
            {
                
                    DAODanhMuc.insertDanhMuc(name);
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void updateCategory(int id,string name) {
            try
            {
                
                    DAODanhMuc.updateDanhMuc(id, name);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void deleteCategory(int id)
        {
            try
            {
                DAODanhMuc.deleteDanhMuc(id);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool checkDuplicate(string name)
        {
            if (DAODanhMuc.checkDuplicate(name))
                return true;
            else
                return false;
        }

        public DataTable findByName(string name)
        {
            DataTable dt = new DataTable();
            dt=DAODanhMuc.findByName(name);
            return dt;
        }
        
    }
}
