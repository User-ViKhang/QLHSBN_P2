using QLHSBN.Utilities;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLHSBN
{
    public partial class Home : Form
    {
        private string userRole;
        common cm = new common();
        public Home(string rule)
        {
            InitializeComponent();
            load_bn_nhapvien();
            load_phongkham();
            load_bn_kham();
            userRole = rule;
        }
        private void load_bn_nhapvien()
        {
            string query = @"select * from  view_hsbn  where trangthai = N'Đang nhập viện'";
            dataGridView1.DataSource = cm.load_data_query(query);
        }
        private void load_bn_kham()
        {
            string query = @"select * from  view_hsbn  where trangthai = N'Đang hoạt động'";
            cbb_hsbn.DataSource = cm.load_data_query(query);
            cbb_hsbn.DisplayMember = "hoten";
            cbb_hsbn.ValueMember = "hs_id";
        }
        private void load_phongkham()
        {
            string query = @"Select * from view_phongkham where trangthai = N'Đang hoạt động'";
            cbb_phongkham.DataSource = cm.load_data_query(query);
            cbb_phongkham.DisplayMember = "ten_phongkham";
            cbb_phongkham.ValueMember = "phongkham_id";
        }
        private void Home_Load(object sender, EventArgs e)
        {
            load_bn_nhapvien();
            load_phongkham();
            load_bn_kham();
            cbb_filter.SelectedIndex = 0;
            if(userRole == "Y tá")
            {
                thanhToánToolStripMenuItem.Visible = false;
                hồSơKhámBệnhToolStripMenuItem.Visible = false;
                bácSỉToolStripMenuItem.Visible = false;
            }  
            else if(userRole == "Thu ngân")
            {
                dịchVụToolStripMenuItem.Visible = false;
                phòngKhámToolStripMenuItem.Visible = false;
                bácSỉToolStripMenuItem.Visible = false;
            }
            if(dataGridView1.DataSource != null)
            {
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
            }    
            
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            var search = txt_search.Text;
            if (txt_search.Text != "")
            {
                if(cbb_filter.Text == "Tên bệnh nhân")
                {
                    // 0 = khóa , 1 = hoạt động, 2 = đang khám, 3 nhập viện
                    string query = @"select * from view_hsbn where hoten like '%" + search + "%' and trangthai = N'Đang nhập viện'";
                    dataGridView1.DataSource = cm.load_data_query(query);
                }
                else if(cbb_filter.Text == "Căn cước công dân")
                {
                    string query = @"select * from view_hsbn where cccd like '%" + search + "%' and trangthai = N'Đang nhập viện'";
                    dataGridView1.DataSource = cm.load_data_query(query);
                }
                else if(cbb_filter.Text == "Số điện thoại")
                {
                    string query = @"select * from view_hsbn where sdt like '%" + search + "%' and trangthai = N'Đang nhập viện'";
                    dataGridView1.DataSource = cm.load_data_query(query);
                }
            }   
            else
            {
                load_bn_nhapvien();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(cbb_hsbn.SelectedValue);
            string query = @"insert into dangkykham ( hs_id,ngaytao,ngaydangky,trangthai)  values ( @mahs , @ngaytao, @ngaydangky, 1) ";
            try
            {
                using (SqlConnection connection = new SqlConnection(cm.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@mahs", code);
                        command.Parameters.AddWithValue("@ngaytao", DateTime.Now.Date);
                        command.Parameters.AddWithValue("@ngaydangky", DateTime.Now.Date);
                        // Thực thi câu lệnh SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            load_bn_kham();
                        }
                        else
                        {
                            MessageBox.Show("Không thể đăng ký, kiểm tra lại cột và bảng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void bácSỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            nv.ShowDialog();
        }

        private void tạoHồSơMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hsbn hsm = new Hsbn();
            hsm.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void danhSáchĐăngKýKhámToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HSDangKyKham hsdk = new HSDangKyKham();
            hsdk.ShowDialog();
        }

        private void phiếuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuThu ptttt = new PhieuThu();
            ptttt.ShowDialog();
        }

        private void danhMụcDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dichvu dvvv = new Dichvu();
            dvvv.ShowDialog();
        }

        private void thêmDịchVụChoHSBNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaoPXN taophieu = new TaoPXN();
            taophieu.ShowDialog();
        }

        private void danhMụcPhòngKhámToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phongkham pk = new Phongkham();
            pk.ShowDialog();
        }

        private void danhMụcPhòngBệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phongbenh pb = new Phongbenh();
            pb.ShowDialog();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhậpViệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phieunhapvien pnv = new Phieunhapvien();
            pnv.ShowDialog();
        }
    }
}
