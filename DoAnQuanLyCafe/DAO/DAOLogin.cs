using DoAnQuanLyCafe.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyCafe.DAO
{
    internal class DAOLogin
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

        public int checkTaiKhoan(String taikhoannhap, String matkhaunhap)
        {
            con = ConnectSQL.GetConnection();

            ArrayList arrtk = getAllTaiKhoan();
            int checktk = 0;
            foreach(DTOTaiKhoan tk in arrtk)
            {
                if(tk.getTentaikhoan() == taikhoannhap)
                {
                    checktk = 1;
                    if (tk.getMatkhau() == matkhaunhap)
                    {
                        checktk = 2;
                    }
                    break;
                }
            }
            return checktk;
            /*
                0: Khong tim thay tai khoan
                1: Tim thay tai khoan nhung sai mat khau
                2: Dung tai khoan va mat khau
             */
        }

        public int getLoaiTaiKhoan(String taikhoannhap)
        {

            int maloaitaikhoan = 0;
            try
            {
                con = ConnectSQL.GetConnection();

                String sql = "Select * from TAIKHOAN WHERE TenTaiKhoan = '" + taikhoannhap + "'";
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader Sdr = command.ExecuteReader();
                Sdr.Read();
                maloaitaikhoan = (int)Sdr["MaLoaiTaiKhoan"];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
            return maloaitaikhoan;
        }


        public int checkDangNhap(String taikhoannhap, String matkhaunhap)
        {
            con = ConnectSQL.GetConnection();

            int checktk = checkTaiKhoan(taikhoannhap, matkhaunhap);
            if (checktk == 2)
            {
                return getLoaiTaiKhoan(taikhoannhap) + 1;
            }
            return checktk;
            /*
                0: Khong tim thay ten tai khoan
                1: Sai mat khau
                2: Dang nhap bang admin
                3: Dang nhap bang nhan vien ban
                4: Dang nhap bang nhan vien kho
             */
        }
    }
}
