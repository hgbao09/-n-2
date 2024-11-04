namespace DoAnCK
{
    partial class FormHoaDonXuat
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
            this.dataHDX = new System.Windows.Forms.DataGridView();
            this.IDHDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylaphdx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanvienhdx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtienhdx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHDX)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 104);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(289, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách hóa đơn xuất";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataHDX
            // 
            this.dataHDX.AllowUserToAddRows = false;
            this.dataHDX.AllowUserToDeleteRows = false;
            this.dataHDX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHDX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDHDX,
            this.ngaylaphdx,
            this.nhanvienhdx,
            this.tongtienhdx});
            this.dataHDX.Location = new System.Drawing.Point(0, 103);
            this.dataHDX.Name = "dataHDX";
            this.dataHDX.ReadOnly = true;
            this.dataHDX.RowHeadersWidth = 51;
            this.dataHDX.RowTemplate.Height = 24;
            this.dataHDX.Size = new System.Drawing.Size(1107, 497);
            this.dataHDX.TabIndex = 6;
            // 
            // IDHDX
            // 
            this.IDHDX.FillWeight = 50F;
            this.IDHDX.HeaderText = "ID";
            this.IDHDX.MinimumWidth = 6;
            this.IDHDX.Name = "IDHDX";
            this.IDHDX.ReadOnly = true;
            this.IDHDX.Width = 125;
            // 
            // ngaylaphdx
            // 
            this.ngaylaphdx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaylaphdx.FillWeight = 110F;
            this.ngaylaphdx.HeaderText = "Ngày Lập";
            this.ngaylaphdx.MinimumWidth = 110;
            this.ngaylaphdx.Name = "ngaylaphdx";
            this.ngaylaphdx.ReadOnly = true;
            // 
            // nhanvienhdx
            // 
            this.nhanvienhdx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nhanvienhdx.FillWeight = 110F;
            this.nhanvienhdx.HeaderText = "Nhân Viên Lập";
            this.nhanvienhdx.MinimumWidth = 110;
            this.nhanvienhdx.Name = "nhanvienhdx";
            this.nhanvienhdx.ReadOnly = true;
            // 
            // tongtienhdx
            // 
            this.tongtienhdx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tongtienhdx.FillWeight = 110F;
            this.tongtienhdx.HeaderText = "Tổng Tiền";
            this.tongtienhdx.MinimumWidth = 110;
            this.tongtienhdx.Name = "tongtienhdx";
            this.tongtienhdx.ReadOnly = true;
            // 
            // FormHoaDonXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 664);
            this.Controls.Add(this.dataHDX);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHoaDonXuat";
            this.Text = "FormHoaDonXuat";
            this.Load += new System.EventHandler(this.HoaDonXuat_load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHDX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataHDX;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHDX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylaphdx;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhanvienhdx;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtienhdx;
    }
}