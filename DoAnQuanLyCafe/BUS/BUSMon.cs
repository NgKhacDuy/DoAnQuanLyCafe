using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQuanLyCafe.DAO;

namespace DoAnQuanLyCafe.BUS {
    public class BUSMon
    {
        private DataTable listFood = null;
        private DAO.DAOMon DAOFood = new DAOMon();
        private DAO.DAODanhMuc DAODanhMuc = new DAODanhMuc();

        public BUSMon()
        {
            docListCategory();
        }

        public void docListCategory()

        {
            listFood = DAOFood.getFood();
        }

        public DataTable getListFood()
        {
            docListCategory();
            return listFood;
        }

        public void insertFood(string name, int categoryID, int price)
        {
            try
            {
                DAOFood.insertFood(name, categoryID, price);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void updateFood(int id, string name, int CategoryID, int Price)
        {
            try
            {
                DAOFood.updateFood(id, name, CategoryID, Price);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void deleteFood(int id)
        {
            try
            {
                DAOFood.deleteFood(id);
            }

            catch (Exception ex)
            {

            }
        }

        public DataTable findByName(string name)
        {
            DataTable dt = new DataTable();
            dt = DAOFood.findByName(name);
            return dt;
        }

        public int findIDbyName(string name)
        {
            int id;
            id = DAODanhMuc.findIDbyName(name);
            return id;
        }

        public string findNamebyID(string id)
        {
            return DAODanhMuc.findNamebyID(id);
        }

        public DataTable getAllNameCategory()
        {
            DataTable dt = new DataTable();
            dt = DAODanhMuc.GetAllName();
            return dt;
        }

    }

}

