using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyCafe.DTO
{
    internal class DTONguyenLieu
    {
        private int manl;
        private string tennl;
        private int tonkho;
        private string donvi;

        public DTONguyenLieu ()
        {

        }
        public DTONguyenLieu(int manl, string tennl, int tonkho, string donvi)
        {
            this.manl = manl;
            this.tennl = tennl;
            this.tonkho = tonkho;
            this.donvi = donvi;
        }   

        public int getMaNL()
        {
            return manl;
        }
        public string getTenNL()
        {
            return tennl;
        }
        public int getTonKho()
        {
            return tonkho;
        }
        public string getDonVi()
        {
            return donvi;
        }

        public void setMaNL(int manl)
        {
            this.manl = manl;
        }
        public void setTenNL(string tennl)
        {
            this.tennl = tennl;
        }
        public void setTonKho(int tonkho)
        {
            this.tonkho = tonkho;
        }
        public void setDonVi(string donvi)
        {
            this.donvi = donvi;
        }
    }
}
