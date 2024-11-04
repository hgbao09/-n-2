namespace DoAnCK
{
    partial class FormNhapXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapXuat));
            this.dshh_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.diachi_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctlh_lbl = new System.Windows.Forms.Label();
            this.dshh_lbl = new System.Windows.Forms.Label();
            this.ncc_ch_cbb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.search_txb = new Guna.UI2.WinForms.Guna2TextBox();
            this.loaihh_cbb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.id_lbl = new System.Windows.Forms.Label();
            this.ncc_ch_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.apdung_btn = new Guna.UI2.WinForms.Guna2Button();
            this.search_lbl = new System.Windows.Forms.Label();
            this.loaisp_lbl = new System.Windows.Forms.Label();
            this.ctlh_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.idsp_lbl = new System.Windows.Forms.Label();
            this.tensp_lbl = new System.Windows.Forms.Label();
            this.sl_lbl = new System.Windows.Forms.Label();
            this.thanhtien_lbl = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tongtien_lbl = new System.Windows.Forms.Label();
            this.xuathoadon_btn = new Guna.UI2.WinForms.Guna2Button();
            this.huy_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dshh_flp
            // 
            this.dshh_flp.AutoScroll = true;
            this.dshh_flp.Location = new System.Drawing.Point(440, 180);
            this.dshh_flp.Name = "dshh_flp";
            this.dshh_flp.Size = new System.Drawing.Size(392, 386);
            this.dshh_flp.TabIndex = 15;
            // 
            // diachi_lbl
            // 
            this.diachi_lbl.AutoSize = true;
            this.diachi_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.diachi_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.diachi_lbl.Location = new System.Drawing.Point(150, 80);
            this.diachi_lbl.Name = "diachi_lbl";
            this.diachi_lbl.Size = new System.Drawing.Size(71, 19);
            this.diachi_lbl.TabIndex = 19;
            this.diachi_lbl.Text = "Địa chỉ: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.ctlh_lbl);
            this.panel1.Controls.Add(this.dshh_lbl);
            this.panel1.Location = new System.Drawing.Point(0, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 60);
            this.panel1.TabIndex = 20;
            // 
            // ctlh_lbl
            // 
            this.ctlh_lbl.AutoSize = true;
            this.ctlh_lbl.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.ctlh_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ctlh_lbl.Location = new System.Drawing.Point(113, 15);
            this.ctlh_lbl.Name = "ctlh_lbl";
            this.ctlh_lbl.Size = new System.Drawing.Size(164, 26);
            this.ctlh_lbl.TabIndex = 6;
            this.ctlh_lbl.Text = "Chi tiết lô hàng";
            // 
            // dshh_lbl
            // 
            this.dshh_lbl.AutoSize = true;
            this.dshh_lbl.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.dshh_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dshh_lbl.Location = new System.Drawing.Point(519, 15);
            this.dshh_lbl.Name = "dshh_lbl";
            this.dshh_lbl.Size = new System.Drawing.Size(222, 26);
            this.dshh_lbl.TabIndex = 5;
            this.dshh_lbl.Text = "Danh sách hàng hoá";
            // 
            // ncc_ch_cbb
            // 
            this.ncc_ch_cbb.BackColor = System.Drawing.Color.Transparent;
            this.ncc_ch_cbb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ncc_ch_cbb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ncc_ch_cbb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ncc_ch_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ncc_ch_cbb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ncc_ch_cbb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ncc_ch_cbb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ncc_ch_cbb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ncc_ch_cbb.ItemHeight = 30;
            this.ncc_ch_cbb.Location = new System.Drawing.Point(20, 25);
            this.ncc_ch_cbb.Name = "ncc_ch_cbb";
            this.ncc_ch_cbb.Size = new System.Drawing.Size(220, 36);
            this.ncc_ch_cbb.TabIndex = 21;
            this.ncc_ch_cbb.SelectedIndexChanged += new System.EventHandler(this.ncc_ch_cbb_SelectedIndexChanged);
            // 
            // search_txb
            // 
            this.search_txb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.search_txb.BorderRadius = 18;
            this.search_txb.BorderThickness = 3;
            this.search_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_txb.DefaultText = "Search";
            this.search_txb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_txb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_txb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_txb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_txb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_txb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.search_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.search_txb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_txb.IconLeft = ((System.Drawing.Image)(resources.GetObject("search_txb.IconLeft")));
            this.search_txb.IconLeftOffset = new System.Drawing.Point(-3, -1);
            this.search_txb.IconLeftSize = new System.Drawing.Size(35, 35);
            this.search_txb.Location = new System.Drawing.Point(440, 25);
            this.search_txb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.search_txb.Name = "search_txb";
            this.search_txb.PasswordChar = '\0';
            this.search_txb.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.search_txb.PlaceholderText = "";
            this.search_txb.SelectedText = "";
            this.search_txb.Size = new System.Drawing.Size(200, 40);
            this.search_txb.TabIndex = 22;
            this.search_txb.Click += new System.EventHandler(this.search_tb_Click);
            // 
            // loaihh_cbb
            // 
            this.loaihh_cbb.BackColor = System.Drawing.Color.Transparent;
            this.loaihh_cbb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.loaihh_cbb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loaihh_cbb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.loaihh_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loaihh_cbb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loaihh_cbb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loaihh_cbb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.loaihh_cbb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.loaihh_cbb.ItemHeight = 30;
            this.loaihh_cbb.Items.AddRange(new object[] {
            "Tất cả",
            "Điện tử",
            "Gia dụng",
            "Thực phẩm"});
            this.loaihh_cbb.Location = new System.Drawing.Point(660, 27);
            this.loaihh_cbb.Name = "loaihh_cbb";
            this.loaihh_cbb.Size = new System.Drawing.Size(150, 36);
            this.loaihh_cbb.StartIndex = 0;
            this.loaihh_cbb.TabIndex = 23;
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.id_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.id_lbl.Location = new System.Drawing.Point(20, 80);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(35, 19);
            this.id_lbl.TabIndex = 24;
            this.id_lbl.Text = "ID: ";
            // 
            // ncc_ch_lbl
            // 
            this.ncc_ch_lbl.AutoSize = true;
            this.ncc_ch_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ncc_ch_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ncc_ch_lbl.Location = new System.Drawing.Point(20, 5);
            this.ncc_ch_lbl.Name = "ncc_ch_lbl";
            this.ncc_ch_lbl.Size = new System.Drawing.Size(195, 19);
            this.ncc_ch_lbl.TabIndex = 25;
            this.ncc_ch_lbl.Text = "Nhà cung cấp/Cửa hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.panel2.Location = new System.Drawing.Point(420, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 578);
            this.panel2.TabIndex = 26;
            // 
            // apdung_btn
            // 
            this.apdung_btn.BorderRadius = 10;
            this.apdung_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apdung_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.apdung_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.apdung_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.apdung_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.apdung_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.apdung_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.apdung_btn.ForeColor = System.Drawing.Color.White;
            this.apdung_btn.Location = new System.Drawing.Point(450, 75);
            this.apdung_btn.Name = "apdung_btn";
            this.apdung_btn.Size = new System.Drawing.Size(120, 30);
            this.apdung_btn.TabIndex = 27;
            this.apdung_btn.Text = "Áp dụng";
            this.apdung_btn.Click += new System.EventHandler(this.apdung_btn_Click);
            // 
            // search_lbl
            // 
            this.search_lbl.AutoSize = true;
            this.search_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.search_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.search_lbl.Location = new System.Drawing.Point(450, 5);
            this.search_lbl.Name = "search_lbl";
            this.search_lbl.Size = new System.Drawing.Size(114, 19);
            this.search_lbl.TabIndex = 28;
            this.search_lbl.Text = "Tên hàng hoá";
            // 
            // loaisp_lbl
            // 
            this.loaisp_lbl.AutoSize = true;
            this.loaisp_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.loaisp_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.loaisp_lbl.Location = new System.Drawing.Point(660, 5);
            this.loaisp_lbl.Name = "loaisp_lbl";
            this.loaisp_lbl.Size = new System.Drawing.Size(118, 19);
            this.loaisp_lbl.TabIndex = 29;
            this.loaisp_lbl.Text = "Loại hàng hoá";
            // 
            // ctlh_flp
            // 
            this.ctlh_flp.AutoScroll = true;
            this.ctlh_flp.Location = new System.Drawing.Point(5, 200);
            this.ctlh_flp.Name = "ctlh_flp";
            this.ctlh_flp.Size = new System.Drawing.Size(410, 250);
            this.ctlh_flp.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.panel3.Location = new System.Drawing.Point(60, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 280);
            this.panel3.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.panel4.Location = new System.Drawing.Point(195, 170);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 280);
            this.panel4.TabIndex = 28;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.panel5.Location = new System.Drawing.Point(290, 170);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 280);
            this.panel5.TabIndex = 28;
            // 
            // idsp_lbl
            // 
            this.idsp_lbl.AutoSize = true;
            this.idsp_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.idsp_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.idsp_lbl.Location = new System.Drawing.Point(19, 180);
            this.idsp_lbl.Name = "idsp_lbl";
            this.idsp_lbl.Size = new System.Drawing.Size(25, 19);
            this.idsp_lbl.TabIndex = 30;
            this.idsp_lbl.Text = "ID";
            // 
            // tensp_lbl
            // 
            this.tensp_lbl.AutoSize = true;
            this.tensp_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tensp_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tensp_lbl.Location = new System.Drawing.Point(71, 180);
            this.tensp_lbl.Name = "tensp_lbl";
            this.tensp_lbl.Size = new System.Drawing.Size(114, 19);
            this.tensp_lbl.TabIndex = 31;
            this.tensp_lbl.Text = "Tên hàng hoá";
            // 
            // sl_lbl
            // 
            this.sl_lbl.AutoSize = true;
            this.sl_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.sl_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.sl_lbl.Location = new System.Drawing.Point(203, 180);
            this.sl_lbl.Name = "sl_lbl";
            this.sl_lbl.Size = new System.Drawing.Size(81, 19);
            this.sl_lbl.TabIndex = 32;
            this.sl_lbl.Text = "Số lượng";
            // 
            // thanhtien_lbl
            // 
            this.thanhtien_lbl.AutoSize = true;
            this.thanhtien_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.thanhtien_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.thanhtien_lbl.Location = new System.Drawing.Point(293, 180);
            this.thanhtien_lbl.Name = "thanhtien_lbl";
            this.thanhtien_lbl.Size = new System.Drawing.Size(90, 19);
            this.thanhtien_lbl.TabIndex = 33;
            this.thanhtien_lbl.Text = "Thành tiền";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.panel6.Location = new System.Drawing.Point(0, 200);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(422, 2);
            this.panel6.TabIndex = 28;
            // 
            // tongtien_lbl
            // 
            this.tongtien_lbl.AutoSize = true;
            this.tongtien_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tongtien_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tongtien_lbl.Location = new System.Drawing.Point(200, 470);
            this.tongtien_lbl.Name = "tongtien_lbl";
            this.tongtien_lbl.Size = new System.Drawing.Size(139, 19);
            this.tongtien_lbl.TabIndex = 34;
            this.tongtien_lbl.Text = "Tổng tiền: 0 VNĐ";
            // 
            // xuathoadon_btn
            // 
            this.xuathoadon_btn.BorderRadius = 20;
            this.xuathoadon_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuathoadon_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.xuathoadon_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.xuathoadon_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.xuathoadon_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.xuathoadon_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(132)))), ((int)(((byte)(49)))));
            this.xuathoadon_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.xuathoadon_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.xuathoadon_btn.Location = new System.Drawing.Point(40, 510);
            this.xuathoadon_btn.Name = "xuathoadon_btn";
            this.xuathoadon_btn.Size = new System.Drawing.Size(150, 40);
            this.xuathoadon_btn.TabIndex = 35;
            this.xuathoadon_btn.Text = "Xuất hoá đơn";
            this.xuathoadon_btn.Click += new System.EventHandler(this.xuathoadon_btn_Click);
            // 
            // huy_btn
            // 
            this.huy_btn.BorderRadius = 20;
            this.huy_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.huy_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.huy_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.huy_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.huy_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.huy_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.huy_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.huy_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.huy_btn.Location = new System.Drawing.Point(240, 510);
            this.huy_btn.Name = "huy_btn";
            this.huy_btn.Size = new System.Drawing.Size(150, 40);
            this.huy_btn.TabIndex = 36;
            this.huy_btn.Text = "Huỷ";
            this.huy_btn.Click += new System.EventHandler(this.huy_btn_Click);
            // 
            // FormNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(844, 578);
            this.Controls.Add(this.huy_btn);
            this.Controls.Add(this.xuathoadon_btn);
            this.Controls.Add(this.tongtien_lbl);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.thanhtien_lbl);
            this.Controls.Add(this.sl_lbl);
            this.Controls.Add(this.tensp_lbl);
            this.Controls.Add(this.idsp_lbl);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ctlh_flp);
            this.Controls.Add(this.loaisp_lbl);
            this.Controls.Add(this.search_lbl);
            this.Controls.Add(this.apdung_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ncc_ch_lbl);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.loaihh_cbb);
            this.Controls.Add(this.search_txb);
            this.Controls.Add(this.ncc_ch_cbb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.diachi_lbl);
            this.Controls.Add(this.dshh_flp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNhapXuat";
            this.Text = "FormNhapHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel dshh_flp;
        private System.Windows.Forms.Label diachi_lbl;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox ncc_ch_cbb;
        private Guna.UI2.WinForms.Guna2TextBox search_txb;
        private Guna.UI2.WinForms.Guna2ComboBox loaihh_cbb;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.Label ncc_ch_lbl;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button apdung_btn;
        private System.Windows.Forms.Label search_lbl;
        private System.Windows.Forms.Label loaisp_lbl;
        private System.Windows.Forms.Label ctlh_lbl;
        private System.Windows.Forms.Label dshh_lbl;
        private System.Windows.Forms.FlowLayoutPanel ctlh_flp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label idsp_lbl;
        private System.Windows.Forms.Label tensp_lbl;
        private System.Windows.Forms.Label sl_lbl;
        private System.Windows.Forms.Label thanhtien_lbl;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label tongtien_lbl;
        private Guna.UI2.WinForms.Guna2Button xuathoadon_btn;
        private Guna.UI2.WinForms.Guna2Button huy_btn;
    }
}