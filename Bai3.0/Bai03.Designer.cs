namespace Bai03
{
    partial class FormBai03
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKetQua2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKetQua1 = new System.Windows.Forms.TextBox();
            this.txtSoNguyen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKetQua2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtKetQua1);
            this.groupBox2.Location = new System.Drawing.Point(15, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 125);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ket qua";
            // 
            // txtKetQua2
            // 
            this.txtKetQua2.Location = new System.Drawing.Point(47, 70);
            this.txtKetQua2.Name = "txtKetQua2";
            this.txtKetQua2.Size = new System.Drawing.Size(120, 22);
            this.txtKetQua2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "S =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "S =";
            // 
            // txtKetQua1
            // 
            this.txtKetQua1.Location = new System.Drawing.Point(47, 32);
            this.txtKetQua1.Name = "txtKetQua1";
            this.txtKetQua1.Size = new System.Drawing.Size(368, 22);
            this.txtKetQua1.TabIndex = 4;
            // 
            // txtSoNguyen
            // 
            this.txtSoNguyen.Location = new System.Drawing.Point(227, 15);
            this.txtSoNguyen.Name = "txtSoNguyen";
            this.txtSoNguyen.Size = new System.Drawing.Size(93, 22);
            this.txtSoNguyen.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhap vao so nguyen duong N";
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(336, 12);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(100, 40);
            this.btnTinhTong.TabIndex = 9;
            this.btnTinhTong.Text = "Tinh Tong S";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // FormBai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 215);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtSoNguyen);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBai03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tinh tong N so nguyen lien tiep";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKetQua1;
        private System.Windows.Forms.TextBox txtSoNguyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.TextBox txtKetQua2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

