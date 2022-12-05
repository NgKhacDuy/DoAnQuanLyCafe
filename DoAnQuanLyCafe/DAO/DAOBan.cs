using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyCafe.DAO
{
    public class DAOBan
    {
        private ConnectSQL ConnectSQL;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();

        public List<Button> getTable()
        {
            try
            {
                List<Button> list = new List<Button>();
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = "Select MaBan,TenBan From BAN ";
                SqlDataReader reader;
                reader= command.ExecuteReader();
                while(reader.Read())
                {
                    Button button= new Button();
                    button.Text = reader["TenBan"].ToString();
                    button.Name = reader["MaBan"].ToString();
                    button.Height = 100;
                    button.Width = 100;
                    button.Click += testButton;
                    button.BackColor = Color.White;
                    button.Font = new Font("Arial", 12,FontStyle.Bold);
                    list.Add(button);
                    
                }
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public void testButton(object sender, EventArgs e) { }

        public DataTable getTableDataTable()
        {
            try
            {
                DataTable listTable = new DataTable();
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = "Select MaBan,TenBan From BAN ";
                adapter.SelectCommand = command;
                adapter.Fill(listTable);
                return listTable;
            }
            catch
            {

            }
            return null;
        }

        public void InsertTable(string name)
        {
            try
            {
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                // giá trị mặc định của TableID và status là 1 và 0, CheckOut mặc định là NUll;
                command.CommandText = $"insert into BAN(TenBan) values ({name})";
                adapter.SelectCommand = command;
                command.ExecuteReader();
            }
            catch
            {

            }
        }

        public void UpdateTable(int id, string name)
        {
            try
            {
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                // giá trị mặc định của TableID và status là 1 và 0, CheckOut mặc định là NUll;
                command.CommandText = $"update BAN set TenBan = N'{name}' where MaBan={id}";
                adapter.SelectCommand = command;
                command.ExecuteReader();
            }
            catch
            {

            }
        }

        public void DeleteTable(int id)
        {
            try
            {
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                // giá trị mặc định của TableID và status là 1 và 0, CheckOut mặc định là NUll;
                command.CommandText = $"delete from BAN where MaBan = {id}";
                adapter.SelectCommand = command;
                command.ExecuteReader();
            }
            catch
            {

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
                command.CommandText = $"Select MaBan,TenBan from Ban where TenBan LIKE N'%{name}%' ";
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
