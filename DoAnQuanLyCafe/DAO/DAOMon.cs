using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyCafe.DAO
{
    public class DAOMon
    {
        private ConnectSQL ConnectSQL;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        public DataTable getFood() {
            try
            {
                DataTable listFood = new DataTable();
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = "Select * from MON";
                adapter.SelectCommand = command;
                adapter.Fill(listFood);
                return listFood;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;

        }

        public bool checkDuplicate(string name)
        {

            ConnectSQL = new ConnectSQL();
            SqlConnection con = ConnectSQL.GetConnection();
            con.Open();
            command = con.CreateCommand();
            command.CommandText = $"select TenMon from MON where TenMon = '{name}' ";
            SqlDataReader reader;
            reader = command.ExecuteReader();
            if (reader.Read())
                return true;
            else
            {
                return false;
            }

        }

        public void insertFood(string name,int CategoryID, decimal Price)
        {
            try
            {
                if (!checkDuplicate(name))
                {
                    ConnectSQL = new ConnectSQL();
                    SqlConnection con = ConnectSQL.GetConnection();
                    con.Open();
                    command = con.CreateCommand();
                    command.CommandText = $"Insert into MON (TenMon,GiaTien,MaLoaiMon) values (N'{name}',{Price},{CategoryID})";
                    adapter.SelectCommand = command;
                    command.ExecuteReader();
                }
                
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
                if (!checkDuplicate(name))
                {
                    ConnectSQL = new ConnectSQL();
                    SqlConnection con = ConnectSQL.GetConnection();
                    con.Open();
                    command = con.CreateCommand();
                    command.CommandText = $"Update Food set Name = N'{name}', CategoryID = {CategoryID}, Price = {Price} where ID = {id}";
                    adapter.SelectCommand = command;
                    command.ExecuteReader();
                }

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
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = $"Delete from Food where ID = {id}";
                adapter.SelectCommand = command;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public DataTable findByName(string name)
        {
            try
            {
                DataTable result = new DataTable();
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = $"Select * from Food where Name LIKE N'%{name}%' ";
                adapter.SelectCommand = command;
                adapter.Fill(result);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        
    }
}
