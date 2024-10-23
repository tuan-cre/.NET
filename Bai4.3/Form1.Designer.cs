namespace Bai4._3
{
    partial class Form1
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnTaoMang = new System.Windows.Forms.Button();
            this.lblNhap = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(301, 54);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 44);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(15, 54);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(136, 44);
            this.btnSum.TabIndex = 10;
            this.btnSum.Text = "Tong Mang";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnTongMang_Click);
            // 
            // btnTaoMang
            // 
            this.btnTaoMang.Location = new System.Drawing.Point(275, 6);
            this.btnTaoMang.Name = "btnTaoMang";
            this.btnTaoMang.Size = new System.Drawing.Size(138, 42);
            this.btnTaoMang.TabIndex = 9;
            this.btnTaoMang.Text = "Tao Mang Random";
            this.btnTaoMang.UseVisualStyleBackColor = true;
            this.btnTaoMang.Click += new System.EventHandler(this.btnTaoMang_Click);
            // 
            // lblNhap
            // 
            this.lblNhap.AutoSize = true;
            this.lblNhap.Location = new System.Drawing.Point(12, 14);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(153, 16);
            this.lblNhap.TabIndex = 7;
            this.lblNhap.Text = "Nhap So Phan Tu Mang:";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(183, 14);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(73, 22);
            this.txtNhap.TabIndex = 6;
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(157, 54);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(138, 44);
            this.btnMax.TabIndex = 12;
            this.btnMax.Text = "So Lon Nhat";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 106);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnTaoMang);
            this.Controls.Add(this.lblNhap);
            this.Controls.Add(this.txtNhap);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnTaoMang;
        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnMax;
    }
}

