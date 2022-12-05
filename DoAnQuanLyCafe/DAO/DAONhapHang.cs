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
    internal class DAONhapHang
    {
        //private SqlConnection con = new SqlConnection("Data Source=ADMIN\\XZEO;Initial Catalog=DHCoffee;Integrated Security=True");
        private ConnectSQL ConnectSQL = new ConnectSQL();
        SqlConnection con;
        public ArrayList getAllNguyenLieu()
        {
            ArrayList arrNL = new ArrayList();
            try
            {
                con = ConnectSQL.GetConnection();

                String sql = "Select * from NGUYENLIEU";
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader Sdr = command.ExecuteReader();
                while (Sdr.Read())
                {
                    DTONguyenLieu nl = new DTONguyenLieu();
                    nl.setMaNL((int)Sdr["MaNL"]);
                    nl.setTenNL((string)Sdr["TenNL"]);
                    nl.setTonKho((int)Sdr["TonKho"]);
                    nl.setDonVi((string)Sdr["DonVi"]);
                    arrNL.Add(nl);
                }
                Sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return arrNL;
        }
        
        public bool NhapHang(DTOBienLai bl, ArrayList arrctbl, ArrayList arrnl)
        {

            bool check = false;
            try
            {
                con = ConnectSQL.GetConnection();

                String sql = "INSERT INTO BIENLAI(TongTien, NgayGio) VALUES ('" +
                bl.getTongtien() + "','" + bl.getNgaygio() + "')";
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                if (command.ExecuteNonQuery() > 0)
                {
                    con.Close();
                    int count = 0;
                    sql = "SELECT TOP(1) * FROM BIENLAI order by NgayGio desc";
                    command = new SqlCommand(sql, con);
                    con.Open();
                    SqlDataReader Sdr = command.ExecuteReader();
                    Sdr.Read();
                    int mablmoi = (int)Sdr["MaBL"];
                    Sdr.Close();
                    foreach(DTOChiTietBienLai ctbl in arrctbl)
                    {
                        ctbl.setMabienlai(mablmoi);
                        sql = "INSERT INTO CTBIENLAI(MaBL, MaNL, SoLuong) VALUES ('" +
                            ctbl.getMabienlai() + "','" + ctbl.getManl() + "','" + ctbl.getSoluong() +"')";
                        command = new SqlCommand(sql, con);
                        if(command.ExecuteNonQuery() > 0)
                        {
                            count += 1;
                        }
                    }
                    foreach (DTONguyenLieu nl in arrnl)
                    {
                        sql = "UPDATE NGUYENLIEU SET TonKho = TonKho + '" + nl.getTonKho() + "' WHERE MaNL = '" + nl.getMaNL() + "'";
                        command = new SqlCommand(sql, con);
                        if (command.ExecuteNonQuery() > 0)
                        {
                            count += 1;
                        }
                    }
                    if (count == arrctbl.Count*2)
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
