using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyCafe.DAO
{
    public class DAODanhMuc
    {
        private ConnectSQL ConnectSQL;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlDataReader Reader;
        public DataTable getDanhMuc()
        {
            try
            {
                DataTable listDanhMuc = new DataTable();
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = "Select * from CategoryFood";
                adapter.SelectCommand = command;
                adapter.Fill(listDanhMuc);
                return listDanhMuc;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public bool checkDuplicate(string name) {
            
            ConnectSQL = new ConnectSQL();
            SqlConnection con = ConnectSQL.GetConnection();
            con.Open();
            command = con.CreateCommand();
            command.CommandText = $"select Name from CategoryFood where Name = '{name}' ";
            SqlDataReader reader;
            reader=command.ExecuteReader();
            if(reader.Read())
                return true;
            else
            {
                return false;
            }
            
        }

        public void insertDanhMuc(string name)
        {
            try
            {
                if (!checkDuplicate(name)){
                    ConnectSQL = new ConnectSQL();
                    SqlConnection con = ConnectSQL.GetConnection();
                    con.Open();
                    command = con.CreateCommand();
                    command.CommandText = $"Insert into CategoryFood (Name) values (N'{name}')";
                    adapter.SelectCommand = command;
                    command.ExecuteReader();
                }
                else
                {
                    
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void updateDanhMuc(int id, string name)
        {
            try
            {
                if (!checkDuplicate(name)) { 
                    ConnectSQL = new ConnectSQL();
                    SqlConnection con = ConnectSQL.GetConnection();
                    con.Open();
                    command = con.CreateCommand();
                    command.CommandText = $"Update CategoryFood set Name = N'{name}' where ID = {id}";
                    adapter.SelectCommand = command;
                    command.ExecuteReader();
                }
                
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void deleteDanhMuc(int id)
        {
            try
            {
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = $"Delete from CategoryFood where ID = {id}";
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
                command.CommandText = $"Select * from CategoryFood where Name LIKE N'%{name}%' ";
                adapter.SelectCommand = command;
                adapter.Fill(result);
                return result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public int findIDbyName(string name)
        {
            try
            {
                int id = 0 ;
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText =  "select CategoryFood.ID " +
                                        "from CategoryFood " +
                                        $"where Name = N'{name}' ";
                Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    id= Reader.GetInt32(0);
                    
                }

                return id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

        public string findNamebyID(string id)
        {
                string name = "";
            try
            {
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = "select CategoryFood.Name " +
                                        "from CategoryFood " +
                                        $"where ID = N'{id}' ";
                Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    id = Reader.GetString(0);

                }

                return name;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return name;
        }

        public DataTable GetAllName()
        {
            try
            {
                DataTable result = new DataTable();
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = "select CategoryFood.Name " +
                                        "from CategoryFood";
                                        
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
