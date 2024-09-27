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
    public partial class QuanLyLopHoc : Form
    {
        public QuanLyLopHoc()
        {
            InitializeComponent();
        }

        private void QuanLyLopHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string connectionString = @"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True";
            string query = "SELECT * FROM Classes";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvLopHoc.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {

            string tenLop = txtTenLop.Text.Trim();
            string gvcn = txtGVCN.Text.Trim();

            // Kiểm tra thông tin đầu vào
            if (string.IsNullOrEmpty(tenLop) || string.IsNullOrEmpty(gvcn))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin lớp học.");
                return;
            }

            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = @"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True";

            // Câu truy vấn thêm lớp học
            string query = "INSERT INTO Classes (TenLop, GiaoVienCN) VALUES (@TenLop, @GiaoVienCN)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số vào câu lệnh SQL

                        cmd.Parameters.AddWithValue("@TenLop", tenLop);
                        cmd.Parameters.AddWithValue("@GiaoVienCN", gvcn);

                        // Thực thi lệnh SQL
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm lớp học thành công.");
                            LoadData(); // Tải lại dữ liệu lên DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Thêm lớp học thất bại.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            string tenLop = txtTenLop.Text.Trim();
            string gvcn = txtGVCN.Text.Trim();
            string classID = txtMaLop.Text.Trim(); // Lấy mã lớp từ TextBox

            // Kiểm tra thông tin đầu vào
            if (string.IsNullOrEmpty(tenLop) || string.IsNullOrEmpty(gvcn) || string.IsNullOrEmpty(classID))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin lớp học.");
                return;
            }

            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = @"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True";

            // Câu truy vấn cập nhật lớp học
            string query = "UPDATE Classes SET TenLop = @TenLop, GiaoVienCN = @GiaoVienCN WHERE ClassID = @ClassID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        cmd.Parameters.AddWithValue("@TenLop", tenLop);
                        cmd.Parameters.AddWithValue("@GiaoVienCN", gvcn);
                        cmd.Parameters.AddWithValue("@ClassID", classID); // Thêm mã lớp vào tham số

                        // Thực thi lệnh SQL
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật lớp học thành công.");
                            LoadData(); // Tải lại dữ liệu lên DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật lớp học thất bại. Vui lòng kiểm tra lại mã lớp.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }


        private void dgvLopHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấn vào hàng nào không
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin hàng được chọn
                DataGridViewRow row = dgvLopHoc.Rows[e.RowIndex];

                // Điền dữ liệu vào các ô trên form
                txtMaLop.Text = row.Cells["ClassID"].Value.ToString();
                txtTenLop.Text = row.Cells["TenLop"].Value.ToString();
                txtGVCN.Text = row.Cells["GiaoVienCN"].Value.ToString();

            }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mã lớp nào được nhập không
            string classID = txtMaLop.Text.Trim();

            if (string.IsNullOrEmpty(classID))
            {
                MessageBox.Show("Vui lòng nhập mã lớp cần xóa.");
                return;
            }

            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = @"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True";

            // Câu truy vấn xóa lớp học
            string query = "DELETE FROM Classes WHERE ClassID = @ClassID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        cmd.Parameters.AddWithValue("@ClassID", classID);

                        // Thực thi lệnh SQL
                        int rowsAffected = cmd.ExecuteNonQuery();
                        cleardata();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa lớp học thành công.");
                            LoadData(); // Tải lại dữ liệu lên DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy lớp học với mã đã nhập.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void cleardata()
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtGVCN.Clear();
        }
    }

}
