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
using System.Xml.Serialization;


namespace DoAnCK
{
    public partial class FormTrangChu : System.Windows.Forms.Form
    {
        private KhoHang kho = new KhoHang();
        public FormTrangChu()
        {
            InitializeComponent();

            string filePath_hh = "Resources/hang_hoa.dat";
            using (StreamReader reader = new StreamReader(filePath_hh))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<HangHoa>));
                kho.ds_hang_hoa = (List<HangHoa>)serializer.Deserialize(reader);
            }

            foreach (HangHoa hh in kho.ds_hang_hoa)
            {
                HangHoaTrangChuComponent hh_component = new HangHoaTrangChuComponent(this);
                hh_component.hh = hh;
                hh_component.SetProductInfo(hh);
                xoahh_btn.Controls.Add(hh_component);
            }
        }

        private void tatca_btn_Click(object sender, EventArgs e)
        {
            tatca_btn.Checked = true;
            giadung_btn.Checked = false;
            dientu_btn.Checked = false;
            thucpham_btn.Checked = false;

            xoahh_btn.Controls.Clear();
            foreach (HangHoa hh in kho.ds_hang_hoa)
            {
                HangHoaTrangChuComponent hh_component = new HangHoaTrangChuComponent(this);
                hh_component.hh = hh;
                hh_component.SetProductInfo(hh);
                xoahh_btn.Controls.Add(hh_component);
            }
        }

        private void giadung_btn_Click(object sender, EventArgs e)
        {
            tatca_btn.Checked = false;
            giadung_btn.Checked = true;
            dientu_btn.Checked = false;
            thucpham_btn.Checked = false;

            xoahh_btn.Controls.Clear();
            foreach (HangHoa hh in kho.ds_hang_hoa)
            {
                if (hh is GiaDung)
                {
                    HangHoaTrangChuComponent hh_component = new HangHoaTrangChuComponent(this);
                    hh_component.hh = hh;
                    hh_component.SetProductInfo(hh);
                    xoahh_btn.Controls.Add(hh_component);
                }
            }
        }

        private void dientu_btn_Click(object sender, EventArgs e)
        {
            tatca_btn.Checked = false;
            giadung_btn.Checked = false;
            dientu_btn.Checked = true;
            thucpham_btn.Checked = false;

            xoahh_btn.Controls.Clear();
            foreach (HangHoa hh in kho.ds_hang_hoa)
            {
                if (hh is DienTu)
                {
                    HangHoaTrangChuComponent hh_component = new HangHoaTrangChuComponent(this);
                    hh_component.hh = hh;
                    hh_component.SetProductInfo(hh);
                    xoahh_btn.Controls.Add(hh_component);
                }
            }
        }

        private void thucpham_btn_Click(object sender, EventArgs e)
        {
            tatca_btn.Checked = false;
            giadung_btn.Checked = false;
            dientu_btn.Checked = false;
            thucpham_btn.Checked = true;

            xoahh_btn.Controls.Clear();
            foreach (HangHoa hh in kho.ds_hang_hoa)
            {
                if (hh is ThucPham)
                {
                    HangHoaTrangChuComponent hh_component = new HangHoaTrangChuComponent(this);
                    hh_component.hh = hh;
                    hh_component.SetProductInfo(hh);
                    xoahh_btn.Controls.Add(hh_component);
                }
            }
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        { 
            xoahh_btn.Controls.Clear();
            string searchText = search_tb.Text;
            if (dientu_btn.Checked == true)
            {
                foreach (HangHoa hh in kho.ds_hang_hoa)
                {
                    if (hh is DienTu && hh.ten_hang.ToLower().Contains(searchText.ToLower()))
                    {
                        HangHoaTrangChuComponent hh_component = new HangHoaTrangChuComponent(this);
                        hh_component.hh = hh;
                        hh_component.SetProductInfo(hh);
                        xoahh_btn.Controls.Add(hh_component);
                    }
                }
            }

            else if (giadung_btn.Checked == true)
            {
                foreach (HangHoa hh in kho.ds_hang_hoa)
                {
                    if (hh is GiaDung && hh.ten_hang.ToLower().Contains(searchText.ToLower()))
                    {
                        HangHoaTrangChuComponent hh_component = new HangHoaTrangChuComponent(this);
                        hh_component.hh = hh;
                        hh_component.SetProductInfo(hh);
                        xoahh_btn.Controls.Add(hh_component);
                    }
                }
            }

            else if (thucpham_btn.Checked == true)
            {
                foreach (HangHoa hh in kho.ds_hang_hoa)
                {
                    if (hh is ThucPham && hh.ten_hang.ToLower().Contains(searchText.ToLower()))
                    {
                        HangHoaTrangChuComponent hh_component = new HangHoaTrangChuComponent(this);
                        hh_component.hh = hh;
                        hh_component.SetProductInfo(hh);
                        xoahh_btn.Controls.Add(hh_component);
                    }
                }
            }

            else
            {
                foreach (HangHoa hh in kho.ds_hang_hoa)
                {
                    if (hh.ten_hang.ToLower().Contains(searchText.ToLower()))
                    {
                        HangHoaTrangChuComponent hh_component = new HangHoaTrangChuComponent(this);
                        hh_component.hh = hh;
                        hh_component.SetProductInfo(hh);
                        xoahh_btn.Controls.Add(hh_component);
                    }
                }
            }
        }

        private void search_tb_MouseClick(object sender, MouseEventArgs e)
        {
            search_tb.Text = "";
        }

        private void them_btn_Click(object sender, EventArgs e)
        {
            FormThemHang formthem = new FormThemHang();
            formthem.Show();
        }
    }
}
