using QLHSBN.Utilities;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLHSBN
{
    public partial class Hsbn : Form
    {
        common cm = new common();
        public Hsbn()
        {
            InitializeComponent();
            
        }
        private void load_hsbn()
        {
            string query = @"select * from  view_hsbn";
            dataGridView1.DataSource = cm.load_data_query(query);
        }
        private void TaoHSBN_Load(object sender, EventArgs e)
        {
            /*cbb_gt.DropDownStyle = ComboBoxStyle.DropDownList;  // chặn nhập data*/
            load_hsbn();
            cbb_search.SelectedIndex = 0;
            cbb_gt.SelectedIndex = 0;
            cbb_trangthai.SelectedIndex = 0;

            dataGridView1.Columns[0].HeaderText = "STT";
            dataGridView1.Columns[1].HeaderText = "Mã hồ sơ";
            dataGridView1.Columns[2].HeaderText = "Họ Tên";
            dataGridView1.Columns[3].HeaderText = "Ngày sinh";
            dataGridView1.Columns[4].HeaderText = "Số bảo hiểm";
            dataGridView1.Columns[5].HeaderText = "Số điện thoại";
            dataGridView1.Columns[6].HeaderText = "Căn cước";
            dataGridView1.Columns[7].HeaderText = "Địa chỉ";
            dataGridView1.Columns[8].HeaderText = "Giới tính";
            dataGridView1.Columns[9].HeaderText = "Ngày tạo";
            dataGridView1.Columns[10].HeaderText = "Người tạo";
            dataGridView1.Columns[11].HeaderText = "Trạng thái";
            txt_mahsbn.Focus();
        }


        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự
            }
        }

        private void txt_hoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự số
            }
        }

        private void txt_cccd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự
            }
        }

        private void txt_mabhyt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự
            }
        }


        private void btn_tao_Click(object sender, EventArgs e)
        {
            var ht = txt_hoten.Text;
            var ns = dtp_ngaysinh.Value;
            var dc = txt_dc.Text;
            var cccd = txt_cccd.Text;
            var bhyt = txt_mabhyt.Text;
            var bn_code = txt_mahsbn.Text;
            var sdt = txt_sdt.Text;
            var gt = cbb_gt.Text;

            if (ht == "" || dc == "" || cccd == "" || bhyt == "" || bn_code == "" || sdt == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                txt_hoten.Focus();
            }
            else if (sdt.Length > 12 || sdt.Length < 10)
            {
                MessageBox.Show("Vui lòng điền đúng thông tin số điện thoại từ 10 đến 12 số");
                txt_sdt.Focus();
            }
            else if (cccd.Length > 13 || cccd.Length < 10)
            {
                MessageBox.Show("Vui lòng điền đúng thông tin căn cước từ 10 đến 13 số");
                txt_cccd.Focus();
            }
            else if (cm.CheckDuplicate("hsbn", "ma_hs", bn_code) == true)
            {
                MessageBox.Show("Mã hồ sơ này đã có rồi, vui lòng nhập mã khác");
                txt_mahsbn.Focus();
            }
            else if (cm.CheckDuplicate("hsbn", "sdt", sdt) == true)
            {
                MessageBox.Show("Số điện thoại này đã được sử dụng ở bệnh nhân khác, vui lòng nhập số khác");
                txt_sdt.Focus();
            }
            else if (cm.CheckDuplicate("hsbn", "bhyt", bhyt) == true)
            {
                MessageBox.Show("Bảo hiểm này đã được sử dụng ở bệnh nhân khác, vui lòng nhập bảo hiểm khác");
                txt_mabhyt.Focus();
            }
            else if (cm.CheckDuplicate("hsbn", "cccd", cccd) == true)
            {
                MessageBox.Show("Căn cước này đã được sử dụng ở bệnh nhân khác, vui lòng nhập căn cước khác");
                txt_cccd.Focus();
            }
            else if (ns.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
            }
            else
            {
                string query = @"insert into hsbn (ma_hs,hoten,ngaysinh,bhyt,sdt,cccd,diachi,gioitinh,nhanvien_id,trangthai, ngaytao) values (@ma_hs,@hoten,@ns,@bhyt,@sdt,@cccd,@diachi,@gt,@manv,1,@ngaytao)";
                try
                {
                    using (SqlConnection connection = new SqlConnection(cm.connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ma_hs", bn_code);
                            command.Parameters.AddWithValue("@hoten", ht);
                            command.Parameters.AddWithValue("@ns", ns.Date);
                            command.Parameters.AddWithValue("@bhyt", bhyt);
                            command.Parameters.AddWithValue("@sdt", sdt);
                            command.Parameters.AddWithValue("@cccd", cccd);
                            command.Parameters.AddWithValue("@diachi", dc);
                            command.Parameters.AddWithValue("@gt", gt);
                            command.Parameters.AddWithValue("@manv", Session.user_id);
                            command.Parameters.AddWithValue("@ngaytao", DateTime.Now.Date);
                            // Thực thi câu lệnh SQL
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                load_hsbn();
                            }
                            else
                            {
                                MessageBox.Show("Không thể thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            var ht = txt_hoten.Text;
            var ns = dtp_ngaysinh.Value;
            var dc = txt_dc.Text;
            var cccd = txt_cccd.Text;
            var bhyt = txt_mabhyt.Text;
            var bn_code = txt_mahsbn.Text;
            var sdt = txt_sdt.Text;
            var gt = cbb_gt.Text;

            if (ht == "" || dc == "" || cccd == "" || bhyt == "" || bn_code == "" || sdt == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                txt_hoten.Focus();
            }
            else if (sdt.Length > 12 || sdt.Length < 10)
            {
                MessageBox.Show("Vui lòng điền đúng thông tin số điện thoại từ 10 đến 12 số");
                txt_sdt.Focus();
            }
            else if (cccd.Length > 13 || cccd.Length < 10)
            {
                MessageBox.Show("Vui lòng điền đúng thông tin căn cước từ 10 đến 13 số");
                txt_cccd.Focus();
            }
            else if (cm.Checktripple("hsbn", "ma_hs", bn_code) == true)
            {
                MessageBox.Show("Mã hồ sơ này đã có rồi, vui lòng nhập mã khác");
                txt_mahsbn.Focus();
            }
            else if (cm.Checktripple("hsbn", "sdt", sdt) == true)
            {
                MessageBox.Show("Số điện thoại này đã được sử dụng ở bệnh nhân khác, vui lòng nhập số khác");
                txt_sdt.Focus();
            }
            else if (cm.Checktripple("hsbn", "bhyt", bhyt) == true)
            {
                MessageBox.Show("Bảo hiểm này đã được sử dụng ở bệnh nhân khác, vui lòng nhập bảo hiểm khác");
                txt_mabhyt.Focus();
            }
            else if (cm.Checktripple("hsbn", "cccd", cccd) == true)
            {
                MessageBox.Show("Căn cước này đã được sử dụng ở bệnh nhân khác, vui lòng nhập căn cước khác");
                txt_cccd.Focus();
            }
            else if (ns.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
            }
            else
            {
                string query = @"UPDATE hsbn 
                        SET hoten = @hoten,
                            ngaysinh = @ns,
                            bhyt = @bhyt,
                            sdt = @sdt,
                            cccd = @cccd,
                            diachi = @diachi,
                            gioitinh = @gt,
                            nhanvien_id = @manv
                        WHERE ma_hs = @ma_hs";
                try
                {
                    using (SqlConnection connection = new SqlConnection(cm.connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ma_hs", bn_code);
                            command.Parameters.AddWithValue("@hoten", ht);
                            command.Parameters.AddWithValue("@ns", ns.Date);
                            command.Parameters.AddWithValue("@bhyt", bhyt);
                            command.Parameters.AddWithValue("@sdt", sdt);
                            command.Parameters.AddWithValue("@cccd", cccd);
                            command.Parameters.AddWithValue("@diachi", dc);
                            command.Parameters.AddWithValue("@gt", gt);
                            command.Parameters.AddWithValue("@manv", Session.user_id);
                            // Thực thi câu lệnh SQL
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                load_hsbn();
                            }
                            else
                            {
                                MessageBox.Show("Không thể sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btn_khoa_Click(object sender, EventArgs e)
        {
            var bn_code = txt_mahsbn.Text;
            string query = @"UPDATE hsbn    SET trangthai=0, nhanvien_id= @manv    WHERE ma_hs = @ma_hs";
            try
            {
                using (SqlConnection connection = new SqlConnection(cm.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ma_hs", bn_code);
                        command.Parameters.AddWithValue("@manv", Session.user_id);
                        // Thực thi câu lệnh SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Khóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            load_hsbn();
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_rs_Click(object sender, EventArgs e)
        {
            var bn_code = txt_mahsbn.Text;
            string query = @"UPDATE hsbn    SET trangthai=1, nhanvien_id= @manv    WHERE ma_hs = @ma_hs";
            try
            {
                using (SqlConnection connection = new SqlConnection(cm.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ma_hs", bn_code);
                        command.Parameters.AddWithValue("@manv", Session.user_id);
                        // Thực thi câu lệnh SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Khôi phục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            load_hsbn();
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(cbb_search.Text == "BHYT")
            {
                if (txt_search.Text != "")
                {
                    var search = txt_search.Text;
                    string query = "SELECT * FROM view_hsbn WHERE bhyt LIKE '%" + search + "%'";

                    dataGridView1.DataSource = cm.load_data_query(query);
                }
            }    
            else
            {
                if (txt_search.Text != "")
                {
                    var search = txt_search.Text;
                    string query = @"select * from view_hsbn where cccd like '%"+search+"%'";
                    
                    dataGridView1.DataSource = cm.load_data_query(query);
                }
            }    
            
        }

        private void cbb_trangthai_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbb_trangthai.Text != "===Chọn trạng thái===")
            {
                string query = @"Select * from view_hsbn  where trangthai = N'" + cbb_trangthai.Text + "'";
                dataGridView1.DataSource = cm.load_data_query(query);
            }
            else
            {
                load_hsbn();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txt_mahsbn.Text = selectedRow.Cells[1].Value?.ToString(); 
                txt_hoten.Text = selectedRow.Cells[2].Value?.ToString();
                dtp_ngaysinh.Text = selectedRow.Cells[3].Value?.ToString();
                txt_mabhyt.Text = selectedRow.Cells[4].Value?.ToString();
                txt_sdt.Text = selectedRow.Cells[5].Value?.ToString();
                txt_cccd.Text = selectedRow.Cells[6].Value?.ToString();
                txt_dc.Text = selectedRow.Cells[7].Value?.ToString();
                cbb_gt.Text = selectedRow.Cells[8].Value?.ToString();
            }
        }
    }
}
