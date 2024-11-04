namespace DoAnCK
{
    partial class FormCuaHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.daichichlabel = new System.Windows.Forms.Label();
            this.sdtchlabel = new System.Windows.Forms.Label();
            this.tenCHlabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataCH = new System.Windows.Forms.DataGridView();
            this.IDCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.xoabtn = new Guna.UI2.WinForms.Guna2Button();
            this.btnthem = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCH)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 80);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(250, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách cửa hàng";
            // 
            // daichichlabel
            // 
            this.daichichlabel.AutoSize = true;
            this.daichichlabel.Font = new System.Drawing.Font("Arial", 10F);
            this.daichichlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.daichichlabel.Location = new System.Drawing.Point(460, 177);
            this.daichichlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.daichichlabel.Name = "daichichlabel";
            this.daichichlabel.Size = new System.Drawing.Size(53, 16);
            this.daichichlabel.TabIndex = 34;
            this.daichichlabel.Text = "Địa Chỉ";
            // 
            // sdtchlabel
            // 
            this.sdtchlabel.AutoSize = true;
            this.sdtchlabel.Font = new System.Drawing.Font("Arial", 10F);
            this.sdtchlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.sdtchlabel.Location = new System.Drawing.Point(420, 107);
            this.sdtchlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sdtchlabel.Name = "sdtchlabel";
            this.sdtchlabel.Size = new System.Drawing.Size(97, 16);
            this.sdtchlabel.TabIndex = 33;
            this.sdtchlabel.Text = "Số Điện Thoại";
            // 
            // tenCHlabel
            // 
            this.tenCHlabel.AutoSize = true;
            this.tenCHlabel.Font = new System.Drawing.Font("Arial", 10F);
            this.tenCHlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tenCHlabel.Location = new System.Drawing.Point(70, 167);
            this.tenCHlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tenCHlabel.Name = "tenCHlabel";
            this.tenCHlabel.Size = new System.Drawing.Size(100, 16);
            this.tenCHlabel.TabIndex = 32;
            this.tenCHlabel.Text = "Tên Cửa Hàng";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("Arial", 10F);
            this.IDlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.IDlabel.Location = new System.Drawing.Point(150, 107);
            this.IDlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(20, 16);
            this.IDlabel.TabIndex = 31;
            this.IDlabel.Text = "ID";
            // 
            // txtSDT
            // 
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Location = new System.Drawing.Point(530, 100);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(170, 30);
            this.txtSDT.TabIndex = 30;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Location = new System.Drawing.Point(532, 162);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(170, 50);
            this.txtDiaChi.TabIndex = 29;
            // 
            // txtTen
            // 
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.DefaultText = "";
            this.txtTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTen.Font = new System.Drawing.Font("Arial", 10F);
            this.txtTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTen.Location = new System.Drawing.Point(180, 160);
            this.txtTen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTen.Name = "txtTen";
            this.txtTen.PasswordChar = '\0';
            this.txtTen.PlaceholderText = "";
            this.txtTen.SelectedText = "";
            this.txtTen.Size = new System.Drawing.Size(170, 30);
            this.txtTen.TabIndex = 28;
            // 
            // txtId
            // 
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.DefaultText = "";
            this.txtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.Font = new System.Drawing.Font("Arial", 10F);
            this.txtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.Location = new System.Drawing.Point(180, 100);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PlaceholderText = "";
            this.txtId.SelectedText = "";
            this.txtId.Size = new System.Drawing.Size(170, 30);
            this.txtId.TabIndex = 27;
            // 
            // dataCH
            // 
            this.dataCH.AllowUserToAddRows = false;
            this.dataCH.AllowUserToDeleteRows = false;
            this.dataCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCH,
            this.TenCH,
            this.SDTCH,
            this.DCCH});
            this.dataCH.Location = new System.Drawing.Point(0, 230);
            this.dataCH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataCH.Name = "dataCH";
            this.dataCH.ReadOnly = true;
            this.dataCH.RowHeadersWidth = 51;
            this.dataCH.RowTemplate.Height = 24;
            this.dataCH.Size = new System.Drawing.Size(844, 280);
            this.dataCH.TabIndex = 35;
            this.dataCH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCH_CellClick);
            // 
            // IDCH
            // 
            this.IDCH.FillWeight = 50F;
            this.IDCH.HeaderText = "ID";
            this.IDCH.MinimumWidth = 6;
            this.IDCH.Name = "IDCH";
            this.IDCH.ReadOnly = true;
            this.IDCH.Width = 125;
            // 
            // TenCH
            // 
            this.TenCH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenCH.FillWeight = 110F;
            this.TenCH.HeaderText = "Tên Cửa Hàng";
            this.TenCH.MinimumWidth = 110;
            this.TenCH.Name = "TenCH";
            this.TenCH.ReadOnly = true;
            // 
            // SDTCH
            // 
            this.SDTCH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDTCH.FillWeight = 110F;
            this.SDTCH.HeaderText = "Số Điện Thoại";
            this.SDTCH.MinimumWidth = 110;
            this.SDTCH.Name = "SDTCH";
            this.SDTCH.ReadOnly = true;
            // 
            // DCCH
            // 
            this.DCCH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DCCH.FillWeight = 110F;
            this.DCCH.HeaderText = "Địa Chỉ";
            this.DCCH.MinimumWidth = 110;
            this.DCCH.Name = "DCCH";
            this.DCCH.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnCapNhat);
            this.panel2.Controls.Add(this.xoabtn);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 509);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 69);
            this.panel2.TabIndex = 36;
            // 
            // btnHuy
            // 
            this.btnHuy.BorderRadius = 10;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnHuy.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnHuy.Location = new System.Drawing.Point(700, 20);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 35);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 10;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnLuu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnLuu.Location = new System.Drawing.Point(530, 20);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 35);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BorderRadius = 10;
            this.btnCapNhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapNhat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCapNhat.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnCapNhat.Location = new System.Drawing.Point(360, 20);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(120, 35);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // xoabtn
            // 
            this.xoabtn.BorderRadius = 10;
            this.xoabtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.xoabtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.xoabtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.xoabtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.xoabtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.xoabtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.xoabtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.xoabtn.Location = new System.Drawing.Point(190, 20);
            this.xoabtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xoabtn.Name = "xoabtn";
            this.xoabtn.Size = new System.Drawing.Size(120, 35);
            this.xoabtn.TabIndex = 1;
            this.xoabtn.Text = "Xóa";
            this.xoabtn.Click += new System.EventHandler(this.xoabtn_Click);
            // 
            // btnthem
            // 
            this.btnthem.BorderRadius = 10;
            this.btnthem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnthem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnthem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnthem.Location = new System.Drawing.Point(20, 20);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(120, 35);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // FormCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(844, 578);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataCH);
            this.Controls.Add(this.daichichlabel);
            this.Controls.Add(this.sdtchlabel);
            this.Controls.Add(this.tenCHlabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCuaHang";
            this.Text = "FormCuaHang";
            this.Load += new System.EventHandler(this.FormCuaHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCH)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label daichichlabel;
        private System.Windows.Forms.Label sdtchlabel;
        private System.Windows.Forms.Label tenCHlabel;
        private System.Windows.Forms.Label IDlabel;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtTen;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
        private System.Windows.Forms.DataGridView dataCH;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private Guna.UI2.WinForms.Guna2Button xoabtn;
        private Guna.UI2.WinForms.Guna2Button btnthem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCCH;
    }
}