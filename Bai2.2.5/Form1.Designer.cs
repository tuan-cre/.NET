namespace Bai_2._5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.txbA = new System.Windows.Forms.TextBox();
            this.txbB = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbB);
            this.groupBox1.Controls.Add(this.txbA);
            this.groupBox1.Controls.Add(this.lbB);
            this.groupBox1.Controls.Add(this.lbA);
            this.groupBox1.Location = new System.Drawing.Point(279, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHEP TOAN";
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(21, 32);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(18, 16);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "a:";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(21, 66);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(18, 16);
            this.lbB.TabIndex = 1;
            this.lbB.Text = "b:";
            // 
            // txbA
            // 
            this.txbA.Location = new System.Drawing.Point(60, 29);
            this.txbA.Name = "txbA";
            this.txbA.Size = new System.Drawing.Size(111, 22);
            this.txbA.TabIndex = 2;
            // 
            // txbB
            // 
            this.txbB.Location = new System.Drawing.Point(60, 63);
            this.txbB.Name = "txbB";
            this.txbB.Size = new System.Drawing.Size(111, 22);
            this.txbB.TabIndex = 3;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(339, 249);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(96, 41);
            this.btnCal.TabIndex = 2;
            this.btnCal.Text = "Tong";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbB;
        private System.Windows.Forms.TextBox txbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCal;
    }
}

