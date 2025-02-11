
namespace QLHSBN
{
    partial class ToaThuoc
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbbBenhNhan = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBHYT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbTenThuoc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDSToaThuoc = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietThuoc = new System.Windows.Forms.DataGridView();
            this.btnLuuToaThuoc = new System.Windows.Forms.Button();
            this.btnHuyToaThuoc = new System.Windows.Forms.Button();
            this.btnInToaThuoc = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbBacSi = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenToaThuoc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSToaThuoc)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toa thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bệnh nhân:";
            // 
            // cbbBenhNhan
            // 
            this.cbbBenhNhan.FormattingEnabled = true;
            this.cbbBenhNhan.Location = new System.Drawing.Point(83, 60);
            this.cbbBenhNhan.Name = "cbbBenhNhan";
            this.cbbBenhNhan.Size = new System.Drawing.Size(217, 21);
            this.cbbBenhNhan.TabIndex = 2;
            this.cbbBenhNhan.SelectedIndexChanged += new System.EventHandler(this.cbbBenhNhan_SelectedIndexChanged);
            this.cbbBenhNhan.SelectionChangeCommitted += new System.EventHandler(this.cbbBenhNhan_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBHYT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCCCD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 162);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bệnh nhân";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 111);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày xuất dơn:";
            // 
            // txtBHYT
            // 
            this.txtBHYT.Enabled = false;
            this.txtBHYT.Location = new System.Drawing.Point(101, 74);
            this.txtBHYT.Name = "txtBHYT";
            this.txtBHYT.Size = new System.Drawing.Size(209, 20);
            this.txtBHYT.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "BHYT:";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Enabled = false;
            this.txtCCCD.Location = new System.Drawing.Point(101, 33);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(209, 20);
            this.txtCCCD.TabIndex = 1;
            this.txtCCCD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CCCD/CMND:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.btnThemThuoc);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbbTenThuoc);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(351, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 162);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn thuốc";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(86, 74);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(204, 20);
            this.txtSoLuong.TabIndex = 5;
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.Location = new System.Drawing.Point(204, 121);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(86, 27);
            this.btnThemThuoc.TabIndex = 4;
            this.btnThemThuoc.Text = "Thêm thuốc";
            this.btnThemThuoc.UseVisualStyleBackColor = true;
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số lượng:";
            // 
            // cbbTenThuoc
            // 
            this.cbbTenThuoc.FormattingEnabled = true;
            this.cbbTenThuoc.Location = new System.Drawing.Point(86, 32);
            this.cbbTenThuoc.Name = "cbbTenThuoc";
            this.cbbTenThuoc.Size = new System.Drawing.Size(204, 21);
            this.cbbTenThuoc.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên thuốc:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSToaThuoc);
            this.groupBox3.Location = new System.Drawing.Point(12, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 208);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách toa thuốc";
            // 
            // dgvDSToaThuoc
            // 
            this.dgvDSToaThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSToaThuoc.Location = new System.Drawing.Point(6, 19);
            this.dgvDSToaThuoc.Name = "dgvDSToaThuoc";
            this.dgvDSToaThuoc.Size = new System.Drawing.Size(390, 183);
            this.dgvDSToaThuoc.TabIndex = 0;
            this.dgvDSToaThuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSToaThuoc_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvChiTietThuoc);
            this.groupBox4.Location = new System.Drawing.Point(422, 266);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(366, 208);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết thuốc";
            // 
            // dgvChiTietThuoc
            // 
            this.dgvChiTietThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietThuoc.Location = new System.Drawing.Point(6, 19);
            this.dgvChiTietThuoc.Name = "dgvChiTietThuoc";
            this.dgvChiTietThuoc.Size = new System.Drawing.Size(354, 183);
            this.dgvChiTietThuoc.TabIndex = 0;
            // 
            // btnLuuToaThuoc
            // 
            this.btnLuuToaThuoc.Location = new System.Drawing.Point(664, 98);
            this.btnLuuToaThuoc.Name = "btnLuuToaThuoc";
            this.btnLuuToaThuoc.Size = new System.Drawing.Size(124, 27);
            this.btnLuuToaThuoc.TabIndex = 7;
            this.btnLuuToaThuoc.Text = "Lưu toa thuốc";
            this.btnLuuToaThuoc.UseVisualStyleBackColor = true;
            this.btnLuuToaThuoc.Click += new System.EventHandler(this.btnLuuToaThuoc_Click);
            // 
            // btnHuyToaThuoc
            // 
            this.btnHuyToaThuoc.Location = new System.Drawing.Point(664, 219);
            this.btnHuyToaThuoc.Name = "btnHuyToaThuoc";
            this.btnHuyToaThuoc.Size = new System.Drawing.Size(124, 28);
            this.btnHuyToaThuoc.TabIndex = 8;
            this.btnHuyToaThuoc.Text = "Hủy toa thuốc";
            this.btnHuyToaThuoc.UseVisualStyleBackColor = true;
            // 
            // btnInToaThuoc
            // 
            this.btnInToaThuoc.Location = new System.Drawing.Point(664, 157);
            this.btnInToaThuoc.Name = "btnInToaThuoc";
            this.btnInToaThuoc.Size = new System.Drawing.Size(124, 31);
            this.btnInToaThuoc.TabIndex = 9;
            this.btnInToaThuoc.Text = "In toa thuốc";
            this.btnInToaThuoc.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Bác sĩ kê toa:";
            // 
            // cbbBacSi
            // 
            this.cbbBacSi.FormattingEnabled = true;
            this.cbbBacSi.Location = new System.Drawing.Point(429, 60);
            this.cbbBacSi.Name = "cbbBacSi";
            this.cbbBacSi.Size = new System.Drawing.Size(223, 21);
            this.cbbBacSi.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tên toa thuốc:";
            // 
            // txtTenToaThuoc
            // 
            this.txtTenToaThuoc.Location = new System.Drawing.Point(98, 28);
            this.txtTenToaThuoc.Name = "txtTenToaThuoc";
            this.txtTenToaThuoc.Size = new System.Drawing.Size(202, 20);
            this.txtTenToaThuoc.TabIndex = 13;
            // 
            // ToaThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.txtTenToaThuoc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbbBacSi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnInToaThuoc);
            this.Controls.Add(this.btnHuyToaThuoc);
            this.Controls.Add(this.btnLuuToaThuoc);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbBenhNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ToaThuoc";
            this.Text = "ToaThuoc";
            this.Load += new System.EventHandler(this.ToaThuoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSToaThuoc)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbBenhNhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBHYT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbTenThuoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDSToaThuoc;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvChiTietThuoc;
        private System.Windows.Forms.Button btnLuuToaThuoc;
        private System.Windows.Forms.Button btnHuyToaThuoc;
        private System.Windows.Forms.Button btnInToaThuoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbBacSi;
        private System.Windows.Forms.NumericUpDown txtSoLuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenToaThuoc;
    }
}