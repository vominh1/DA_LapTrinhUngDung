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
using System.Xml.Linq;



namespace DA_LapTrinhUngDung
{

    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(@"Data Source=MINHDAY123\SQLEXPRESS;Initial Catalog=school;Integrated Security=True");
                cmd = new SqlCommand();
                cmd.Connection = conn;
                conn.Open();
                Console.WriteLine("Đã liên kết thành công!");
            }
            catch
            {
                Console.WriteLine("Không thể liên kết");
                MessageBox.Show("Không thể mở ???");

            }
            finally
            {
                conn.Close();
            }

            displaydata();

        }
        private void displaydata()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from teacher";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 i = Convert.ToInt32(dataGridView1.CurrentRow.Index);
            addtext(i);

        }
        private void addtext(int i)
        {
            txtmagiaovien.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtaddress.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtGioiTinh.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtSoDT.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtsalary.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            string query = $"insert into teacher values('{int.Parse(txtmagiaovien.Text)}',N'{txtname.Text}',N'{txtaddress.Text}',N'{txtGioiTinh.Text}',N'{txtSoDT.Text}','{int.Parse(txtsalary.Text)}')";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            cleardata();
            conn.Close();
            displaydata();
            string message = "Đã thêm thành công";
            string title = "Thêm";
            MessageBox.Show(message, title);
        }
        
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update teacher set TenGiaoVien = @TenGiaoVien, DiaChi = @DiaChi, GioiTinh = @GioiTinh, SoDT = @SoDT, Luong = @Luong where MaGiaoVien = @MaGiaoVien";

                // Sử dụng các tham số để truyền giá trị vào truy vấn
                cmd.Parameters.AddWithValue("@TenGiaoVien", txtname.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtaddress.Text);
                cmd.Parameters.AddWithValue("@SoDT", txtSoDT.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text);
                cmd.Parameters.AddWithValue("@Luong", int.Parse(txtsalary.Text));
                cmd.Parameters.AddWithValue("@MaGiaoVien", int.Parse(txtmagiaovien.Text));

                cmd.ExecuteNonQuery();
                conn.Close();
                displaydata();
                cleardata();
                string message = "Đã Cập nhật thành công";
                
                string title = "Cập nhật";
                MessageBox.Show(message, title);
            }
            catch (Exception ex)
            {
              
                MessageBox.Show("Lỗi: " + ex.Message);
            }


        }
        private void cleardata()
            {
                txtmagiaovien.Clear();
                txtname.Clear();
                txtaddress.Clear();
                txtGioiTinh.Clear();
                txtSoDT.Clear();
                txtsalary.Clear();
            }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string query = $"delete teacher where MaGiaoVien='{txtmagiaovien.Text.ToString()}'";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            dataGridView1.DataSource = query;
            cleardata();
            conn.Close();
            displaydata();
            string message = "Đã Xóa thành công";
            string title = "Đã xóa";
            MessageBox.Show(message, title);

        }

        private void btnexist_Click(object sender, EventArgs e)
        {
          
                string message = "Bạn có muốn thoát ứng dụng?";
                string title = "Xác nhận Thoát ứng dụng";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    // 
                }

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            
            displaydata(); 
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from teacher where MaGiaoVien='" + txtsearch.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            txtname.Text = dt.ToString();
            txtaddress.Text = dt.ToString();
            txtsalary.Text = dt.ToString();
            txtGioiTinh.Text = dt.ToString();
            txtSoDT.Text = dt.ToString();
            dataGridView1.DataSource = dt;
            conn.Close();

        }

    }
}
