using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DA_LapTrinhUngDung
{
    public partial class DangkiTaiKhoan : Form
    {
        // Kết nối SQL
        SqlConnection conn;
        SqlCommand cmd;

        public DangkiTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kết nối cơ sở dữ liệu
            conn = new SqlConnection(@"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True");
            try
            {
                conn.Open();

                // Kiểm tra nếu tài khoản đã tồn tại
                string checkQuery = "SELECT COUNT(1) FROM admin WHERE Username=@username";
                cmd = new SqlCommand(checkQuery, conn);
                cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                int userExists = Convert.ToInt32(cmd.ExecuteScalar());

                if (userExists > 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!");
                    return;
                }

                // Truy vấn thêm admin mới vào cơ sở dữ liệu
                string query = "INSERT INTO admin (Username, Password, HoTen, NgaySinh, SDT) " +
                               "VALUES (@username, @password, @hoten, @ngaysinh, @sdt)";

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                cmd.Parameters.AddWithValue("@password", txtPassWord.Text);
                cmd.Parameters.AddWithValue("@hoten", textHoTen.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@sdt", textSDT.Text);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Đăng kí thành công!");
                    this.Close(); // Đóng form đăng ký
                }
                else
                {
                    MessageBox.Show("Đăng kí thất bại!");
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

        private void DangkiTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
