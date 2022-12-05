using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyCafe.DAO
{
    public class DAOTacVu
    {
        private ConnectSQL ConnectSQL;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        public DataTable getCategory()
        {
            try
            {
                DataTable listCategory = new DataTable();
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = "Select TenLoaiMon from LOAIMON";
                adapter.SelectCommand = command;
                adapter.Fill(listCategory);
                return listCategory;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public DataTable getFoodFromCategory(string categoryName)
        {
            try
            {
                DataTable listFood = new DataTable();
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = "select Mon.TenMon " +
                                        "from MON join LOAIMON " +
                                        "on MON.MaLoaiMon = LOAIMON.MaLoaiMon " +
                                        "where MON.MaLoaiMon in (" +
                                                                "select MaLoaiMon " +
                                                                "from LOAIMON " +
                                                                $"where LOAIMON.TenLoaiMon = N'{categoryName}' " +
                                                                ")";
                adapter.SelectCommand = command;
                adapter.Fill(listFood);
                return listFood;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public decimal getPriceFromCategory(string foodName)
        {
            try
            {
                decimal price = 0;
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = "select GiaTien " +
                                        "from Mon " +
                                        $"where TenMon = N'{foodName}'";
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    price = reader.GetDecimal(0);
                }
                return price;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 1;
        }

    }
}
