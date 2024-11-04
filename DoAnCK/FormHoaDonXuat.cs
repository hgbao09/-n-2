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
    public partial class FormHoaDonXuat : System.Windows.Forms.Form
    {
        KhoHang kho = new KhoHang();

        public FormHoaDonXuat()
        {
            InitializeComponent();
            kho.LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HoaDonXuat_load(object sender, EventArgs e)
        {
            foreach (HoaDonXuat hdx in kho.ds_hoa_don_xuat)
            {
                dataHDX.Rows.Add(hdx.ma_don_hang, hdx.ngay_tao_don,hdx.nv_lap.id_nv,hdx.tong_tien);
            }
            dataHDX.Enabled = dataHDX.Rows.Count > 0;
        }
    }
}
