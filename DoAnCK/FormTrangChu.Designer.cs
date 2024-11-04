namespace DoAnCK
{
    partial class FormTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChu));
            this.search_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.dssp_pnl = new System.Windows.Forms.Panel();
            this.dshh_lbl = new System.Windows.Forms.Label();
            this.thucpham_btn = new Guna.UI2.WinForms.Guna2Button();
            this.dientu_btn = new Guna.UI2.WinForms.Guna2Button();
            this.giadung_btn = new Guna.UI2.WinForms.Guna2Button();
            this.tatca_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xoahh_btn = new System.Windows.Forms.FlowLayoutPanel();
            this.them_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.dssp_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_tb
            // 
            this.search_tb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.search_tb.BorderRadius = 18;
            this.search_tb.BorderThickness = 3;
            this.search_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_tb.DefaultText = "Search";
            this.search_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_tb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.search_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.search_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_tb.IconLeft = ((System.Drawing.Image)(resources.GetObject("search_tb.IconLeft")));
            this.search_tb.IconLeftOffset = new System.Drawing.Point(-3, -1);
            this.search_tb.IconLeftSize = new System.Drawing.Size(35, 35);
            this.search_tb.Location = new System.Drawing.Point(20, 10);
            this.search_tb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.search_tb.Name = "search_tb";
            this.search_tb.PasswordChar = '\0';
            this.search_tb.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.search_tb.PlaceholderText = "";
            this.search_tb.SelectedText = "";
            this.search_tb.Size = new System.Drawing.Size(200, 40);
            this.search_tb.TabIndex = 5;
            this.search_tb.TextChanged += new System.EventHandler(this.search_tb_TextChanged);
            this.search_tb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.search_tb_MouseClick);
            // 
            // dssp_pnl
            // 
            this.dssp_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dssp_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dssp_pnl.Controls.Add(this.dshh_lbl);
            this.dssp_pnl.Location = new System.Drawing.Point(0, 60);
            this.dssp_pnl.Name = "dssp_pnl";
            this.dssp_pnl.Size = new System.Drawing.Size(844, 50);
            this.dssp_pnl.TabIndex = 6;
            // 
            // dshh_lbl
            // 
            this.dshh_lbl.AutoSize = true;
            this.dshh_lbl.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.dshh_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dshh_lbl.Location = new System.Drawing.Point(300, 11);
            this.dshh_lbl.Name = "dshh_lbl";
            this.dshh_lbl.Size = new System.Drawing.Size(222, 26);
            this.dshh_lbl.TabIndex = 4;
            this.dshh_lbl.Text = "Danh sách hàng hoá";
            // 
            // thucpham_btn
            // 
            this.thucpham_btn.BorderRadius = 20;
            this.thucpham_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thucpham_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.thucpham_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.thucpham_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.thucpham_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.thucpham_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.thucpham_btn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.thucpham_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.thucpham_btn.Location = new System.Drawing.Point(660, 120);
            this.thucpham_btn.Name = "thucpham_btn";
            this.thucpham_btn.Size = new System.Drawing.Size(150, 40);
            this.thucpham_btn.TabIndex = 13;
            this.thucpham_btn.Text = "Thực phẩm";
            this.thucpham_btn.Click += new System.EventHandler(this.thucpham_btn_Click);
            // 
            // dientu_btn
            // 
            this.dientu_btn.BorderRadius = 20;
            this.dientu_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dientu_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dientu_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dientu_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dientu_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dientu_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dientu_btn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.dientu_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dientu_btn.Location = new System.Drawing.Point(450, 120);
            this.dientu_btn.Name = "dientu_btn";
            this.dientu_btn.Size = new System.Drawing.Size(150, 40);
            this.dientu_btn.TabIndex = 12;
            this.dientu_btn.Text = "Điện tử";
            this.dientu_btn.Click += new System.EventHandler(this.dientu_btn_Click);
            // 
            // giadung_btn
            // 
            this.giadung_btn.BorderRadius = 20;
            this.giadung_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.giadung_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.giadung_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.giadung_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.giadung_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.giadung_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.giadung_btn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.giadung_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.giadung_btn.Location = new System.Drawing.Point(240, 120);
            this.giadung_btn.Name = "giadung_btn";
            this.giadung_btn.Size = new System.Drawing.Size(150, 40);
            this.giadung_btn.TabIndex = 11;
            this.giadung_btn.Text = "Gia dụng";
            this.giadung_btn.Click += new System.EventHandler(this.giadung_btn_Click);
            // 
            // tatca_btn
            // 
            this.tatca_btn.BorderRadius = 20;
            this.tatca_btn.Checked = true;
            this.tatca_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tatca_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tatca_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tatca_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tatca_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tatca_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tatca_btn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.tatca_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.tatca_btn.Location = new System.Drawing.Point(30, 120);
            this.tatca_btn.Name = "tatca_btn";
            this.tatca_btn.Size = new System.Drawing.Size(150, 40);
            this.tatca_btn.TabIndex = 10;
            this.tatca_btn.Text = "Tất cả";
            this.tatca_btn.Click += new System.EventHandler(this.tatca_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(0, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 5);
            this.panel2.TabIndex = 15;
            // 
            // xoahh_btn
            // 
            this.xoahh_btn.AutoScroll = true;
            this.xoahh_btn.Location = new System.Drawing.Point(15, 190);
            this.xoahh_btn.Name = "xoahh_btn";
            this.xoahh_btn.Size = new System.Drawing.Size(810, 370);
            this.xoahh_btn.TabIndex = 14;
            // 
            // them_btn
            // 
            this.them_btn.BorderRadius = 20;
            this.them_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.them_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.them_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.them_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.them_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.them_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(132)))), ((int)(((byte)(49)))));
            this.them_btn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.them_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.them_btn.Location = new System.Drawing.Point(472, 10);
            this.them_btn.Name = "them_btn";
            this.them_btn.PressedColor = System.Drawing.Color.Purple;
            this.them_btn.Size = new System.Drawing.Size(150, 40);
            this.them_btn.TabIndex = 16;
            this.them_btn.Text = "Thêm hàng hoá";
            this.them_btn.Click += new System.EventHandler(this.them_btn_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.guna2Button2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.guna2Button2.Location = new System.Drawing.Point(638, 11);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.Red;
            this.guna2Button2.Size = new System.Drawing.Size(150, 40);
            this.guna2Button2.TabIndex = 17;
            this.guna2Button2.Text = "Xoá hàng hoá";
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(844, 578);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.them_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.xoahh_btn);
            this.Controls.Add(this.thucpham_btn);
            this.Controls.Add(this.dientu_btn);
            this.Controls.Add(this.giadung_btn);
            this.Controls.Add(this.tatca_btn);
            this.Controls.Add(this.dssp_pnl);
            this.Controls.Add(this.search_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTrangChu";
            this.Text = "FormTrangChu";
            this.dssp_pnl.ResumeLayout(false);
            this.dssp_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel dssp_pnl;
        private System.Windows.Forms.Label dshh_lbl;
        private Guna.UI2.WinForms.Guna2Button thucpham_btn;
        private Guna.UI2.WinForms.Guna2Button dientu_btn;
        private Guna.UI2.WinForms.Guna2Button giadung_btn;
        private Guna.UI2.WinForms.Guna2Button tatca_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel xoahh_btn;
        private Guna.UI2.WinForms.Guna2TextBox search_tb;
        private Guna.UI2.WinForms.Guna2Button them_btn;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}