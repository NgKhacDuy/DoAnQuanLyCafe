
using System;
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
    public partial class Main : Form
    {
        public Point mouseLocation;
        public Main()
        {
            InitializeComponent();
            loadForm(new GUITacVu());
        }

        public void loadForm(object Form)
        {
            if (panelMain.Controls.Count > 0)
            {
                panelMain.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        public void loadLoaiMon()
        {
            loadForm(new GUIDanhMuc());
        }

        private void changeButtonBG(object sender, EventArgs e)
        {
            foreach(Control c in panelButton.Controls)
            {
                c.BackColor = Color.FromArgb(50, 49, 69);
                c.ForeColor = Color.White;
            }
            Control click = (Control)sender;
            click.BackColor = Color.White;
            click.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeButtonBG(btnTacVu, null);
            loadForm(new GUITacVu());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //changeButtonBG(button2, null);
            loadForm(new GUIDanhMuc());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            changeButtonBG(button3, null);
            loadForm(new GUIMon());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            changeButtonBG(button4, null);
            loadForm(new GUIVoucher());
        }
        private void button5_Click(object sender, EventArgs e)
        {
            changeButtonBG(sender, null);
            loadForm(new GUIKiemKho());
        }
        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            changeButtonBG(button7, null);
            loadForm(new GUIQuanLyTaiKhoan());
        }
        private void button8_Click(object sender, EventArgs e)
        {
            changeButtonBG(button8,null);
            loadForm(new GUIThongKe());
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation=new Point(-e.X, -e.Y);
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            //System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void panelButton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            changeButtonBG(sender, null);
            loadForm(new GUIDanhMuc());
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            GUILogin login = new GUILogin();
            changeButtonBG(sender, null);
            loadForm(new GUICapNhatTaiKhoan(login.getTKNhap()));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            changeButtonBG(sender, null);
            loadForm(new GUIQuanLyLuong());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            changeButtonBG(sender, null);
            loadForm(new GUINhapHang());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            changeButtonBG(sender, null);
            loadForm(new GUIPhanQuyen());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            changeButtonBG(sender, null);
            loadForm(new GUIBan());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            changeButtonBG(sender, null);
            loadForm(new GUIHoaDon());
        }
    }
}
