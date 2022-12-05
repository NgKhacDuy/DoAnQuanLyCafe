using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace DoAnQuanLyCafe
{
    public partial class GUIThongKe : Form
    {
        String strCon = @"Data Source=DESKTOP-841FQQB;Initial Catalog=DHCoffee;Integrated Security=True;trusted_connection=true;encrypt=false";
        SqlConnection sqlCon = null;

        // Khai bao bien chua du lieu tu combobox
        String dataYear;
        String dataMonth;
        String dataDay;
        String dataTop;
        public GUIThongKe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InsertYear(); // insert datacombox Nam khi loaad form
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cboYear.SelectedItem != null && cboMonth.SelectedItem != null && cboTop.SelectedItem != null && cboDay.SelectedItem != null)
            {
                DisplayCharDay();
            }

            if (cboYear.SelectedItem != null && cboMonth.SelectedItem != null && cboTop.SelectedItem != null)
            {
                DisplayCharMonth();
            }

            if (cboYear.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn năm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (cboMonth.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn tháng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (cboTop.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn Top", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Ham khoi tao va mo ket noi
        private void CreateAndOpenDB()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }
        
        // Do du lieu tu Database vao combobox nam
        private void InsertYear()
        {
            CreateAndOpenDB();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select YEAR(NgayGio) as Nam from HOADON\r\ngroup by YEAR(NgayGio)\r\norder by YEAR(NgayGio) asc";

            cmd.Connection = sqlCon;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int year = reader.GetInt32(0);
                cboYear.Items.Add(year.ToString());
            }

            reader.Close();
            sqlCon.Close();
        }

        // Do du lieu tu Database vao combobox ngay
        private void InsertDay()
        {
            CreateAndOpenDB();

            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "\r\nselect DAY(NgayGio) as Ngay from HOADON where MONTH(NgayGio) = " + dataMonth + " and YEAR(NgayGio) = " + dataYear + "\r\ngroup by DAY(NgayGio)\r\norder by Ngay asc";

            cmd.Connection = sqlCon;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int day = reader.GetInt32(0);
                cboDay.Items.Add(day.ToString());
            }

            reader.Close();
            sqlCon.Close();
        }


        // Lay du lieu nam tu combobox
        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataYear = (String)cboYear.SelectedItem;
        }
        // Lay du lieu thang tu combobox
        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataMonth= (String)cboMonth.SelectedItem;

            if (cboYear.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn năm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cboDay.Items.Clear();
                InsertDay();
            }
        }
        // Lay du lieu ngay tu combox
        private void cboDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataDay= (String)cboDay.SelectedItem;
        }
        // Lay du lieu Top tu combo box
        private void cboTop_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataTop = (String)cboTop.SelectedItem;
        }


        // Ham hien thi char theo ngay
        private void DisplayCharDay()
        {
            ResetChart();
            CreateAndOpenDB();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top(" + dataTop + ") m.MaMon, m.TenMon, SUM(c.SoLuong) from HOADON as h, CTHOADON as c,MON as m\r\nwhere h.MaHD = c.MaHD and c.MaMon = m.MaMon and YEAR(h.NgayGio) = " + dataYear + " and MONTH(h.NgayGio) = " + dataMonth + " and DAY(h.NgayGio) = " + dataDay + "\r\ngroup by m.MaMon, m.TenMon\r\norder by SUM(c.SoLuong) desc";

            cmd.Connection = sqlCon;

            SqlDataReader reader = cmd.ExecuteReader();

            bool status = false;
            while (reader.Read())
            {
                status = true;
                int MaMon = reader.GetInt32(0);
                String TenMon = reader.GetString(1);
                int SoLuongBanRa = reader.GetInt32(2);

                chartTop.Series["Số lượng bán ra"].Points.AddXY(TenMon, SoLuongBanRa);
            }

            if (status == false)
            {
                MessageBox.Show("Bạn chưa chọn năm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            reader.Close();

            sqlCon.Close();
        }

        //Ham hien thi char theo thang
        private void DisplayCharMonth()
        {
            ResetChart();
            CreateAndOpenDB();

            bool status = false;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top(" + dataTop + ") m.MaMon, m.TenMon, SUM(c.SoLuong) from HOADON as h, CTHOADON as c,MON as m\r\nwhere h.MaHD = c.MaHD and c.MaMon = m.MaMon and YEAR(h.NgayGio) = " + dataYear + " and MONTH(h.NgayGio) = " + dataMonth + "\r\ngroup by m.MaMon, m.TenMon\r\norder by SUM(c.SoLuong) desc";

            cmd.Connection = sqlCon;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                status = true;
                int MaMon = reader.GetInt32(0);
                String TenMon = reader.GetString(1);
                int SoLuongBanRa = reader.GetInt32(2);

                chartTop.Series["Số lượng bán ra"].Points.AddXY(TenMon, SoLuongBanRa);
            }

            if (status == false)
            {
                MessageBox.Show("Không có dữ liệu");
            }

            reader.Close();

            sqlCon.Close();
        }

        // Ham reset chart khi nhan Submit
        private void ResetChart()
        {
            foreach (var series in chartTop.Series)
            {
                series.Points.Clear();
            }
        }

        
        

    }
}
