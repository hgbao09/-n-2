using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCK
{
    public partial class HangHoaLoComponent : UserControl
    {
        public HangHoaLoComponent(FormNhapXuat NhapXuat)
        {
            InitializeComponent();
            this.NhapXuat = NhapXuat;
        }
        private FormNhapXuat NhapXuat;
        public HangHoa hh;

        public void SetProductInfo()
        {
            id_lbl.Text = hh.id.ToString();
            ten_lbl.Text = hh.ten_hang;
            soluong_txb.Text = hh.so_luong.ToString();
            thanhtien_lbl.Text = String.Format("{0:N0}",hh.don_gia * hh.so_luong);
        }

        private void xoa_btn_Click(object sender, EventArgs e)
        {
            NhapXuat.xoa_hh_lo(this);
        }

        private void tang_btn_Click(object sender, EventArgs e)
        {
            NhapXuat.tang_sl(this);
            soluong_txb.Text = hh.so_luong.ToString();
            thanhtien_lbl.Text = String.Format("{0:N0}", hh.don_gia * hh.so_luong);
        }
        private void giam_btn_Click(object sender, EventArgs e)
        {
            NhapXuat.giam_sl(this);
            soluong_txb.Text = hh.so_luong.ToString();
            thanhtien_lbl.Text = String.Format("{0:N0}", hh.don_gia * hh.so_luong);
        }


        private void soluong_txb_TextChanged(object sender, EventArgs e)
        {
            if (soluong_txb.Text != "")
            {
                hh.so_luong = Convert.ToUInt32(soluong_txb.Text);
                soluong_txb.Text = hh.so_luong.ToString();
                thanhtien_lbl.Text = String.Format("{0:N0}", hh.don_gia * hh.so_luong);
                NhapXuat.nhap_sl(this);
            }
        }

        private void soluong_txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
