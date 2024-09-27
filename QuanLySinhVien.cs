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
    public partial class QuanLySinhVien : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True");

        public QuanLySinhVien()
        {
            InitializeComponent();
        }
        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {

            HienThiSinhVien();
            LoadMaLop();
            LoadGioiTinh();

        }
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Sử dụng khối using để tự động quản lý kết nối
            using (SqlConnection conn = new SqlConnection(@"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True"))
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Câu truy vấn để thêm sinh viên
                    string query = "INSERT INTO Students (HoTen, NgaySinh, GioiTinh, SDT, Email, DiaChi, ClassID) VALUES (@HoTen, @NgaySinh, @GioiTinh, @SDT, @Email, @DiaChi, @ClassID)";

                    // Khởi tạo SqlCommand với câu truy vấn và kết nối
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số vào câu truy vấn
                        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                        cmd.Parameters.AddWithValue("@GioiTinh", cbGioiTinh.Text);
                        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                        cmd.Parameters.AddWithValue("@ClassID", cbMaLop.SelectedValue);

                        // Thực thi câu truy vấn
                        cmd.ExecuteNonQuery();

                        // Hiển thị thông báo thành công
                        MessageBox.Show("Thêm sinh viên thành công!");

                        // Cập nhật DataGridView
                        HienThiSinhVien();

                        // Xóa dữ liệu trên form nếu cần
                        cleardata();
                    } // SqlCommand sẽ tự động được giải phóng
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                // Kết nối sẽ tự động được đóng ở đây nhờ vào using
            }
        }

        private void cleardata()
        {
            txtHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Now; // Đặt lại ngày sinh về hiện tại hoặc giá trị mặc định
            cbGioiTinh.SelectedIndex = -1; // Đặt lại ComboBox về không chọn
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            cbMaLop.SelectedIndex = -1; // Đặt lại ComboBox lớp học về không chọn
        }
        private void LoadMaLop()
        {
            try
            {
                conn.Open();
                string query = "SELECT ClassID, TenLop FROM Classes"; // Điều chỉnh câu truy vấn nếu cần
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbMaLop.DataSource = dt;
                cbMaLop.DisplayMember = "TenLop"; // Tên hiển thị trong ComboBox
                cbMaLop.ValueMember = "ClassID"; // Giá trị thực tế khi chọn
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
        private void LoadGioiTinh()
        {
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
        }


        private void HienThiSinhVien()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Students";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSinhVien.DataSource = dt;
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
       

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dữ liệu cần sửa không
            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa và điền đầy đủ thông tin.");
                return;
            }

            // Sử dụng khối using để tự động quản lý kết nối
            using (SqlConnection conn = new SqlConnection(@"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True"))
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Câu truy vấn cập nhật thông tin sinh viên
                    string query = "UPDATE Students SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, SDT = @SDT, Email = @Email, DiaChi = @DiaChi, ClassID = @ClassID WHERE StudentID = @StudentID";

                    // Khởi tạo SqlCommand với câu truy vấn và kết nối
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số vào câu truy vấn
                        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                        cmd.Parameters.AddWithValue("@GioiTinh", cbGioiTinh.Text);
                        cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                        cmd.Parameters.AddWithValue("@ClassID", cbMaLop.SelectedValue);

                        // Thêm tham số StudentID để xác định sinh viên cần sửa
                        cmd.Parameters.AddWithValue("@StudentID", txtMaSV.Text); // Cần có trường StudentID trên form để lưu ID của sinh viên

                        // Thực thi câu truy vấn
                        cmd.ExecuteNonQuery();

                        // Hiển thị thông báo thành công
                        MessageBox.Show("Cập nhật thông tin sinh viên thành công!");

                        // Cập nhật lại DataGridView
                        HienThiSinhVien();

                        // Xóa dữ liệu trên form nếu cần
                        cleardata();
                    } // SqlCommand sẽ tự động được giải phóng
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                // Kết nối sẽ tự động được đóng ở đây nhờ vào using
            }
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
                // Kiểm tra xem người dùng có nhấn vào hàng nào không
                if (e.RowIndex >= 0)
                {
                    // Lấy thông tin hàng được chọn
                    DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

                    // Điền dữ liệu vào các ô trên form
                    txtMaSV.Text = row.Cells["StudentID"].Value.ToString();
                    txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                    cbGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                    txtSDT.Text = row.Cells["SDT"].Value.ToString();
                    txtEmail.Text = row.Cells["Email"].Value.ToString();
                    txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                    cbMaLop.SelectedValue = row.Cells["ClassID"].Value;
                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn sinh viên nào chưa
            if (string.IsNullOrEmpty(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa.");
                return;
            }

            // Hiển thị thông báo xác nhận trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Sử dụng khối using để tự động quản lý kết nối
                using (SqlConnection conn = new SqlConnection(@"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True"))
                {
                    try
                    {
                        // Mở kết nối
                        conn.Open();

                        // Câu truy vấn để xóa sinh viên
                        string query = "DELETE FROM Students WHERE StudentID = @StudentID";

                        // Khởi tạo SqlCommand với câu truy vấn và kết nối
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Thêm tham số StudentID vào câu truy vấn
                            cmd.Parameters.AddWithValue("@StudentID", txtMaSV.Text);

                            // Thực thi câu truy vấn
                            cmd.ExecuteNonQuery();

                            // Hiển thị thông báo thành công
                            MessageBox.Show("Xóa sinh viên thành công!");

                            // Cập nhật lại DataGridView
                            HienThiSinhVien();

                            // Xóa dữ liệu trên form nếu cần
                            cleardata();
                        } // SqlCommand sẽ tự động được giải phóng
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo lỗi
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                    // Kết nối sẽ tự động được đóng ở đây nhờ vào using
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu tìm kiếm từ các ô text
            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();

            // Kiểm tra người dùng có nhập gì không
            if (string.IsNullOrEmpty(maSV) && string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập Mã sinh viên hoặc Họ tên để tìm kiếm.");
                return;
            }

            // Khởi tạo chuỗi truy vấn SQL cơ bản
            string query = "SELECT * FROM Students WHERE 1 = 1";

            // Sử dụng khối using để tự động quản lý kết nối
            using (SqlConnection conn = new SqlConnection(@"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True"))
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Khởi tạo SqlCommand với câu truy vấn và kết nối
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;

                        // Nếu người dùng nhập mã sinh viên, thêm điều kiện tìm kiếm theo mã sinh viên
                        if (!string.IsNullOrEmpty(maSV))
                        {
                            query += " AND StudentID LIKE @StudentID";
                            cmd.Parameters.AddWithValue("@StudentID", "%" + maSV + "%"); // Sử dụng LIKE và dấu % để tìm kiếm chứa chuỗi
                        }

                        // Nếu người dùng nhập họ tên, thêm điều kiện tìm kiếm theo họ tên
                        if (!string.IsNullOrEmpty(hoTen))
                        {
                            query += " AND HoTen LIKE @HoTen";
                            cmd.Parameters.AddWithValue("@HoTen", "%" + hoTen + "%"); // Sử dụng LIKE và dấu % để tìm kiếm chứa chuỗi
                        }

                        // Gán câu truy vấn cho SqlCommand
                        cmd.CommandText = query;

                        // Tạo SqlDataAdapter để lấy dữ liệu từ cơ sở dữ liệu
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        // Đổ dữ liệu vào DataTable
                        da.Fill(dt);

                        // Kiểm tra nếu không có kết quả
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy sinh viên nào khớp với tiêu chí tìm kiếm.");
                        }

                        // Gán kết quả vào DataGridView
                        dgvSinhVien.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

    }
}