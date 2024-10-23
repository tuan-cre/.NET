namespace Bai4._2
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
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.lblNhap = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnTaoMang = new System.Windows.Forms.Button();
            this.btnInMang = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(183, 21);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(73, 22);
            this.txtNhap.TabIndex = 0;
            // 
            // lblNhap
            // 
            this.lblNhap.AutoSize = true;
            this.lblNhap.Location = new System.Drawing.Point(12, 21);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(153, 16);
            this.lblNhap.TabIndex = 1;
            this.lblNhap.Text = "Nhap So Phan Tu Mang:";
            // 
            // lblKQ
            // 
            this.lblKQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblKQ.Location = new System.Drawing.Point(12, 59);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(409, 44);
            this.lblKQ.TabIndex = 2;
            // 
            // btnTaoMang
            // 
            this.btnTaoMang.Location = new System.Drawing.Point(279, 11);
            this.btnTaoMang.Name = "btnTaoMang";
            this.btnTaoMang.Size = new System.Drawing.Size(142, 42);
            this.btnTaoMang.TabIndex = 3;
            this.btnTaoMang.Text = "Tao Mang Random";
            this.btnTaoMang.UseVisualStyleBackColor = true;
            this.btnTaoMang.Click += new System.EventHandler(this.btnTaoMang_Click);
            // 
            // btnInMang
            // 
            this.btnInMang.Location = new System.Drawing.Point(81, 113);
            this.btnInMang.Name = "btnInMang";
            this.btnInMang.Size = new System.Drawing.Size(84, 44);
            this.btnInMang.TabIndex = 4;
            this.btnInMang.Text = "In Mang";
            this.btnInMang.UseVisualStyleBackColor = true;
            this.btnInMang.Click += new System.EventHandler(this.btnInMang_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(264, 113);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 44);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 169);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnInMang);
            this.Controls.Add(this.btnTaoMang);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.lblNhap);
            this.Controls.Add(this.txtNhap);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAI4.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button btnTaoMang;
        private System.Windows.Forms.Button btnInMang;
        private System.Windows.Forms.Button btnThoat;
    }
}

