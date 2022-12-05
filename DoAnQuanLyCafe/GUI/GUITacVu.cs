
using DoAnQuanLyCafe.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace DoAnQuanLyCafe.GUI
{
    public partial class GUITacVu : Form
    {
        BUSBan BUSBan = new BUSBan();
        BUSTacVu BUSTacVu = new BUSTacVu();
        BUSHoaDon BUSBill = new BUSHoaDon();
        List<Button> listButton = new List<Button>();
        decimal price = 0;
        private Control button_sender = (Control)null;
        List<ListViewItem> lvTable = new List<ListViewItem>();
        List<ListViewItem> lvItem = new List<ListViewItem>(20);
        




        bool checkDeleteFirstRowListView = false;
        public GUITacVu()
        {
            InitializeComponent();
            loadCategory();
            loadTable();
            createListViewItem();
            resizeListView();
        }

        private void GUITacVu_Load(object sender, EventArgs e)
        {
           
        }
        //private void Button_Click(Object sender, EventArgs e)
        //{
        //    var btn = (Button)sender;
        //    switch (btn.Name)
        //    {
        //        case "btn_Ban1":
        //            if (btn_Ban1.BackColor == Color.SpringGreen)
        //            {
        //                this.btn_Ban1.BackColor = Color.Blue;
        //            }
        //            else
        //            {
        //                this.btn_Ban1.BackColor = Color.SpringGreen;
        //            }
        //            if (btn_Ban2.BackColor == Color.Blue || btn_Ban3.BackColor == Color.Blue || btn_Ban4.BackColor == Color.Blue || btn_Ban5.BackColor == Color.Blue || btn_Ban6.BackColor == Color.Blue || btn_Ban7.BackColor == Color.Blue || btn_Ban8.BackColor == Color.Blue || btn_Ban9.BackColor == Color.Blue || btn_Ban10.BackColor == Color.Blue || btn_Ban11.BackColor == Color.Blue || btn_Ban12.BackColor == Color.Blue || btn_Ban13.BackColor == Color.Blue || btn_Ban14.BackColor == Color.Blue || btn_Ban15.BackColor == Color.Blue)
        //            {
        //                MessageBox.Show("Bạn đang chọn cùng lúc 2 bàn ! Vui lòng bỏ chọn 1 bàn");
        //                this.btn_Ban1.BackColor = Color.SpringGreen;
        //            }
        //            break;
        //        case "btn_Ban2":
        //            if (btn_Ban2.BackColor == Color.SpringGreen)
        //            {
        //                this.btn_Ban2.BackColor = Color.Blue;
        //            }
        //            else
        //            {
        //                this.btn_Ban2.BackColor = Color.SpringGreen;
        //            }
        //            if (btn_Ban1.BackColor == Color.Blue || btn_Ban3.BackColor == Color.Blue || btn_Ban4.BackColor == Color.Blue || btn_Ban5.BackColor == Color.Blue || btn_Ban6.BackColor == Color.Blue || btn_Ban7.BackColor == Color.Blue || btn_Ban8.BackColor == Color.Blue || btn_Ban9.BackColor == Color.Blue || btn_Ban10.BackColor == Color.Blue || btn_Ban11.BackColor == Color.Blue || btn_Ban12.BackColor == Color.Blue || btn_Ban13.BackColor == Color.Blue || btn_Ban14.BackColor == Color.Blue || btn_Ban15.BackColor == Color.Blue)
        //            {
        //                MessageBox.Show("Bạn đang chọn cùng lúc 2 bàn ! Vui lòng bỏ chọn 1 bàn");
        //                this.btn_Ban2.BackColor = Color.SpringGreen;
        //            }
        //            break;
        //        case "btn_Ban3":
        //            if (btn_Ban3.BackColor == Color.SpringGreen)
        //            {
        //                this.btn_Ban3.BackColor = Color.Blue;
        //            }
        //            else
        //            {
        //                this.btn_Ban3.BackColor = Color.SpringGreen;
        //            }
        //            if (btn_Ban1.BackColor == Color.Blue || btn_Ban2.BackColor == Color.Blue || btn_Ban4.BackColor == Color.Blue || btn_Ban5.BackColor == Color.Blue || btn_Ban6.BackColor == Color.Blue || btn_Ban7.BackColor == Color.Blue || btn_Ban8.BackColor == Color.Blue || btn_Ban9.BackColor == Color.Blue || btn_Ban10.BackColor == Color.Blue || btn_Ban11.BackColor == Color.Blue || btn_Ban12.BackColor == Color.Blue || btn_Ban13.BackColor == Color.Blue || btn_Ban14.BackColor == Color.Blue || btn_Ban15.BackColor == Color.Blue)
        //            {
        //                MessageBox.Show("Bạn đang chọn cùng lúc 2 bàn ! Vui lòng bỏ chọn 1 bàn");
        //                this.btn_Ban3.BackColor = Color.SpringGreen;
        //            }
        //            break;
        //        case "btn_Ban4":
        //            if (btn_Ban4.BackColor == Color.SpringGreen)
        //            {
        //                this.btn_Ban4.BackColor = Color.Blue;
        //            }
        //            else
        //            {
        //                this.btn_Ban4.BackColor = Color.SpringGreen;
        //            }
        //            if (btn_Ban1.BackColor == Color.Blue || btn_Ban2.BackColor == Color.Blue || btn_Ban3.BackColor == Color.Blue || btn_Ban5.BackColor == Color.Blue || btn_Ban6.BackColor == Color.Blue || btn_Ban7.BackColor == Color.Blue || btn_Ban8.BackColor == Color.Blue || btn_Ban9.BackColor == Color.Blue || btn_Ban10.BackColor == Color.Blue || btn_Ban11.BackColor == Color.Blue || btn_Ban12.BackColor == Color.Blue || btn_Ban13.BackColor == Color.Blue || btn_Ban14.BackColor == Color.Blue || btn_Ban15.BackColor == Color.Blue)
        //            {
        //                MessageBox.Show("Bạn đang chọn cùng lúc 2 bàn ! Vui lòng bỏ chọn 1 bàn");
        //                this.btn_Ban4.BackColor = Color.SpringGreen;
        //            }
        //            break;
        //        case "btn_Ban5":
        //            if (btn_Ban5.BackColor == Color.SpringGreen)
        //            {
        //                this.btn_Ban5.BackColor = Color.Blue;
        //            }
        //            else
        //            {
        //                this.btn_Ban5.BackColor = Color.SpringGreen;
        //            }
        //            if (btn_Ban1.BackColor == Color.Blue || btn_Ban2.BackColor == Color.Blue || btn_Ban3.BackColor == Color.Blue || btn_Ban4.BackColor == Color.Blue || btn_Ban6.BackColor == Color.Blue || btn_Ban7.BackColor == Color.Blue || btn_Ban8.BackColor == Color.Blue || btn_Ban9.BackColor == Color.Blue || btn_Ban10.BackColor == Color.Blue || btn_Ban11.BackColor == Color.Blue || btn_Ban12.BackColor == Color.Blue || btn_Ban13.BackColor == Color.Blue || btn_Ban14.BackColor == Color.Blue || btn_Ban15.BackColor == Color.Blue)
        //            {
        //                MessageBox.Show("Bạn đang chọn cùng lúc 2 bàn ! Vui lòng bỏ chọn 1 bàn");
        //                this.btn_Ban5.BackColor = Color.SpringGreen;
        //            }
        //            break;
        //        case "btn_Ban6":
        //            if (btn_Ban6.BackColor == Color.SpringGreen)
        //            {
        //                this.btn_Ban6.BackColor = Color.Blue;
        //            }
        //            else
        //            {
        //                this.btn_Ban6.BackColor = Color.SpringGreen;
        //            }
        //            if (btn_Ban1.BackColor == Color.Blue || btn_Ban2.BackColor == Color.Blue || btn_Ban3.BackColor == Color.Blue || btn_Ban4.BackColor == Color.Blue || btn_Ban5.BackColor == Color.Blue || btn_Ban7.BackColor == Color.Blue || btn_Ban8.BackColor == Color.Blue || btn_Ban9.BackColor == Color.Blue || btn_Ban10.BackColor == Color.Blue || btn_Ban11.BackColor == Color.Blue || btn_Ban12.BackColor == Color.Blue || btn_Ban13.BackColor == Color.Blue || btn_Ban14.BackColor == Color.Blue || btn_Ban15.BackColor == Color.Blue)
        //            {
        //                MessageBox.Show("Bạn đang chọn cùng lúc 2 bàn ! Vui lòng bỏ chọn 1 bàn");
        //                this.btn_Ban6.BackColor = Color.SpringGreen;
        //            }
        //            break;
        //        case "btn_Ban7":
        //            if (btn_Ban7.BackColor == Color.SpringGreen)
        //            {
        //                this.btn_Ban7.BackColor = Color.Blue;
        //            }
        //            else
        //            {
        //                this.btn_Ban7.BackColor = Color.SpringGreen;
        //            }
        //            if (btn_Ban1.BackColor == Color.Blue || btn_Ban2.BackColor == Color.Blue || btn_Ban3.BackColor == Color.Blue || btn_Ban4.BackColor == Color.Blue || btn_Ban5.BackColor == Color.Blue || btn_Ban6.BackColor == Color.Blue || btn_Ban8.BackColor == Color.Blue || btn_Ban9.BackColor == Color.Blue || btn_Ban10.BackColor == Color.Blue || btn_Ban11.BackColor == Color.Blue || btn_Ban12.BackColor == Color.Blue || btn_Ban13.BackColor == Color.Blue || btn_Ban14.BackColor == Color.Blue || btn_Ban15.BackColor == Color.Blue)
        //            {
        //                MessageBox.Show("Bạn đang chọn cùng lúc 2 bàn ! Vui lòng bỏ chọn 1 bàn");
        //                this.btn_Ban7.BackColor = Color.SpringGreen;
        //            }
        //            break;
        //        case "btn_Ban8":
        //            if (btn_Ban8.BackColor == Color.SpringGreen)
        //            {
        //                this.btn_Ban8.BackColor = Color.Blue;
        //            }
        //            else
        //            {
        //                this.btn_Ban8.BackColor = Color.SpringGreen;
        //            }
        //            if (btn_Ban1.BackColor == Color.Blue || btn_Ban2.BackColor == Color.Blue || btn_Ban3.BackColor == Color.Blue || btn_Ban4.BackColor == Color.Blue || btn_Ban5.BackColor == Color.Blue || btn_Ban6.BackColor == Color.Blue || btn_Ban7.BackColor == Color.Blue || btn_Ban9.BackColor == Color.Blue || btn_Ban10.BackColor == Color.Blue || btn_Ban11.BackColor == Color.Blue || btn_Ban12.BackColor == Color.Blue || btn_Ban13.BackColor == Color.Blue || btn_Ban14.BackColor == Color.Blue || btn_Ban15.BackColor == Color.Blue)
        //            {
        //                MessageBox.Show("Bạn đang chọn cùng lúc 2 bàn ! Vui lòng bỏ chọn 1 bàn");
        //                this.btn_Ban8.BackColor = Color.SpringGreen;
        //            }
        //            break;
        //        case "btn_Ban9":
        //            if (btn_Ban9.BackColor == Color.SpringGreen)
        //            {
        //                this.btn_Ban9.BackColor = Color.Blue;
        //            }
        //            else
        //            {
        //                this.btn_Ban5.BackColor = Color.SpringGreen;
        //            }
        //            if (btn_Ban1.BackColor == Color.Blue || btn_Ban2.BackColor == Color.Blue || btn_Ban3.BackColor == Color.Blue || btn_Ban4.BackColor == Color.Blue || btn_Ban5.BackColor == Color.Blue || btn_Ban6.BackColor == Color.Blue || btn_Ban7.BackColor == Color.Blue || btn_Ban8.BackColor == Color.Blue || btn_Ban10.BackColor == Color.Blue || btn_Ban11.BackColor == Color.Blue || btn_Ban12.BackColor == Color.Blue || btn_Ban13.BackColor == Color.Blue || btn_Ban14.BackColor == Color.Blue || btn_Ban15.BackColor == Color.Blue)
        //            {
        //                MessageBox.Show("Bạn đang chọn cùng lúc 2 bàn ! Vui lòng bỏ chọn 1 bàn");
        //                this.btn_Ban9.BackColor = Color.SpringGreen;
        //            }
        //            break;
        //        case "btn_Ban10":
        //            if (btn_Ban10.BackColor == Color.SpringGreen)
        //            {
        //                this.btn_Ban10.BackColor = Color.Blue;
        //            }
        //            else
        //            {
        //                this.btn_Ban10.BackColor = Color.SpringGreen;
        //            }
        //            if (btn_Ban1.BackColor == Color.Blue || btn_Ban2.BackColor == Color.Blue || btn_Ban3.BackColor == Color.Blue || btn_Ban4.BackColor == Color.Blue || btn_Ban5.BackColor == Color.Blue || btn_Ban6.BackColor == Color.Blue || btn_Ban7.BackColor == Color.Blue || btn_Ban8.BackColor == Color.Blue || btn_Ban9.BackColor == Color.Blue || btn_Ban11.BackColor == Color.Blue || btn_Ban12.BackColor == Color.Blue || btn_Ban13.BackColor == Color.Blue || btn_Ban14.BackColor == Color.Blue || btn_Ban15.BackColor == Color.Blue)
        //            {
        //                MessageBox.Show("Bạn đang chọn cùng lúc 2 bàn ! Vui lòng bỏ chọn 1 bàn");
        //                this.btn_Ban10.BackColor = Color.SpringGreen;
        //            }
        //            break;
        //        case "btn_Ban11":
        //            if (btn_Ban11.BackColor == Color.SpringGreen)
        //            {
        //                this.btn_Ban11.BackColor = Color.Blue;
        //            }
        //            else
        //            {
        //                this.btn_Ban11.BackColor = Color.SpringGreen;
        //            }
        //            if (btn_Ban1.BackColor == Color.Blue || btn_Ban2.BackColor == Color.Blue || btn_Ban3.BackColor == Color.Blue || btn_Ban4.BackColor == Color.Blue || btn_Ban5.BackColor == Color.Blue || btn_Ban6.BackColor == Color.Blue || btn_Ban7.BackColor == Color.Blue || btn_Ban8.BackColor == Color.Blue || btn_Ban9.BackColor == Color.Blue || btn_Ban10.BackColor == Color.Blue || btn_Ban12.BackColor == Color.Blue || btn_Ban13.BackColor == Color.Blue || btn_Ban14.BackColor == Color.Blue || btn_Ban15.BackColor == Color.Blue)
        //            {
        //                MessageBox.Show("Bạn đang chọn cùng lúc 2 bàn ! Vui lòng bỏ chọn 1 bàn");
        //                this.btn_Ban11.BackColor = Color.SpringGreen;
        //            }
        //            break;
        //        case "btn_Ban12":
        //            if (btn_Ban12.BackColor == Color.SpringGreen)
        //            {
        //                this.btn_Ban12.BackColor = Color.Blue;
        //            }
        //            else
        //            {
        //                this.btn_Ban12.BackColor = Color.SpringGreen;
        //            }
        //            if (btn_Ban1.BackColor == Color.Blue || btn_Ban2.BackColor == Color.Blue || btn_Ban3.BackColor == Color.Blue || btn_Ban4.BackColor == Color.Blue || btn_Ban5.BackColor == Color.Blue || btn_Ban6.BackColor == Color.Blue || btn_Ban7.BackColor == Color.Blue || btn_Ban8.BackColor == Color.Blue || btn_Ban9.BackColor == Color.Blue || btn_Ban10.BackColor == Color.Blue || btn_Ban11.BackColor == Color.Blue || btn_Ban13.BackColor == Color.Blue || btn_Ban14.BackColor == Color.Blue || btn_Ban15.BackColor == Color.Blue)
        //            {
        //                MessageBox.Show("Bạn đang chọn cùng lúc 2 bàn ! Vui lòng bỏ chọn 1 bàn");
        //                this.btn_Ban12.BackColor = Color.SpringGreen;
        //            }
        //            break;
        //        case "btn_Ban13":
        //            if (btn_Ban13.BackColor == Color.SpringGreen)
        //            {
        //                this.btn_Ban13.BackColor = Color.Blue;
        //            }
        //            else
        //            {
        //                this.btn_Ban13.BackColor = Color.SpringGreen;
        //            }
        //            if (btn_Ban1.BackColor == Color.Blue || btn_Ban2.BackColor == Color.Blue || btn_Ban3.BackColor == Color.Blue || btn_Ban4.BackColor == Color.Blue || btn_Ban5.BackColor == Color.Blue || btn_Ban6.BackColor == Color.Blue || btn_Ban7.BackColor == Color.Blue || btn_Ban8.BackColor == Color.Blue || btn_Ban9.BackColor == Color.Blue || btn_Ban10.BackColor == Color.Blue || btn_Ban11.BackColor == Color.Blue || btn_Ban12.BackColor == Color.Blue || btn_Ban14.BackColor == Color.Blue || btn_Ban15.BackColor == Color.Blue)
        //            {
        //                MessageBox.Show("Bạn đang chọn cùng lúc 2 bàn ! Vui lòng bỏ chọn 1 bàn");
        //                this.btn_Ban13.BackColor = Color.SpringGreen;
        //            }
        //            break;
        //        case "btn_Ban14":
        //            if (btn_Ban14.BackColor == Color.SpringGreen)
        //            {
        //                this.btn_Ban14.BackColor = Color.Blue;
        //            }
        //            else
        //            {
        //                this.btn_Ban14.BackColor = Color.SpringGreen;
        //            }
        //            if (btn_Ban1.BackColor == Color.Blue || btn_Ban2.BackColor == Color.Blue || btn_Ban3.BackColor == Color.Blue || btn_Ban4.BackColor == Color.Blue || btn_Ban5.BackColor == Color.Blue || btn_Ban6.BackColor == Color.Blue || btn_Ban7.BackColor == Color.Blue || btn_Ban8.BackColor == Color.Blue || btn_Ban9.BackColor == Color.Blue || btn_Ban10.BackColor == Color.Blue || btn_Ban11.BackColor == Color.Blue || btn_Ban12.BackColor == Color.Blue || btn_Ban13.BackColor == Color.Blue || btn_Ban15.BackColor == Color.Blue)
        //            {
        //                MessageBox.Show("Bạn đang chọn cùng lúc 2 bàn ! Vui lòng bỏ chọn 1 bàn");
        //                this.btn_Ban14.BackColor = Color.SpringGreen;
        //            }
        //            break;
        //        case "btn_Ban15":
        //            if (btn_Ban15.BackColor == Color.SpringGreen)
        //            {
        //                this.btn_Ban15.BackColor = Color.Blue;
        //            }
        //            else
        //            {
        //                this.btn_Ban15.BackColor = Color.SpringGreen;
        //            }
        //            if (btn_Ban1.BackColor == Color.Blue || btn_Ban2.BackColor == Color.Blue || btn_Ban3.BackColor == Color.Blue || btn_Ban4.BackColor == Color.Blue || btn_Ban5.BackColor == Color.Blue || btn_Ban6.BackColor == Color.Blue || btn_Ban7.BackColor == Color.Blue || btn_Ban8.BackColor == Color.Blue || btn_Ban9.BackColor == Color.Blue || btn_Ban10.BackColor == Color.Blue || btn_Ban11.BackColor == Color.Blue || btn_Ban12.BackColor == Color.Blue || btn_Ban13.BackColor == Color.Blue || btn_Ban14.BackColor == Color.Blue)
        //            {
        //                MessageBox.Show("Bạn đang chọn cùng lúc 2 bàn ! Vui lòng bỏ chọn 1 bàn");
        //                this.btn_Ban15.BackColor = Color.SpringGreen;
        //            }
        //            break;
        //    }
        //}

        public void loadCategory()
        {
            DataTable listCategory = new DataTable();
            BUSTacVu.docListCategory();
            listCategory = BUSTacVu.getListCategory();
            cbbCategory.DataSource = listCategory;
            cbbCategory.DisplayMember = "TenLoaiMon";
            
        }




        private void createListViewItem()
        {
            for (int i = 0; i <= flowLayoutPanel1.Controls.Count; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                lvTable.Add(item);


            }


        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable listFood = new DataTable();
            listFood = BUSTacVu.getFoodFromCategory(((DataRowView)cbbCategory.SelectedItem)["TenLoaiMon"].ToString());
            cbbFood.DataSource = listFood;
            cbbFood.DisplayMember = "TenMon";
        }

        private void btn_Themmon_Click(object sender, EventArgs e)  
        {
            decimal priceAfter = 0;
            int index = int.Parse(button_sender.Name);
            //ListViewItem item = new ListViewItem(cbbFood.Text);
            //item.SubItems.Add(numericSoLuong.Value.ToString());
            //item.SubItems.Add(txtPrice.Text);
            priceAfter = (decimal)(numericSoLuong.Value * decimal.Parse(txtPrice.Text));
            //item.SubItems.Add(priceAfter.ToString());
            //listView1.Items.Add(item);
            resizeListView();
            button_sender.BackColor = Color.Green;
            lvTable[int.Parse(button_sender.Name)] = new ListViewItem(cbbFood.Text);
            lvTable[int.Parse(button_sender.Name)].SubItems.Add(numericSoLuong.Value.ToString());
            lvTable[int.Parse(button_sender.Name)].SubItems.Add(txtPrice.Text);
            lvTable[int.Parse(button_sender.Name)].SubItems.Add(priceAfter.ToString());
            listView1.Items.Add(lvTable[int.Parse(button_sender.Name)]);


            //lvItem[index] = new ListViewItem(cbbFood.Text);
            //lvItem[index].SubItems.Add(numericSoLuong.Value.ToString());
            //lvItem[index].SubItems.Add(txtPrice.Text);
            //lvItem[index].SubItems.Add(priceAfter.ToString());
            //lvTable[int.Parse(button_sender.Name)].Items.Add(lvItem[index]);
            //listView1 = lvTable[int.Parse(button_sender.Name)];


            updateTotalPrice();
            txtTotal.Text = price.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void cbbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrice.Text = (BUSTacVu.getPriceFromFood(((DataRowView)cbbFood.SelectedItem)["TenMon"].ToString())).ToString();
        }

        private void updateTotalPrice()
        {
            price = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                price += decimal.Parse(item.SubItems[3].Text);
                
            }
            

        }
        public void GetListView(ListView list)
        {
            foreach (ListViewItem item in list.Items)
                this.listView1.Items.Add((ListViewItem)item.Clone());
        }


        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {

            DateTime date = DateTime.Now.Date;
            string s = date.ToString("yyyy-MM-dd");
            try
            {
                // If you want a preview use the PrintPreviewDialog
                PrintPreviewDialog preview = new PrintPreviewDialog();

                PrintDocument document = new PrintDocument();
                document.PrintPage += new PrintPageEventHandler(document_PrintPage);

                preview.Document = document;
                // Then show the dialog window.
                preview.Show();
                //BUSBill.insertBill(s, Convert.ToInt32(numericPercentSale.Value), int.Parse(txtTotal.Text));

                // Otherwise, just call the document.Print();

            }
            catch
            {
                throw;

            }


        }

        protected void document_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float offset = 40;
            int startX = 10, startY = 100;
            Font font = new Font("Arial", 14);
            StringFormat sf = new StringFormat();
            string title = " ".PadRight(60) + "HOÁ ĐƠN";
            string categoryTitle = "\tTÊN MÓN ĂN\t" + "SỐ LƯỢNG\t" + "ĐƠN GIÁ\t" + "THÀNH TIỀN";
            ev.Graphics.DrawString(categoryTitle, font, new SolidBrush(Color.Black), 10, 80);
            ev.Graphics.DrawString(title, font, new SolidBrush(Color.Black), 10, 40);
            for (int i=0; i<listView1.Items.Count;i++)
            {
                ev.Graphics.DrawString("\t"+listView1.Items[i].SubItems[0].Text.PadRight(30) + listView1.Items[i].SubItems[1].Text.PadRight(18) + listView1.Items[i].SubItems[2].Text.PadRight(23) + listView1.Items[i].SubItems[3].Text,font,new SolidBrush(Color.Black),startX,startY+offset);
                offset += 40;
            }
            ev.Graphics.DrawString("Tổng tiền: " + price+"đ", font, new SolidBrush(Color.Black), 650, 100 + offset);
        }

        private void btnApplySale_Click(object sender, EventArgs e)
        {
            decimal temp = (decimal)(numericPercentSale.Value / 100) * price;
            price -= temp;
            txtTotal.Text = price.ToString();
        }

        private void numericPercentSale_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Voucher_Click(object sender, EventArgs e)
        {
            GUI.GUIVoucherInput voucherInput= new GUIVoucherInput();
            voucherInput.ShowDialog();
            numericPercentSale.Value = (decimal)voucherInput.getPercent();
            decimal temp = (decimal)(numericPercentSale.Value / 100) * price;
            price -= temp;
            txtTotal.Text = price.ToString();
        }

        private void panel_TacVu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadTable()
        {
            transferList();
            for (int i = 0; i < listButton.Count; i++)
            {
                flowLayoutPanel1.Controls.Add(listButton[i]);
            }
        }

        private void clickButton(object sender, EventArgs e) {
            listView1.Items.Clear();
            var button = (Button)sender;
            markSelectingButton(button,null);
            button_sender = button;


            listView1.Items.Add(lvTable[int.Parse(button_sender.Name)]);
            //listView1 = lvTable[int.Parse(button_sender.Name)-1];

            if (listView1.Items[0].Text == button.Name)
            {
                listView1.Items[0].Remove();
            }



            resizeListView();
            //MessageBox.Show(button.Name);

            //MessageBox.Show(lvTable[int.Parse(button_sender.Name)-1].SubItems.ToString());
            //listView1.Items.Clear();
        }

        private void transferList()
        {
            listButton = BUSBan.getTable().ToList();
            for(int i=0;i<listButton.Count;i++)
            {
                listButton[i].Click += clickButton;
            }
        }

        private void markSelectingButton(object sender, EventArgs e)
        {
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c.BackColor == Color.Green)
                    continue;
                c.BackColor = Color.White;
                c.ForeColor = Color.Black;
            }
            Control click = (Control)sender;
            
            if (click.BackColor == Color.Green)
            {
                click.BackColor = Color.Green;
            }
            else
            {
                click.BackColor = Color.Red;
                click.ForeColor = Color.Black;
            }
        }

        private void markSelectedButton(object sender, EventArgs e)
        {
            
        }

        private void resizeListView()
        {
            listView1.Columns[0].Width = -2;
            listView1.Columns[1].Width = -2;
            listView1.Columns[2].Width = -2;
            listView1.Columns[3].Width = -2;    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}   
