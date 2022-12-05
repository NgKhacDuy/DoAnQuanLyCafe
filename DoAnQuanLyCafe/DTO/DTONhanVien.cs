using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyCafe.DTO
{
    internal class DTONhanVien
    {
        private int manhanvien;
        private string cccd;
        private string hovaten;
        private string gioitinh;
        private string ntns;
        private string diachi;
        private string sodienthoai;
        private string tentaikhoan;
        private string anhdaidien;
        private int songaylam;
        private decimal luongcoban;
        private decimal thuong;

        public DTONhanVien()
        {
        }

        public DTONhanVien(int manhanvien, string cccd, string hovaten, string gioitinh, string ntns, string diachi, string sodienthoai, string tentaikhoan, string anhdaidien, int songaylam, decimal luongcoban, decimal thuong)
        {
            this.manhanvien = manhanvien;
            this.cccd = cccd;
            this.hovaten = hovaten;
            this.gioitinh = gioitinh;
            this.ntns = ntns;
            this.diachi = diachi;
            this.sodienthoai = sodienthoai;
            this.tentaikhoan = tentaikhoan;
            this.anhdaidien = anhdaidien;
            this.songaylam = songaylam;
            this.luongcoban = luongcoban;
            this.thuong = thuong;
        }

        public int getManhanvien()
        {
            return manhanvien;
        }
        public string getCccd()
        {
            return cccd;
        }
        public string getHovaten()
        {
            return hovaten;
        }
        public string getGioitinh()
        {
            return gioitinh;
        }
        public string getNtns()
        {
            return ntns;
        }
        public string getDiachi()
        {
            return diachi;
        }
        public string getSoienthoai()
        {
            return sodienthoai;
        }
        public string getTentaikhoan()
        {
            return tentaikhoan;
        }
        public string getAnhdaidien()
        {
            return anhdaidien;
        }
        public int getSongaylam()
        {
            return songaylam;
        }
        public decimal getLuongcoban()
        {
            return luongcoban;
        }
        public decimal getThuong()
        {
            return thuong;
        }


        public void setManhanvien(int manhanvien)
        {
            this.manhanvien = manhanvien;
        }
        public void setCccd(string cccd)
        {
            this.cccd = cccd;
        }
        public void setHovaten(string hovaten)
        {
            this.hovaten = hovaten;
        }
        public void setGioitinh(string gioitinh)
        {
            this.gioitinh = gioitinh;
        }
        public void setNtns(string ntns)
        {
            this.ntns = ntns;
        }
        public void setDiachi(string diachi)
        {
            this.diachi = diachi;
        }
        public void setSodienthoai(string sodienthoai)
        {
            this.sodienthoai = sodienthoai;
        }
        public void setTentaikhoan(string tentaikhoan)
        {
            this.tentaikhoan = tentaikhoan;
        }
        public void setAnhdaidien(string anhdaidien)
        {
            this.anhdaidien = anhdaidien;
        }
        public void setSongaylam(int songaylam)
        {
            this.songaylam = songaylam;
        }
        public void setLuongcoban(decimal luongcoban)
        {
            this.luongcoban = luongcoban;
        }
        public void setThuong(decimal thuong)
        {
            this.thuong = thuong;
        }
    }
}
