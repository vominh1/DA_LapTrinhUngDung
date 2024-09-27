using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DA_LapTrinhUngDung
{
    public partial class QuanLyGhiDanh : Form
    {
        public QuanLyGhiDanh()
        {
            InitializeComponent();
            LoadData();
        }
        private void QuanLyGhiDanh_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadMaMH();
        }
        private void LoadData()
        {
            string connectionString = @"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True";
            string query = "SELECT * FROM Enrollments";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvGhiDanh.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void LoadMaMH()
        {
            string connectionString = @"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True";
            string query = "SELECT * FROM Subjects"; // Giả sử bạn có bảng MonHoc
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbMaMH.Items.Add(reader["MaMH"].ToString()); // Chỉ thêm mã môn học
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnThemGhiDanh_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            string studentID = txtMaSV.Text.Trim();
            string courseID = txtMaKhoaHc.Text.Trim();
            string maMH = cmbMaMH.SelectedItem?.ToString(); // Giả sử bạn sử dụng ComboBox cho mã môn học
            float diem;

            // Kiểm tra đầu vào hợp lệ
            if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(courseID) || string.IsNullOrEmpty(maMH) || !float.TryParse(txtDiem.Text.Trim(), out diem))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và điểm hợp lệ.");
                return;
            }

            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = @"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True";

            // Câu lệnh SQL để thêm ghi danh mới
            string query = "INSERT INTO Enrollments (StudentID, CourseID, MaMH, Diem) VALUES (@StudentID, @CourseID, @MaMH, @Diem)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm các tham số cho câu lệnh SQL
                        cmd.Parameters.AddWithValue("@StudentID", studentID);
                        cmd.Parameters.AddWithValue("@CourseID", courseID);
                        cmd.Parameters.AddWithValue("@MaMH", maMH);
                        cmd.Parameters.AddWithValue("@Diem", diem);

                        // Thực thi câu lệnh
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm ghi danh mới thành công.");
                            LoadData(); // Tải lại dữ liệu lên DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Thêm ghi danh thất bại.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }



        private void dgvGhiDanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin hàng được chọn
                DataGridViewRow row = dgvGhiDanh.Rows[e.RowIndex];

                // Điền dữ liệu vào các ô trên form
                txtMaGhiDanh.Text = row.Cells["EnrollmentID"].Value.ToString();
                txtMaSV.Text = row.Cells["StudentID"].Value.ToString();
                txtMaKhoaHoc.Text = row.Cells["CourseID"].Value.ToString();
                cmbMaMH.SelectedItem = row.Cells["MaMH"].Value.ToString(); // Đặt giá trị cho ComboBox
                txtDiem.Text = row.Cells["Diem"].Value.ToString();
            }
        }

        private void btnSuaGhiDanh_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            int enrollmentID;
            string studentID = txtMaSV.Text.Trim();
            string courseID = txtMaKhoaHc.Text.Trim();
            string maMH = cmbMaMH.SelectedItem?.ToString(); // Giả sử bạn sử dụng ComboBox cho mã môn học
            float diem;

            // Kiểm tra đầu vào hợp lệ
            if (!int.TryParse(txtMaGhiDanh.Text.Trim(), out enrollmentID) ||
                string.IsNullOrEmpty(studentID) ||
                string.IsNullOrEmpty(courseID) ||
                string.IsNullOrEmpty(maMH) ||
                !float.TryParse(txtDiem.Text.Trim(), out diem))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và điểm hợp lệ.");
                return;
            }

            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = @"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True";

            // Câu lệnh SQL để cập nhật ghi danh
            string query = "UPDATE Enrollments SET StudentID = @StudentID, CourseID = @CourseID, MaMH = @MaMH, Diem = @Diem WHERE EnrollmentID = @EnrollmentID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open(); // Mở kết nối
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm các tham số cho câu lệnh SQL
                        cmd.Parameters.AddWithValue("@EnrollmentID", enrollmentID);
                        cmd.Parameters.AddWithValue("@StudentID", studentID);
                        cmd.Parameters.AddWithValue("@CourseID", courseID);
                        cmd.Parameters.AddWithValue("@MaMH", maMH);
                        cmd.Parameters.AddWithValue("@Diem", diem);

                        // Thực thi câu lệnh
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật ghi danh thành công."); // Thông báo thành công
                            LoadData(); // Tải lại dữ liệu lên DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật ghi danh thất bại."); // Thông báo thất bại
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message); // Hiển thị lỗi nếu có
                }
            }
        }

        private void btnXoaGhiDanh_Click(object sender, EventArgs e)
        {
            int enrollmentID;

            // Kiểm tra đầu vào hợp lệ
            if (!int.TryParse(txtMaGhiDanh.Text.Trim(), out enrollmentID))
            {
                MessageBox.Show("Vui lòng nhập mã ghi danh hợp lệ để xóa.");
                return;
            }

            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = @"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True";

            // Câu lệnh SQL để xóa ghi danh
            string query = "DELETE FROM Enrollments WHERE EnrollmentID = @EnrollmentID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open(); // Mở kết nối
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số cho câu lệnh SQL
                        cmd.Parameters.AddWithValue("@EnrollmentID", enrollmentID);

                        // Thực thi câu lệnh
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa ghi danh thành công."); // Thông báo thành công
                            LoadData(); // Tải lại dữ liệu lên DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Xóa ghi danh thất bại."); // Thông báo thất bại
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message); // Hiển thị lỗi nếu có
                }
            }
        }

    }
}
