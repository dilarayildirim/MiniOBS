namespace MiniOBS
{
    partial class OgrenciNotIslemleri
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
            this.lblOgrenciNo = new System.Windows.Forms.Label();
            this.lblOgrenciAdsoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNotuKaydet = new System.Windows.Forms.Button();
            this.cbDers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DersAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SinavTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SinavNotu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSinavTuru = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSinavNotu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOgrenciNo
            // 
            this.lblOgrenciNo.AutoSize = true;
            this.lblOgrenciNo.ForeColor = System.Drawing.Color.Red;
            this.lblOgrenciNo.Location = new System.Drawing.Point(222, 38);
            this.lblOgrenciNo.Name = "lblOgrenciNo";
            this.lblOgrenciNo.Size = new System.Drawing.Size(0, 13);
            this.lblOgrenciNo.TabIndex = 30;
            // 
            // lblOgrenciAdsoyad
            // 
            this.lblOgrenciAdsoyad.AutoSize = true;
            this.lblOgrenciAdsoyad.ForeColor = System.Drawing.Color.Red;
            this.lblOgrenciAdsoyad.Location = new System.Drawing.Point(92, 37);
            this.lblOgrenciAdsoyad.Name = "lblOgrenciAdsoyad";
            this.lblOgrenciAdsoyad.Size = new System.Drawing.Size(0, 13);
            this.lblOgrenciAdsoyad.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Öğrenci:";
            // 
            // btnNotuKaydet
            // 
            this.btnNotuKaydet.Location = new System.Drawing.Point(222, 125);
            this.btnNotuKaydet.Name = "btnNotuKaydet";
            this.btnNotuKaydet.Size = new System.Drawing.Size(96, 23);
            this.btnNotuKaydet.TabIndex = 27;
            this.btnNotuKaydet.Text = "Notu Kaydet";
            this.btnNotuKaydet.UseVisualStyleBackColor = true;
            this.btnNotuKaydet.Click += new System.EventHandler(this.btnNotuKaydet_Click);
            // 
            // cbDers
            // 
            this.cbDers.DisplayMember = "DersAd";
            this.cbDers.FormattingEnabled = true;
            this.cbDers.Location = new System.Drawing.Point(92, 60);
            this.cbDers.Name = "cbDers";
            this.cbDers.Size = new System.Drawing.Size(134, 21);
            this.cbDers.TabIndex = 26;
            this.cbDers.ValueMember = "DersID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ders:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DersAd,
            this.SinavTuru,
            this.SinavNotu});
            this.dataGridView1.Location = new System.Drawing.Point(12, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 278);
            this.dataGridView1.TabIndex = 24;
            // 
            // DersAd
            // 
            this.DersAd.DataPropertyName = "DersAd";
            this.DersAd.HeaderText = "Ders Adı";
            this.DersAd.Name = "DersAd";
            // 
            // SinavTuru
            // 
            this.SinavTuru.DataPropertyName = "SinavTuru";
            this.SinavTuru.HeaderText = "Sınav Türü";
            this.SinavTuru.Name = "SinavTuru";
            // 
            // SinavNotu
            // 
            this.SinavNotu.DataPropertyName = "SinavNotu";
            this.SinavNotu.HeaderText = "Sınav Notu";
            this.SinavNotu.Name = "SinavNotu";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Bul";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Öğrenci No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Sınav Türü:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSinavTuru
            // 
            this.txtSinavTuru.Location = new System.Drawing.Point(92, 92);
            this.txtSinavTuru.Name = "txtSinavTuru";
            this.txtSinavTuru.Size = new System.Drawing.Size(100, 20);
            this.txtSinavTuru.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Sınav Notu:";
            // 
            // txtSinavNotu
            // 
            this.txtSinavNotu.Location = new System.Drawing.Point(92, 126);
            this.txtSinavNotu.Name = "txtSinavNotu";
            this.txtSinavNotu.Size = new System.Drawing.Size(100, 20);
            this.txtSinavNotu.TabIndex = 34;
            // 
            // OgrenciNotIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 514);
            this.Controls.Add(this.txtSinavNotu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSinavTuru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOgrenciNo);
            this.Controls.Add(this.lblOgrenciAdsoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNotuKaydet);
            this.Controls.Add(this.cbDers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "OgrenciNotIslemleri";
            this.Text = "OgrenciNotIslemleri";
            this.Load += new System.EventHandler(this.OgrenciNotIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOgrenciNo;
        private System.Windows.Forms.Label lblOgrenciAdsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNotuKaydet;
        private System.Windows.Forms.ComboBox cbDers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSinavTuru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSinavNotu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn SinavTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn SinavNotu;
    }
}