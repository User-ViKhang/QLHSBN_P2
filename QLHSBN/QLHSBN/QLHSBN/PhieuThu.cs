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
    public partial class PhieuThu : Form
    {
        public PhieuThu()
        {
            InitializeComponent();
        }

        common cm = new common();
        int bn_code;
        int code;
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void load_cbb_BenhNhan()
        {
            string query = @"select pnv.nhapvien_id, hs.hoten
                            from phieunhapvien pnv, hsbn hs
                            where pnv.hs_id = hs.hs_id and pnv.trangthai = 1";
            cbbBenhNhan.DataSource = cm.load_data_query(query);
            cbbBenhNhan.DisplayMember = "hoten";
            cbbBenhNhan.ValueMember = "nhapvien_id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void load()
        {
            string query = @"exec pro_chitiet_nhapvien_xetnghiem " + code;
            dataGridView1.DataSource = cm.load_data_query(query);
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.Columns[0].HeaderText = "Mã phiếu";
                dataGridView1.Columns[1].HeaderText = "Ngày tạo";
                dataGridView1.Columns[2].HeaderText = "Bệnh nhân";
                dataGridView1.Columns[3].HeaderText = "Dịch vụ";
                dataGridView1.Columns[4].HeaderText = "Người lập";
                dataGridView1.Columns[5].HeaderText = "Kết quả";
                dataGridView1.Columns[6].HeaderText = "Trạng thái";
            }
            string query2 = @"select * from view_thudichvu order by STT DESC";
            dataGridView2.DataSource = cm.load_data_query(query2);
            if (dataGridView2.DataSource != null)
            {
                dataGridView2.Columns[0].HeaderText = "Mã phiếu";
                dataGridView2.Columns[1].HeaderText = "Ngày thu";
                dataGridView2.Columns[2].HeaderText = "Dịch vụ";
                dataGridView2.Columns[3].HeaderText = "Người lập";
                dataGridView2.Columns[4].HeaderText = "Số tiền";
                dataGridView2.Columns[5].HeaderText = "Trạng thái";
            }

            
        }
        private void PhieuThu_Load(object sender, EventArgs e)
        {
            load_cbb_BenhNhan();
            load_DSPhieuThu();
            load();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void cbbBenhNhan_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbbBenhNhan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            code = Convert.ToInt32(cbbBenhNhan.SelectedValue);
            int tongTienPhongThuong = 0, tongTienPhongDichVu = 0;
            int tongSoNgayPhongThuong = 0, tongSoNgayPhongDichVu = 0;

            string query = @"SELECT hs_id FROM phieunhapvien WHERE nhapvien_id=" + code;
            DataTable dt = cm.load_data_query(query);

            if (dt.Rows.Count == 0 || dt.Rows[0]["hs_id"] == DBNull.Value)
            {
                MessageBox.Show("Không tìm thấy hồ sơ bệnh nhân.");
                return;
            }

            bn_code = Convert.ToInt32(dt.Rows[0]["hs_id"]);

            // Lấy thông tin phòng bệnh
            string queryPhongThuong = @"SELECT SUM(a.so_ngay) AS songay, b.gia
FROM lichsunamvien a
JOIN phongbenh b ON a.phong_id = b.phong_id
WHERE a.nhapvien_id = "+ code +" AND a.trangthai = 1 and b.loaiphongbenh = N'Thường' GROUP BY b.gia";

            string queryPhongDichVu = @"SELECT SUM(a.so_ngay) AS songay, b.gia
FROM lichsunamvien a
JOIN phongbenh b ON a.phong_id = b.phong_id
WHERE a.nhapvien_id = "+code+" AND a.trangthai = 1 and b.loaiphongbenh = N'Dịch vụ' GROUP BY b.gia;";

            DataTable dtPhongThuong = cm.load_data_query(queryPhongThuong);
            DataTable dtPhongDichVu = cm.load_data_query(queryPhongDichVu);

            // Xử lý thông tin phòng Thường
            if (dtPhongThuong != null)
            {
                if (dtPhongThuong.Rows.Count > 0)
                {
                    foreach (DataRow row in dtPhongThuong.Rows)
                    {
                        int soNgay = row["songay"] != DBNull.Value ? Convert.ToInt32(row["songay"]) : 0;
                        int gia = row["gia"] != DBNull.Value ? Convert.ToInt32(row["gia"]) : 0;
                        tongTienPhongThuong += soNgay * gia;
                        tongSoNgayPhongThuong += soNgay;  // Cộng dồn số ngày
                    }

                    txtSoNgayPhongThuong.Text = tongSoNgayPhongThuong.ToString();
                    txtDonGiaPhongThuong.Text = dtPhongThuong.Rows[0]["gia"].ToString();
                    txtTongTienPhongThuong.Text = tongTienPhongThuong.ToString();
                }
                else
                {
                    txtSoNgayPhongThuong.Text = "0";
                    txtDonGiaPhongThuong.Text = "0";
                    txtTongTienPhongThuong.Text = "0";
                }
            }

            // Xử lý thông tin phòng Dịch Vụ
            if (dtPhongDichVu != null)
            {
                if (dtPhongDichVu.Rows.Count > 0)
                {
                    foreach (DataRow row in dtPhongDichVu.Rows)
                    {
                        int soNgay = row["songay"] != DBNull.Value ? Convert.ToInt32(row["songay"]) : 0;
                        int gia = row["gia"] != DBNull.Value ? Convert.ToInt32(row["gia"]) : 0;
                        tongTienPhongDichVu += soNgay * gia;
                        tongSoNgayPhongDichVu += soNgay;  // Cộng dồn số ngày
                    }

                    txtSoNgayPhongDichVu.Text = tongSoNgayPhongDichVu.ToString();
                    txtDonGiaPhongDichVu.Text = dtPhongDichVu.Rows[0]["gia"].ToString();
                    txtTongTienPhongDichVu.Text = tongTienPhongDichVu.ToString();
                }
                else
                {
                    txtSoNgayPhongDichVu.Text = "0";
                    txtDonGiaPhongDichVu.Text = "0";
                    txtTongTienPhongDichVu.Text = "0";
                }
            }



            // Tính tổng tiền dịch vụ
            string tongDV = @"SELECT SUM(giatien) AS Gia FROM chitiet_nhapvien WHERE nhapvien_id=" + code;
            DataTable dv = cm.load_data_query(tongDV);
            int tongTienDichVu = 0;

            if (dv.Rows.Count > 0 && dv.Rows[0]["Gia"] != DBNull.Value)
            {
                tongTienDichVu = Convert.ToInt32(dv.Rows[0]["Gia"]);
                txtTongTienDichVu.Text = tongTienDichVu.ToString();
            }
            else
            {
                txtTongTienDichVu.Text = "0";
            }

            // Tính tổng tiền
            int tongTien = tongTienPhongThuong + tongTienPhongDichVu + tongTienDichVu;
            txtTongTien.Text = tongTien.ToString();
            load();
        }

        private void load_DSPhieuThu()
        {
            string query = @"SELECT * from view_phieuthutien order by STT DESC";
            dgvDSPhieuThu.DataSource = cm.load_data_query(query);
            if(dgvDSPhieuThu.DataSource != null)
            {
                dgvDSPhieuThu.Columns[0].HeaderText = "STT";
                dgvDSPhieuThu.Columns[1].HeaderText = "Bệnh nhân";
                dgvDSPhieuThu.Columns[2].HeaderText = "Người thu tiền";
                dgvDSPhieuThu.Columns[3].HeaderText = "Ngày thu";
                dgvDSPhieuThu.Columns[4].HeaderText = "Tổng tiền";
                dgvDSPhieuThu.Columns[5].HeaderText = "Trạng thái";
            }
            string query_pxn = @"select b.ten_dichvu, a.dichvu_id, phieuxn_id from phieuxetnghiem a, dichvu b where a.trangthai=1 and a.dichvu_id = b.dichvu_id";
            comboBox1.DataSource = cm.load_data_query(query_pxn);
            comboBox1.DisplayMember = "ten_dichvu";
            comboBox1.ValueMember = "dichvu_id";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int nhapvien_id = Convert.ToInt32(cbbBenhNhan.SelectedValue);

            string updatQuery = @"INSERT INTO phieuthu (nhanvien_id, hs_id, ngaytao, ngaythu, sotien, ghichu, trangthai)
                      VALUES (@nhanvien_id, @hs_id, @ngaytao, @ngaythu, @sotien, @ghichu, 1);";

            try
            {
                using (SqlConnection connection = new SqlConnection(cm.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(updatQuery, connection))
                    {
                        int total = Convert.ToInt32(txtTongTien.Text);

                        // Thêm tham số vào câu lệnh SQL
                        command.Parameters.AddWithValue("@nhanvien_id", Session.user_id); // Sử dụng user_id từ session
                        command.Parameters.AddWithValue("@hs_id", bn_code);
                        command.Parameters.AddWithValue("@ngaytao", DateTime.Now.Date);
                        command.Parameters.AddWithValue("@ngaythu", DateTime.Now.Date);
                        command.Parameters.AddWithValue("@sotien", total);
                        command.Parameters.AddWithValue("@ghichu", rtxtGhiChu.Text);

                        // Thực thi câu lệnh SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            load_DSPhieuThu();
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm, kiểm tra lại cột và bảng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    // Cập nhật trạng thái cho phieunhapvien
                    string update_pnv = @"UPDATE phieunhapvien SET trangthai = 2 WHERE nhapvien_id = @nhapvien_id";
                    using (SqlCommand cmm = new SqlCommand(update_pnv, connection))
                    {
                        cmm.Parameters.AddWithValue("@nhapvien_id", nhapvien_id); // Thêm tham số
                        cmm.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            load_DSPhieuThu();

        }
        private void dgvDSPhieuThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSPhieuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.ColumnIndex == dgvDSPhieuThu.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                int phieuthu_id = Convert.ToInt32(dgvDSPhieuThu.Rows[e.RowIndex].Cells["phieuthu_id"].Value);

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string deleteQuery = "DELETE FROM phieuthu WHERE phieuthu_id = @phieuthu_id";
                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    parameters.Add("@phieuthu_id", phieuthu_id);

                    cm.load_data_query(deleteQuery);
                    MessageBox.Show("Xóa thành công!");

                    // Load lại danh sách sau khi xóa
                    load_DSPhieuThu();
                }
            }*/
        }

        private void dgvDSPhieuThu_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string updateQuery = @"INSERT INTO phieuthu (nhanvien_id, dichvu_id ,ngaytao, ngaythu, sotien, ghichu, trangthai)
                      VALUES (@nhanvien_id, @dichvu, @ngaytao, @ngaythu, @sotien, @ghichu, 1);";
            int code = Convert.ToInt32(comboBox1.SelectedValue);
            int gia = Convert.ToInt32(txt_gia.Text);

            int code_pxn = Convert.ToInt32(txt_pxn.Text);
            string update_pxn = @"update phieuxetnghiem set trangthai=3 where phieuxn_id="+code_pxn;
            try
            {
                using (SqlConnection connection = new SqlConnection(cm.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        command.Parameters.AddWithValue("@nhanvien_id", Session.user_id); // Sử dụng user_id từ session
                        command.Parameters.AddWithValue("@dichvu", code);
                        command.Parameters.AddWithValue("@ngaytao", DateTime.Now.Date);
                        command.Parameters.AddWithValue("@ngaythu", DateTime.Now.Date);
                        command.Parameters.AddWithValue("@sotien", gia);
                        command.Parameters.AddWithValue("@ghichu", rtxtGhiChu.Text);

                        // Thực thi câu lệnh SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            load_DSPhieuThu();
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm, kiểm tra lại cột và bảng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    SqlCommand cmmm = new SqlCommand(update_pxn, connection);
                    cmmm.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            load_DSPhieuThu();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(comboBox1.SelectedValue);
            string query_pxn = @"select b.gia_dichvu, phieuxn_id from phieuxetnghiem a, dichvu b where a.trangthai=1 and a.dichvu_id = b.dichvu_id and a.dichvu_id="+code;
            DataTable dt = cm.load_data_query(query_pxn);

            // Kiểm tra nếu DataTable có dữ liệu
            if (dt != null && dt.Rows.Count > 0)
            {
                txt_gia.Text = dt.Rows[0]["gia_dichvu"]?.ToString();
                txt_pxn.Text = dt.Rows[0]["phieuxn_id"]?.ToString();
            }
        }
    }
}
