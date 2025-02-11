
namespace QLHSBN
{
    partial class ThongKeBenhNhan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_filter = new System.Windows.Forms.Button();
            this.dtp_2 = new System.Windows.Forms.DateTimePicker();
            this.dtp_1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê bệnh nhân";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1048, 468);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bệnh nhân";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1029, 443);
            this.dataGridView1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "In danh sách bảng bên dưới";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(968, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 55);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(375, 18);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(121, 23);
            this.btn_filter.TabIndex = 8;
            this.btn_filter.Text = "Lọc dữ liệu";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // dtp_2
            // 
            this.dtp_2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_2.Location = new System.Drawing.Point(239, 19);
            this.dtp_2.Name = "dtp_2";
            this.dtp_2.Size = new System.Drawing.Size(121, 20);
            this.dtp_2.TabIndex = 6;
            // 
            // dtp_1
            // 
            this.dtp_1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_1.Location = new System.Drawing.Point(98, 19);
            this.dtp_1.Name = "dtp_1";
            this.dtp_1.Size = new System.Drawing.Size(121, 20);
            this.dtp_1.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Ngày nhập viện";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.dtp_1);
            this.groupBox2.Controls.Add(this.btn_filter);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dtp_2);
            this.groupBox2.Location = new System.Drawing.Point(12, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 72);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc dữ liệu";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(375, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Hiện tất cả";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ThongKeBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 606);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ThongKeBenhNhan";
            this.Text = "ThongKeBenhNhan";
            this.Load += new System.EventHandler(this.ThongKeBenhNhan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.DateTimePicker dtp_2;
        private System.Windows.Forms.DateTimePicker dtp_1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
    }
}