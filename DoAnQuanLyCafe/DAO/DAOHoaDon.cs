using DoAnQuanLyCafe.GUI;
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
    public class DAOHoaDon
    {
        private ConnectSQL ConnectSQL;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        

        public DataTable getHoaDon()
        {
            try
            {
                DataTable listHoaDon = new DataTable();
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = "Select MaHD,NgayGio,TongTien,MaBan from HOADON ";
                adapter.SelectCommand = command;
                adapter.Fill(listHoaDon);
                return listHoaDon;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public DataTable getCTHoaDon()
        {
            try
            {
                DataTable listHoaDon = new DataTable();
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = "Select MaHD,MaMon,SoLuong from CTHOADON ";
                adapter.SelectCommand = command;
                adapter.Fill(listHoaDon);
                return listHoaDon;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public DataTable getHoaDonFromDate(string firstDate, string secondDate)
        {

            try
            {
                
                DataTable listHoaDon = new DataTable();
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = $"select MaHD,NgayGio,TongTien,MaBan from HOADON where NgayGio >= '{firstDate}' and NgayGio <= '{secondDate}'";
                adapter.SelectCommand = command;
                adapter.Fill(listHoaDon);
                return listHoaDon;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public void insertHoaDon(int tongTien, string date,int MaBan) 
        {
            try
            {
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = $"insert into HOADON (TongTien,NgayGio,MaBan) values ({tongTien},'{date}',{MaBan})";
                adapter.SelectCommand = command;
                command.ExecuteReader();
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void insertCTHoaDon(int MaHD,int MaMon,int SoLuong) 
        {
            try
            {
                ConnectSQL = new ConnectSQL();
                SqlConnection con = ConnectSQL.GetConnection();
                con.Open();
                command = con.CreateCommand();
                command.CommandText = $"insert into CTHOADON (MaMon,MaHD,SoLuong) values ({MaMon},{MaHD},{SoLuong})";
                adapter.SelectCommand = command;
                command.ExecuteReader();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
