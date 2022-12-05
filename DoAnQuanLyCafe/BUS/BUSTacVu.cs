using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQuanLyCafe.DAO;

namespace DoAnQuanLyCafe.BUS
{
    public class BUSTacVu
    {
        private DataTable listCategory = null;
        private DAO.DAOTacVu DAOTacVu = new DAOTacVu();
        public BUSTacVu()
        {
            docListCategory();
        }

        public void docListCategory()
        
        {
            listCategory = DAOTacVu.getCategory();
        }
        public DataTable getListCategory()
        {
            //if (listCategory == null)
                docListCategory();
            return listCategory;
        }

        public DataTable getFoodFromCategory(string categoryName)
        {
            DataTable food = new DataTable();
            food = DAOTacVu.getFoodFromCategory(categoryName);
            return food;
        }

        public decimal getPriceFromFood(string FoodName)
        {
            decimal price = 0;
            price = DAOTacVu.getPriceFromCategory(FoodName);
            return price;
        }
    }
}
