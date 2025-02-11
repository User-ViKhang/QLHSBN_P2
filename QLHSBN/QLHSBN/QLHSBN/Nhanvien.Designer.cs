
namespace QLHSBN
{
    partial class Nhanvien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbb_lock = new System.Windows.Forms.ComboBox();
            this.cbb_filter = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbb_gt = new System.Windows.Forms.ComboBox();
            this.cbb_chucvu = new System.Windows.Forms.ComboBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.txt_exp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_chuyenkhoa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_hocvan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_lock = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbb_lock);
            this.groupBox1.Controls.Add(this.cbb_filter);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên trong bệnh viện";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(211, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Hiển thị nhân viên theo trạng thái tài khoản";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(559, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Hiển thị nhân viên theo chức vụ";
            // 
            // cbb_lock
            // 
            this.cbb_lock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_lock.FormattingEnabled = true;
            this.cbb_lock.Items.AddRange(new object[] {
            "===Chọn trạng thái===",
            "Đã khóa",
            "Hoạt động"});
            this.cbb_lock.Location = new System.Drawing.Point(230, 19);
            this.cbb_lock.Name = "cbb_lock";
            this.cbb_lock.Size = new System.Drawing.Size(150, 21);
            this.cbb_lock.TabIndex = 2;
            this.cbb_lock.SelectionChangeCommitted += new System.EventHandler(this.cbb_lock_SelectionChangeCommitted);
            // 
            // cbb_filter
            // 
            this.cbb_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_filter.FormattingEnabled = true;
            this.cbb_filter.Items.AddRange(new object[] {
            "===Chọn chức vụ===",
            "Bác sỉ",
            "Y tá",
            "Thu ngân"});
            this.cbb_filter.Location = new System.Drawing.Point(724, 19);
            this.cbb_filter.Name = "cbb_filter";
            this.cbb_filter.Size = new System.Drawing.Size(150, 21);
            this.cbb_filter.TabIndex = 2;
            this.cbb_filter.SelectionChangeCommitted += new System.EventHandler(this.cbb_filter_SelectionChangeCommitted);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(868, 302);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_ngaysinh);
            this.groupBox2.Controls.Add(this.cbb_gt);
            this.groupBox2.Controls.Add(this.cbb_chucvu);
            this.groupBox2.Controls.Add(this.txt_sdt);
            this.groupBox2.Controls.Add(this.txt_hoten);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_code);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 168);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaysinh.Location = new System.Drawing.Point(23, 131);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(100, 20);
            this.dtp_ngaysinh.TabIndex = 3;
            // 
            // cbb_gt
            // 
            this.cbb_gt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_gt.FormattingEnabled = true;
            this.cbb_gt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_gt.Location = new System.Drawing.Point(295, 131);
            this.cbb_gt.Name = "cbb_gt";
            this.cbb_gt.Size = new System.Drawing.Size(121, 21);
            this.cbb_gt.TabIndex = 2;
            // 
            // cbb_chucvu
            // 
            this.cbb_chucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_chucvu.FormattingEnabled = true;
            this.cbb_chucvu.Items.AddRange(new object[] {
            "Bác sỉ",
            "Y tá",
            "Thu ngân"});
            this.cbb_chucvu.Location = new System.Drawing.Point(295, 56);
            this.cbb_chucvu.Name = "cbb_chucvu";
            this.cbb_chucvu.Size = new System.Drawing.Size(121, 21);
            this.cbb_chucvu.TabIndex = 2;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(157, 131);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(100, 20);
            this.txt_sdt.TabIndex = 1;
            this.txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sdt_KeyPress);
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(157, 56);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(100, 20);
            this.txt_hoten.TabIndex = 1;
            this.txt_hoten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hoten_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên";
            // 
            // txt_code
            // 
            this.txt_code.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_code.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txt_code.Location = new System.Drawing.Point(23, 56);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(100, 23);
            this.txt_code.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_them);
            this.groupBox3.Controls.Add(this.txt_mk);
            this.groupBox3.Controls.Add(this.txt_tk);
            this.groupBox3.Controls.Add(this.txt_exp);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_chuyenkhoa);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_hocvan);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(455, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(437, 168);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Học vấn";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(295, 128);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 23);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(157, 131);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(100, 20);
            this.txt_mk.TabIndex = 1;
            // 
            // txt_tk
            // 
            this.txt_tk.Location = new System.Drawing.Point(19, 131);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(100, 20);
            this.txt_tk.TabIndex = 1;
            // 
            // txt_exp
            // 
            this.txt_exp.Location = new System.Drawing.Point(295, 56);
            this.txt_exp.Name = "txt_exp";
            this.txt_exp.Size = new System.Drawing.Size(100, 20);
            this.txt_exp.TabIndex = 1;
            this.txt_exp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_exp_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mật khẩu";
            // 
            // txt_chuyenkhoa
            // 
            this.txt_chuyenkhoa.Location = new System.Drawing.Point(157, 56);
            this.txt_chuyenkhoa.Name = "txt_chuyenkhoa";
            this.txt_chuyenkhoa.Size = new System.Drawing.Size(100, 20);
            this.txt_chuyenkhoa.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tài khoản";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số năm kinh nghiệm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(154, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Chuyên khoa";
            // 
            // txt_hocvan
            // 
            this.txt_hocvan.Location = new System.Drawing.Point(23, 56);
            this.txt_hocvan.Name = "txt_hocvan";
            this.txt_hocvan.Size = new System.Drawing.Size(100, 20);
            this.txt_hocvan.TabIndex = 1;
            this.txt_hocvan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hocvan_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Học vị";
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(792, 201);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(100, 23);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_lock
            // 
            this.btn_lock.Location = new System.Drawing.Point(630, 201);
            this.btn_lock.Name = "btn_lock";
            this.btn_lock.Size = new System.Drawing.Size(100, 23);
            this.btn_lock.TabIndex = 2;
            this.btn_lock.Text = "Khóa tài khoản";
            this.btn_lock.UseVisualStyleBackColor = true;
            this.btn_lock.Click += new System.EventHandler(this.btn_lock_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(12, 201);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 23);
            this.btn_thoat.TabIndex = 2;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Khôi phục tài khoản";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 628);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_lock);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Nhanvien";
            this.Text = "Nhanvien";
            this.Load += new System.EventHandler(this.Nhanvien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbb_chucvu;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_filter;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.ComboBox cbb_gt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_exp;
        private System.Windows.Forms.TextBox txt_chuyenkhoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_hocvan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_lock;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.ComboBox cbb_lock;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
    }
}