namespace Bai6._2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbHoten = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.rdLopA = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdLopB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbLopA = new System.Windows.Forms.ListBox();
            this.btnA_B = new System.Windows.Forms.Button();
            this.btnB_A = new System.Windows.Forms.Button();
            this.btnA_B_All = new System.Windows.Forms.Button();
            this.btnB_A_All = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbLopB = new System.Windows.Forms.ListBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // txbHoten
            // 
            this.txbHoten.Location = new System.Drawing.Point(102, 27);
            this.txbHoten.Name = "txbHoten";
            this.txbHoten.Size = new System.Drawing.Size(288, 22);
            this.txbHoten.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(396, 24);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 29);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // rdLopA
            // 
            this.rdLopA.AutoSize = true;
            this.rdLopA.Location = new System.Drawing.Point(23, 21);
            this.rdLopA.Name = "rdLopA";
            this.rdLopA.Size = new System.Drawing.Size(63, 20);
            this.rdLopA.TabIndex = 3;
            this.rdLopA.TabStop = true;
            this.rdLopA.Text = "Lớp A";
            this.rdLopA.UseVisualStyleBackColor = true;
            this.rdLopA.CheckedChanged += new System.EventHandler(this.rdLopA_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdLopB);
            this.groupBox1.Controls.Add(this.rdLopA);
            this.groupBox1.Location = new System.Drawing.Point(154, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 55);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn lớp";
            // 
            // rdLopB
            // 
            this.rdLopB.AutoSize = true;
            this.rdLopB.Location = new System.Drawing.Point(126, 21);
            this.rdLopB.Name = "rdLopB";
            this.rdLopB.Size = new System.Drawing.Size(63, 20);
            this.rdLopB.TabIndex = 4;
            this.rdLopB.TabStop = true;
            this.rdLopB.Text = "Lớp B";
            this.rdLopB.UseVisualStyleBackColor = true;
            this.rdLopB.CheckedChanged += new System.EventHandler(this.rdLopB_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbLopA);
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 228);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp A";
            // 
            // lbLopA
            // 
            this.lbLopA.FormattingEnabled = true;
            this.lbLopA.ItemHeight = 16;
            this.lbLopA.Location = new System.Drawing.Point(7, 23);
            this.lbLopA.Name = "lbLopA";
            this.lbLopA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbLopA.Size = new System.Drawing.Size(179, 196);
            this.lbLopA.TabIndex = 0;
            // 
            // btnA_B
            // 
            this.btnA_B.Location = new System.Drawing.Point(210, 187);
            this.btnA_B.Name = "btnA_B";
            this.btnA_B.Size = new System.Drawing.Size(93, 39);
            this.btnA_B.TabIndex = 9;
            this.btnA_B.Text = ">";
            this.btnA_B.UseVisualStyleBackColor = true;
            this.btnA_B.Click += new System.EventHandler(this.btnA_B_Click);
            // 
            // btnB_A
            // 
            this.btnB_A.Location = new System.Drawing.Point(210, 232);
            this.btnB_A.Name = "btnB_A";
            this.btnB_A.Size = new System.Drawing.Size(93, 39);
            this.btnB_A.TabIndex = 10;
            this.btnB_A.Text = "<";
            this.btnB_A.UseVisualStyleBackColor = true;
            this.btnB_A.Click += new System.EventHandler(this.btnB_A_Click);
            // 
            // btnA_B_All
            // 
            this.btnA_B_All.Location = new System.Drawing.Point(210, 277);
            this.btnA_B_All.Name = "btnA_B_All";
            this.btnA_B_All.Size = new System.Drawing.Size(93, 39);
            this.btnA_B_All.TabIndex = 11;
            this.btnA_B_All.Text = ">>";
            this.btnA_B_All.UseVisualStyleBackColor = true;
            this.btnA_B_All.Click += new System.EventHandler(this.btnA_B_All_Click);
            // 
            // btnB_A_All
            // 
            this.btnB_A_All.Location = new System.Drawing.Point(210, 322);
            this.btnB_A_All.Name = "btnB_A_All";
            this.btnB_A_All.Size = new System.Drawing.Size(93, 39);
            this.btnB_A_All.TabIndex = 12;
            this.btnB_A_All.Text = "<<";
            this.btnB_A_All.UseVisualStyleBackColor = true;
            this.btnB_A_All.Click += new System.EventHandler(this.btnB_A_All_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbLopB);
            this.groupBox4.Location = new System.Drawing.Point(309, 155);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(192, 228);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lớp A";
            // 
            // lbLopB
            // 
            this.lbLopB.FormattingEnabled = true;
            this.lbLopB.ItemHeight = 16;
            this.lbLopB.Location = new System.Drawing.Point(7, 23);
            this.lbLopB.Name = "lbLopB";
            this.lbLopB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbLopB.Size = new System.Drawing.Size(179, 196);
            this.lbLopB.TabIndex = 0;
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(102, 401);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(162, 42);
            this.btnTong.TabIndex = 14;
            this.btnTong.Text = "Tổng số sinh viên";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(309, 401);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 42);
            this.button7.TabIndex = 15;
            this.button7.Text = "Thoát";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 470);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnB_A_All);
            this.Controls.Add(this.btnA_B_All);
            this.Controls.Add(this.btnB_A);
            this.Controls.Add(this.btnA_B);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txbHoten);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbHoten;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RadioButton rdLopA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdLopB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbLopA;
        private System.Windows.Forms.Button btnA_B;
        private System.Windows.Forms.Button btnB_A;
        private System.Windows.Forms.Button btnA_B_All;
        private System.Windows.Forms.Button btnB_A_All;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbLopB;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button button7;
    }
}

