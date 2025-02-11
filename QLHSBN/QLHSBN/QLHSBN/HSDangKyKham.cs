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
    public partial class HSDangKyKham : Form
    {
        public HSDangKyKham()
        {
            InitializeComponent();
        }

        private void btn_toathuoc_Click(object sender, EventArgs e)
        {
            ToaThuoc tt = new ToaThuoc();
            tt.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        common cm = new common();
      
        private void load_hsdk()
        {
            string view1 = @"select * from view_truockham order by STT DESC";
            dataGridView1.DataSource = cm.load_data_query(view1);
            string view2 = @"select * from view_hsdk_kham order by hsdk_khamid DESC";
            dataGridView2.DataSource = cm.load_data_query(view2);
        }
        private void HSDangKyKham_Load(object sender, EventArgs e)
        {
            load_hsdk();
            dataGridView1.Columns[0].HeaderText = "STT";
            dataGridView1.Columns[1].HeaderText = "Mã hồ sơ";
            dataGridView1.Columns[2].HeaderText = "Bệnh nhân";
            dataGridView1.Columns[3].HeaderText = "Bảo hiểm y tế";
            dataGridView1.Columns[4].HeaderText = "Căn cước";
            dataGridView1.Columns[5].HeaderText = "Ngày tạo";
            dataGridView1.Columns[6].HeaderText = "Ngày đăng ký";

            dataGridView2.Columns[0].HeaderText = "STT";
            dataGridView2.Columns[1].HeaderText = "Bệnh nhân";
            dataGridView2.Columns[2].HeaderText = "Bác sỉ";
            dataGridView2.Columns[3].HeaderText = "Ngày đăng ký";
            dataGridView2.Columns[4].HeaderText = "Kết quả khám";
            dataGridView2.Columns[5].HeaderText = "Trạng thái";
        }

        private void btn_nhapvien_Click(object sender, EventArgs e)
        {
            Phieunhapvien nv = new Phieunhapvien();
            nv.ShowDialog();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TaoPXN tpx = new TaoPXN();
            tpx.ShowDialog();
        }
        int code;
        private void btn_dakham_Click(object sender, EventArgs e)
        {
            if (txt_mahs.Text != "")
            {
                var ma_hs = txt_mahs.Text;
                var kq = kq_kham.Text;
                string query = @"update dangkykham set trangthai=2, nhanvien_id=@nhanvien, thongtin=@kq where hsdk_khamid=@ma_hs";
                try
                {
                    using (SqlConnection connection = new SqlConnection(cm.connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ma_hs", code);
                            command.Parameters.AddWithValue("@nhanvien", Session.user_id);
                            command.Parameters.AddWithValue("@kq", kq);
                            // Thực thi câu lệnh SQL
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                load_hsdk();
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
                    MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // e.RowIndex là chỉ số hàng được double click
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                // Gán giá trị từ cột 0 và cột 1 vào các TextBox
                code = Convert.ToInt32(selectedRow.Cells[0].Value?.ToString());
                txt_hoten.Text = selectedRow.Cells[1].Value?.ToString();
                kq_kham.Text = selectedRow.Cells[4].Value?.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txt_hoten.Text != "")
            {
                var kq = kq_kham.Text;
                string query = @"update dangkykham set thongtin=@ketqua, nhanvien_id=@nhanvien where hsdk_khamid=@ma_hs";
                try
                {
                    using (SqlConnection connection = new SqlConnection(cm.connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ma_hs", code);
                            command.Parameters.AddWithValue("@ketqua", kq);
                            command.Parameters.AddWithValue("@nhanvien", Session.user_id);

                            // Thực thi câu lệnh SQL
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                load_hsdk();
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
                    MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // e.RowIndex là chỉ số hàng được double click
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                code = Convert.ToInt32(selectedRow.Cells[0].Value?.ToString());
                txt_mahs.Text = selectedRow.Cells[1].Value?.ToString(); // Cột 1
                txt_hoten.Text = selectedRow.Cells[2].Value?.ToString();
            }
        }
    }
}
