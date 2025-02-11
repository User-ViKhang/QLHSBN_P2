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
    public partial class Phongbenh : Form
    {
        public Phongbenh()
        {
            InitializeComponent();
        }
        common cm = new common();
        private void btn_sua_Click(object sender, EventArgs e)
        {
            var code = txt_maphong.Text;
            var ten = txt_tenphong.Text;
            var so = txt_sogiuong.Text;
            var gia = txt_gia.Text;
            var serv= "Thường";
            if(ck_dv.Checked==true)
            {
                serv = "Dịch vụ";
            }    
            if (so == "" || code == "" || gia=="")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                txt_maphong.Focus();
            }
            else if (cm.CheckDuplicate("phongbenh", "maphongbenh", code) == false)
            {
                MessageBox.Show("Mã phòng này không tồn tại để cập nhật");
                txt_maphong.Focus();
            }
            else
            {
                string query = "UPDATE phongbenh SET sogiuong_moi = @sogiuong, gia=@gia, loaiphongbenh=@loai, tenphongbenh = @tenphongbenh WHERE maphongbenh = @code";
                try
                {
                    using (SqlConnection connection = new SqlConnection(cm.connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            int b = int.Parse(so);
                            int c = int.Parse(gia);
                            command.Parameters.AddWithValue("@maphongbenh", code);
                            command.Parameters.AddWithValue("@tenphongbenh", ten);
                            command.Parameters.AddWithValue("@sogiuong", b);
                            command.Parameters.AddWithValue("@gia", c);
                            command.Parameters.AddWithValue("@loai", serv);
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            var code = txt_maphong.Text;
            var ten = txt_tenphong.Text;
            var gia = txt_gia.Text;
            var so = txt_sogiuong.Text;
            var serv = "Thường";
            if (ck_dv.Checked == true)
            {
                serv = "Dịch vụ";
            }
            if (ten == "" || code == "" || gia == "" || so=="")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                txt_maphong.Focus();
            }
            else if (cm.CheckDuplicate("phongbenh", "maphongbenh", code) == true)
            {
                MessageBox.Show("Mã phòng này đã tồn tại");
                txt_maphong.Focus();
            }
            else
            {
                string query = @"insert into phongbenh (maphongbenh,tenphongbenh,loaiphongbenh,gia,sogiuong_moi,trangthai)
                                                values (@maphongbenh, @tenphongbenh,@loai, @gia,@so ,  1) ";
                try
                {
                    using (SqlConnection connection = new SqlConnection(cm.connectionString))
                    {
                        connection.Open();
                        int b = int.Parse(so);
                        int c = int.Parse(gia);
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@maphongbenh", code);
                            command.Parameters.AddWithValue("@tenphongbenh", ten);
                            command.Parameters.AddWithValue("@so", b);
                            command.Parameters.AddWithValue("@gia", c);
                            command.Parameters.AddWithValue("@loai", serv);

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

        private void load_data()
        {
            //1 empty, 2 full , 3 deactive
            string query = @"Select * from view_phongbenh";
            dataGridView1.DataSource = cm.load_data_query(query);
        }

        private void btn_ngung_Click(object sender, EventArgs e)
        {
            var code = txt_maphong.Text;
            if (code == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin trong bảng");
                txt_maphong.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc sẽ ngừng hoạt động phòng này", "Cảnh báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = "UPDATE phongbenh SET trangthai = 0 WHERE maphongbenh = @maphong";
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
                txt_maphong.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc sẽ kích hoạt động phòng này", "Cảnh báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = "UPDATE phongbenh SET trangthai = 1 WHERE maphong = @maphong";
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

        private void Phongbenh_Load(object sender, EventArgs e)
        {
            load_data();
            dataGridView1.Columns[0].HeaderText = "STT";
            dataGridView1.Columns[1].HeaderText = "Mã phòng";
            dataGridView1.Columns[2].HeaderText = "Tên phòng";
            dataGridView1.Columns[3].HeaderText = "Loại phòng";
            dataGridView1.Columns[4].HeaderText = "Giá phòng";
            dataGridView1.Columns[5].HeaderText = "Số giường";
            dataGridView1.Columns[5].HeaderText = "Trạng thái";
            txt_maphong.Focus();
        }

        private void txt_gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự
            }
        }

        private void txt_sophong_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự
            }*/
        }

        private void txt_sogiuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn hay không
            if (e.RowIndex >= 0) // e.RowIndex là chỉ số hàng được double click
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Gán giá trị từ các cột vào các TextBox
                txt_maphong.Text = selectedRow.Cells[1].Value?.ToString();
                txt_tenphong.Text = selectedRow.Cells[2].Value?.ToString(); 
                txt_gia.Text = selectedRow.Cells[4].Value?.ToString();
                txt_sogiuong.Text = selectedRow.Cells[5].Value?.ToString();
                // Kiểm tra giá trị cột 3 (dichvu)
                string dichvu = selectedRow.Cells[3].Value?.ToString(); // Cột 3
                if (dichvu == "Dịch vụ")
                {
                    ck_dv.Checked = true;
                }
                else
                {
                    ck_dv.Checked = false;
                }
            }
        }
    }
}
