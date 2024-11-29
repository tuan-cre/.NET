namespace Bai9
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mởFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmTraSốHoànHảoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoMảngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnCheckPerfectNumber = new System.Windows.Forms.Button();
            this.btnCreateArray = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mởFormToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mởFormToolStripMenuItem
            // 
            this.mởFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kiểmTraSốHoànHảoToolStripMenuItem,
            this.tạoMảngToolStripMenuItem});
            this.mởFormToolStripMenuItem.Name = "mởFormToolStripMenuItem";
            this.mởFormToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.mởFormToolStripMenuItem.Text = "Mở Form";
            // 
            // kiểmTraSốHoànHảoToolStripMenuItem
            // 
            this.kiểmTraSốHoànHảoToolStripMenuItem.Name = "kiểmTraSốHoànHảoToolStripMenuItem";
            this.kiểmTraSốHoànHảoToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.kiểmTraSốHoànHảoToolStripMenuItem.Text = "Kiểm Tra Số Hoàn Hảo";
            this.kiểmTraSốHoànHảoToolStripMenuItem.Click += new System.EventHandler(this.kiểmTraSốHoànHảoToolStripMenuItem_Click);
            // 
            // tạoMảngToolStripMenuItem
            // 
            this.tạoMảngToolStripMenuItem.Name = "tạoMảngToolStripMenuItem";
            this.tạoMảngToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.tạoMảngToolStripMenuItem.Text = "Tạo Mảng";
            this.tạoMảngToolStripMenuItem.Click += new System.EventHandler(this.tạoMảngToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập Số N";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(278, 73);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(131, 22);
            this.txtN.TabIndex = 2;
            // 
            // btnCheckPerfectNumber
            // 
            this.btnCheckPerfectNumber.Location = new System.Drawing.Point(30, 155);
            this.btnCheckPerfectNumber.Name = "btnCheckPerfectNumber";
            this.btnCheckPerfectNumber.Size = new System.Drawing.Size(209, 44);
            this.btnCheckPerfectNumber.TabIndex = 3;
            this.btnCheckPerfectNumber.Text = "Kiểm Tra Số Hoàn Hảo";
            this.btnCheckPerfectNumber.UseVisualStyleBackColor = true;
            this.btnCheckPerfectNumber.Click += new System.EventHandler(this.btnCheckPerfectNumber_Click);
            // 
            // btnCreateArray
            // 
            this.btnCreateArray.Location = new System.Drawing.Point(291, 155);
            this.btnCreateArray.Name = "btnCreateArray";
            this.btnCreateArray.Size = new System.Drawing.Size(209, 44);
            this.btnCreateArray.TabIndex = 4;
            this.btnCreateArray.Text = "Tạo Mảng";
            this.btnCreateArray.UseVisualStyleBackColor = true;
            this.btnCreateArray.Click += new System.EventHandler(this.btnCreateArray_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(52, 267);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(166, 44);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Làm Lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(311, 267);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 44);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 358);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCreateArray);
            this.Controls.Add(this.btnCheckPerfectNumber);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "From Chính";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mởFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểmTraSốHoànHảoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoMảngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnCheckPerfectNumber;
        private System.Windows.Forms.Button btnCreateArray;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

