
namespace QLHSBN
{
    partial class Dangnhap
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
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_dangnhap);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.txt_mk);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_tk);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.groupBox1.Location = new System.Drawing.Point(33, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 398);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản đăng nhập";
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Location = new System.Drawing.Point(361, 280);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(124, 45);
            this.btn_dangnhap.TabIndex = 9;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(175, 280);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(129, 45);
            this.btn_thoat.TabIndex = 10;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(175, 171);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.PasswordChar = '*';
            this.txt_mk.Size = new System.Drawing.Size(310, 27);
            this.txt_mk.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(172, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu";
            // 
            // txt_tk
            // 
            this.txt_tk.Location = new System.Drawing.Point(174, 79);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(310, 27);
            this.txt_tk.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(171, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tài khoản";
            // 
            // Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 453);
            this.Controls.Add(this.groupBox1);
            this.Name = "Dangnhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Dangnhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Label label1;
    }
}

