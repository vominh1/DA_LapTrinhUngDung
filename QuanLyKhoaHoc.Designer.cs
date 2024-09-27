
namespace DA_LapTrinhUngDung
{
    partial class QuanLyKhoaHoc
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
            this.txtMaKhoaHoc = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.dgvKhoaHoc = new System.Windows.Forms.DataGridView();
            this.btnThemKhoaHoc = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTenKhoaHoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuaKhoaHoc = new System.Windows.Forms.Button();
            this.btnXoaKhoaHoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoaHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaKhoaHoc
            // 
            this.txtMaKhoaHoc.Location = new System.Drawing.Point(75, 94);
            this.txtMaKhoaHoc.Multiline = true;
            this.txtMaKhoaHoc.Name = "txtMaKhoaHoc";
            this.txtMaKhoaHoc.Size = new System.Drawing.Size(111, 35);
            this.txtMaKhoaHoc.TabIndex = 1;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(72, 52);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(89, 17);
            this.txt.TabIndex = 55;
            this.txt.Text = "Mã khóa học";
            // 
            // dgvKhoaHoc
            // 
            this.dgvKhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoaHoc.Location = new System.Drawing.Point(75, 163);
            this.dgvKhoaHoc.Name = "dgvKhoaHoc";
            this.dgvKhoaHoc.RowHeadersWidth = 51;
            this.dgvKhoaHoc.RowTemplate.Height = 24;
            this.dgvKhoaHoc.Size = new System.Drawing.Size(665, 213);
            this.dgvKhoaHoc.TabIndex = 54;
            this.dgvKhoaHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoaHoc_CellContentClick);
            // 
            // btnThemKhoaHoc
            // 
            this.btnThemKhoaHoc.Location = new System.Drawing.Point(73, 449);
            this.btnThemKhoaHoc.Name = "btnThemKhoaHoc";
            this.btnThemKhoaHoc.Size = new System.Drawing.Size(128, 67);
            this.btnThemKhoaHoc.TabIndex = 5;
            this.btnThemKhoaHoc.Text = "Thêm";
            this.btnThemKhoaHoc.UseVisualStyleBackColor = true;
            this.btnThemKhoaHoc.Click += new System.EventHandler(this.btnThemKhoaHoc_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(851, 94);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(380, 300);
            this.txtMoTa.TabIndex = 4;
            // 
            // txtTenKhoaHoc
            // 
            this.txtTenKhoaHoc.Location = new System.Drawing.Point(246, 94);
            this.txtTenKhoaHoc.Multiline = true;
            this.txtTenKhoaHoc.Name = "txtTenKhoaHoc";
            this.txtTenKhoaHoc.Size = new System.Drawing.Size(111, 35);
            this.txtTenKhoaHoc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(848, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Mô tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Tên khóa học";
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Location = new System.Drawing.Point(452, 94);
            this.txtSoTinChi.Multiline = true;
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Size = new System.Drawing.Size(111, 35);
            this.txtSoTinChi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Số tín chỉ";
            // 
            // btnSuaKhoaHoc
            // 
            this.btnSuaKhoaHoc.Location = new System.Drawing.Point(268, 449);
            this.btnSuaKhoaHoc.Name = "btnSuaKhoaHoc";
            this.btnSuaKhoaHoc.Size = new System.Drawing.Size(128, 67);
            this.btnSuaKhoaHoc.TabIndex = 6;
            this.btnSuaKhoaHoc.Text = "Sửa";
            this.btnSuaKhoaHoc.UseVisualStyleBackColor = true;
            this.btnSuaKhoaHoc.Click += new System.EventHandler(this.btnSuaKhoaHoc_Click);
            // 
            // btnXoaKhoaHoc
            // 
            this.btnXoaKhoaHoc.Location = new System.Drawing.Point(477, 449);
            this.btnXoaKhoaHoc.Name = "btnXoaKhoaHoc";
            this.btnXoaKhoaHoc.Size = new System.Drawing.Size(128, 67);
            this.btnXoaKhoaHoc.TabIndex = 7;
            this.btnXoaKhoaHoc.Text = "Xóa";
            this.btnXoaKhoaHoc.UseVisualStyleBackColor = true;
            this.btnXoaKhoaHoc.Click += new System.EventHandler(this.btnXoaKhoaHoc_Click);
            // 
            // QuanLyKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 578);
            this.Controls.Add(this.btnXoaKhoaHoc);
            this.Controls.Add(this.btnSuaKhoaHoc);
            this.Controls.Add(this.txtSoTinChi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaKhoaHoc);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.dgvKhoaHoc);
            this.Controls.Add(this.btnThemKhoaHoc);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtTenKhoaHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "QuanLyKhoaHoc";
            this.Text = "QuanLyKhoaHoc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoaHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaKhoaHoc;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.DataGridView dgvKhoaHoc;
        private System.Windows.Forms.Button btnThemKhoaHoc;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenKhoaHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuaKhoaHoc;
        private System.Windows.Forms.Button btnXoaKhoaHoc;
    }
}