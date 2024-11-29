namespace Bai_3._2
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
            this.lbMua = new System.Windows.Forms.Label();
            this.lbThang = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.btnTimMua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMua
            // 
            this.lbMua.AutoSize = true;
            this.lbMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMua.Location = new System.Drawing.Point(271, 101);
            this.lbMua.Name = "lbMua";
            this.lbMua.Size = new System.Drawing.Size(266, 32);
            this.lbMua.TabIndex = 0;
            this.lbMua.Text = "MUA TRONG NAM";
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Location = new System.Drawing.Point(274, 167);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(49, 16);
            this.lbThang.TabIndex = 1;
            this.lbThang.Text = "Thang:";
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(329, 164);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(157, 22);
            this.txtThang.TabIndex = 2;
            // 
            // btnTimMua
            // 
            this.btnTimMua.Location = new System.Drawing.Point(352, 215);
            this.btnTimMua.Name = "btnTimMua";
            this.btnTimMua.Size = new System.Drawing.Size(88, 39);
            this.btnTimMua.TabIndex = 3;
            this.btnTimMua.Text = "Thong Bao";
            this.btnTimMua.UseVisualStyleBackColor = true;
            this.btnTimMua.Click += new System.EventHandler(this.btnTimThang_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTimMua);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.lbThang);
            this.Controls.Add(this.lbMua);
            this.Name = "Form1";
            this.Text = "BAI 3.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMua;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Button btnTimMua;
    }
}

