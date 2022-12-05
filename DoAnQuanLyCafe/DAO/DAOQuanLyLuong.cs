using DoAnQuanLyCafe.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyCafe.DAO
{
    internal class DAOQuanLyLuong
    {
        //private SqlConnection con = new SqlConnection("Data Source=ADMIN\\XZEO;Initial Catalog=QuanLyQuanCaPhe;Integrated Security=True");
        private ConnectSQL ConnectSQL = new ConnectSQL();
        SqlConnection con;
        public ArrayList getALlNhanVien()
        {
            ArrayList arrNV = new ArrayList();
            try
            {
                con = ConnectSQL.GetConnection();

                String sql = "Select * from NHANVIEN";
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader Sdr = command.ExecuteReader();
                while (Sdr.Read())
                {
                    DTONhanVien nv = new DTONhanVien();
                    nv.setManhanvien((int)Sdr["MaNhanVien"]);
                    nv.setCccd((string)Sdr["Cccd"]);
                    nv.setHovaten((string)Sdr["HoVaTen"]);
                    nv.setGioitinh((string)Sdr["GioiTinh"]);
                    nv.setNtns((string)Sdr["NTNS"]);
                    nv.setDiachi((string)Sdr["DiaChi"]);
                    nv.setSodienthoai((string)Sdr["SoDienThoai"]);
                    nv.setTentaikhoan((string)Sdr["TenTaiKhoan"]);
                    nv.setAnhdaidien((string)Sdr["AnhDaiDien"]);
                    nv.setSongaylam((int)Sdr["SoNgayLam"]);
                    nv.setLuongcoban((decimal)Sdr["LuongCoBan"]);
                    nv.setThuong((decimal)Sdr["Thuong"]);
                    arrNV.Add(nv);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return arrNV;
        }

        public bool TinhLuong(DTONhanVien nv)
        {
            bool check = false;
            try
            {
                con = ConnectSQL.GetConnection();

                String sql = "UPDATE NHANVIEN SET SoNgayLam = '0' WHERE MaNhanVien = '" + nv.getManhanvien() + "'";
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    check = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return check;
        }

        public bool SuaLuong(DTONhanVien nv)
        {
            bool check = false;
            try
            {
                con = ConnectSQL.GetConnection();

                String sql = "UPDATE NHANVIEN SET LuongCoBan = '" + nv.getLuongcoban()
                    + "', Thuong = '" + nv.getThuong() + "' WHERE MaNhanVien = '" + nv.getManhanvien() + "'";
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    check = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return check;
        }
    }
}
