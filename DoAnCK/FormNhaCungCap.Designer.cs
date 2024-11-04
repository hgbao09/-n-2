namespace DoAnCK
{
    partial class FormNhaCungCap
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
            this.daichincclabel = new System.Windows.Forms.Label();
            this.sdtncclabel = new System.Windows.Forms.Label();
            this.tenNCClabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataNCC = new System.Windows.Forms.DataGridView();
            this.IDNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.xoabtn = new Guna.UI2.WinForms.Guna2Button();
            this.btnthem = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNCC)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 80);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(230, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách nhà cung cấp";
            // 
            // daichincclabel
            // 
            this.daichincclabel.AutoSize = true;
            this.daichincclabel.Font = new System.Drawing.Font("Arial", 10F);
            this.daichincclabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.daichincclabel.Location = new System.Drawing.Point(460, 177);
            this.daichincclabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.daichincclabel.Name = "daichincclabel";
            this.daichincclabel.Size = new System.Drawing.Size(53, 16);
            this.daichincclabel.TabIndex = 26;
            this.daichincclabel.Text = "Địa Chỉ";
            // 
            // sdtncclabel
            // 
            this.sdtncclabel.AutoSize = true;
            this.sdtncclabel.Font = new System.Drawing.Font("Arial", 10F);
            this.sdtncclabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.sdtncclabel.Location = new System.Drawing.Point(420, 107);
            this.sdtncclabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sdtncclabel.Name = "sdtncclabel";
            this.sdtncclabel.Size = new System.Drawing.Size(97, 16);
            this.sdtncclabel.TabIndex = 25;
            this.sdtncclabel.Text = "Số Điện Thoại";
            // 
            // tenNCClabel
            // 
            this.tenNCClabel.AutoSize = true;
            this.tenNCClabel.Font = new System.Drawing.Font("Arial", 10F);
            this.tenNCClabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tenNCClabel.Location = new System.Drawing.Point(40, 167);
            this.tenNCClabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tenNCClabel.Name = "tenNCClabel";
            this.tenNCClabel.Size = new System.Drawing.Size(129, 16);
            this.tenNCClabel.TabIndex = 24;
            this.tenNCClabel.Text = "Tên Nhà Cung Cấp";
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
            this.IDlabel.TabIndex = 23;
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
            this.txtSDT.Size = new System.Drawing.Size(172, 32);
            this.txtSDT.TabIndex = 22;
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
            this.txtDiaChi.Location = new System.Drawing.Point(530, 160);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(172, 52);
            this.txtDiaChi.TabIndex = 21;
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
            this.txtTen.Size = new System.Drawing.Size(172, 32);
            this.txtTen.TabIndex = 20;
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
            this.txtId.Size = new System.Drawing.Size(172, 32);
            this.txtId.TabIndex = 19;
            // 
            // dataNCC
            // 
            this.dataNCC.AllowUserToAddRows = false;
            this.dataNCC.AllowUserToDeleteRows = false;
            this.dataNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDNCC,
            this.TenNCC,
            this.SDTNCC,
            this.DCNCC});
            this.dataNCC.Location = new System.Drawing.Point(0, 230);
            this.dataNCC.Margin = new System.Windows.Forms.Padding(2);
            this.dataNCC.Name = "dataNCC";
            this.dataNCC.ReadOnly = true;
            this.dataNCC.RowHeadersWidth = 51;
            this.dataNCC.RowTemplate.Height = 24;
            this.dataNCC.Size = new System.Drawing.Size(844, 280);
            this.dataNCC.TabIndex = 27;
            this.dataNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataNCC_CellClick);
            // 
            // IDNCC
            // 
            this.IDNCC.HeaderText = "ID";
            this.IDNCC.MinimumWidth = 6;
            this.IDNCC.Name = "IDNCC";
            this.IDNCC.ReadOnly = true;
            this.IDNCC.Width = 50;
            // 
            // TenNCC
            // 
            this.TenNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNCC.FillWeight = 110F;
            this.TenNCC.HeaderText = "Tên Nhà Cung Cấp";
            this.TenNCC.MinimumWidth = 110;
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.ReadOnly = true;
            // 
            // SDTNCC
            // 
            this.SDTNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDTNCC.FillWeight = 110F;
            this.SDTNCC.HeaderText = "Số Điện Thoại";
            this.SDTNCC.MinimumWidth = 110;
            this.SDTNCC.Name = "SDTNCC";
            this.SDTNCC.ReadOnly = true;
            // 
            // DCNCC
            // 
            this.DCNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DCNCC.FillWeight = 110F;
            this.DCNCC.HeaderText = "Địa Chỉ";
            this.DCNCC.MinimumWidth = 110;
            this.DCNCC.Name = "DCNCC";
            this.DCNCC.ReadOnly = true;
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
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 69);
            this.panel2.TabIndex = 28;
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
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
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
            this.xoabtn.Margin = new System.Windows.Forms.Padding(2);
            this.xoabtn.Name = "xoabtn";
            this.xoabtn.Size = new System.Drawing.Size(120, 35);
            this.xoabtn.TabIndex = 1;
            this.xoabtn.Text = "Xóa";
            this.xoabtn.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(120, 35);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // FormNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(844, 578);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataNCC);
            this.Controls.Add(this.daichincclabel);
            this.Controls.Add(this.sdtncclabel);
            this.Controls.Add(this.tenNCClabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormNhaCungCap";
            this.Text = "FormNhaCungCap";
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNCC)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label daichincclabel;
        private System.Windows.Forms.Label sdtncclabel;
        private System.Windows.Forms.Label tenNCClabel;
        private System.Windows.Forms.Label IDlabel;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtTen;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
        private System.Windows.Forms.DataGridView dataNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCNCC;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private Guna.UI2.WinForms.Guna2Button xoabtn;
        private Guna.UI2.WinForms.Guna2Button btnthem;
    }
}