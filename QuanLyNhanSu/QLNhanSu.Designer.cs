namespace QuanLyNhanSu
{
    partial class frm_NhanSu
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
            this.lb_NhanVien = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_HoTen = new System.Windows.Forms.Label();
            this.lb_SoLuongNV = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.txt_SLNhanVien = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.TextBox_DiaChi = new System.Windows.Forms.RichTextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_CapNhap = new System.Windows.Forms.Button();
            this.btn_Dem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_NhanVien
            // 
            this.lb_NhanVien.AutoSize = true;
            this.lb_NhanVien.Location = new System.Drawing.Point(32, 49);
            this.lb_NhanVien.Name = "lb_NhanVien";
            this.lb_NhanVien.Size = new System.Drawing.Size(86, 13);
            this.lb_NhanVien.TabIndex = 0;
            this.lb_NhanVien.Text = "Mã số nhân viên";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Location = new System.Drawing.Point(32, 160);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(40, 13);
            this.lb_DiaChi.TabIndex = 1;
            this.lb_DiaChi.Text = "Địa chỉ";
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.AutoSize = true;
            this.lb_HoTen.Location = new System.Drawing.Point(32, 102);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.Size = new System.Drawing.Size(39, 13);
            this.lb_HoTen.TabIndex = 2;
            this.lb_HoTen.Text = "Họ tên";
            // 
            // lb_SoLuongNV
            // 
            this.lb_SoLuongNV.AutoSize = true;
            this.lb_SoLuongNV.Location = new System.Drawing.Point(530, 46);
            this.lb_SoLuongNV.Name = "lb_SoLuongNV";
            this.lb_SoLuongNV.Size = new System.Drawing.Size(99, 13);
            this.lb_SoLuongNV.TabIndex = 3;
            this.lb_SoLuongNV.Text = "Số lượng nhân viên";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(155, 46);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(170, 20);
            this.txt_MaNV.TabIndex = 4;
            this.txt_MaNV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_SLNhanVien
            // 
            this.txt_SLNhanVien.Location = new System.Drawing.Point(533, 73);
            this.txt_SLNhanVien.Name = "txt_SLNhanVien";
            this.txt_SLNhanVien.ReadOnly = true;
            this.txt_SLNhanVien.Size = new System.Drawing.Size(96, 20);
            this.txt_SLNhanVien.TabIndex = 6;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(155, 95);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(170, 20);
            this.txt_HoTen.TabIndex = 8;
            // 
            // TextBox_DiaChi
            // 
            this.TextBox_DiaChi.Location = new System.Drawing.Point(154, 158);
            this.TextBox_DiaChi.Name = "TextBox_DiaChi";
            this.TextBox_DiaChi.Size = new System.Drawing.Size(170, 102);
            this.TextBox_DiaChi.TabIndex = 9;
            this.TextBox_DiaChi.Text = "";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(71, 321);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(120, 47);
            this.btn_Them.TabIndex = 10;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(234, 321);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(122, 47);
            this.btn_Xoa.TabIndex = 11;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_CapNhap
            // 
            this.btn_CapNhap.Location = new System.Drawing.Point(408, 321);
            this.btn_CapNhap.Name = "btn_CapNhap";
            this.btn_CapNhap.Size = new System.Drawing.Size(111, 47);
            this.btn_CapNhap.TabIndex = 12;
            this.btn_CapNhap.Text = "Cập Nhập";
            this.btn_CapNhap.UseVisualStyleBackColor = true;
            this.btn_CapNhap.Click += new System.EventHandler(this.btn_CapNhap_Click);
            // 
            // btn_Dem
            // 
            this.btn_Dem.Location = new System.Drawing.Point(646, 73);
            this.btn_Dem.Name = "btn_Dem";
            this.btn_Dem.Size = new System.Drawing.Size(66, 22);
            this.btn_Dem.TabIndex = 13;
            this.btn_Dem.Text = "Đếm";
            this.btn_Dem.UseVisualStyleBackColor = true;
            this.btn_Dem.Click += new System.EventHandler(this.btn_Dem_Click);
            // 
            // frm_NhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 419);
            this.Controls.Add(this.btn_Dem);
            this.Controls.Add(this.btn_CapNhap);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.TextBox_DiaChi);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.txt_SLNhanVien);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.lb_SoLuongNV);
            this.Controls.Add(this.lb_HoTen);
            this.Controls.Add(this.lb_DiaChi);
            this.Controls.Add(this.lb_NhanVien);
            this.Name = "frm_NhanSu";
            this.Text = "Nhân Sự";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_NhanVien;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_HoTen;
        private System.Windows.Forms.Label lb_SoLuongNV;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.TextBox txt_SLNhanVien;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.RichTextBox TextBox_DiaChi;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_CapNhap;
        private System.Windows.Forms.Button btn_Dem;
    }
}

