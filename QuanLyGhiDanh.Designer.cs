
namespace DA_LapTrinhUngDung
{
    partial class QuanLyGhiDanh
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
            this.btnXoaGhiDanh = new System.Windows.Forms.Button();
            this.btnSuaGhiDanh = new System.Windows.Forms.Button();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKhoaHoc = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.dgvGhiDanh = new System.Windows.Forms.DataGridView();
            this.btnThemKhoaHoc = new System.Windows.Forms.Button();
            this.txtMaGhiDanh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaKhoaHc = new System.Windows.Forms.TextBox();
            this.btnThemGhiDanh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMaMH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGhiDanh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoaGhiDanh
            // 
            this.btnXoaGhiDanh.Location = new System.Drawing.Point(685, 475);
            this.btnXoaGhiDanh.Name = "btnXoaGhiDanh";
            this.btnXoaGhiDanh.Size = new System.Drawing.Size(128, 67);
            this.btnXoaGhiDanh.TabIndex = 64;
            this.btnXoaGhiDanh.Text = "Xóa";
            this.btnXoaGhiDanh.UseVisualStyleBackColor = true;
            this.btnXoaGhiDanh.Click += new System.EventHandler(this.btnXoaGhiDanh_Click);
            // 
            // btnSuaGhiDanh
            // 
            this.btnSuaGhiDanh.Location = new System.Drawing.Point(386, 475);
            this.btnSuaGhiDanh.Name = "btnSuaGhiDanh";
            this.btnSuaGhiDanh.Size = new System.Drawing.Size(128, 67);
            this.btnSuaGhiDanh.TabIndex = 63;
            this.btnSuaGhiDanh.Text = "Sửa";
            this.btnSuaGhiDanh.UseVisualStyleBackColor = true;
            this.btnSuaGhiDanh.Click += new System.EventHandler(this.btnSuaGhiDanh_Click);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(260, 79);
            this.txtMaSV.Multiline = true;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(111, 35);
            this.txtMaSV.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 69;
            this.label1.Text = "Mã sinh viên";
            // 
            // txtMaKhoaHoc
            // 
            this.txtMaKhoaHoc.Location = new System.Drawing.Point(-176, 35);
            this.txtMaKhoaHoc.Multiline = true;
            this.txtMaKhoaHoc.Name = "txtMaKhoaHoc";
            this.txtMaKhoaHoc.Size = new System.Drawing.Size(111, 35);
            this.txtMaKhoaHoc.TabIndex = 58;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(-179, -7);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(89, 17);
            this.txt.TabIndex = 68;
            this.txt.Text = "Mã khóa học";
            // 
            // dgvGhiDanh
            // 
            this.dgvGhiDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGhiDanh.Location = new System.Drawing.Point(54, 176);
            this.dgvGhiDanh.Name = "dgvGhiDanh";
            this.dgvGhiDanh.RowHeadersWidth = 51;
            this.dgvGhiDanh.RowTemplate.Height = 24;
            this.dgvGhiDanh.Size = new System.Drawing.Size(704, 213);
            this.dgvGhiDanh.TabIndex = 67;
            this.dgvGhiDanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGhiDanh_CellContentClick);
            // 
            // btnThemKhoaHoc
            // 
            this.btnThemKhoaHoc.Location = new System.Drawing.Point(-178, 390);
            this.btnThemKhoaHoc.Name = "btnThemKhoaHoc";
            this.btnThemKhoaHoc.Size = new System.Drawing.Size(128, 67);
            this.btnThemKhoaHoc.TabIndex = 62;
            this.btnThemKhoaHoc.Text = "Thêm";
            this.btnThemKhoaHoc.UseVisualStyleBackColor = true;
            // 
            // txtMaGhiDanh
            // 
            this.txtMaGhiDanh.Location = new System.Drawing.Point(54, 79);
            this.txtMaGhiDanh.Multiline = true;
            this.txtMaGhiDanh.Name = "txtMaGhiDanh";
            this.txtMaGhiDanh.Size = new System.Drawing.Size(111, 35);
            this.txtMaGhiDanh.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 66;
            this.label3.Text = "Mã khóa học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "Mã ghi danh";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(647, 79);
            this.txtDiem.Multiline = true;
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(111, 35);
            this.txtDiem.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(644, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 71;
            this.label4.Text = "Điểm";
            // 
            // txtMaKhoaHc
            // 
            this.txtMaKhoaHc.Location = new System.Drawing.Point(447, 79);
            this.txtMaKhoaHc.Multiline = true;
            this.txtMaKhoaHc.Name = "txtMaKhoaHc";
            this.txtMaKhoaHc.Size = new System.Drawing.Size(111, 35);
            this.txtMaKhoaHc.TabIndex = 72;
            // 
            // btnThemGhiDanh
            // 
            this.btnThemGhiDanh.Location = new System.Drawing.Point(138, 475);
            this.btnThemGhiDanh.Name = "btnThemGhiDanh";
            this.btnThemGhiDanh.Size = new System.Drawing.Size(128, 67);
            this.btnThemGhiDanh.TabIndex = 73;
            this.btnThemGhiDanh.Text = "Thêm ghi danh";
            this.btnThemGhiDanh.UseVisualStyleBackColor = true;
            this.btnThemGhiDanh.Click += new System.EventHandler(this.btnThemGhiDanh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(847, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "Mã môn học";
            // 
            // cmbMaMH
            // 
            this.cmbMaMH.FormattingEnabled = true;
            this.cmbMaMH.Location = new System.Drawing.Point(850, 79);
            this.cmbMaMH.Name = "cmbMaMH";
            this.cmbMaMH.Size = new System.Drawing.Size(121, 24);
            this.cmbMaMH.TabIndex = 76;
            // 
            // QuanLyGhiDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 616);
            this.Controls.Add(this.cmbMaMH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThemGhiDanh);
            this.Controls.Add(this.txtMaKhoaHc);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXoaGhiDanh);
            this.Controls.Add(this.btnSuaGhiDanh);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaKhoaHoc);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.dgvGhiDanh);
            this.Controls.Add(this.btnThemKhoaHoc);
            this.Controls.Add(this.txtMaGhiDanh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "QuanLyGhiDanh";
            this.Text = "QuanLyGhiDanh";
            this.Load += new System.EventHandler(this.QuanLyGhiDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGhiDanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaGhiDanh;
        private System.Windows.Forms.Button btnSuaGhiDanh;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKhoaHoc;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.DataGridView dgvGhiDanh;
        private System.Windows.Forms.Button btnThemKhoaHoc;
        private System.Windows.Forms.TextBox txtMaGhiDanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaKhoaHc;
        private System.Windows.Forms.Button btnThemGhiDanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMaMH;
    }
}