using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DA_LapTrinhUngDung
{
    public partial class dangnhap : Form
    {
        // Kết nối SQL
        SqlConnection conn;
        SqlCommand cmd;
        public dangnhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {// Kết nối cơ sở dữ liệu
            conn = new SqlConnection(@"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True");

            try
            {
                conn.Open();
                string query = "SELECT COUNT(1) FROM admin WHERE Username=@username AND Password=@password";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", txtTaikhoan.Text);
                cmd.Parameters.AddWithValue("@password", txtMatKhau.Text);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    this.Hide();
                    // mở form quản lí chính
                    FormQL mainForm = new FormQL();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            // Ẩn form đăng nhập hiện tại
            this.Hide();

            // Mở form đăng ký tài khoản
            DangkiTaiKhoan formDangKi = new DangkiTaiKhoan();
            formDangKi.ShowDialog();

            // Sau khi form đăng ký đóng, hiện lại form đăng nhập (nếu cần)
            this.Show();
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}