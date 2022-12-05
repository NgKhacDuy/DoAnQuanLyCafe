using DoAnQuanLyCafe.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DoAnQuanLyCafe.BUS
{
    internal class BLLLogin
    {
        DAOLogin DAOlogin = new DAOLogin();

        public int checkDangNhap(String taikhoannhap, String matkhaunhap)
        {
            return DAOlogin.checkDangNhap(taikhoannhap, matkhaunhap);
        }
    }
}
