using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnQuanLyCafe.DTO;
using System.Collections;
using System.Drawing;

namespace DoAnQuanLyCafe.DAO
{
    internal class DAOKiemKho
    {
        public ArrayList getAllNguyenLieu()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-841FQQB;Initial Catalog=DHCoffee;Integrated Security=True;trusted_connection=true;encrypt=false")) //Sửa chỗ này
            {
                ArrayList arrKho = new ArrayList();
                try
                {
                    String sql = "SELECT * FROM NGUYENLIEU";
                    SqlCommand command = new SqlCommand(sql, conn);
                    conn.Open();
                    SqlDataReader Sdr = command.ExecuteReader();
                    while (Sdr.Read())
                    {
                        DTO.DTOKiemKho kho = new DTO.DTOKiemKho();
                        kho.setMaNL((int)Sdr["MaNL"]);
                        kho.setTenNL((string)Sdr["TenNL"]);
                        kho.setTonKho((int)Sdr["TonKho"]);
                        kho.setDonVi((string)Sdr["DonVi"]);
                        arrKho.Add(kho);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                return arrKho;
            }
        }
        public DataTable getListViewTable()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-841FQQB;Initial Catalog=DHCoffee;Integrated Security=True;trusted_connection=true;encrypt=false")) //Sửa chỗ này
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM NGUYENLIEU";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        return dt;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
            return null;
        }
        public bool updateData(DTO.DTOKiemKho DTO)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-841FQQB;Initial Catalog=DHCoffee;Integrated Security=True;trusted_connection=true;encrypt=false")) //Sửa chỗ này
            {
                bool status = false;
                try
                {
                    conn.Open();
                    string sql = "UPDATE NGUYENLIEU SET TenNL = N'" + DTO.getTenNL() + "', TonKho = " + DTO.getTonKho()+ ", DonVi = N'" + DTO.getDonVi() + "'  WHERE MaNL = " + DTO.getMaNL();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    if (cmd.ExecuteNonQuery() > 0)
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
                    conn.Close();
                }
                return status;
            }

        }
        public bool updateTonKho(DTO.DTOKiemKho DTO)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-841FQQB;Initial Catalog=DHCoffee;Integrated Security=True;trusted_connection=true;encrypt=false")) //Sửa chỗ này
            {
                bool status = false;
                try
                {
                    conn.Open();
                    string sql = "UPDATE NGUYENLIEU SET TonKho = " + DTO.getTonKho()+ "  WHERE MaNL = " + DTO.getMaNL();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    if (cmd.ExecuteNonQuery() > 0)
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
                    conn.Close();
                }
                return status;
            }

        }
        public bool deleteData(DTO.DTOKiemKho DTO)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-841FQQB;Initial Catalog=DHCoffee;Integrated Security=True;trusted_connection=true;encrypt=false")) //Sửa chỗ này
            {
                bool status = false;
                try
                {
                    conn.Open();
                    string sql = "DELETE FROM NGUYENLIEU WHERE MaNL = " + DTO.getMaNL();
                    //string sql = "SELECT * FROM DoanhThu WHERE MONTH(Date) = " + Thang + " AND YEAR(Date) = " + Nam + " ORDER BY MONTH(Date) ASC";s
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    if (cmd.ExecuteNonQuery() > 0)
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
                    conn.Close();
                }
                return status;
            }

        }
        public bool insertData(DTO.DTOKiemKho DTO)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-841FQQB;Initial Catalog=DHCoffee;Integrated Security=True;trusted_connection=true;encrypt=false")) //Sửa chỗ này
            {
                bool status = false;
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO NGUYENLIEU VALUES ( N'" + DTO.getMaNL() + "', N'" + DTO.getTenNL() + "', " + DTO.getTonKho() + ", N'" + DTO.getDonVi() + "')";
                    //string sql = "SELECT * FROM DoanhThu WHERE MONTH(Date) = " + Thang + " AND YEAR(Date) = " + Nam + " ORDER BY MONTH(Date) ASC";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    if (cmd.ExecuteNonQuery() > 0)
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
                    conn.Close();
                }
                return status;
            }
        }

    }
}
