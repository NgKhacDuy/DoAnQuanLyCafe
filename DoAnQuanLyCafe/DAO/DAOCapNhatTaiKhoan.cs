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
    internal class DAOCapNhatTaiKhoan
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
                while(Sdr.Read())
                {
                    DTOTaiKhoan tk = new DTOTaiKhoan();
                    tk.setTentaikhoan((string)Sdr["TenTaiKhoan"]);
                    tk.setMatkhau((string)Sdr["MatKhau"]);
                    tk.setMaLoaiTaiKhoan((int)Sdr["MaLoaiTaiKhoan"]);
                    arrTK.Add(tk);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
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
                    nv.setCccd((string)Sdr["CCCD"]);
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

        public bool CapNhatTaiKhoan(DTOTaiKhoan tk)
        {
            bool status = false;
            try
            {
                con = ConnectSQL.GetConnection();

                string tentaikhoan = tk.getTentaikhoan();
                string matkhau = tk.getMatkhau();
                int maloaitaikhoan = tk.getMaLoaiTaiKhoan();
                String sql = "UPDATE TAIKHOAN SET MatKhau = '" + matkhau +
                            "', MaLoaiTaiKhoan = '" + maloaitaikhoan + 
                            "' WHERE TenTaiKhoan = '" + tentaikhoan + "'";
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                if(command.ExecuteNonQuery()>0)
                {
                    status = true;
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
            return status;
        }

        public bool CapNhatTTCN(DTONhanVien nv)
        {
            bool status = false;
            try
            {
                con = ConnectSQL.GetConnection();

                String sql = "UPDATE NHANVIEN SET CCCD = '" + nv.getCccd() +
                            "', HoVaTen = '" + nv.getHovaten() +
                            "', GioiTinh = '" + nv.getGioitinh() +
                            "', NTNS = '" + nv.getNtns() +
                            "', DiaChi = '" + nv.getDiachi() +
                            "', SoDienThoai = '" + nv.getSoienthoai() +
                            "', TenTaiKhoan = '" + nv.getTentaikhoan() +
                            "', AnhDaiDien = '" + nv.getAnhdaidien() +
                            "' WHERE MaNhanVien = '" + nv.getManhanvien() + "'";
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    status = true;
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
            return status;
        }
    }
}
