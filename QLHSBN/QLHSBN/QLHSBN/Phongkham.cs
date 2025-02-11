using QLHSBN.Utilities;
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

namespace QLHSBN
{
    public partial class Phongkham : Form
    {
        public Phongkham()
        {
            InitializeComponent();
        }
        common cm = new common();
        private void load_data()
        {
            string query = @"Select * from view_phongkham";
            dataGridView1.DataSource = cm.load_data_query(query);
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            var code = txt_maphong.Text;
            var ten = txt_tenphong.Text;
            if (ten == "" || code == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                txt_tenphong.Focus();
            }
            else if (cm.CheckDuplicate("phongkham", "ma_phongkham", code) == true)
            {
                MessageBox.Show("Mã phòng này đã được sử dụng");
                txt_maphong.Focus();
            }
            else
            {
                string query = @"insert   into   phongkham (ma_phongkham, ten_phongkham, nhanvien_id,trangthai)   values (@maphong, @tenphong, @manv, 1) ";
                try
                {
                    using (SqlConnection connection = new SqlConnection(cm.connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@maphong", code);
                            command.Parameters.AddWithValue("@tenphong", ten);
                            command.Parameters.AddWithValue("@manv", Session.user_id);

                            // Thực thi câu lệnh SQL
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                load_data();
                            }
                            else
                            {
                                MessageBox.Show("Không thể thêm, kiểm tra lại cột và bảng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
        }

       

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var code = txt_maphong.Text;
            var ten = txt_tenphong.Text;
            if (ten == "" || code == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                txt_tenphong.Focus();
            }
            else if (cm.Checktripple("phongkham", "ma_phongkham", code) == false)
            {
                MessageBox.Show("Mã phòng này không tồn tại để cập nhật");
                txt_maphong.Focus();
            }
            else
            {
                string query = "UPDATE phongkham SET tenphong = @tenphong WHERE ma_phongkham = @maphong";
                try
                {
                    using (SqlConnection connection = new SqlConnection(cm.connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Sử dụng tham số hóa để tránh SQL Injection
                            command.Parameters.AddWithValue("@tenphong", ten);
                            command.Parameters.AddWithValue("@maphong", code);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy phòng cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_ngung_Click(object sender, EventArgs e)
        {
            var code = txt_maphong.Text;
            if (code == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong bảng");
                txt_tenphong.Focus();
            }
            else if (cm.CheckDuplicate("phongkham", "ma_phongkham", code) == false)
            {
                MessageBox.Show("Mã phòng này không tồn tại để cập nhật");
                txt_maphong.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc sẽ ngừng hoạt động phòng này","Cảnh báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = "UPDATE phongkham SET trangthai = 0 WHERE ma_phongkham = @maphong";
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(cm.connectionString))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                // Sử dụng tham số hóa để tránh SQL Injection
                                command.Parameters.AddWithValue("@maphong", code);

                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Ngừng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    load_data();
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy phòng cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }    
               
        }

        private void btn_active_Click(object sender, EventArgs e)
        {
            var code = txt_maphong.Text;
            if (code == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong bảng");
                txt_tenphong.Focus();
            }
            else if (cm.CheckDuplicate("phongkham", "ma_phongkham", code) == false)
            {
                MessageBox.Show("Mã phòng này không tồn tại để cập nhật");
                txt_maphong.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc kích hoạt phòng này", "Cảnh báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = "UPDATE phongkham SET trangthai = 1 WHERE ma_phongkham = @maphong";
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(cm.connectionString))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                // Sử dụng tham số hóa để tránh SQL Injection
                                command.Parameters.AddWithValue("@maphong", code);

                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Kích hoạt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    load_data();
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy phòng cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Phongkham_Load(object sender, EventArgs e)
        {
            load_data();
            dataGridView1.Columns[0].HeaderText = "STT";
            dataGridView1.Columns[1].HeaderText = "Mã phòng khám";
            dataGridView1.Columns[2].HeaderText = "Tên phòng khám";
            dataGridView1.Columns[3].HeaderText = "Người tạo";
            dataGridView1.Columns[4].HeaderText = "Trạng thái";
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn hay không
            if (e.RowIndex >= 0) // e.RowIndex là chỉ số hàng được double click
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Gán giá trị từ cột 0 và cột 1 vào các TextBox
                txt_maphong.Text = selectedRow.Cells[1].Value?.ToString(); // Cột 0
                txt_tenphong.Text = selectedRow.Cells[2].Value?.ToString(); // Cột 1
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
