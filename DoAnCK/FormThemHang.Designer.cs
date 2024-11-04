namespace DoAnCK
{
    partial class FormThemHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ptb_anhhanghoa = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bt_themanh = new Guna.UI2.WinForms.Guna2Button();
            this.bt_xacnhanthemhang = new Guna.UI2.WinForms.Guna2Button();
            this.lb_thongtinhanghoa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_idhanghoa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_tenhanghoa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_dongiahang = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_chonloaihang = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_tenhang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_dongia = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbb_loaihanghoa = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_anhhanghoa)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_anhhanghoa
            // 
            this.ptb_anhhanghoa.ImageRotate = 0F;
            this.ptb_anhhanghoa.Location = new System.Drawing.Point(35, 30);
            this.ptb_anhhanghoa.Margin = new System.Windows.Forms.Padding(2);
            this.ptb_anhhanghoa.Name = "ptb_anhhanghoa";
            this.ptb_anhhanghoa.Size = new System.Drawing.Size(222, 299);
            this.ptb_anhhanghoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_anhhanghoa.TabIndex = 0;
            this.ptb_anhhanghoa.TabStop = false;
            // 
            // bt_themanh
            // 
            this.bt_themanh.BackColor = System.Drawing.Color.Transparent;
            this.bt_themanh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_themanh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_themanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_themanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_themanh.FillColor = System.Drawing.Color.Transparent;
            this.bt_themanh.Font = new System.Drawing.Font("Arial", 9F);
            this.bt_themanh.ForeColor = System.Drawing.Color.DimGray;
            this.bt_themanh.Location = new System.Drawing.Point(44, 37);
            this.bt_themanh.Margin = new System.Windows.Forms.Padding(2);
            this.bt_themanh.Name = "bt_themanh";
            this.bt_themanh.Size = new System.Drawing.Size(205, 282);
            this.bt_themanh.TabIndex = 1;
            this.bt_themanh.Text = "+Thêm ảnh....";
            this.bt_themanh.Click += new System.EventHandler(this.bt_themanh_Click);
            // 
            // bt_xacnhanthemhang
            // 
            this.bt_xacnhanthemhang.BorderRadius = 15;
            this.bt_xacnhanthemhang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_xacnhanthemhang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_xacnhanthemhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_xacnhanthemhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_xacnhanthemhang.FillColor = System.Drawing.Color.DarkGray;
            this.bt_xacnhanthemhang.Font = new System.Drawing.Font("Arial", 12F);
            this.bt_xacnhanthemhang.ForeColor = System.Drawing.Color.White;
            this.bt_xacnhanthemhang.Location = new System.Drawing.Point(473, 315);
            this.bt_xacnhanthemhang.Margin = new System.Windows.Forms.Padding(2);
            this.bt_xacnhanthemhang.Name = "bt_xacnhanthemhang";
            this.bt_xacnhanthemhang.Size = new System.Drawing.Size(118, 33);
            this.bt_xacnhanthemhang.TabIndex = 2;
            this.bt_xacnhanthemhang.Text = "Thêm hàng";
            this.bt_xacnhanthemhang.Click += new System.EventHandler(this.bt_xacnhanthemhang_Click);
            // 
            // lb_thongtinhanghoa
            // 
            this.lb_thongtinhanghoa.AutoSize = false;
            this.lb_thongtinhanghoa.BackColor = System.Drawing.Color.Transparent;
            this.lb_thongtinhanghoa.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thongtinhanghoa.Location = new System.Drawing.Point(316, 20);
            this.lb_thongtinhanghoa.Margin = new System.Windows.Forms.Padding(2);
            this.lb_thongtinhanghoa.Name = "lb_thongtinhanghoa";
            this.lb_thongtinhanghoa.Size = new System.Drawing.Size(266, 48);
            this.lb_thongtinhanghoa.TabIndex = 3;
            this.lb_thongtinhanghoa.Text = "Thông Tin Hàng Hóa";
            // 
            // lb_idhanghoa
            // 
            this.lb_idhanghoa.AutoSize = false;
            this.lb_idhanghoa.BackColor = System.Drawing.Color.Transparent;
            this.lb_idhanghoa.Font = new System.Drawing.Font("Arial", 12F);
            this.lb_idhanghoa.Location = new System.Drawing.Point(301, 63);
            this.lb_idhanghoa.Margin = new System.Windows.Forms.Padding(2);
            this.lb_idhanghoa.Name = "lb_idhanghoa";
            this.lb_idhanghoa.Size = new System.Drawing.Size(106, 24);
            this.lb_idhanghoa.TabIndex = 4;
            this.lb_idhanghoa.Text = "Nhập ID hàng:";
            // 
            // lb_tenhanghoa
            // 
            this.lb_tenhanghoa.AutoSize = false;
            this.lb_tenhanghoa.BackColor = System.Drawing.Color.Transparent;
            this.lb_tenhanghoa.Font = new System.Drawing.Font("Arial", 12F);
            this.lb_tenhanghoa.Location = new System.Drawing.Point(301, 141);
            this.lb_tenhanghoa.Margin = new System.Windows.Forms.Padding(2);
            this.lb_tenhanghoa.Name = "lb_tenhanghoa";
            this.lb_tenhanghoa.Size = new System.Drawing.Size(112, 20);
            this.lb_tenhanghoa.TabIndex = 5;
            this.lb_tenhanghoa.Text = "Nhập tên hàng:";
            // 
            // lb_dongiahang
            // 
            this.lb_dongiahang.AutoSize = false;
            this.lb_dongiahang.BackColor = System.Drawing.Color.Transparent;
            this.lb_dongiahang.Font = new System.Drawing.Font("Arial", 12F);
            this.lb_dongiahang.Location = new System.Drawing.Point(301, 216);
            this.lb_dongiahang.Margin = new System.Windows.Forms.Padding(2);
            this.lb_dongiahang.Name = "lb_dongiahang";
            this.lb_dongiahang.Size = new System.Drawing.Size(106, 24);
            this.lb_dongiahang.TabIndex = 6;
            this.lb_dongiahang.Text = "Đơn giá:";
            // 
            // lb_chonloaihang
            // 
            this.lb_chonloaihang.AutoSize = false;
            this.lb_chonloaihang.BackColor = System.Drawing.Color.Transparent;
            this.lb_chonloaihang.Font = new System.Drawing.Font("Arial", 12F);
            this.lb_chonloaihang.Location = new System.Drawing.Point(463, 215);
            this.lb_chonloaihang.Margin = new System.Windows.Forms.Padding(2);
            this.lb_chonloaihang.Name = "lb_chonloaihang";
            this.lb_chonloaihang.Size = new System.Drawing.Size(119, 22);
            this.lb_chonloaihang.TabIndex = 7;
            this.lb_chonloaihang.Text = "Chọn loại hàng:";
            // 
            // txt_id
            // 
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.DefaultText = "";
            this.txt_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.Location = new System.Drawing.Point(301, 93);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.PlaceholderText = "";
            this.txt_id.SelectedText = "";
            this.txt_id.Size = new System.Drawing.Size(282, 26);
            this.txt_id.TabIndex = 8;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            this.txt_id.Leave += new System.EventHandler(this.txt_id_Leave);
            // 
            // txt_tenhang
            // 
            this.txt_tenhang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenhang.DefaultText = "";
            this.txt_tenhang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tenhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tenhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenhang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenhang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenhang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tenhang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenhang.Location = new System.Drawing.Point(301, 166);
            this.txt_tenhang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_tenhang.Name = "txt_tenhang";
            this.txt_tenhang.PasswordChar = '\0';
            this.txt_tenhang.PlaceholderText = "";
            this.txt_tenhang.SelectedText = "";
            this.txt_tenhang.Size = new System.Drawing.Size(282, 26);
            this.txt_tenhang.TabIndex = 9;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dongia.DefaultText = "";
            this.txt_dongia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_dongia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_dongia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dongia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dongia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dongia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_dongia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dongia.Location = new System.Drawing.Point(301, 242);
            this.txt_dongia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.PasswordChar = '\0';
            this.txt_dongia.PlaceholderText = "";
            this.txt_dongia.SelectedText = "";
            this.txt_dongia.Size = new System.Drawing.Size(124, 26);
            this.txt_dongia.TabIndex = 10;
            this.txt_dongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keypress_txt_dongia);
            // 
            // cbb_loaihanghoa
            // 
            this.cbb_loaihanghoa.BackColor = System.Drawing.Color.Transparent;
            this.cbb_loaihanghoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_loaihanghoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_loaihanghoa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_loaihanghoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_loaihanghoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_loaihanghoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_loaihanghoa.ItemHeight = 30;
            this.cbb_loaihanghoa.Location = new System.Drawing.Point(463, 239);
            this.cbb_loaihanghoa.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_loaihanghoa.Name = "cbb_loaihanghoa";
            this.cbb_loaihanghoa.Size = new System.Drawing.Size(121, 36);
            this.cbb_loaihanghoa.TabIndex = 11;
            // 
            // FormThemHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cbb_loaihanghoa);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.txt_tenhang);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lb_chonloaihang);
            this.Controls.Add(this.lb_dongiahang);
            this.Controls.Add(this.lb_tenhanghoa);
            this.Controls.Add(this.lb_idhanghoa);
            this.Controls.Add(this.lb_thongtinhanghoa);
            this.Controls.Add(this.bt_xacnhanthemhang);
            this.Controls.Add(this.bt_themanh);
            this.Controls.Add(this.ptb_anhhanghoa);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormThemHang";
            this.Text = "FormThemHang";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_anhhanghoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox ptb_anhhanghoa;
        private Guna.UI2.WinForms.Guna2Button bt_themanh;
        private Guna.UI2.WinForms.Guna2Button bt_xacnhanthemhang;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_thongtinhanghoa;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_idhanghoa;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_tenhanghoa;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_dongiahang;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_chonloaihang;
        private Guna.UI2.WinForms.Guna2TextBox txt_id;
        private Guna.UI2.WinForms.Guna2TextBox txt_tenhang;
        private Guna.UI2.WinForms.Guna2TextBox txt_dongia;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_loaihanghoa;
    }
}