using DoAnQuanLyCafe.BUS;
using DoAnQuanLyCafe.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyCafe.GUI
{
    public partial class GUIPhanQuyen : Form
    {

        private BLLQuanLyPhanQuyen BLLQLPQ = new BLLQuanLyPhanQuyen();
        private string loaitaikhoandung = "";
        private ArrayList arrCN = new ArrayList();

        public GUIPhanQuyen()
        {
            InitializeComponent();
            LoadListView();
        }

        private void LoadListView()
        {
            lvChucNang.Items.Clear();
            arrCN = BLLQLPQ.getAllChucNang();
            foreach (DTOChucNang cn in arrCN)
            {
                string[] row = {
                    cn.getMachucnang().ToString(),
                    cn.getTenchucnang()
                };
                ListViewItem lvi = new ListViewItem(row);
                lvChucNang.Items.Add(lvi);
            }
        }

        private void resetCheckBox()
        {
            cb1.Checked = false;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = false;
        }

        private void lvChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvChucNang.SelectedItems.Count > 0)
            {
                resetCheckBox();
                foreach (DTOChucNang cn in arrCN)
                {
                    if (cn.getMachucnang() == Convert.ToInt32(lvChucNang.SelectedItems[0].SubItems[0].Text))
                    {
                        string getmaloaitkdung = cn.getMaloaitkdung();
                        string[] ssplit = getmaloaitkdung.Split(' ');
                        for (int i = 0; i < ssplit.Length; i++)
                        {
                            if (ssplit[i] == "1")
                            {
                                cb1.Checked = true;
                            }
                            if (ssplit[i] == "2")
                            {
                                cb2.Checked = true;
                            }
                            if (ssplit[i] == "3")
                            {
                                cb3.Checked = true;
                            }
                            if (ssplit[i] == "4")
                            {
                                cb4.Checked = true;
                            }
                        }
                    }
                }
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(lvChucNang.SelectedItems.Count <= 0)
            {
                MessageBox.Show("BẠN CHƯA CHỌN TÀI KHOẢN VÀ CHỨC NĂNG CẦN PHÂN QUYỀN!");
            }
            if(cb1.Checked == true)
            {
                loaitaikhoandung += "1 ";
            }
            if (cb2.Checked == true)
            {
                loaitaikhoandung += "2 ";
            }
            if (cb3.Checked == true)
            {
                loaitaikhoandung += "3 ";
            }
            if (cb4.Checked == true)
            {
                loaitaikhoandung += "4 ";
            }
            int ma = Convert.ToInt32(lvChucNang.SelectedItems[0].SubItems[0].Text);
            DTOChucNang cn = new DTOChucNang(ma, "", loaitaikhoandung);
            if (BLLQLPQ.CapNhatPhanQuyen(cn))
            {
                MessageBox.Show("CẬP NHẬT PHÂN QUYỀN THÀNH CÔNG!");
            }
            else
            {
                MessageBox.Show("CẬP NHẬT PHÂN QUYỀN THẤT BẠI!");
            }
            arrCN = BLLQLPQ.getAllChucNang();
            loaitaikhoandung = "";
        }
    }
}
