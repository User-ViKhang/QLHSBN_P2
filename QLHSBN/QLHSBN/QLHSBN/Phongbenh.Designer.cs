
namespace QLHSBN
{
    partial class Phongbenh
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
            this.btn_active = new System.Windows.Forms.Button();
            this.btn_ngung = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_sogiuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maphong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ck_dv = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tenphong = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_active
            // 
            this.btn_active.Location = new System.Drawing.Point(19, 163);
            this.btn_active.Name = "btn_active";
            this.btn_active.Size = new System.Drawing.Size(93, 40);
            this.btn_active.TabIndex = 10;
            this.btn_active.Text = "Kích hoạt";
            this.btn_active.UseVisualStyleBackColor = true;
            this.btn_active.Click += new System.EventHandler(this.btn_active_Click);
            // 
            // btn_ngung
            // 
            this.btn_ngung.Location = new System.Drawing.Point(137, 163);
            this.btn_ngung.Name = "btn_ngung";
            this.btn_ngung.Size = new System.Drawing.Size(109, 40);
            this.btn_ngung.TabIndex = 11;
            this.btn_ngung.Text = "Ngừng hoạt động";
            this.btn_ngung.UseVisualStyleBackColor = true;
            this.btn_ngung.Click += new System.EventHandler(this.btn_ngung_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(282, 163);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(96, 40);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(397, 163);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(95, 40);
            this.btn_them.TabIndex = 13;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 397);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(478, 372);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // txt_sogiuong
            // 
            this.txt_sogiuong.Location = new System.Drawing.Point(19, 111);
            this.txt_sogiuong.Name = "txt_sogiuong";
            this.txt_sogiuong.Size = new System.Drawing.Size(75, 20);
            this.txt_sogiuong.TabIndex = 7;
            this.txt_sogiuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sogiuong_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số giường";
            // 
            // txt_maphong
            // 
            this.txt_maphong.Location = new System.Drawing.Point(19, 42);
            this.txt_maphong.Name = "txt_maphong";
            this.txt_maphong.Size = new System.Drawing.Size(227, 20);
            this.txt_maphong.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã phòng";
            // 
            // ck_dv
            // 
            this.ck_dv.AutoSize = true;
            this.ck_dv.Location = new System.Drawing.Point(283, 114);
            this.ck_dv.Name = "ck_dv";
            this.ck_dv.Size = new System.Drawing.Size(95, 17);
            this.ck_dv.TabIndex = 14;
            this.ck_dv.Text = "Phòng dịch vụ";
            this.ck_dv.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giá / giường / ngày";
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(137, 111);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(109, 20);
            this.txt_gia.TabIndex = 7;
            this.txt_gia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gia_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên phòng";
            // 
            // txt_tenphong
            // 
            this.txt_tenphong.Location = new System.Drawing.Point(282, 42);
            this.txt_tenphong.Name = "txt_tenphong";
            this.txt_tenphong.Size = new System.Drawing.Size(210, 20);
            this.txt_tenphong.TabIndex = 8;
            this.txt_tenphong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sophong_KeyPress);
            // 
            // Phongbenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 635);
            this.Controls.Add(this.ck_dv);
            this.Controls.Add(this.btn_active);
            this.Controls.Add(this.btn_ngung);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_gia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_sogiuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tenphong);
            this.Controls.Add(this.txt_maphong);
            this.Controls.Add(this.label1);
            this.Name = "Phongbenh";
            this.Text = "Phongbenh";
            this.Load += new System.EventHandler(this.Phongbenh_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_active;
        private System.Windows.Forms.Button btn_ngung;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_sogiuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maphong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ck_dv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tenphong;
    }
}