using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyCafe.DTO
{
    internal class DTOChiTietBienLai
    {
        private int mabienlai;
        private int manl;
        private int soluong;

        public DTOChiTietBienLai()
        {

        }
        public DTOChiTietBienLai(int mabienlai, int manl, int soluong)
        {
            this.mabienlai = mabienlai;
            this.manl = manl;
            this.soluong = soluong;
        }

        public int getMabienlai()
        {
            return mabienlai;
        }
        public int getManl()
        {
            return manl;
        }
        public int getSoluong()
        {
            return soluong;
        }

        public void setMabienlai(int mabienlai)
        {
            this.mabienlai = mabienlai;
        }
        public void setManl(int manl)
        {
            this.manl = manl;
        }
        public void setSoluong(int soluong)
        {
            this.soluong = soluong;
        }
    }
}
