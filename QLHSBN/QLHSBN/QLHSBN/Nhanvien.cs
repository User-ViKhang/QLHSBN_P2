using QLHSBN.Utilities;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLHSBN
{
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();
        }
        common cm = new common();
        private void load_nhanvien()
        {
            string query = @"Select    *   from    view_nhanvien ";
            dataGridView1.DataSource = cm.load_data_query(query);
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_hoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự số
            }
        }

        private void txt_hocvan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự số
            }
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự
            }
        }

        private void txt_exp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự
            }
        }
        
        private void Nhanvien_Load(object sender, EventArgs e)
        {
            load_nhanvien();
            cbb_chucvu.SelectedIndex = 0;
            cbb_gt.SelectedIndex = 0;

            dataGridView1.Columns[0].HeaderText = "STT";
            dataGridView1.Columns[1].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[2].HeaderText = "Họ Tên";
            dataGridView1.Columns[3].HeaderText = "Chức vụ";
            dataGridView1.Columns[4].HeaderText = "Ngày sinh";
            dataGridView1.Columns[5].HeaderText = "Số điện thoại";
            dataGridView1.Columns[6].HeaderText = "Giới tính";
            dataGridView1.Columns[7].HeaderText = "Trình độ";
            dataGridView1.Columns[8].HeaderText = "Chuyên khoa";
            dataGridView1.Columns[9].HeaderText = "Kinh nghiệm (năm)";
            dataGridView1.Columns[10].HeaderText = "Tài khoản";
            dataGridView1.Columns[11].HeaderText = "Ngày tạo";
            dataGridView1.Columns[12].HeaderText = "Trạng thái";

            cbb_lock.SelectedIndex = 0;
            cbb_filter.SelectedIndex = 0;
            cbb_chucvu.SelectedIndex = 0;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var ht = txt_hoten.Text;
            var ns = dtp_ngaysinh.Value;
            var code = txt_code.Text;
            var rule = cbb_chucvu.Text;
            var gt = cbb_gt.Text;
            var sdt = txt_sdt.Text;
            var tk = txt_tk.Text;
            var mk = txt_mk.Text;
            var hv = txt_hocvan.Text;
            var ck = txt_chuyenkhoa.Text;
            var exp = txt_exp.Text;
            int age = DateTime.Now.Year - ns.Year;

            if (ht == "" || code == "" || tk == "" || mk == "" || hv == "" || sdt == "" || ck == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                txt_hoten.Focus();
            }
            else if (sdt.Length > 12 || sdt.Length < 10)
            {
                MessageBox.Show("Vui lòng điền đúng thông tin số điện thoại từ 10 đến 12 số");
                txt_sdt.Focus();
            }
            else if (exp.Length > 2 )
            {
                MessageBox.Show("Vui lòng điền đúng thông tin số năm");
                txt_exp.Focus();
            }
            else if (cm.CheckDuplicate("Nhanvien", "ma_nhanvien", code) == true)
            {
                MessageBox.Show("Mã nhân viên này đã có rồi, vui lòng nhập mã khác");
                txt_code.Focus();
            }
            else if (cm.CheckDuplicate("Nhanvien", "sdt", sdt) == true)
            {
                MessageBox.Show("Số điện thoại này đã được sử dụng ở bệnh nhân khác, vui lòng nhập số khác");
                txt_sdt.Focus();
            }
            else if (cm.CheckDuplicate("Nhanvien", "taikhoan", tk) == true)
            {
                MessageBox.Show("tài khoản này đã được sử dụng, vui lòng nhập tài khoản khác");
                txt_tk.Focus();
            }
            
            else if (ns.Date >= DateTime.Now.Date || age < 22)
            {
                MessageBox.Show("Ngày sinh không hợp lệ, nhân viên phải lớn hơn 22 tuổi");
            }
            else
            {
                string query = @"insert into Nhanvien (ma_nhanvien, hoten, chucvu, ngaysinh, sdt, gioitinh, hocvan, chuyenkhoa, exp, taikhoan, matkhau, ngaytao ,trangthai) 
                                                values (@manv, @hoten, @chucvu, @ngaysinh, @sdt, @gioitinh, @hocvan, @chuyenkhoa, @exp, @taikhoan, @matkhau, @ngaytao, 1)";
                try
                {
                    using (SqlConnection connection = new SqlConnection(cm.connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Thêm tham số vào câu lệnh SQL 
                            command.Parameters.AddWithValue("@manv", code);
                            command.Parameters.AddWithValue("@hoten", ht);
                            command.Parameters.AddWithValue("@chucvu", rule);
                            command.Parameters.AddWithValue("@ngaysinh", ns.Date);
                            command.Parameters.AddWithValue("@sdt", sdt);
                            command.Parameters.AddWithValue("@gioitinh", gt);
                            command.Parameters.AddWithValue("@hocvan", hv);
                            command.Parameters.AddWithValue("@chuyenkhoa", ck);
                            command.Parameters.AddWithValue("@exp", exp);
                            command.Parameters.AddWithValue("@taikhoan", tk);
                            command.Parameters.AddWithValue("@matkhau", mk);
                            command.Parameters.AddWithValue("@ngaytao", DateTime.Now.Date);
                            // Thực thi câu lệnh SQL
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                load_nhanvien();
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

        private void cbb_filter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cbb_filter.Text != "===Chọn chức vụ===")
            {
                string query = @"Select * from view_nhanvien  where trang_thai = N'Đang sử dụng' and chucvu= N'" + cbb_filter.Text + "'";
                dataGridView1.DataSource = cm.load_data_query(query);
            }    
            else
            {
                load_nhanvien();
            }    
            
        }

        private void cbb_lock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cbb_lock.Text != "===Chọn trạng thái===")
            {
                string query = @"Select * from view_nhanvien  where trang_thai = N'"+cbb_lock.Text+"'";
                dataGridView1.DataSource = cm.load_data_query(query);
            }    
            else
            {
                load_nhanvien();
            }    
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn hay không
            if (e.RowIndex >= 0) // e.RowIndex là chỉ số hàng được double click
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                txt_code.Text = selectedRow.Cells[1].Value?.ToString(); // Cột 1
                txt_hoten.Text = selectedRow.Cells[2].Value?.ToString(); // Cột 2
                cbb_chucvu.Text = selectedRow.Cells[3].Value?.ToString(); 
                dtp_ngaysinh.Text = selectedRow.Cells[4].Value?.ToString(); 
                txt_sdt.Text = selectedRow.Cells[5].Value?.ToString(); 
                cbb_gt.Text = selectedRow.Cells[6].Value?.ToString(); 
                txt_hocvan.Text = selectedRow.Cells[7].Value?.ToString(); 
                txt_chuyenkhoa.Text = selectedRow.Cells[8].Value?.ToString(); 
                txt_exp.Text = selectedRow.Cells[9].Value?.ToString(); 
                txt_tk.Text = selectedRow.Cells[10].Value?.ToString(); 
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var ht = txt_hoten.Text;
            var ns = dtp_ngaysinh.Value;
            var code = txt_code.Text;
            var rule = cbb_chucvu.Text;
            var gt = cbb_gt.Text;
            var sdt = txt_sdt.Text;
            var hv = txt_hocvan.Text;
            var ck = txt_chuyenkhoa.Text;
            var exp = txt_exp.Text;
            int age = DateTime.Now.Year - ns.Year;

            if (ht == "" || code == "" ||  hv == "" || sdt == "" || ck == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                txt_hoten.Focus();
            }
            else if (sdt.Length > 12 || sdt.Length < 10)
            {
                MessageBox.Show("Vui lòng điền đúng thông tin số điện thoại từ 10 đến 12 số");
                txt_sdt.Focus();
            }
            else if (exp.Length > 2)
            {
                MessageBox.Show("Vui lòng điền đúng thông tin số năm");
                txt_exp.Focus();
            }
            else if(cm.Checktripple("nhanvien","sdt",sdt)==true)
            {
                MessageBox.Show("Số này đã có người dùng");
                txt_sdt.Focus();
            }    
            else if (ns.Date >= DateTime.Now.Date || age < 22)
            {
                MessageBox.Show("Ngày sinh không hợp lệ, nhân viên phải lớn hơn 22 tuổi");
                dtp_ngaysinh.Focus();
            }
            else
            {
                string query = @"update Nhanvien SET 
                                    hoten = @hoten,
                                    chucvu = @chucvu,
                                    ngaysinh = @ngaysinh,
                                    sdt = @sdt,
                                    gioitinh = @gioitinh,
                                    hocvan = @hocvan,
                                    chuyenkhoa = @chuyenkhoa,
                                    exp = @exp
                                WHERE ma_nhanvien = @ma_nhanvien";
                try
                {
                    using (SqlConnection connection = new SqlConnection(cm.connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Thêm tham số vào câu lệnh SQL 
                            command.Parameters.AddWithValue("@hoten", ht);
                            command.Parameters.AddWithValue("@chucvu", rule);
                            command.Parameters.AddWithValue("@ngaysinh", ns.Date);
                            command.Parameters.AddWithValue("@sdt", sdt);
                            command.Parameters.AddWithValue("@gioitinh", gt);
                            command.Parameters.AddWithValue("@hocvan", hv);
                            command.Parameters.AddWithValue("@chuyenkhoa", ck);
                            command.Parameters.AddWithValue("@exp", exp);
                            command.Parameters.AddWithValue("@ma_nhanvien", code);
                            // Thực thi câu lệnh SQL
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                load_nhanvien();
                            }
                            else
                            {
                                MessageBox.Show("Không thể cập nhật, kiểm tra lại cột và bảng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btn_lock_Click(object sender, EventArgs e)
        {
            var code = txt_code.Text;
                string query = @"update Nhanvien SET trangthai = 0  WHERE ma_nhanvien = @ma_nhanvien";
                try
                {
                    using (SqlConnection connection = new SqlConnection(cm.connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Thêm tham số vào câu lệnh SQL 
                            command.Parameters.AddWithValue("@ma_nhanvien", code);
                            // Thực thi câu lệnh SQL
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("khóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                load_nhanvien();
                            }
                            else
                            {
                                MessageBox.Show("Không thể khóa, kiểm tra lại cột và bảng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var code = txt_code.Text;
            string query = @"update Nhanvien SET trangthai = 1  WHERE ma_nhanvien = @ma_nhanvien";
            try
            {
                using (SqlConnection connection = new SqlConnection(cm.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số vào câu lệnh SQL 
                        command.Parameters.AddWithValue("@ma_nhanvien", code);
                        // Thực thi câu lệnh SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Mở khóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            load_nhanvien();
                        }
                        else
                        {
                            MessageBox.Show("Không thể mở khóa, kiểm tra lại cột và bảng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
