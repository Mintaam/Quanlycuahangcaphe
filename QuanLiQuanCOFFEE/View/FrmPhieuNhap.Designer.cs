namespace QuanLiQuanCOFFEE
{
    partial class FrmPhieuNhap
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
            this.QuảnlýPN = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNV = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbMaNV1 = new System.Windows.Forms.ComboBox();
            this.txtNgaylap = new System.Windows.Forms.DateTimePicker();
            this.btnSua1 = new System.Windows.Forms.Button();
            this.btnThoat1 = new System.Windows.Forms.Button();
            this.btnThem1 = new System.Windows.Forms.Button();
            this.btnXoa1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPN1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbMaHH2 = new System.Windows.Forms.ComboBox();
            this.cbMaPN2 = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btnSua2 = new System.Windows.Forms.Button();
            this.btnThoat2 = new System.Windows.Forms.Button();
            this.btnThem2 = new System.Windows.Forms.Button();
            this.btnXoa2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvPN2 = new System.Windows.Forms.DataGridView();
            this.txtMaPN1 = new System.Windows.Forms.TextBox();
            this.QuảnlýPN.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN2)).BeginInit();
            this.SuspendLayout();
            // 
            // QuảnlýPN
            // 
            this.QuảnlýPN.Controls.Add(this.tabPage1);
            this.QuảnlýPN.Controls.Add(this.tabPage2);
            this.QuảnlýPN.Location = new System.Drawing.Point(21, 22);
            this.QuảnlýPN.Name = "QuảnlýPN";
            this.QuảnlýPN.SelectedIndex = 0;
            this.QuảnlýPN.Size = new System.Drawing.Size(978, 521);
            this.QuảnlýPN.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lbNV);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dgvPN1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(970, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý Phiếu nhập";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(543, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 31);
            this.label4.TabIndex = 23;
            this.label4.Text = "Danh sách phiếu nhập";
            // 
            // lbNV
            // 
            this.lbNV.AutoSize = true;
            this.lbNV.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNV.Location = new System.Drawing.Point(116, 14);
            this.lbNV.Name = "lbNV";
            this.lbNV.Size = new System.Drawing.Size(245, 31);
            this.lbNV.TabIndex = 22;
            this.lbNV.Text = "Quản lý phiếu nhập";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaPN1);
            this.panel1.Controls.Add(this.cbMaNV1);
            this.panel1.Controls.Add(this.txtNgaylap);
            this.panel1.Controls.Add(this.btnSua1);
            this.panel1.Controls.Add(this.btnThoat1);
            this.panel1.Controls.Add(this.btnThem1);
            this.panel1.Controls.Add(this.btnXoa1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(64, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 392);
            this.panel1.TabIndex = 21;
            // 
            // cbMaNV1
            // 
            this.cbMaNV1.FormattingEnabled = true;
            this.cbMaNV1.Location = new System.Drawing.Point(153, 82);
            this.cbMaNV1.Name = "cbMaNV1";
            this.cbMaNV1.Size = new System.Drawing.Size(161, 21);
            this.cbMaNV1.TabIndex = 57;
            // 
            // txtNgaylap
            // 
            this.txtNgaylap.CustomFormat = "dd/MM/yy";
            this.txtNgaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgaylap.Location = new System.Drawing.Point(153, 131);
            this.txtNgaylap.Name = "txtNgaylap";
            this.txtNgaylap.Size = new System.Drawing.Size(162, 20);
            this.txtNgaylap.TabIndex = 37;
            // 
            // btnSua1
            // 
            this.btnSua1.Location = new System.Drawing.Point(112, 238);
            this.btnSua1.Name = "btnSua1";
            this.btnSua1.Size = new System.Drawing.Size(64, 35);
            this.btnSua1.TabIndex = 35;
            this.btnSua1.Text = "Sửa";
            this.btnSua1.UseVisualStyleBackColor = true;
            this.btnSua1.Click += new System.EventHandler(this.btnSua1_Click_1);
            // 
            // btnThoat1
            // 
            this.btnThoat1.Location = new System.Drawing.Point(287, 238);
            this.btnThoat1.Name = "btnThoat1";
            this.btnThoat1.Size = new System.Drawing.Size(64, 35);
            this.btnThoat1.TabIndex = 36;
            this.btnThoat1.Text = "Thoát";
            this.btnThoat1.UseVisualStyleBackColor = true;
            this.btnThoat1.Click += new System.EventHandler(this.btnThoat1_Click_1);
            // 
            // btnThem1
            // 
            this.btnThem1.Location = new System.Drawing.Point(28, 238);
            this.btnThem1.Name = "btnThem1";
            this.btnThem1.Size = new System.Drawing.Size(64, 35);
            this.btnThem1.TabIndex = 33;
            this.btnThem1.Text = "Thêm";
            this.btnThem1.UseVisualStyleBackColor = true;
            this.btnThem1.Click += new System.EventHandler(this.btnThem1_Click_1);
            // 
            // btnXoa1
            // 
            this.btnXoa1.Location = new System.Drawing.Point(205, 238);
            this.btnXoa1.Name = "btnXoa1";
            this.btnXoa1.Size = new System.Drawing.Size(64, 35);
            this.btnXoa1.TabIndex = 34;
            this.btnXoa1.Text = "Xóa";
            this.btnXoa1.UseVisualStyleBackColor = true;
            this.btnXoa1.Click += new System.EventHandler(this.btnXoa1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(15, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mã Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(15, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ngày nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã Phiếu nhập";
            // 
            // dgvPN1
            // 
            this.dgvPN1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPN1.Location = new System.Drawing.Point(481, 48);
            this.dgvPN1.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPN1.Name = "dgvPN1";
            this.dgvPN1.RowTemplate.Height = 28;
            this.dgvPN1.Size = new System.Drawing.Size(424, 392);
            this.dgvPN1.TabIndex = 20;
            this.dgvPN1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPN1_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.dgvPN2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(970, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi tiết Phiếu nhập";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(550, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(275, 31);
            this.label11.TabIndex = 27;
            this.label11.Text = "Danh sách phiếu nhập";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(125, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(240, 31);
            this.label12.TabIndex = 26;
            this.label12.Text = "Chi tiết phiếu nhập";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbMaHH2);
            this.panel2.Controls.Add(this.cbMaPN2);
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(this.txtDonGia);
            this.panel2.Controls.Add(this.btnSua2);
            this.panel2.Controls.Add(this.btnThoat2);
            this.panel2.Controls.Add(this.btnThem2);
            this.panel2.Controls.Add(this.btnXoa2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(69, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 409);
            this.panel2.TabIndex = 25;
            // 
            // cbMaHH2
            // 
            this.cbMaHH2.FormattingEnabled = true;
            this.cbMaHH2.Location = new System.Drawing.Point(154, 75);
            this.cbMaHH2.Name = "cbMaHH2";
            this.cbMaHH2.Size = new System.Drawing.Size(161, 21);
            this.cbMaHH2.TabIndex = 56;
            // 
            // cbMaPN2
            // 
            this.cbMaPN2.FormattingEnabled = true;
            this.cbMaPN2.Location = new System.Drawing.Point(154, 30);
            this.cbMaPN2.Name = "cbMaPN2";
            this.cbMaPN2.Size = new System.Drawing.Size(161, 21);
            this.cbMaPN2.TabIndex = 56;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(154, 120);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(163, 20);
            this.txtSoLuong.TabIndex = 55;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(154, 164);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(163, 20);
            this.txtDonGia.TabIndex = 54;
            // 
            // btnSua2
            // 
            this.btnSua2.Location = new System.Drawing.Point(109, 269);
            this.btnSua2.Name = "btnSua2";
            this.btnSua2.Size = new System.Drawing.Size(64, 35);
            this.btnSua2.TabIndex = 35;
            this.btnSua2.Text = "Sửa";
            this.btnSua2.UseVisualStyleBackColor = true;
            this.btnSua2.Click += new System.EventHandler(this.btnSua2_Click);
            // 
            // btnThoat2
            // 
            this.btnThoat2.Location = new System.Drawing.Point(284, 269);
            this.btnThoat2.Name = "btnThoat2";
            this.btnThoat2.Size = new System.Drawing.Size(64, 35);
            this.btnThoat2.TabIndex = 36;
            this.btnThoat2.Text = "Thoát";
            this.btnThoat2.UseVisualStyleBackColor = true;
            // 
            // btnThem2
            // 
            this.btnThem2.Location = new System.Drawing.Point(25, 269);
            this.btnThem2.Name = "btnThem2";
            this.btnThem2.Size = new System.Drawing.Size(64, 35);
            this.btnThem2.TabIndex = 33;
            this.btnThem2.Text = "Thêm";
            this.btnThem2.UseVisualStyleBackColor = true;
            this.btnThem2.Click += new System.EventHandler(this.btnThem2_Click);
            // 
            // btnXoa2
            // 
            this.btnXoa2.Location = new System.Drawing.Point(202, 269);
            this.btnXoa2.Name = "btnXoa2";
            this.btnXoa2.Size = new System.Drawing.Size(64, 35);
            this.btnXoa2.TabIndex = 34;
            this.btnXoa2.Text = "Xóa";
            this.btnXoa2.UseVisualStyleBackColor = true;
            this.btnXoa2.Click += new System.EventHandler(this.btnXoa2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(32, 165);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "Đơn giá";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(32, 121);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 28;
            this.label9.Text = "Số lượng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(32, 77);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "Mã Hàng hóa";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(32, 30);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 19);
            this.label15.TabIndex = 21;
            this.label15.Text = "Mã Phiếu nhập";
            // 
            // dgvPN2
            // 
            this.dgvPN2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPN2.Location = new System.Drawing.Point(489, 51);
            this.dgvPN2.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPN2.Name = "dgvPN2";
            this.dgvPN2.RowTemplate.Height = 28;
            this.dgvPN2.Size = new System.Drawing.Size(424, 408);
            this.dgvPN2.TabIndex = 24;
            this.dgvPN2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPN2_CellClick);
            // 
            // txtMaPN1
            // 
            this.txtMaPN1.Location = new System.Drawing.Point(153, 29);
            this.txtMaPN1.Name = "txtMaPN1";
            this.txtMaPN1.Size = new System.Drawing.Size(163, 20);
            this.txtMaPN1.TabIndex = 58;
            // 
            // FrmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 516);
            this.Controls.Add(this.QuảnlýPN);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPhieuNhap";
            this.Text = "FrmPhieuNhap";
            this.Load += new System.EventHandler(this.FrmPhieuNhap_Load);
            this.QuảnlýPN.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl QuảnlýPN;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker txtNgaylap;
        private System.Windows.Forms.Button btnSua1;
        private System.Windows.Forms.Button btnThoat1;
        private System.Windows.Forms.Button btnThem1;
        private System.Windows.Forms.Button btnXoa1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPN1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btnSua2;
        private System.Windows.Forms.Button btnThoat2;
        private System.Windows.Forms.Button btnThem2;
        private System.Windows.Forms.Button btnXoa2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvPN2;
        private System.Windows.Forms.ComboBox cbMaHH2;
        private System.Windows.Forms.ComboBox cbMaPN2;
        private System.Windows.Forms.ComboBox cbMaNV1;
        private System.Windows.Forms.TextBox txtMaPN1;

    }
}