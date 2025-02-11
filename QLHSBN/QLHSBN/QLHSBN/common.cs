using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLHSBN
{
    public class common
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        public common()
        {

        }
        public DataTable load_data_table(string table)
        {
            try
            {
                string query = $"SELECT * FROM {table}";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        public DataTable load_data_query(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        public void AddPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.GotFocus += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }
       

        public bool CheckDuplicate(string table, string column, string value)
        {
            // Câu truy vấn kiểm tra
            string query = $"SELECT COUNT(*) FROM {table} WHERE {column} = @Value";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số vào truy vấn
                        command.Parameters.AddWithValue("@Value", value);

                        // Thực thi truy vấn và lấy kết quả
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        return count > 0; // Trả về true nếu mã đã tồn tại
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Checktripple(string table, string column, string value)
        {
            // Câu truy vấn kiểm tra
            string query = $"SELECT COUNT(*) FROM {table} WHERE {column} = @Value";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số vào truy vấn
                        command.Parameters.AddWithValue("@Value", value);

                        // Thực thi truy vấn và lấy kết quả
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        return count > 1; // Trả về true nếu mã đã tồn tại
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool login(string _taikhoan, string _matkhau)
        {
            // Câu truy vấn kiểm tra
            string query = $"SELECT COUNT(*) FROM nhanvien WHERE taikhoan = @_taikhoan and matkhau = @_matkhau";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số vào truy vấn
                        command.Parameters.AddWithValue("@_taikhoan", _taikhoan);
                        command.Parameters.AddWithValue("@_matkhau", _matkhau);
                        // Thực thi truy vấn và lấy kết quả
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        return count > 0; // Trả về true nếu mã đã tồn tại
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
