namespace Bai5._4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdChuNhat = new System.Windows.Forms.RadioButton();
            this.rdVuong = new System.Windows.Forms.RadioButton();
            this.rdTamGiac = new System.Windows.Forms.RadioButton();
            this.rdTron = new System.Windows.Forms.RadioButton();
            this.gbHinhVuong = new System.Windows.Forms.GroupBox();
            this.txtVuongDT = new System.Windows.Forms.TextBox();
            this.txtVuongCV = new System.Windows.Forms.TextBox();
            this.txtVuongA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.gbHinhTron = new System.Windows.Forms.GroupBox();
            this.txtTronDT = new System.Windows.Forms.TextBox();
            this.txtTronCV = new System.Windows.Forms.TextBox();
            this.txtTronR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbHinhTamGiac = new System.Windows.Forms.GroupBox();
            this.txtTamGiacC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTamGiacB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTamGiacDT = new System.Windows.Forms.TextBox();
            this.txtTamGiacCV = new System.Windows.Forms.TextBox();
            this.txtTamGiacA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gbHinhChuNhat = new System.Windows.Forms.GroupBox();
            this.txtChuNhatDT = new System.Windows.Forms.TextBox();
            this.txtChuNhatCV = new System.Windows.Forms.TextBox();
            this.txtChuNhatA = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtChuNhatB = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbHinhVuong.SuspendLayout();
            this.gbHinhTron.SuspendLayout();
            this.gbHinhTamGiac.SuspendLayout();
            this.gbHinhChuNhat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tim Chu Vi Va Dien Tich";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(158, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hinh Tron - Hinh Vuong";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(125, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hinh Tam Giac - Hinh Chu Nhat";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdChuNhat);
            this.groupBox1.Controls.Add(this.rdVuong);
            this.groupBox1.Controls.Add(this.rdTamGiac);
            this.groupBox1.Controls.Add(this.rdTron);
            this.groupBox1.Location = new System.Drawing.Point(142, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chon";
            // 
            // rdChuNhat
            // 
            this.rdChuNhat.AutoSize = true;
            this.rdChuNhat.Location = new System.Drawing.Point(108, 64);
            this.rdChuNhat.Name = "rdChuNhat";
            this.rdChuNhat.Size = new System.Drawing.Size(112, 20);
            this.rdChuNhat.TabIndex = 3;
            this.rdChuNhat.TabStop = true;
            this.rdChuNhat.Text = "Hinh Chu Nhat";
            this.rdChuNhat.UseVisualStyleBackColor = true;
            this.rdChuNhat.CheckedChanged += new System.EventHandler(this.rdChuNhat_CheckedChanged);
            // 
            // rdVuong
            // 
            this.rdVuong.AutoSize = true;
            this.rdVuong.Location = new System.Drawing.Point(6, 64);
            this.rdVuong.Name = "rdVuong";
            this.rdVuong.Size = new System.Drawing.Size(97, 20);
            this.rdVuong.TabIndex = 2;
            this.rdVuong.TabStop = true;
            this.rdVuong.Text = "Hinh Vuong";
            this.rdVuong.UseVisualStyleBackColor = true;
            this.rdVuong.CheckedChanged += new System.EventHandler(this.rdVuong_CheckedChanged);
            // 
            // rdTamGiac
            // 
            this.rdTamGiac.AutoSize = true;
            this.rdTamGiac.Location = new System.Drawing.Point(108, 22);
            this.rdTamGiac.Name = "rdTamGiac";
            this.rdTamGiac.Size = new System.Drawing.Size(117, 20);
            this.rdTamGiac.TabIndex = 1;
            this.rdTamGiac.TabStop = true;
            this.rdTamGiac.Text = "Hinh Tam Giac";
            this.rdTamGiac.UseVisualStyleBackColor = true;
            this.rdTamGiac.CheckedChanged += new System.EventHandler(this.rdTamGiac_CheckedChanged);
            // 
            // rdTron
            // 
            this.rdTron.AutoSize = true;
            this.rdTron.Location = new System.Drawing.Point(6, 22);
            this.rdTron.Name = "rdTron";
            this.rdTron.Size = new System.Drawing.Size(86, 20);
            this.rdTron.TabIndex = 0;
            this.rdTron.TabStop = true;
            this.rdTron.Text = "Hinh Tron";
            this.rdTron.UseVisualStyleBackColor = true;
            this.rdTron.CheckedChanged += new System.EventHandler(this.rdTron_CheckedChanged);
            // 
            // gbHinhVuong
            // 
            this.gbHinhVuong.Controls.Add(this.txtVuongDT);
            this.gbHinhVuong.Controls.Add(this.txtVuongCV);
            this.gbHinhVuong.Controls.Add(this.txtVuongA);
            this.gbHinhVuong.Controls.Add(this.label6);
            this.gbHinhVuong.Controls.Add(this.label5);
            this.gbHinhVuong.Controls.Add(this.label4);
            this.gbHinhVuong.Location = new System.Drawing.Point(142, 290);
            this.gbHinhVuong.Name = "gbHinhVuong";
            this.gbHinhVuong.Size = new System.Drawing.Size(236, 143);
            this.gbHinhVuong.TabIndex = 4;
            this.gbHinhVuong.TabStop = false;
            this.gbHinhVuong.Text = "Hinh Vuong";
            this.gbHinhVuong.Visible = false;
            // 
            // txtVuongDT
            // 
            this.txtVuongDT.Location = new System.Drawing.Point(108, 111);
            this.txtVuongDT.Name = "txtVuongDT";
            this.txtVuongDT.Size = new System.Drawing.Size(100, 22);
            this.txtVuongDT.TabIndex = 5;
            // 
            // txtVuongCV
            // 
            this.txtVuongCV.Location = new System.Drawing.Point(109, 73);
            this.txtVuongCV.Name = "txtVuongCV";
            this.txtVuongCV.Size = new System.Drawing.Size(100, 22);
            this.txtVuongCV.TabIndex = 4;
            // 
            // txtVuongA
            // 
            this.txtVuongA.Location = new System.Drawing.Point(108, 31);
            this.txtVuongA.Name = "txtVuongA";
            this.txtVuongA.Size = new System.Drawing.Size(100, 22);
            this.txtVuongA.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Dien Tich:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Chu Vi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Canh A:";
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(76, 227);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(98, 42);
            this.btnThucHien.TabIndex = 5;
            this.btnThucHien.Text = "Thuc Hien";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(216, 227);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 42);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(351, 227);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(98, 42);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Thoat";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // gbHinhTron
            // 
            this.gbHinhTron.Controls.Add(this.txtTronDT);
            this.gbHinhTron.Controls.Add(this.txtTronCV);
            this.gbHinhTron.Controls.Add(this.txtTronR);
            this.gbHinhTron.Controls.Add(this.label7);
            this.gbHinhTron.Controls.Add(this.label8);
            this.gbHinhTron.Controls.Add(this.label9);
            this.gbHinhTron.Location = new System.Drawing.Point(148, 280);
            this.gbHinhTron.Name = "gbHinhTron";
            this.gbHinhTron.Size = new System.Drawing.Size(236, 143);
            this.gbHinhTron.TabIndex = 8;
            this.gbHinhTron.TabStop = false;
            this.gbHinhTron.Text = "Hinh Tron";
            this.gbHinhTron.Visible = false;
            // 
            // txtTronDT
            // 
            this.txtTronDT.Location = new System.Drawing.Point(108, 111);
            this.txtTronDT.Name = "txtTronDT";
            this.txtTronDT.Size = new System.Drawing.Size(100, 22);
            this.txtTronDT.TabIndex = 5;
            // 
            // txtTronCV
            // 
            this.txtTronCV.Location = new System.Drawing.Point(109, 73);
            this.txtTronCV.Name = "txtTronCV";
            this.txtTronCV.Size = new System.Drawing.Size(100, 22);
            this.txtTronCV.TabIndex = 4;
            // 
            // txtTronR
            // 
            this.txtTronR.Location = new System.Drawing.Point(108, 31);
            this.txtTronR.Name = "txtTronR";
            this.txtTronR.Size = new System.Drawing.Size(100, 22);
            this.txtTronR.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Dien Tich:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Chu Vi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ban kinh R:";
            // 
            // gbHinhTamGiac
            // 
            this.gbHinhTamGiac.Controls.Add(this.txtTamGiacC);
            this.gbHinhTamGiac.Controls.Add(this.label14);
            this.gbHinhTamGiac.Controls.Add(this.txtTamGiacB);
            this.gbHinhTamGiac.Controls.Add(this.label13);
            this.gbHinhTamGiac.Controls.Add(this.txtTamGiacDT);
            this.gbHinhTamGiac.Controls.Add(this.txtTamGiacCV);
            this.gbHinhTamGiac.Controls.Add(this.txtTamGiacA);
            this.gbHinhTamGiac.Controls.Add(this.label10);
            this.gbHinhTamGiac.Controls.Add(this.label11);
            this.gbHinhTamGiac.Controls.Add(this.label12);
            this.gbHinhTamGiac.Location = new System.Drawing.Point(124, 275);
            this.gbHinhTamGiac.Name = "gbHinhTamGiac";
            this.gbHinhTamGiac.Size = new System.Drawing.Size(260, 164);
            this.gbHinhTamGiac.TabIndex = 9;
            this.gbHinhTamGiac.TabStop = false;
            this.gbHinhTamGiac.Text = "Hinh Tam Giac";
            this.gbHinhTamGiac.Visible = false;
            // 
            // txtTamGiacC
            // 
            this.txtTamGiacC.Location = new System.Drawing.Point(110, 66);
            this.txtTamGiacC.Name = "txtTamGiacC";
            this.txtTamGiacC.Size = new System.Drawing.Size(100, 22);
            this.txtTamGiacC.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(43, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "Canh C:";
            // 
            // txtTamGiacB
            // 
            this.txtTamGiacB.Location = new System.Drawing.Point(110, 43);
            this.txtTamGiacB.Name = "txtTamGiacB";
            this.txtTamGiacB.Size = new System.Drawing.Size(100, 22);
            this.txtTamGiacB.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 16);
            this.label13.TabIndex = 6;
            this.label13.Text = "Canh B:";
            // 
            // txtTamGiacDT
            // 
            this.txtTamGiacDT.Location = new System.Drawing.Point(110, 132);
            this.txtTamGiacDT.Name = "txtTamGiacDT";
            this.txtTamGiacDT.Size = new System.Drawing.Size(100, 22);
            this.txtTamGiacDT.TabIndex = 5;
            // 
            // txtTamGiacCV
            // 
            this.txtTamGiacCV.Location = new System.Drawing.Point(110, 100);
            this.txtTamGiacCV.Name = "txtTamGiacCV";
            this.txtTamGiacCV.Size = new System.Drawing.Size(100, 22);
            this.txtTamGiacCV.TabIndex = 4;
            // 
            // txtTamGiacA
            // 
            this.txtTamGiacA.Location = new System.Drawing.Point(110, 20);
            this.txtTamGiacA.Name = "txtTamGiacA";
            this.txtTamGiacA.Size = new System.Drawing.Size(100, 22);
            this.txtTamGiacA.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Dien Tich:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Chu Vi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Canh A:";
            // 
            // gbHinhChuNhat
            // 
            this.gbHinhChuNhat.Controls.Add(this.txtChuNhatB);
            this.gbHinhChuNhat.Controls.Add(this.label18);
            this.gbHinhChuNhat.Controls.Add(this.txtChuNhatDT);
            this.gbHinhChuNhat.Controls.Add(this.txtChuNhatCV);
            this.gbHinhChuNhat.Controls.Add(this.txtChuNhatA);
            this.gbHinhChuNhat.Controls.Add(this.label15);
            this.gbHinhChuNhat.Controls.Add(this.label16);
            this.gbHinhChuNhat.Controls.Add(this.label17);
            this.gbHinhChuNhat.Location = new System.Drawing.Point(136, 296);
            this.gbHinhChuNhat.Name = "gbHinhChuNhat";
            this.gbHinhChuNhat.Size = new System.Drawing.Size(236, 143);
            this.gbHinhChuNhat.TabIndex = 9;
            this.gbHinhChuNhat.TabStop = false;
            this.gbHinhChuNhat.Text = "Hinh Chu Nhat";
            this.gbHinhChuNhat.Visible = false;
            // 
            // txtChuNhatDT
            // 
            this.txtChuNhatDT.Location = new System.Drawing.Point(108, 111);
            this.txtChuNhatDT.Name = "txtChuNhatDT";
            this.txtChuNhatDT.Size = new System.Drawing.Size(100, 22);
            this.txtChuNhatDT.TabIndex = 5;
            // 
            // txtChuNhatCV
            // 
            this.txtChuNhatCV.Location = new System.Drawing.Point(109, 83);
            this.txtChuNhatCV.Name = "txtChuNhatCV";
            this.txtChuNhatCV.Size = new System.Drawing.Size(100, 22);
            this.txtChuNhatCV.TabIndex = 4;
            // 
            // txtChuNhatA
            // 
            this.txtChuNhatA.Location = new System.Drawing.Point(109, 25);
            this.txtChuNhatA.Name = "txtChuNhatA";
            this.txtChuNhatA.Size = new System.Drawing.Size(100, 22);
            this.txtChuNhatA.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "Dien Tich:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(55, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 16);
            this.label16.TabIndex = 1;
            this.label16.Text = "Chu Vi:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(60, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "Dai A:";
            // 
            // txtChuNhatB
            // 
            this.txtChuNhatB.Location = new System.Drawing.Point(109, 54);
            this.txtChuNhatB.Name = "txtChuNhatB";
            this.txtChuNhatB.Size = new System.Drawing.Size(100, 22);
            this.txtChuNhatB.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(48, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 16);
            this.label18.TabIndex = 6;
            this.label18.Text = "Rong B:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 451);
            this.Controls.Add(this.gbHinhTamGiac);
            this.Controls.Add(this.gbHinhChuNhat);
            this.Controls.Add(this.gbHinhTron);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.gbHinhVuong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CV DT";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbHinhVuong.ResumeLayout(false);
            this.gbHinhVuong.PerformLayout();
            this.gbHinhTron.ResumeLayout(false);
            this.gbHinhTron.PerformLayout();
            this.gbHinhTamGiac.ResumeLayout(false);
            this.gbHinhTamGiac.PerformLayout();
            this.gbHinhChuNhat.ResumeLayout(false);
            this.gbHinhChuNhat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdChuNhat;
        private System.Windows.Forms.RadioButton rdVuong;
        private System.Windows.Forms.RadioButton rdTamGiac;
        private System.Windows.Forms.RadioButton rdTron;
        private System.Windows.Forms.GroupBox gbHinhVuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TextBox txtVuongDT;
        private System.Windows.Forms.TextBox txtVuongCV;
        private System.Windows.Forms.TextBox txtVuongA;
        private System.Windows.Forms.GroupBox gbHinhTron;
        private System.Windows.Forms.TextBox txtTronDT;
        private System.Windows.Forms.TextBox txtTronCV;
        private System.Windows.Forms.TextBox txtTronR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbHinhTamGiac;
        private System.Windows.Forms.TextBox txtTamGiacC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTamGiacB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTamGiacDT;
        private System.Windows.Forms.TextBox txtTamGiacCV;
        private System.Windows.Forms.TextBox txtTamGiacA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbHinhChuNhat;
        private System.Windows.Forms.TextBox txtChuNhatB;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtChuNhatDT;
        private System.Windows.Forms.TextBox txtChuNhatCV;
        private System.Windows.Forms.TextBox txtChuNhatA;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

