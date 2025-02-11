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
    public partial class Dichvu : Form
    {
        public Dichvu()
        {
            InitializeComponent();
        }
        common cm = new common();
        private void load_data()
        {
            string query = @"Select * from view_dichvu";
            dataGridView1.DataSource = cm.load_data_query(query);
        }
        private void dichvu_Load(object sender, EventArgs e)
        {
            load_data();

            dataGridView1.Columns[0].HeaderText = "STT";
            dataGridView1.Columns[1].HeaderText = "Mã dịch vụ";
            dataGridView1.Columns[2].HeaderText = "Tên dịch vụ";
            dataGridView1.Columns[3].HeaderText = "Giá dịch vụ";
            dataGridView1.Columns[4].HeaderText = "Trạng thái";
        }

        private void txt_gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var code = txt_ma.Text;
            var ten = txt_ten.Text;
            var gia = txt_gia.Text;
            if (ten == "" || code == "" || gia == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                txt_ten.Focus();
            }
            else if (cm.CheckDuplicate("dichvu", "ma_dichvu", code) == true)
            {
                MessageBox.Show("Mã này đã tồn tại");
                txt_ma.Focus();
            }
            else
            {
                string query = @"insert into dichvu values (@ma_dichvu, @ten, @gia, 1) ";
                try
                {
                    using (SqlConnection connection = new SqlConnection(cm.connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Thêm tham số vào câu lệnh SQL  tổng = 7
                            command.Parameters.AddWithValue("@ma_dichvu", code);
                            command.Parameters.AddWithValue("@ten", ten);
                            command.Parameters.AddWithValue("@gia", gia);

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
            var code = txt_ma.Text;
            var ten = txt_ten.Text;
            var gia = txt_gia.Text;
            if (ten == "" || code == "" || gia == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                txt_ten.Focus();
            }
            else if (cm.Checktripple("dichvu", "ma_dichvu", code) == true)
            {
                MessageBox.Show("Mã này đã tồn tại");
                txt_ma.Focus();
            }
            else
            {
                string query = @"UPDATE    dichvu   set ten_dichvu=@ten_dichvu , gia_dichvu=@gia_dichvu   where    ma_dichvu = @ma_dichvu";
                try
                {
                    using (SqlConnection connection = new SqlConnection(cm.connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            int _i = int.Parse(gia); 
                            command.Parameters.AddWithValue("@ma_dichvu", code);
                            command.Parameters.AddWithValue("@ten_dichvu", ten);
                            command.Parameters.AddWithValue("@gia_dichvu", _i);

                            // Thực thi câu lệnh SQL
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_ngung_Click(object sender, EventArgs e)
        {
            var code = txt_ma.Text;
            if (code == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong bảng");
                txt_ma.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc sẽ ngừng hoạt động xét nghiệm này", "Cảnh báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = "UPDATE dichvu SET trangthai = 0 WHERE ma_dichvu = @ma_dichvu";
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(cm.connectionString))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                // Sử dụng tham số hóa để tránh SQL Injection
                                command.Parameters.AddWithValue("@ma_dichvu", code);

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
            var code = txt_ma.Text;
            if (code == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong bảng");
                txt_ma.Focus();
            }
            else if (cm.CheckDuplicate("dichvu", "ma_dichvu", code) == false)
            {
                MessageBox.Show("Mã xét nghiệm này không tồn tại để cập nhật");
                txt_ma.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc sẽ hoạt động xét nghiệm này", "Cảnh báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = "UPDATE dichvu SET trangthai = 1 WHERE ma_dichvu = @ma_dichvu";
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(cm.connectionString))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                // Sử dụng tham số hóa để tránh SQL Injection
                                command.Parameters.AddWithValue("@ma_dichvu", code);

                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("kích hoạt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn hay không
            if (e.RowIndex >= 0) // e.RowIndex là chỉ số hàng được double click
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Gán giá trị từ cột 0 và cột 1 vào các TextBox
                txt_ma.Text = selectedRow.Cells[1].Value?.ToString(); // Cột 0
                txt_ten.Text = selectedRow.Cells[2].Value?.ToString(); // Cột 1
                txt_gia.Text = selectedRow.Cells[3].Value?.ToString(); // Cột 2
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
