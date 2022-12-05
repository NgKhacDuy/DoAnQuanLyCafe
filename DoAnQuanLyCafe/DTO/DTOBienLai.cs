using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyCafe.DTO
{
    internal class DTOBienLai
    {
        private int mabienlai;
        private decimal tongtien;
        private DateTime ngaygio;

        public DTOBienLai()
        {

        }
        public DTOBienLai(int mabienlai, decimal tongtien, DateTime ngaygio)
        {
            this.mabienlai = mabienlai;
            this.tongtien = tongtien;
            this.ngaygio = ngaygio;
        }

        public int getMabienlai()
        {
            return mabienlai;
        }
        public decimal getTongtien()
        {
            return tongtien;
        }
        public DateTime getNgaygio()
        {
            return ngaygio;
        }

        public void setMabienlai(int mabienlai) 
        {
            this.mabienlai = mabienlai;
        }
        public void setTongtien(decimal tongtien)
        {
            this.tongtien = tongtien;
        }
        public void setNgaygio(DateTime ngaygio)
        {
            this.ngaygio = ngaygio;
        }
    }
}
