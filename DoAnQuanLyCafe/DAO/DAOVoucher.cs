using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyCafe.DAO
{
    public class DAOVoucher
    {
        private ConnectSQL ConnectSQL;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();

        public DataTable getVoucher()
        {
            try
            {
                DataTable listVoucher = new DataTable();
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = "Select * from VOUCHER";
                adapter.SelectCommand = command;
                adapter.Fill(listVoucher);
                return listVoucher;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public void insertVoucher(int id, string dateStart, string dateEnd, float percent, string tenVoucher)
        {
            try
            {
               
                    ConnectSQL = new ConnectSQL();
                    SqlConnection con = ConnectSQL.GetConnection();
                    con.Open();
                    command = con.CreateCommand();
                    command.CommandText = $"Insert into VOUCHER values ({id},'{dateStart}','{dateEnd}', {percent},N'{tenVoucher}')";
                    adapter.SelectCommand = command;
                    command.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void updateVoucher(int id, string dateStart, string dateEnd, float percent, string tenVoucher)
        {
            try
            {

                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = $"Update VOUCHER set NgayBatDau = '{dateStart}', NgayKetThuc = '{dateEnd}', PhanTramGiamGia ={percent}, TenVoucher = N'{tenVoucher}' where MaVC = {id} ";
                adapter.SelectCommand = command;
                command.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void deleteVoucher(int id)
        {
            try
            {

                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = $"Delete from VOUCHER where MaVC = {id}";
                adapter.SelectCommand = command;
                command.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public DataTable searchVoucherFromDate(string dateStart, string dateEnd)
        {
            try
            {
                
                DataTable listVoucher = new DataTable();
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = $"select * from VOUCHER where NgayBatDau >= '{dateStart}' and NgayKetThuc <= '{dateEnd}'";
                adapter.SelectCommand = command;
                adapter.Fill(listVoucher);
                return listVoucher;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public bool checkVoucher(int id)
        {
            try
            {
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = $"Select MaVC from VOUCHER where MaVC = {id}";
                adapter.SelectCommand = command;
                SqlDataReader reader;
                reader = command.ExecuteReader();
                if (reader.Read())
                    return true;
                else
                {
                    return false;
                }

            }

            catch(Exception ex)
            {
                return false;
            }
            return false;
        }

        public float getPercent(int id)
        {
            try
            {
                float percent = 0;
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = $"select PhanTramGiamGia from VOUCHER where MaVC = {id}";
                adapter.SelectCommand = command;
                SqlDataReader reader;
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    percent = Convert.ToSingle(reader["PhanTramGiamGia"]);
                }
                return percent;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

        public DataTable searchVoucherFromName(string name)
        {
            try
            {

                DataTable listVoucher = new DataTable();
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = $"select * from VOUCHER where TenVoucher Like N'%{name}%'";
                adapter.SelectCommand = command;
                adapter.Fill(listVoucher);
                return listVoucher;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
