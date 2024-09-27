using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_LapTrinhUngDung
{
    public partial class QuanLyKhoaHoc : Form
    {
        public QuanLyKhoaHoc()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string connectionString = @"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True";
            string query = "SELECT * FROM Courses";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvKhoaHoc.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void btnThemKhoaHoc_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            string tenKhoaHoc = txtTenKhoaHoc.Text.Trim();
            int soTinChi;
            string moTa = txtMoTa.Text.Trim();

            // Kiểm tra đầu vào hợp lệ
            if (string.IsNullOrEmpty(tenKhoaHoc) || !int.TryParse(txtSoTinChi.Text.Trim(), out soTinChi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và số tín chỉ hợp lệ.");
                return;
            }

            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = @"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True";

            // Câu lệnh SQL để thêm khóa học mới
            string query = "INSERT INTO Courses (TenKhoaHoc, SoTinChi, MoTa) VALUES (@TenKhoaHoc, @SoTinChi, @MoTa)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm các tham số cho câu lệnh SQL
                        cmd.Parameters.AddWithValue("@TenKhoaHoc", tenKhoaHoc);
                        cmd.Parameters.AddWithValue("@SoTinChi", soTinChi);
                        cmd.Parameters.AddWithValue("@MoTa", moTa);

                        // Thực thi câu lệnh
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm khóa học mới thành công.");
                            LoadData(); // Tải lại dữ liệu lên DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Thêm khóa học thất bại.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }


        private void dgvKhoaHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin hàng được chọn
                DataGridViewRow row = dgvKhoaHoc.Rows[e.RowIndex];

                // Điền dữ liệu vào các ô trên form
                txtMaKhoaHoc.Text = row.Cells["CourseID"].Value.ToString();
                txtTenKhoaHoc.Text = row.Cells["TenKhoaHoc"].Value.ToString();
                txtSoTinChi.Text = row.Cells["SoTinChi"].Value.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value.ToString();
            }
        }

        private void btnSuaKhoaHoc_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            int courseId;
            string tenKhoaHoc = txtTenKhoaHoc.Text.Trim();
            int soTinChi;
            string moTa = txtMoTa.Text.Trim();

            // Kiểm tra đầu vào hợp lệ
            if (!int.TryParse(txtMaKhoaHoc.Text.Trim(), out courseId) || string.IsNullOrEmpty(tenKhoaHoc) || !int.TryParse(txtSoTinChi.Text.Trim(), out soTinChi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và số tín chỉ hợp lệ.");
                return;
            }

            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = @"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True";

            // Câu lệnh SQL để cập nhật khóa học
            string query = "UPDATE Courses SET TenKhoaHoc = @TenKhoaHoc, SoTinChi = @SoTinChi, MoTa = @MoTa WHERE CourseID = @CourseID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm các tham số cho câu lệnh SQL
                        cmd.Parameters.AddWithValue("@CourseID", courseId);
                        cmd.Parameters.AddWithValue("@TenKhoaHoc", tenKhoaHoc);
                        cmd.Parameters.AddWithValue("@SoTinChi", soTinChi);
                        cmd.Parameters.AddWithValue("@MoTa", moTa);

                        // Thực thi câu lệnh
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật khóa học thành công.");
                            LoadData(); // Tải lại dữ liệu lên DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật khóa học thất bại.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoaKhoaHoc_Click(object sender, EventArgs e)
        {
            int courseId;

            // Kiểm tra đầu vào hợp lệ
            if (!int.TryParse(txtMaKhoaHoc.Text.Trim(), out courseId))
            {
                MessageBox.Show("Vui lòng chọn một khóa học để xóa.");
                return;
            }

            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = @"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True";

            // Câu lệnh SQL để xóa khóa học
            string query = "DELETE FROM Courses WHERE CourseID = @CourseID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số cho câu lệnh SQL
                        cmd.Parameters.AddWithValue("@CourseID", courseId);

                        // Thực thi câu lệnh
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa khóa học thành công.");
                            LoadData(); // Tải lại dữ liệu lên DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Xóa khóa học thất bại.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

    }
}
