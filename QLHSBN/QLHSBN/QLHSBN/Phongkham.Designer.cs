
namespace QLHSBN
{
    partial class Phongkham
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
            this.txt_maphong = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenphong = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_ngung = new System.Windows.Forms.Button();
            this.btn_active = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng khám";
            // 
            // txt_maphong
            // 
            this.txt_maphong.Location = new System.Drawing.Point(18, 56);
            this.txt_maphong.Name = "txt_maphong";
            this.txt_maphong.Size = new System.Drawing.Size(210, 20);
            this.txt_maphong.TabIndex = 1;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 397);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng khám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên phòng khám";
            // 
            // txt_tenphong
            // 
            this.txt_tenphong.Location = new System.Drawing.Point(281, 56);
            this.txt_tenphong.Name = "txt_tenphong";
            this.txt_tenphong.Size = new System.Drawing.Size(215, 20);
            this.txt_tenphong.TabIndex = 1;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(402, 99);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(94, 40);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(281, 99);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(98, 40);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_ngung
            // 
            this.btn_ngung.Location = new System.Drawing.Point(18, 99);
            this.btn_ngung.Name = "btn_ngung";
            this.btn_ngung.Size = new System.Drawing.Size(106, 40);
            this.btn_ngung.TabIndex = 4;
            this.btn_ngung.Text = "Ngừng hoạt động";
            this.btn_ngung.UseVisualStyleBackColor = true;
            this.btn_ngung.Click += new System.EventHandler(this.btn_ngung_Click);
            // 
            // btn_active
            // 
            this.btn_active.Location = new System.Drawing.Point(153, 99);
            this.btn_active.Name = "btn_active";
            this.btn_active.Size = new System.Drawing.Size(75, 40);
            this.btn_active.TabIndex = 4;
            this.btn_active.Text = "Kích hoạt";
            this.btn_active.UseVisualStyleBackColor = true;
            this.btn_active.Click += new System.EventHandler(this.btn_active_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Phongkham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 632);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_active);
            this.Controls.Add(this.btn_ngung);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_tenphong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_maphong);
            this.Controls.Add(this.label1);
            this.Name = "Phongkham";
            this.Text = "Phòng khám bệnh";
            this.Load += new System.EventHandler(this.Phongkham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_maphong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenphong;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_ngung;
        private System.Windows.Forms.Button btn_active;
        private System.Windows.Forms.Button button1;
    }
}