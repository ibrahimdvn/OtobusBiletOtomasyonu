﻿namespace OtobusBiletOtomasyonu
{
    partial class OdemeSil
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
            this.tbOdemeTarihi = new System.Windows.Forms.TextBox();
            this.lblOdemeID = new System.Windows.Forms.Label();
            this.lblOdemeNo = new System.Windows.Forms.Label();
            this.cbOdemeTipi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbToplamTutar = new System.Windows.Forms.TextBox();
            this.tbYolcuAdiSoyadi = new System.Windows.Forms.TextBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbOdemeTarihi
            // 
            this.tbOdemeTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbOdemeTarihi.Location = new System.Drawing.Point(177, 172);
            this.tbOdemeTarihi.Name = "tbOdemeTarihi";
            this.tbOdemeTarihi.Size = new System.Drawing.Size(201, 28);
            this.tbOdemeTarihi.TabIndex = 33;
            // 
            // lblOdemeID
            // 
            this.lblOdemeID.AutoSize = true;
            this.lblOdemeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeID.Location = new System.Drawing.Point(134, 37);
            this.lblOdemeID.Name = "lblOdemeID";
            this.lblOdemeID.Size = new System.Drawing.Size(32, 24);
            this.lblOdemeID.TabIndex = 32;
            this.lblOdemeID.Text = "52";
            // 
            // lblOdemeNo
            // 
            this.lblOdemeNo.AutoSize = true;
            this.lblOdemeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeNo.Location = new System.Drawing.Point(10, 37);
            this.lblOdemeNo.Name = "lblOdemeNo";
            this.lblOdemeNo.Size = new System.Drawing.Size(118, 24);
            this.lblOdemeNo.TabIndex = 31;
            this.lblOdemeNo.Text = "Ödeme No:";
            // 
            // cbOdemeTipi
            // 
            this.cbOdemeTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOdemeTipi.FormattingEnabled = true;
            this.cbOdemeTipi.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı"});
            this.cbOdemeTipi.Location = new System.Drawing.Point(177, 213);
            this.cbOdemeTipi.Name = "cbOdemeTipi";
            this.cbOdemeTipi.Size = new System.Drawing.Size(201, 30);
            this.cbOdemeTipi.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Yolcu Adı Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Toplam Tutar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ödeme Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ödeme Tipi:";
            // 
            // tbToplamTutar
            // 
            this.tbToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbToplamTutar.Location = new System.Drawing.Point(177, 126);
            this.tbToplamTutar.Name = "tbToplamTutar";
            this.tbToplamTutar.Size = new System.Drawing.Size(201, 28);
            this.tbToplamTutar.TabIndex = 16;
            // 
            // tbYolcuAdiSoyadi
            // 
            this.tbYolcuAdiSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbYolcuAdiSoyadi.Location = new System.Drawing.Point(177, 83);
            this.tbYolcuAdiSoyadi.Name = "tbYolcuAdiSoyadi";
            this.tbYolcuAdiSoyadi.Size = new System.Drawing.Size(201, 28);
            this.tbYolcuAdiSoyadi.TabIndex = 15;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Red;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(629, 283);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(118, 45);
            this.btnIptal.TabIndex = 27;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(490, 283);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(118, 45);
            this.btnSil.TabIndex = 26;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOdemeID);
            this.groupBox1.Controls.Add(this.tbOdemeTarihi);
            this.groupBox1.Controls.Add(this.lblOdemeNo);
            this.groupBox1.Controls.Add(this.tbYolcuAdiSoyadi);
            this.groupBox1.Controls.Add(this.cbOdemeTipi);
            this.groupBox1.Controls.Add(this.tbToplamTutar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 273);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Sil";
            // 
            // OdemeSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(759, 342);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OdemeSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Silme Sayfası";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblOdemeID;
        public System.Windows.Forms.Label lblOdemeNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbToplamTutar;
        public System.Windows.Forms.TextBox tbYolcuAdiSoyadi;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.ComboBox cbOdemeTipi;
        public System.Windows.Forms.TextBox tbOdemeTarihi;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}