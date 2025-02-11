using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSBN
{
    public partial class ThongKeBenhNhan : Form
    {
        public ThongKeBenhNhan()
        {
            InitializeComponent();
        }
        common cm = new common();
        private void btn_filter_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ DateTimePicker
                DateTime ngayNhapVienStart = dtp_1.Value;
                DateTime ngayNhapVienEnd = dtp_2.Value;

                // Sử dụng parameters để truyền giá trị vào câu lệnh SQL
                string query = @"SELECT * FROM view_nhapvien where ngaynhapvien BETWEEN '" + ngayNhapVienStart + "' AND '" + ngayNhapVienEnd + "'";

                // Gọi phương thức để tải dữ liệu vào DataGridView
                dataGridView1.DataSource = cm.load_data_query(query);
                MessageBox.Show("Đã lọc dữ liệu");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi truy vấn dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThongKeBenhNhan_Load(object sender, EventArgs e)
        {
            load_data();
            dtp_1.MaxDate = DateTime.Now.Date;
            dtp_2.MaxDate = DateTime.Now.Date;
            load_data();
            dataGridView1.Columns[0].HeaderText = "STT";
            dataGridView1.Columns[1].HeaderText = "Họ tên bệnh nhân";
            dataGridView1.Columns[2].HeaderText = "Ngày nhập viện";
            dataGridView1.Columns[3].HeaderText = "Tên phòng";
            dataGridView1.Columns[4].HeaderText = "Ngày xuất viện";
            dataGridView1.Columns[5].HeaderText = "Người lập";
            dataGridView1.Columns[6].HeaderText = "Trạng thái";
        }

        private void load_data()
        {
            string query = @"select * from view_nhapvien";
            dataGridView1.DataSource = cm.load_data_query(query);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            load_data();
            dtp_1.Value = DateTime.Now.Date;
            dtp_2.Value = DateTime.Now.Date;
            MessageBox.Show("Hiển thị tất cả bệnh nhân.");
        }
    }
}
