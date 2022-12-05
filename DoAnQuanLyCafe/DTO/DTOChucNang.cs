using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyCafe.DTO
{
    internal class DTOChucNang
    {
        private int machucnang;
        private string tenchucnang;
        private string maloaitkdung;

        public DTOChucNang()
        {

        }
        public DTOChucNang(int machucnang, string tenchucnang, string maloaitkdung)
        {
            this.machucnang = machucnang;
            this.tenchucnang = tenchucnang;
            this.maloaitkdung = maloaitkdung;
        }   

        public int getMachucnang()
        {
            return machucnang;
        }
        public string getTenchucnang()
        {
            return tenchucnang;
        }
        public string getMaloaitkdung()
        {
            return maloaitkdung;
        }

        public void setMachucnang(int machucnang)
        {
            this.machucnang = machucnang;
        }
        public void setTenchucnang(string tenchucnang)
        {
            this.tenchucnang = tenchucnang;
        }
        public void setMaloaitkdung(string maloaitkdung)
        {
            this.maloaitkdung = maloaitkdung;
        }
    }
}
