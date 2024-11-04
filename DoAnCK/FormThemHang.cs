using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCK
{
    public partial class FormThemHang : System.Windows.Forms.Form
    {
        private KhoHang kho = new KhoHang();
        private string img_filepath;
        public FormThemHang()
        {
            InitializeComponent();
            cbb_loaihanghoa.Items.Add("Điện tử");
            cbb_loaihanghoa.Items.Add("Gia dụng");
            cbb_loaihanghoa.Items.Add("Thực phẩm");

            kho.LoadData();
        }

        private void bt_themanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Chọn ảnh hàng hóa",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                ptb_anhhanghoa.Image = Image.FromFile(filePath);
                bt_themanh.Visible = false;
                img_filepath = filePath;
            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            if (txt_id.Text.Length > 4)
            {
                txt_id.Text = txt_id.Text.Substring(0, 4);
                txt_id.SelectionStart = txt_id.Text.Length;
            }


        }

        private void txt_id_Leave(object sender, EventArgs e)
        {
            string text = txt_id.Text;
            if (!(text.StartsWith("DT") || text.StartsWith("GD") || text.StartsWith("TP")))
            {
                MessageBox.Show("ID phải bắt đầu bằng DT, GD, hoặc TP.", "Sai mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_id.Focus();
            }

            HangHoa hh = kho.ds_hang_hoa.Find(x => x.id == txt_id.Text);
            if (hh != null)
            {
                MessageBox.Show("Hàng hoá đã tồn tại");
            }
        }

        private void keypress_txt_dongia(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bt_xacnhanthemhang_Click(object sender, EventArgs e)
        {
            string loai_hh = cbb_loaihanghoa.Text;
            if (txt_tenhang.Text == "" || txt_id.Text == "" || txt_dongia.Text == "" || img_filepath == "" || cbb_loaihanghoa.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }   
            else if (loai_hh == "Điện tử")
            {
                DienTu new_hh = new DienTu();
                new_hh.ten_hang = txt_tenhang.Text;
                new_hh.id = txt_id.Text;
                new_hh.don_gia = Convert.ToUInt64(txt_dongia.Text);
                new_hh.img = img_filepath;

                kho.them_hh(new_hh);
            }

            else if (loai_hh == "Gia dụng")
            {
                GiaDung new_hh = new GiaDung();
                new_hh.ten_hang = txt_tenhang.Text;
                new_hh.id = txt_id.Text;
                new_hh.don_gia = Convert.ToUInt64(txt_dongia.Text);
                new_hh.img = img_filepath;

                kho.them_hh(new_hh);
            }    
            else if (loai_hh == "Thực phẩm")
            {
                ThucPham new_hh = new ThucPham();
                new_hh.ten_hang = txt_tenhang.Text;
                new_hh.id = txt_id.Text;
                new_hh.don_gia = Convert.ToUInt64(txt_dongia.Text);
                new_hh.img = img_filepath;

                kho.them_hh(new_hh);
            }
            this.Close();
        }
    }
}