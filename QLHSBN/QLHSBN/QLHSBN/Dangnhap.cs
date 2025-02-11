using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using QLHSBN.Utilities;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLHSBN
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        common cm = new common();
        private void Dangnhap_Load(object sender, EventArgs e)
        {
            
            cm.AddPlaceholder(txt_tk,"Nhập tài khoản của bạn");
            cm.AddPlaceholder(txt_mk, "Nhập mật khẩu của bạn");
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if(txt_tk.Text == "" || txt_mk.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                txt_tk.Focus();
            }    
            else
            {
                string query = $"SELECT nhanvien_id, hoten, chucvu FROM nhanvien WHERE taikhoan = @_taikhoan and matkhau = @_matkhau";

                try
                {
                    using (SqlConnection connection = new SqlConnection(cm.connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Thêm tham số vào truy vấn
                            command.Parameters.AddWithValue("@_taikhoan", txt_tk.Text);
                            command.Parameters.AddWithValue("@_matkhau", txt_mk.Text);

                            // Thực thi truy vấn và lấy dữ liệu
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                // Kiểm tra nếu có dữ liệu trả về
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        // Gắn thông tin vào Session
                                        Session.user_id = reader.GetInt32(0);  // nhanvienid
                                        Session.name = reader.GetString(1);   // hoten
                                        Session.chucvu = reader.GetString(2); // chucvu
                                    }

                                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Home h = new Home(Session.chucvu);
                                    h.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
        }
    }
}
