
namespace DA_LapTrinhUngDung
{
    partial class QuanLyLichDay
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
            this.txtScheduleID = new System.Windows.Forms.TextBox();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.txtDayOfWeek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemLichDay = new System.Windows.Forms.Button();
            this.btnSuaLichDay = new System.Windows.Forms.Button();
            this.btnXoaLichDay = new System.Windows.Forms.Button();
            this.cmbLopHoc = new System.Windows.Forms.ComboBox();
            this.cmbGiaoVien = new System.Windows.Forms.ComboBox();
            this.dgvLichDay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichDay)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScheduleID
            // 
            this.txtScheduleID.Location = new System.Drawing.Point(197, 349);
            this.txtScheduleID.Name = "txtScheduleID";
            this.txtScheduleID.Size = new System.Drawing.Size(154, 22);
            this.txtScheduleID.TabIndex = 0;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(197, 377);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(154, 22);
            this.txtStartTime.TabIndex = 1;
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(197, 405);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(154, 22);
            this.txtEndTime.TabIndex = 2;
            // 
            // txtDayOfWeek
            // 
            this.txtDayOfWeek.Location = new System.Drawing.Point(197, 433);
            this.txtDayOfWeek.Name = "txtDayOfWeek";
            this.txtDayOfWeek.Size = new System.Drawing.Size(154, 22);
            this.txtDayOfWeek.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "mã lớp học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "mã giáo viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "mã lịch dạy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "thời gian bắt đầu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "thời gian kết thúc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "ngày trong tuần";
            // 
            // btnThemLichDay
            // 
            this.btnThemLichDay.Location = new System.Drawing.Point(81, 521);
            this.btnThemLichDay.Name = "btnThemLichDay";
            this.btnThemLichDay.Size = new System.Drawing.Size(99, 51);
            this.btnThemLichDay.TabIndex = 15;
            this.btnThemLichDay.Text = "Thêm";
            this.btnThemLichDay.UseVisualStyleBackColor = true;
            this.btnThemLichDay.Click += new System.EventHandler(this.btnThemLichDay_Click);
            // 
            // btnSuaLichDay
            // 
            this.btnSuaLichDay.Location = new System.Drawing.Point(224, 521);
            this.btnSuaLichDay.Name = "btnSuaLichDay";
            this.btnSuaLichDay.Size = new System.Drawing.Size(99, 51);
            this.btnSuaLichDay.TabIndex = 16;
            this.btnSuaLichDay.Text = " sửa";
            this.btnSuaLichDay.UseVisualStyleBackColor = true;
            this.btnSuaLichDay.Click += new System.EventHandler(this.btnSuaLichDay_Click);
            // 
            // btnXoaLichDay
            // 
            this.btnXoaLichDay.Location = new System.Drawing.Point(383, 521);
            this.btnXoaLichDay.Name = "btnXoaLichDay";
            this.btnXoaLichDay.Size = new System.Drawing.Size(99, 51);
            this.btnXoaLichDay.TabIndex = 17;
            this.btnXoaLichDay.Text = "xóa lịch dạy";
            this.btnXoaLichDay.UseVisualStyleBackColor = true;
            this.btnXoaLichDay.Click += new System.EventHandler(this.btnXoaLichDay_Click);
            // 
            // cmbLopHoc
            // 
            this.cmbLopHoc.FormattingEnabled = true;
            this.cmbLopHoc.Location = new System.Drawing.Point(197, 291);
            this.cmbLopHoc.Name = "cmbLopHoc";
            this.cmbLopHoc.Size = new System.Drawing.Size(154, 24);
            this.cmbLopHoc.TabIndex = 19;
            // 
            // cmbGiaoVien
            // 
            this.cmbGiaoVien.FormattingEnabled = true;
            this.cmbGiaoVien.Location = new System.Drawing.Point(197, 323);
            this.cmbGiaoVien.Name = "cmbGiaoVien";
            this.cmbGiaoVien.Size = new System.Drawing.Size(154, 24);
            this.cmbGiaoVien.TabIndex = 20;
            // 
            // dgvLichDay
            // 
            this.dgvLichDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichDay.Location = new System.Drawing.Point(25, 12);
            this.dgvLichDay.Name = "dgvLichDay";
            this.dgvLichDay.RowHeadersWidth = 51;
            this.dgvLichDay.RowTemplate.Height = 24;
            this.dgvLichDay.Size = new System.Drawing.Size(941, 213);
            this.dgvLichDay.TabIndex = 55;
            this.dgvLichDay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichDay_CellContentClick);
            // 
            // QuanLyLichDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 649);
            this.Controls.Add(this.dgvLichDay);
            this.Controls.Add(this.cmbGiaoVien);
            this.Controls.Add(this.cmbLopHoc);
            this.Controls.Add(this.btnXoaLichDay);
            this.Controls.Add(this.btnSuaLichDay);
            this.Controls.Add(this.btnThemLichDay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDayOfWeek);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.txtScheduleID);
            this.Name = "QuanLyLichDay";
            this.Text = "QuanLyLichDay";
            this.Load += new System.EventHandler(this.QuanLyLichDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScheduleID;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.TextBox txtDayOfWeek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemLichDay;
        private System.Windows.Forms.Button btnSuaLichDay;
        private System.Windows.Forms.Button btnXoaLichDay;
        private System.Windows.Forms.ComboBox cmbLopHoc;
        private System.Windows.Forms.ComboBox cmbGiaoVien;
        private System.Windows.Forms.DataGridView dgvLichDay;
    }
}