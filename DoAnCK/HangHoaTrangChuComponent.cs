using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCK
{
    public partial class HangHoaTrangChuComponent : UserControl
    {
        public HangHoaTrangChuComponent(FormTrangChu TrangChu)
        {
            InitializeComponent();
            this.TrangChu = TrangChu;
        }
        private FormTrangChu TrangChu;
        public HangHoa hh;
        public void SetProductInfo(HangHoa hh)
        {
            id_lbl.Text = "ID: " + hh.id;
            ten_lbl.Text = hh.ten_hang;
            dongia_lbl.Text = "Đơn giá: " + hh.don_gia.ToString();
            soluong_lbl.Text = "SL: " + hh.so_luong.ToString();
            if (hh.img != null)
            {
                hanghoa_ptb.ImageLocation = hh.img;
            }
            else
            { 
                hanghoa_ptb.ImageLocation = "Resources/default.jpg";
            }
        }

        private void MouseEnter(object sender, EventArgs e)
        {
            guna2Panel1.FillColor = ColorTranslator.FromHtml("#888888");
            id_lbl.BackColor = ColorTranslator.FromHtml("#888888");
            hanghoa_ptb.BackColor = ColorTranslator.FromHtml("#888888");
            ten_lbl.BackColor = ColorTranslator.FromHtml("#888888");
            dongia_lbl.BackColor = ColorTranslator.FromHtml("#888888");
            soluong_lbl.BackColor = ColorTranslator.FromHtml("#888888");
        }
        private void MouseLeave(object sender, EventArgs e)
        {
            guna2Panel1.FillColor = ColorTranslator.FromHtml("#bbbbbb");
            id_lbl.BackColor = ColorTranslator.FromHtml("#bbbbbb");
            hanghoa_ptb.BackColor = ColorTranslator.FromHtml("#bbbbbb");
            ten_lbl.BackColor = ColorTranslator.FromHtml("#bbbbbb");
            dongia_lbl.BackColor = ColorTranslator.FromHtml("#bbbbbb");
            soluong_lbl.BackColor = ColorTranslator.FromHtml("#bbbbbb");
        }

        private void MouseClick(object sender, EventArgs e)
        {
            guna2Panel1.FillColor = ColorTranslator.FromHtml("#888888");
            id_lbl.BackColor = ColorTranslator.FromHtml("#888888");
            hanghoa_ptb.BackColor = ColorTranslator.FromHtml("#888888");
            ten_lbl.BackColor = ColorTranslator.FromHtml("#888888");
            dongia_lbl.BackColor = ColorTranslator.FromHtml("#888888");
            soluong_lbl.BackColor = ColorTranslator.FromHtml("#888888");
        }
    }
}
