
namespace QLHSBN
{
    partial class QuanLyThuoc
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
            this.label2 = new System.Windows.Forms.Label();
            this.ckbThuocBaoHiem = new System.Windows.Forms.CheckBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDanhSachThuoc = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMoTa = new System.Windows.Forms.RichTextBox();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachThuoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên thuốc";
            // 
            // ckbThuocBaoHiem
            // 
            this.ckbThuocBaoHiem.AutoSize = true;
            this.ckbThuocBaoHiem.Location = new System.Drawing.Point(32, 83);
            this.ckbThuocBaoHiem.Name = "ckbThuocBaoHiem";
            this.ckbThuocBaoHiem.Size = new System.Drawing.Size(103, 17);
            this.ckbThuocBaoHiem.TabIndex = 25;
            this.ckbThuocBaoHiem.Text = "Thuốc bảo hiểm";
            this.ckbThuocBaoHiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(474, 155);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(474, 116);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(474, 77);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(474, 41);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewDanhSachThuoc);
            this.groupBox2.Location = new System.Drawing.Point(27, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 207);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thuốc";
            // 
            // dataGridViewDanhSachThuoc
            // 
            this.dataGridViewDanhSachThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachThuoc.Location = new System.Drawing.Point(12, 19);
            this.dataGridViewDanhSachThuoc.Name = "dataGridViewDanhSachThuoc";
            this.dataGridViewDanhSachThuoc.Size = new System.Drawing.Size(510, 173);
            this.dataGridViewDanhSachThuoc.TabIndex = 0;
            this.dataGridViewDanhSachThuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachThuoc_CellContentClick);
            this.dataGridViewDanhSachThuoc.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachThuoc_CellContentDoubleClick);
            this.dataGridViewDanhSachThuoc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDanhSachThuoc_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMoTa);
            this.groupBox1.Location = new System.Drawing.Point(141, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 133);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(6, 18);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(302, 108);
            this.txtMoTa.TabIndex = 5;
            this.txtMoTa.Text = "";
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(212, 41);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(249, 20);
            this.txtTenThuoc.TabIndex = 18;
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Location = new System.Drawing.Point(32, 41);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(145, 20);
            this.txtMaThuoc.TabIndex = 17;
            this.txtMaThuoc.TextChanged += new System.EventHandler(this.txtMaThuoc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã thuốc";
            // 
            // QuanLyThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckbThuocBaoHiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTenThuoc);
            this.Controls.Add(this.txtMaThuoc);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyThuoc";
            this.Text = "QuanLyThuoc";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachThuoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbThuocBaoHiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewDanhSachThuoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label label1;
    }
}