
namespace QLHSBN
{
    partial class Hsbn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbb_gt = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dc = new System.Windows.Forms.TextBox();
            this.txt_cccd = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_mabhyt = new System.Windows.Forms.TextBox();
            this.txt_mahsbn = new System.Windows.Forms.TextBox();
            this.btn_tao = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_khoa = new System.Windows.Forms.Button();
            this.btn_rs = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbb_trangthai = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.cbb_search = new System.Windows.Forms.ComboBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(349, 51);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(250, 20);
            this.txt_hoten.TabIndex = 1;
            this.txt_hoten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hoten_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_ngaysinh);
            this.groupBox1.Controls.Add(this.cbb_gt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_dc);
            this.groupBox1.Controls.Add(this.txt_cccd);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.txt_mabhyt);
            this.groupBox1.Controls.Add(this.txt_mahsbn);
            this.groupBox1.Controls.Add(this.txt_hoten);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1276, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hồ sơ bệnh nhân";
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaysinh.Location = new System.Drawing.Point(28, 130);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(250, 20);
            this.dtp_ngaysinh.TabIndex = 3;
            // 
            // cbb_gt
            // 
            this.cbb_gt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_gt.FormattingEnabled = true;
            this.cbb_gt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_gt.Location = new System.Drawing.Point(1011, 132);
            this.cbb_gt.Name = "cbb_gt";
            this.cbb_gt.Size = new System.Drawing.Size(250, 21);
            this.cbb_gt.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1008, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1008, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Căn cước công dân";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(687, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số bảo hiểm y tế";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(687, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã hồ sơ khám bệnh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày tháng năm sinh";
            // 
            // txt_dc
            // 
            this.txt_dc.Location = new System.Drawing.Point(690, 132);
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(250, 20);
            this.txt_dc.TabIndex = 1;
            // 
            // txt_cccd
            // 
            this.txt_cccd.Location = new System.Drawing.Point(1011, 51);
            this.txt_cccd.Name = "txt_cccd";
            this.txt_cccd.Size = new System.Drawing.Size(250, 20);
            this.txt_cccd.TabIndex = 1;
            this.txt_cccd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cccd_KeyPress);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(690, 51);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(250, 20);
            this.txt_sdt.TabIndex = 1;
            this.txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sdt_KeyPress);
            // 
            // txt_mabhyt
            // 
            this.txt_mabhyt.Location = new System.Drawing.Point(349, 130);
            this.txt_mabhyt.Name = "txt_mabhyt";
            this.txt_mabhyt.Size = new System.Drawing.Size(250, 20);
            this.txt_mabhyt.TabIndex = 1;
            this.txt_mabhyt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mabhyt_KeyPress);
            // 
            // txt_mahsbn
            // 
            this.txt_mahsbn.Location = new System.Drawing.Point(28, 51);
            this.txt_mahsbn.Name = "txt_mahsbn";
            this.txt_mahsbn.Size = new System.Drawing.Size(250, 20);
            this.txt_mahsbn.TabIndex = 1;
            // 
            // btn_tao
            // 
            this.btn_tao.Location = new System.Drawing.Point(1023, 208);
            this.btn_tao.Name = "btn_tao";
            this.btn_tao.Size = new System.Drawing.Size(250, 23);
            this.btn_tao.TabIndex = 3;
            this.btn_tao.Text = "Tạo hồ sơ";
            this.btn_tao.UseVisualStyleBackColor = true;
            this.btn_tao.Click += new System.EventHandler(this.btn_tao_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(702, 208);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(250, 23);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Sửa hồ sơ";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_khoa
            // 
            this.btn_khoa.Location = new System.Drawing.Point(487, 208);
            this.btn_khoa.Name = "btn_khoa";
            this.btn_khoa.Size = new System.Drawing.Size(124, 23);
            this.btn_khoa.TabIndex = 3;
            this.btn_khoa.Text = "Khóa hồ sơ";
            this.btn_khoa.UseVisualStyleBackColor = true;
            this.btn_khoa.Click += new System.EventHandler(this.btn_khoa_Click);
            // 
            // btn_rs
            // 
            this.btn_rs.Location = new System.Drawing.Point(361, 208);
            this.btn_rs.Name = "btn_rs";
            this.btn_rs.Size = new System.Drawing.Size(120, 23);
            this.btn_rs.TabIndex = 3;
            this.btn_rs.Text = "Khôi phục hồ sơ";
            this.btn_rs.UseVisualStyleBackColor = true;
            this.btn_rs.Click += new System.EventHandler(this.btn_rs_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1276, 327);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbb_trangthai
            // 
            this.cbb_trangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_trangthai.FormattingEnabled = true;
            this.cbb_trangthai.Items.AddRange(new object[] {
            "===Chọn trạng thái===",
            "Đã khóa",
            "Đang hoạt động"});
            this.cbb_trangthai.Location = new System.Drawing.Point(12, 258);
            this.cbb_trangthai.Name = "cbb_trangthai";
            this.cbb_trangthai.Size = new System.Drawing.Size(180, 21);
            this.cbb_trangthai.TabIndex = 5;
            this.cbb_trangthai.SelectionChangeCommitted += new System.EventHandler(this.cbb_trangthai_SelectionChangeCommitted);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(702, 259);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(250, 20);
            this.txt_search.TabIndex = 1;
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mabhyt_KeyPress);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(1198, 259);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Tìm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cbb_search
            // 
            this.cbb_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_search.FormattingEnabled = true;
            this.cbb_search.Items.AddRange(new object[] {
            "BHYT",
            "CCCD"});
            this.cbb_search.Location = new System.Drawing.Point(1023, 258);
            this.cbb_search.Name = "cbb_search";
            this.cbb_search.Size = new System.Drawing.Size(114, 21);
            this.cbb_search.TabIndex = 2;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(12, 208);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 23);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Hsbn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 642);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cbb_search);
            this.Controls.Add(this.cbb_trangthai);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_rs);
            this.Controls.Add(this.btn_khoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_tao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_search);
            this.Name = "Hsbn";
            this.Text = "TaoHSBN";
            this.Load += new System.EventHandler(this.TaoHSBN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dc;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.ComboBox cbb_gt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cccd;
        private System.Windows.Forms.TextBox txt_mabhyt;
        private System.Windows.Forms.TextBox txt_mahsbn;
        private System.Windows.Forms.Button btn_tao;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_khoa;
        private System.Windows.Forms.Button btn_rs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbb_trangthai;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cbb_search;
        private System.Windows.Forms.Button btn_thoat;
    }
}