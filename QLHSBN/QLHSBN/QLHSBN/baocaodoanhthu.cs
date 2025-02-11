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
    public partial class baocaodoanhthu : Form
    {
        public baocaodoanhthu()
        {
            InitializeComponent();
        }
        common cm = new common();
        private void load_baocao()
        {
            dataGridView1.DataSource = cm.load_data_query("select * from view_baocaodoanhthu order by STT DESC");
        }
        private void baocaodoanhthu_Load(object sender, EventArgs e)
        {
            load_baocao();
            if(dataGridView1.DataSource != null)
            {
                dataGridView1.Columns[0].HeaderText = "STT";
                dataGridView1.Columns[1].HeaderText = "Nhân viên thu tiền";
                dataGridView1.Columns[2].HeaderText = "Dịch vụ";
                dataGridView1.Columns[3].HeaderText = "Bệnh nhân";
                dataGridView1.Columns[4].HeaderText = "Số tiền";
                dataGridView1.Columns[5].HeaderText = "Ghi chú";
                dataGridView1.Columns[6].HeaderText = "Ngày thu";
                dataGridView1.Columns[7].HeaderText = "Ngày tạo";
            }    
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
