using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_LapTrinhUngDung
{
    public partial class FormQL : Form
    {
        public FormQL()
        {
            InitializeComponent();
        }

        private void btnQLGiaoVien_Click(object sender, EventArgs e)
        {
            // Ẩn form hiện tại
            this.Hide();

            // Mở form quản lý giáo viên 
            Form1 formQlGiaoVien = new Form1();
            formQlGiaoVien.ShowDialog();

            
            this.Show();
        }

        private void btnQLSinhvien_Click(object sender, EventArgs e)
        {
            // Ẩn form hiện tại
            this.Hide();

            // Mở form đăng ký tài khoản
            QuanLySinhVien formQlSinhVien = new QuanLySinhVien();
            formQlSinhVien.ShowDialog();

            this.Show();
        }

        private void btnQLLopHoc_Click(object sender, EventArgs e)
        {
            // Ẩn form hiện tại
            this.Hide();

            // Mở form đăng ký tài khoản
            QuanLyLopHoc formQlLopHoc = new QuanLyLopHoc();  
            formQlLopHoc.ShowDialog();

            this.Show();
        }

        private void btnQLKhoaHoc_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Mở form đăng ký tài khoản
            QuanLyKhoaHoc formQlKhoaHoc = new QuanLyKhoaHoc();
            formQlKhoaHoc.ShowDialog();

            this.Show();
        }

        private void btnQLGhiDanh_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Mở form đăng ký tài khoản
            QuanLyGhiDanh formQlGhiDanh = new QuanLyGhiDanh();
            formQlGhiDanh.ShowDialog();

            this.Show();
        }

        private void btnQLLichDay_Click(object sender, EventArgs e)
        {
                 this.Hide();

                // Mở form đăng ký tài khoản
                QuanLyLichDay formQlLichDay = new QuanLyLichDay();
                formQlLichDay.ShowDialog();

                this.Show();
        }
        
    }
}
