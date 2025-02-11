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
    public partial class QuanLyThuoc : Form
    {
        public QuanLyThuoc()
        {
            InitializeComponent();
            load_thuoc();

        }

        common cm = new common();

        private void load_thuoc()
        {
            string query = @"Select    *   from    view_thuoc ";
            dataGridViewDanhSachThuoc.DataSource = cm.load_data_query(query);

            dataGridViewDanhSachThuoc.Columns[0].HeaderText = "Mã thuốc";
            dataGridViewDanhSachThuoc.Columns[1].HeaderText = "Tên thuốc";
            dataGridViewDanhSachThuoc.Columns[2].HeaderText = "Mô tả";
            dataGridViewDanhSachThuoc.Columns[3].HeaderText = "Thuộc bảo hiểm";
            dataGridViewDanhSachThuoc.Columns[3].Width += 10;
        }
        private void txtMaThuoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var mathuoc = txtMaThuoc.Text;
            var tenthuoc = txtTenThuoc.Text;
            var mota = txtMoTa.Text;
            int thuocbaohiem = 0;
            if (ckbThuocBaoHiem.Checked == true) thuocbaohiem = 1;

            if (mathuoc == "" || tenthuoc == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                txtMaThuoc.Focus();
            }
            else
            {
                string query = @"insert into Thuoc (mathuoc, tenthuoc, mota, thuocbaohiem, trangthai) 
                                                values (@mathuoc, @tenthuoc, @mota, @thuocbaohiem, @trangthai)";
                try
                {
                    using (SqlConnection connection = new SqlConnection(cm.connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Thêm tham số vào câu lệnh SQL 
                            command.Parameters.AddWithValue("@mathuoc", mathuoc);
                            command.Parameters.AddWithValue("@tenthuoc", tenthuoc);
                            command.Parameters.AddWithValue("@mota", mota);
                            command.Parameters.AddWithValue("@thuocbaohiem", thuocbaohiem);
                            command.Parameters.AddWithValue("@trangthai", 1);


                            // Thực thi câu lệnh SQL
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                load_thuoc();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            var maThuoc = txtMaThuoc.Text;
            var tenThuoc = txtTenThuoc.Text;
            var moTa = txtMoTa.Text;
            int thuocBH = 0;
            if (ckbThuocBaoHiem.Checked == true) thuocBH = 1;
            if (maThuoc == "" || tenThuoc == "" || moTa == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                txtMaThuoc.Focus();
            }
            else
            {
                string query = @"UPDATE thuoc set mathuoc=@maThuoc, tenthuoc=@tenThuoc, moTa=@moTa, thuocbaohiem=@thuocBH where mathuoc = @maThuoc";
                try
                {
                    using (SqlConnection connection = new SqlConnection(cm.connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@mathuoc", maThuoc);
                            command.Parameters.AddWithValue("@tenthuoc", tenThuoc);
                            command.Parameters.AddWithValue("@mota", moTa);
                            command.Parameters.AddWithValue("@thuocbh", thuocBH);

                            // Thực thi câu lệnh SQL
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                load_thuoc();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var maThuoc = txtMaThuoc.Text.Trim(); // Lấy mã thuốc từ ô nhập liệu

            if (string.IsNullOrEmpty(maThuoc))
            {
                MessageBox.Show("Vui lòng nhập mã thuốc để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaThuoc.Focus();
                return;
            }

            // Hộp thoại xác nhận xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thuốc này?", "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            string query = @"DELETE FROM thuoc WHERE mathuoc = @mathuoc";

            try
            {
                using (SqlConnection connection = new SqlConnection(cm.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@mathuoc", maThuoc);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            load_thuoc(); // Load lại danh sách thuốc sau khi xóa
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mã thuốc để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi thoát
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Home homeForm = new Home("rule"); // Tạo một instance của form Home
                homeForm.Show();            // Hiển thị form Home
                this.Close();                // Đóng form hiện tại (QuanLyThuoc)
            }
        }

        private void dataGridViewDanhSachThuoc_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDanhSachThuoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn hay không
            if (e.RowIndex >= 0) // e.RowIndex là chỉ số hàng được double click
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridViewDanhSachThuoc.Rows[e.RowIndex];

                // Gán giá trị từ cột 0 và cột 1 vào các TextBox
                txtMaThuoc.Text = selectedRow.Cells[0].Value?.ToString();
                txtTenThuoc.Text = selectedRow.Cells[1].Value?.ToString();
                txtMoTa.Text = selectedRow.Cells[2].Value?.ToString();
                ckbThuocBaoHiem.Checked = true;
                if (selectedRow.Cells[3].Value?.ToString() == "0") ckbThuocBaoHiem.Checked = false;
            }
        }

        private void dataGridViewDanhSachThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
