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
    public partial class BillComponent : UserControl
    {
        private FormHoaDon HoaDon;
        public HangHoa hh;
        public BillComponent(FormHoaDon HoaDon)
        {
            InitializeComponent();
            this.HoaDon = HoaDon;
        }
        public void SetProductInfo(HangHoa hh)
        {
            id_bhdx.Text = hh.id.ToString();
            sp_bhdx.Text = hh.ten_hang;
            sl_bhdx.Text = hh.so_luong.ToString();
            tt_bhdx.Text = String.Format("{0:N0}", hh.don_gia * hh.so_luong);
        }
    }
}
