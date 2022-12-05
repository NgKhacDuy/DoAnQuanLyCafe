using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyCafe.DTO
{
    internal class DTOKiemKho
    {
        private int MaNL;
        private string TenNL;
        private int TonKho = 0;
        private string DonVi;
        public DTOKiemKho() { }
        public DTOKiemKho(int MaNL, string TenNL, int TonKho, string DonVi)
        {
            this.MaNL = MaNL;
            this.TenNL = TenNL;
            this.TonKho = TonKho;
            this.DonVi = DonVi;

        }
        public int getMaNL()
        {
            return MaNL;
        }
        public string getTenNL()
        {
            return TenNL;
        }
        public int getTonKho()
        {
            return TonKho;
        }
        public string getDonVi()
        {
            return DonVi;
        }
        public void setMaNL(int MaNL)
        {
            this.MaNL = MaNL;
        }
        public void setTenNL(string TenNL)
        {
            this.TenNL = TenNL;
        }
        public void setTonKho(int TonKho)
        {
            this.TonKho = TonKho;
        }
        public void setDonVi(string DonVi)
        {
            this.DonVi = DonVi;
        }
    }
}
