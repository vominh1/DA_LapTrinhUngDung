
namespace DA_LapTrinhUngDung
{
    partial class FormQL
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
            this.btnQLMonHoc = new System.Windows.Forms.Button();
            this.btnQLSinhvien = new System.Windows.Forms.Button();
            this.btnQLGiaoVien = new System.Windows.Forms.Button();
            this.btnQLLopHoc = new System.Windows.Forms.Button();
            this.btnQLKhoaHoc = new System.Windows.Forms.Button();
            this.btnQLGhiDanh = new System.Windows.Forms.Button();
            this.btnQLLichDay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQLMonHoc
            // 
            this.btnQLMonHoc.Location = new System.Drawing.Point(0, 0);
            this.btnQLMonHoc.Name = "btnQLMonHoc";
            this.btnQLMonHoc.Size = new System.Drawing.Size(75, 23);
            this.btnQLMonHoc.TabIndex = 45;
            // 
            // btnQLSinhvien
            // 
            this.btnQLSinhvien.Location = new System.Drawing.Point(265, 192);
            this.btnQLSinhvien.Name = "btnQLSinhvien";
            this.btnQLSinhvien.Size = new System.Drawing.Size(117, 67);
            this.btnQLSinhvien.TabIndex = 42;
            this.btnQLSinhvien.Text = "Quản lý sinh viên";
            this.btnQLSinhvien.UseVisualStyleBackColor = true;
            this.btnQLSinhvien.Click += new System.EventHandler(this.btnQLSinhvien_Click);
            // 
            // btnQLGiaoVien
            // 
            this.btnQLGiaoVien.Location = new System.Drawing.Point(93, 192);
            this.btnQLGiaoVien.Name = "btnQLGiaoVien";
            this.btnQLGiaoVien.Size = new System.Drawing.Size(128, 67);
            this.btnQLGiaoVien.TabIndex = 41;
            this.btnQLGiaoVien.Text = "Quản lý giáo viên";
            this.btnQLGiaoVien.UseVisualStyleBackColor = true;
            this.btnQLGiaoVien.Click += new System.EventHandler(this.btnQLGiaoVien_Click);
            // 
            // btnQLLopHoc
            // 
            this.btnQLLopHoc.Location = new System.Drawing.Point(445, 192);
            this.btnQLLopHoc.Name = "btnQLLopHoc";
            this.btnQLLopHoc.Size = new System.Drawing.Size(106, 67);
            this.btnQLLopHoc.TabIndex = 46;
            this.btnQLLopHoc.Text = "Quản lý lớp học";
            this.btnQLLopHoc.UseVisualStyleBackColor = true;
            this.btnQLLopHoc.Click += new System.EventHandler(this.btnQLLopHoc_Click);
            // 
            // btnQLKhoaHoc
            // 
            this.btnQLKhoaHoc.Location = new System.Drawing.Point(620, 192);
            this.btnQLKhoaHoc.Name = "btnQLKhoaHoc";
            this.btnQLKhoaHoc.Size = new System.Drawing.Size(131, 67);
            this.btnQLKhoaHoc.TabIndex = 47;
            this.btnQLKhoaHoc.Text = "Quản lý lớp học";
            this.btnQLKhoaHoc.UseVisualStyleBackColor = true;
            this.btnQLKhoaHoc.Click += new System.EventHandler(this.btnQLKhoaHoc_Click);
            // 
            // btnQLGhiDanh
            // 
            this.btnQLGhiDanh.Location = new System.Drawing.Point(93, 305);
            this.btnQLGhiDanh.Name = "btnQLGhiDanh";
            this.btnQLGhiDanh.Size = new System.Drawing.Size(131, 67);
            this.btnQLGhiDanh.TabIndex = 48;
            this.btnQLGhiDanh.Text = "Quản lý ghi danh";
            this.btnQLGhiDanh.UseVisualStyleBackColor = true;
            this.btnQLGhiDanh.Click += new System.EventHandler(this.btnQLGhiDanh_Click);
            // 
            // btnQLLichDay
            // 
            this.btnQLLichDay.Location = new System.Drawing.Point(265, 305);
            this.btnQLLichDay.Name = "btnQLLichDay";
            this.btnQLLichDay.Size = new System.Drawing.Size(131, 67);
            this.btnQLLichDay.TabIndex = 49;
            this.btnQLLichDay.Text = "Quản lý lịch dạy";
            this.btnQLLichDay.UseVisualStyleBackColor = true;
            this.btnQLLichDay.Click += new System.EventHandler(this.btnQLLichDay_Click);
            // 
            // FormQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQLLichDay);
            this.Controls.Add(this.btnQLGhiDanh);
            this.Controls.Add(this.btnQLKhoaHoc);
            this.Controls.Add(this.btnQLLopHoc);
            this.Controls.Add(this.btnQLMonHoc);
            this.Controls.Add(this.btnQLSinhvien);
            this.Controls.Add(this.btnQLGiaoVien);
            this.Name = "FormQL";
            this.Text = "FormQL";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnQLMonHoc;
        private System.Windows.Forms.Button btnQLSinhvien;
        private System.Windows.Forms.Button btnQLGiaoVien;
        private System.Windows.Forms.Button btnQLLopHoc;
        private System.Windows.Forms.Button btnQLKhoaHoc;
        private System.Windows.Forms.Button btnQLGhiDanh;
        private System.Windows.Forms.Button btnQLLichDay;
    }
}