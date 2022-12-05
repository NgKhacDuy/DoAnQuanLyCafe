using DoAnQuanLyCafe.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyCafe.DAO
{
    internal class DAOQuanLyTaiKhoan
    {
        //private SqlConnection con = new SqlConnection("Data Source=ADMIN\\XZEO;Initial Catalog=QuanLyQuanCaPhe;Integrated Security=True");
        private ConnectSQL ConnectSQL = new ConnectSQL();
        SqlConnection con;
        public ArrayList getAllTaiKhoan()
        {
            ArrayList arrTK = new ArrayList();
            try
            {
                con = ConnectSQL.GetConnection();

                String sql = "Select * from TAIKHOAN";
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader Sdr = command.ExecuteReader();
                while (Sdr.Read())
                {
                    DTOTaiKhoan tk = new DTOTaiKhoan();
                    tk.setTentaikhoan((string)Sdr["TenTaiKhoan"]);
                    tk.setMatkhau((string)Sdr["MatKhau"]);
                    tk.setMaLoaiTaiKhoan((int)Sdr["MaLoaiTaiKhoan"]);
                    arrTK.Add(tk);
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
            return arrTK;
        }

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

        public ArrayList getAllLoaiTK()
        {
            ArrayList arrLoaiTK = new ArrayList();
            try
            {
                con = ConnectSQL.GetConnection();

                String sql = "Select * from LOAITAIKHOAN";
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader Sdr = command.ExecuteReader();
                while (Sdr.Read())
                {
                    DTOLoaiTaiKhoan ltk = new DTOLoaiTaiKhoan();
                    ltk.setMaLoaiTaiKhoan((int)Sdr["MaLoaiTaiKhoan"]);
                    ltk.setTenLoaiTaiKhoan((string)Sdr["TenLoaiTaiKhoan"]);
                    arrLoaiTK.Add(ltk);
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
            return arrLoaiTK;
        }

        public bool ThemTaiKhoan(DTOTaiKhoan tk, DTONhanVien nv)
        {
            bool check = false;
            try
            {
                con = ConnectSQL.GetConnection();

                String sql = "INSERT INTO TAIKHOAN(TenTaiKhoan, MatKhau, MaLoaiTaiKhoan) VALUES ('" +
                tk.getTentaikhoan() + "','" + tk.getMatkhau() + "','" + tk.getMaLoaiTaiKhoan() + "')";
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    con.Close();
                    sql = "INSERT INTO NHANVIEN(MaNhanVien, CCCD, HoVaTen, GioiTinh, NTNS, DiaChi, SoDienThoai, TenTaiKhoan, AnhDaiDien, SoNgayLam, LuongCoBan, Thuong) VALUES ('" +
                        nv.getManhanvien() + "','" + nv.getCccd() + "','" + nv.getHovaten() + "','" + nv.getGioitinh() + "','" + nv.getNtns() + "','" + nv.getDiachi() + "','" +
                        nv.getSoienthoai() + "','" + nv.getTentaikhoan() + "','" + nv.getAnhdaidien() + "','" + nv.getSongaylam() + "','" + nv.getLuongcoban() + "','" + nv.getThuong() + "')";
                    command = new SqlCommand(sql, con);
                    con.Open();
                    if (command.ExecuteNonQuery() > 0)
                    {
                        check = true;
                    }
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

        public bool SuaTaiKhoan(DTOTaiKhoan tk)
        {
            bool check = false;
            try
            {
                con = ConnectSQL.GetConnection();

                String sql = "UPDATE TAIKHOAN SET MatKhau = '" + tk.getMatkhau() 
                    + "', MaLoaiTaiKhoan = '" + tk.getMaLoaiTaiKhoan() + "' WHERE TenTaiKhoan = '" + tk.getTentaikhoan() + "'";
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                if(command.ExecuteNonQuery() > 0)
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

        public bool XoaTaiKhoan(DTOTaiKhoan tk)
        {
            bool check = false;
            try
            {
                con = ConnectSQL.GetConnection();

                String sql = "DELETE FROM TAIKHOAN WHERE TenTaiKhoan = '" + tk.getTentaikhoan() + "'";
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    con.Close();
                    sql = "DELETE FROM NHANVIEN Where TenTaiKhoan = '" + tk.getTentaikhoan() + "'";
                    command = new SqlCommand(sql, con);
                    con.Open();
                    if (command.ExecuteNonQuery() > 0)
                    {
                        check = true;
                    }
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
