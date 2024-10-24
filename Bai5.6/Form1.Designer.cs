namespace Bai5._6
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
            this.gbMang = new System.Windows.Forms.GroupBox();
            this.txtMangGoc = new System.Windows.Forms.TextBox();
            this.gbKetQua = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.rdMangRandom = new System.Windows.Forms.RadioButton();
            this.rdTongLe = new System.Windows.Forms.RadioButton();
            this.rdTongChan = new System.Windows.Forms.RadioButton();
            this.rdTimMin = new System.Windows.Forms.RadioButton();
            this.rdDemChan = new System.Windows.Forms.RadioButton();
            this.rdLietKeChan = new System.Windows.Forms.RadioButton();
            this.rdDemLe = new System.Windows.Forms.RadioButton();
            this.rdChanCuoiCung = new System.Windows.Forms.RadioButton();
            this.gbMang.SuspendLayout();
            this.gbKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMang
            // 
            this.gbMang.Controls.Add(this.txtMangGoc);
            this.gbMang.Location = new System.Drawing.Point(12, 12);
            this.gbMang.Name = "gbMang";
            this.gbMang.Size = new System.Drawing.Size(420, 59);
            this.gbMang.TabIndex = 10;
            this.gbMang.TabStop = false;
            this.gbMang.Text = "Mang Goc";
            // 
            // txtMangGoc
            // 
            this.txtMangGoc.Location = new System.Drawing.Point(7, 22);
            this.txtMangGoc.Name = "txtMangGoc";
            this.txtMangGoc.Size = new System.Drawing.Size(407, 22);
            this.txtMangGoc.TabIndex = 0;
            // 
            // gbKetQua
            // 
            this.gbKetQua.Controls.Add(this.txtKetQua);
            this.gbKetQua.Location = new System.Drawing.Point(12, 87);
            this.gbKetQua.Name = "gbKetQua";
            this.gbKetQua.Size = new System.Drawing.Size(420, 59);
            this.gbKetQua.TabIndex = 11;
            this.gbKetQua.TabStop = false;
            this.gbKetQua.Text = "Ket Qua";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(7, 22);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(407, 22);
            this.txtKetQua.TabIndex = 0;
            // 
            // rdMangRandom
            // 
            this.rdMangRandom.AutoSize = true;
            this.rdMangRandom.Location = new System.Drawing.Point(69, 164);
            this.rdMangRandom.Name = "rdMangRandom";
            this.rdMangRandom.Size = new System.Drawing.Size(145, 20);
            this.rdMangRandom.TabIndex = 12;
            this.rdMangRandom.TabStop = true;
            this.rdMangRandom.Text = "Tao Mang Random";
            this.rdMangRandom.UseVisualStyleBackColor = true;
            this.rdMangRandom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdMangRandom_MouseClick);
            // 
            // rdTongLe
            // 
            this.rdTongLe.AutoSize = true;
            this.rdTongLe.Location = new System.Drawing.Point(249, 164);
            this.rdTongLe.Name = "rdTongLe";
            this.rdTongLe.Size = new System.Drawing.Size(121, 20);
            this.rdTongLe.TabIndex = 13;
            this.rdTongLe.TabStop = true;
            this.rdTongLe.Text = "Tong cac so Le";
            this.rdTongLe.UseVisualStyleBackColor = true;
            this.rdTongLe.CheckedChanged += new System.EventHandler(this.rdTongLe_CheckedChanged);
            // 
            // rdTongChan
            // 
            this.rdTongChan.AutoSize = true;
            this.rdTongChan.Location = new System.Drawing.Point(249, 211);
            this.rdTongChan.Name = "rdTongChan";
            this.rdTongChan.Size = new System.Drawing.Size(137, 20);
            this.rdTongChan.TabIndex = 15;
            this.rdTongChan.TabStop = true;
            this.rdTongChan.Text = "Tong cac so Chan";
            this.rdTongChan.UseVisualStyleBackColor = true;
            this.rdTongChan.CheckedChanged += new System.EventHandler(this.rdTongChan_CheckedChanged);
            // 
            // rdTimMin
            // 
            this.rdTimMin.AutoSize = true;
            this.rdTimMin.Location = new System.Drawing.Point(69, 211);
            this.rdTimMin.Name = "rdTimMin";
            this.rdTimMin.Size = new System.Drawing.Size(75, 20);
            this.rdTimMin.TabIndex = 14;
            this.rdTimMin.TabStop = true;
            this.rdTimMin.Text = "Tim Min";
            this.rdTimMin.UseVisualStyleBackColor = true;
            this.rdTimMin.CheckedChanged += new System.EventHandler(this.rdTimMin_CheckedChanged);
            // 
            // rdDemChan
            // 
            this.rdDemChan.AutoSize = true;
            this.rdDemChan.Location = new System.Drawing.Point(249, 256);
            this.rdDemChan.Name = "rdDemChan";
            this.rdDemChan.Size = new System.Drawing.Size(109, 20);
            this.rdDemChan.TabIndex = 17;
            this.rdDemChan.TabStop = true;
            this.rdDemChan.Text = "Dem so Chan";
            this.rdDemChan.UseVisualStyleBackColor = true;
            this.rdDemChan.CheckedChanged += new System.EventHandler(this.rdDemChan_CheckedChanged);
            // 
            // rdLietKeChan
            // 
            this.rdLietKeChan.AutoSize = true;
            this.rdLietKeChan.Location = new System.Drawing.Point(69, 256);
            this.rdLietKeChan.Name = "rdLietKeChan";
            this.rdLietKeChan.Size = new System.Drawing.Size(122, 20);
            this.rdLietKeChan.TabIndex = 16;
            this.rdLietKeChan.TabStop = true;
            this.rdLietKeChan.Text = "Liet Ke So Chan";
            this.rdLietKeChan.UseVisualStyleBackColor = true;
            this.rdLietKeChan.CheckedChanged += new System.EventHandler(this.rdLietKeChan_CheckedChanged);
            // 
            // rdDemLe
            // 
            this.rdDemLe.AutoSize = true;
            this.rdDemLe.Location = new System.Drawing.Point(249, 302);
            this.rdDemLe.Name = "rdDemLe";
            this.rdDemLe.Size = new System.Drawing.Size(93, 20);
            this.rdDemLe.TabIndex = 19;
            this.rdDemLe.TabStop = true;
            this.rdDemLe.Text = "Dem so Le";
            this.rdDemLe.UseVisualStyleBackColor = true;
            this.rdDemLe.CheckedChanged += new System.EventHandler(this.rdDemLe_CheckedChanged);
            // 
            // rdChanCuoiCung
            // 
            this.rdChanCuoiCung.AutoSize = true;
            this.rdChanCuoiCung.Location = new System.Drawing.Point(69, 302);
            this.rdChanCuoiCung.Name = "rdChanCuoiCung";
            this.rdChanCuoiCung.Size = new System.Drawing.Size(143, 20);
            this.rdChanCuoiCung.TabIndex = 18;
            this.rdChanCuoiCung.TabStop = true;
            this.rdChanCuoiCung.Text = "So Chan Cuoi Cung";
            this.rdChanCuoiCung.UseVisualStyleBackColor = true;
            this.rdChanCuoiCung.CheckedChanged += new System.EventHandler(this.rdChanCuoiCung_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 360);
            this.Controls.Add(this.rdDemLe);
            this.Controls.Add(this.rdChanCuoiCung);
            this.Controls.Add(this.rdDemChan);
            this.Controls.Add(this.rdLietKeChan);
            this.Controls.Add(this.rdTongChan);
            this.Controls.Add(this.rdTimMin);
            this.Controls.Add(this.rdTongLe);
            this.Controls.Add(this.rdMangRandom);
            this.Controls.Add(this.gbMang);
            this.Controls.Add(this.gbKetQua);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mang";
            this.gbMang.ResumeLayout(false);
            this.gbMang.PerformLayout();
            this.gbKetQua.ResumeLayout(false);
            this.gbKetQua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMang;
        private System.Windows.Forms.TextBox txtMangGoc;
        private System.Windows.Forms.GroupBox gbKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.RadioButton rdMangRandom;
        private System.Windows.Forms.RadioButton rdTongLe;
        private System.Windows.Forms.RadioButton rdTongChan;
        private System.Windows.Forms.RadioButton rdTimMin;
        private System.Windows.Forms.RadioButton rdDemChan;
        private System.Windows.Forms.RadioButton rdLietKeChan;
        private System.Windows.Forms.RadioButton rdDemLe;
        private System.Windows.Forms.RadioButton rdChanCuoiCung;
    }
}

