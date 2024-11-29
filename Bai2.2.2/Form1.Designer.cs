namespace Bai_2._2
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
            this.lbXinchao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbXinchao
            // 
            this.lbXinchao.AutoSize = true;
            this.lbXinchao.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXinchao.Location = new System.Drawing.Point(154, 183);
            this.lbXinchao.Name = "lbXinchao";
            this.lbXinchao.Size = new System.Drawing.Size(516, 39);
            this.lbXinchao.TabIndex = 0;
            this.lbXinchao.Text = "Xin chao, chuc mot ngay vui ve";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbXinchao);
            this.Name = "Form1";
            this.Text = "BAI 2.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbXinchao;
    }
}

