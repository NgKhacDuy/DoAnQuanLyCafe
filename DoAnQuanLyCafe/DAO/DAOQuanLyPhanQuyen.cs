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
    internal class DAOQuanLyPhanQuyen
    {
        //private SqlConnection con = new SqlConnection("Data Source=ADMIN\\XZEO;Initial Catalog=DHCoffee;Integrated Security=True");
        private ConnectSQL ConnectSQL = new ConnectSQL();
        SqlConnection con;
        public ArrayList getAllChucNang()
        {
            ArrayList arrCN = new ArrayList();
            try
            {
                con = ConnectSQL.GetConnection();

                String sql = "Select * from CHUCNANG";
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader Sdr = command.ExecuteReader();
                while (Sdr.Read())
                {
                    DTOChucNang cn = new DTOChucNang();
                    cn.setMachucnang((int)Sdr["MaChucNang"]);
                    cn.setTenchucnang((string)Sdr["TenChucNang"]);
                    cn.setMaloaitkdung((string)Sdr["MaLoaiTKDung"]);
                    arrCN.Add(cn);
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
            return arrCN;
        }

        public bool CapNhatPhanQuyen(DTOChucNang cn)
        {
            bool check = false;
            try
            {
                con = ConnectSQL.GetConnection();

                String sql = "UPDATE CHUCNANG SET MaLoaiTKDung = '" + cn.getMaloaitkdung() + "' WHERE MaChucNang = '" + cn.getMachucnang() + "'";
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
