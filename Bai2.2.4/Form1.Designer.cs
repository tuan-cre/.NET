namespace BAI_2._4
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
            this.txbHoten = new System.Windows.Forms.TextBox();
            this.lbHoten = new System.Windows.Forms.Label();
            this.btnDisplayHT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbHoten
            // 
            this.txbHoten.Location = new System.Drawing.Point(324, 192);
            this.txbHoten.Name = "txbHoten";
            this.txbHoten.Size = new System.Drawing.Size(159, 22);
            this.txbHoten.TabIndex = 0;
            // 
            // lbHoten
            // 
            this.lbHoten.AutoSize = true;
            this.lbHoten.Location = new System.Drawing.Point(269, 195);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(49, 16);
            this.lbHoten.TabIndex = 1;
            this.lbHoten.Text = "Ho ten:";
            // 
            // btnDisplayHT
            // 
            this.btnDisplayHT.Location = new System.Drawing.Point(359, 220);
            this.btnDisplayHT.Name = "btnDisplayHT";
            this.btnDisplayHT.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayHT.TabIndex = 2;
            this.btnDisplayHT.Text = "Hien Thi";
            this.btnDisplayHT.UseVisualStyleBackColor = true;
            this.btnDisplayHT.Click += new System.EventHandler(this.btnDisplayHT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisplayHT);
            this.Controls.Add(this.lbHoten);
            this.Controls.Add(this.txbHoten);
            this.Name = "Form1";
            this.Text = "BAI 2.4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbHoten;
        private System.Windows.Forms.Label lbHoten;
        private System.Windows.Forms.Button btnDisplayHT;
    }
}

