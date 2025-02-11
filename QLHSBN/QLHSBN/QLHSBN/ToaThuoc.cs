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
    public partial class ToaThuoc : Form
    {
        public ToaThuoc()
        {
            InitializeComponent();
        }
        common cm = new common();
        private void load_cbb_BenhNhan()
        {
            string query = @"select hs.hoten, hs.cccd, hs.bhyt, hs.hs_id from phieunhapvien pnv inner join hsbn hs on pnv.hs_id=hs.hs_id";
            cbbBenhNhan.DataSource = cm.load_data_query(query);
            cbbBenhNhan.DisplayMember = "hoten";
            cbbBenhNhan.ValueMember = "hs_id";
        }

        private void load_cbb_BacSi()
        {
            string query = @"select hoten, nhanvien_id from nhanvien where chucvu = N'Bác sỉ' and trangthai=1";
            cbbBacSi.DataSource = cm.load_data_query(query);
            cbbBacSi.DisplayMember = "hoten";
            cbbBacSi.ValueMember = "nhanvien_id";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbBenhNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void load_cbb_DSThuoc()
        {
            string query = @"select thuoc_id, tenthuoc from thuoc";
            cbbTenThuoc.DataSource = cm.load_data_query(query);
            cbbTenThuoc.DisplayMember = "tenthuoc";
            cbbTenThuoc.ValueMember = "thuoc_id";
        }

        private void load_DSToaThuoc()
        {
            string query = @"select a.toathuoc_id as STT, tentoathuoc, ngayxuattoa, c.hoten as N'Bac si', b.hoten
from toathuoc as a, hsbn as b, nhanvien as c
where a.hs_id = b.hs_id and a.nhanvien_id= c.nhanvien_id";
            dgvDSToaThuoc.DataSource = cm.load_data_query(query);
        }

        private void cbbBenhNhan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = cm.load_data_query("select hs.hoten, hs.cccd, hs.bhyt, nhapvien_id from phieunhapvien pnv inner join hsbn hs on pnv.hs_id=hs.hs_id where pnv.nhapvien_id="+ cbbBenhNhan.SelectedValue);
            if (dt.Rows.Count > 0)
            {
                txtCCCD.Text = dt.Rows[0]["cccd"].ToString();  // Lấy giá trị cccd từ dòng đầu tiên
                txtBHYT.Text = dt.Rows[0]["bhyt"].ToString();  // Nếu có bhyt, lấy giá trị bhyt
            }
            else
            {
                txtCCCD.Text = "";
                txtBHYT.Text = "";
            }
        }

        private void ToaThuoc_Load(object sender, EventArgs e)
        {
            load_cbb_BenhNhan();
            load_cbb_BacSi();
            load_cbb_DSThuoc();
            load_DSToaThuoc();
            
            // dgvDSToaThuoc.Columns[0].HeaderText = "ID Thuốc";
            //  dgvDSToaThuoc.Columns[1].HeaderText = "Tên thuốc";
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            if(dgvChiTietThuoc.DataSource != null) {
                dgvChiTietThuoc.Columns[0].HeaderText = "ID thuốc";
                dgvChiTietThuoc.Columns[1].HeaderText = "Tên thuốc";
                dgvChiTietThuoc.Columns[2].HeaderText = "Số lượng";
            }
            if (dgvChiTietThuoc.DataSource == null)
            {
                dgvChiTietThuoc.Columns.Add("Ma", "STT");
                dgvChiTietThuoc.Columns.Add("Ten", "Tên thuoc");
                dgvChiTietThuoc.Columns.Add("SL", "Số lượng");
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "Delete Row";
                btn.Text = "Delete";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
                dgvChiTietThuoc.Columns.Add(btn);
            }
            dgvChiTietThuoc.Rows.Add(cbbTenThuoc.SelectedValue, cbbTenThuoc.Text, txtSoLuong.Text);
        }
        int code = 0;
        private void dgvDSToaThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // e.RowIndex là chỉ số hàng được double click
            {

                DataGridViewRow selectedRow = dgvDSToaThuoc.Rows[e.RowIndex];
                code = Convert.ToInt32(selectedRow.Cells[0].Value);
                if(code != 0)
                {
                    
                    dgvChiTietThuoc.DataSource = cm.load_data_query("select * from chitiet_toathuoc where toathuoc_id = " + code);
                    if (dgvChiTietThuoc.DataSource != null)
                    {
                        dgvChiTietThuoc.Columns[0].HeaderText = "ID thuốc";
                        dgvChiTietThuoc.Columns[1].HeaderText = "Tên thuốc";
                        dgvChiTietThuoc.Columns[2].HeaderText = "Số lượng";
                        dgvChiTietThuoc.Columns[3].HeaderText = "abc";
                    }
                }
            }
        }

        private void btnLuuToaThuoc_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cm.connectionString))
                {
                    connection.Open();

                    // Bắt đầu Transaction
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Chuyển đổi dữ liệu từ ComboBox
                            int hs_id = Convert.ToInt32(cbbBenhNhan.SelectedValue);
                            int nhanvien_id = Convert.ToInt32(cbbBacSi.SelectedValue);

                            // Câu lệnh INSERT vào phieunhapvien
                            string query = @"
                                            INSERT INTO toathuoc (tentoathuoc, hs_id, ngaytao, ngayxuattoa, nhanvien_id, trangthai)
                                            VALUES (@tentoathuoc, @hs_id, @ngaytao, @ngayxuattoa, @nhanvien_id, 1);
                                            SELECT SCOPE_IDENTITY();";
                            int toathuoc_id;

                            using (SqlCommand command = new SqlCommand(query, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@hs_id", hs_id);
                                command.Parameters.AddWithValue("@tentoathuoc", txtTenToaThuoc.Text);
                                command.Parameters.AddWithValue("@nhanvien_id", nhanvien_id);
                                command.Parameters.AddWithValue("@ngayxuattoa", DateTime.Now.Date);
                                command.Parameters.AddWithValue("@ngaytao", DateTime.Now.Date);

                                object result = command.ExecuteScalar();
                                toathuoc_id = Convert.ToInt32(result);

                                int rowsAffected = command.ExecuteNonQuery();
                            }

                            foreach (DataGridViewRow row in dgvChiTietThuoc.Rows)
                            {
                                if (row.IsNewRow) continue; // Bỏ qua dòng trống

                                // Lấy giá trị từ DataGridView
                                int thuoc_id = Convert.ToInt32(row.Cells["Ma"].Value);
                                int soluong = Convert.ToInt32(row.Cells["SL"].Value);

                                string query1 = @"
                                            INSERT INTO chitiet_toathuoc (toathuoc_id, thuoc_id, soluong)
                                            VALUES (@toathuoc_id, @thuoc_id, @soluong);";

                                using (SqlCommand cmd = new SqlCommand(query1, connection, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@toathuoc_id", toathuoc_id);
                                    cmd.Parameters.AddWithValue("@thuoc_id", thuoc_id);
                                    cmd.Parameters.AddWithValue("@soluong", soluong);
                                    cmd.ExecuteNonQuery();
                                    
                                }
                            }
                            transaction.Commit();
                            MessageBox.Show("Lưu thành công");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
}
