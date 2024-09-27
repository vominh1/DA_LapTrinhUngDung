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
    public partial class QuanLyLichDay : Form
    {
        public QuanLyLichDay()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string connectionString = @"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True";
            string query = "SELECT * FROM Schedule";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvLichDay.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void LoadLopHoc()
        {
            string connectionString = @"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True";
            string query = "SELECT * FROM Classes";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbLopHoc.Items.Add(reader["ClassID"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void LoadGiaoVien()
        {
            string connectionString = @"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True";
            string query = "SELECT * FROM Teacher"; // Giả sử có bảng Teachers
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbGiaoVien.Items.Add(reader["MaGiaoVien"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }



       


     

        private void QuanLyLichDay_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadLopHoc();
            LoadGiaoVien();
        }

        private void btnThemLichDay_Click(object sender, EventArgs e)
        {
            {
                string classID = cmbLopHoc.SelectedItem?.ToString();
                string maGiaoVien = cmbGiaoVien.SelectedItem?.ToString();
                string startTime = txtStartTime.Text.Trim();
                string endTime = txtEndTime.Text.Trim();
                string dayOfWeek = txtDayOfWeek.Text.Trim();

                if (string.IsNullOrEmpty(classID) || string.IsNullOrEmpty(maGiaoVien) || string.IsNullOrEmpty(startTime) || string.IsNullOrEmpty(endTime) || string.IsNullOrEmpty(dayOfWeek))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                string connectionString = @"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True";
                string query = "INSERT INTO Schedule (ClassID, MaGiaoVien, StartTime, EndTime, DayOfWeek) VALUES (@ClassID, @MaGiaoVien, @StartTime, @EndTime, @DayOfWeek)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ClassID", classID);
                            cmd.Parameters.AddWithValue("@MaGiaoVien", maGiaoVien);
                            cmd.Parameters.AddWithValue("@StartTime", startTime);
                            cmd.Parameters.AddWithValue("@EndTime", endTime);
                            cmd.Parameters.AddWithValue("@DayOfWeek", dayOfWeek);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm lịch dạy mới thành công.");
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Thêm lịch dạy thất bại.");
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

        private void btnSuaLichDay_Click(object sender, EventArgs e)
        {
            {
                string classID = cmbLopHoc.SelectedItem?.ToString();
                string maGiaoVien = cmbGiaoVien.SelectedItem?.ToString();
                string startTime = txtStartTime.Text.Trim();
                string endTime = txtEndTime.Text.Trim();
                string dayOfWeek = txtDayOfWeek.Text.Trim();
                int scheduleID;

                if (!int.TryParse(txtScheduleID.Text.Trim(), out scheduleID) || string.IsNullOrEmpty(classID) || string.IsNullOrEmpty(maGiaoVien) || string.IsNullOrEmpty(startTime) || string.IsNullOrEmpty(endTime) || string.IsNullOrEmpty(dayOfWeek))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                string connectionString = @"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True";
                string query = "UPDATE Schedule SET ClassID = @ClassID, MaGiaoVien = @MaGiaoVien, StartTime = @StartTime, EndTime = @EndTime, DayOfWeek = @DayOfWeek WHERE ScheduleID = @ScheduleID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
                            cmd.Parameters.AddWithValue("@ClassID", classID);
                            cmd.Parameters.AddWithValue("@MaGiaoVien", maGiaoVien);
                            cmd.Parameters.AddWithValue("@StartTime", startTime);
                            cmd.Parameters.AddWithValue("@EndTime", endTime);
                            cmd.Parameters.AddWithValue("@DayOfWeek", dayOfWeek);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật lịch dạy thành công.");
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật lịch dạy thất bại.");
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

        private void btnXoaLichDay_Click(object sender, EventArgs e)
        {
            int scheduleID;
            if (!int.TryParse(txtScheduleID.Text.Trim(), out scheduleID))
            {
                MessageBox.Show("Vui lòng nhập mã lịch dạy hợp lệ.");
                return;
            }

            string connectionString = @"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True";
            string query = "DELETE FROM Schedule WHERE ScheduleID = @ScheduleID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa lịch dạy thành công.");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Xóa lịch dạy thất bại.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void dgvLichDay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLichDay.Rows[e.RowIndex];
                cmbLopHoc.SelectedItem = row.Cells["ClassID"].Value.ToString();
                cmbGiaoVien.SelectedItem = row.Cells["MaGiaoVien"].Value.ToString();
                txtStartTime.Text = row.Cells["StartTime"].Value.ToString();
                txtEndTime.Text = row.Cells["EndTime"].Value.ToString();
                txtDayOfWeek.Text = row.Cells["DayOfWeek"].Value.ToString();
            }
        }
    }
}