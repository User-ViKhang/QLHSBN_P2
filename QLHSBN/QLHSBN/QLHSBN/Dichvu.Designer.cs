
namespace QLHSBN
{
    partial class Dichvu
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
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_active
            // 
            this.btn_active.Location = new System.Drawing.Point(191, 92);
            this.btn_active.Name = "btn_active";
            this.btn_active.Size = new System.Drawing.Size(91, 40);
            this.btn_active.TabIndex = 10;
            this.btn_active.Text = "Kích hoạt";
            this.btn_active.UseVisualStyleBackColor = true;
            this.btn_active.Click += new System.EventHandler(this.btn_active_Click);
            // 
            // btn_ngung
            // 
            this.btn_ngung.Location = new System.Drawing.Point(12, 92);
            this.btn_ngung.Name = "btn_ngung";
            this.btn_ngung.Size = new System.Drawing.Size(99, 40);
            this.btn_ngung.TabIndex = 11;
            this.btn_ngung.Text = "Ngừng hoạt động";
            this.btn_ngung.UseVisualStyleBackColor = true;
            this.btn_ngung.Click += new System.EventHandler(this.btn_ngung_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(399, 92);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(94, 40);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(547, 92);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(92, 40);
            this.btn_them.TabIndex = 13;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 396);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách dịch vụ xét nghiệm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 372);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(191, 51);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(202, 20);
            this.txt_ten.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên dịch vụ";
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(16, 51);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(148, 20);
            this.txt_ma.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giá dịch vụ";
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(437, 51);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(202, 20);
            this.txt_gia.TabIndex = 7;
            this.txt_gia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gia_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 621);
            this.Controls.Add(this.btn_active);
            this.Controls.Add(this.btn_ngung);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_gia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.label1);
            this.Name = "Dichvu";
            this.Text = "Dịch vụ";
            this.Load += new System.EventHandler(this.dichvu_Load);
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
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.Button button1;
    }
}