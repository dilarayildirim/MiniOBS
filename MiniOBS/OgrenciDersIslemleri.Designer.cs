namespace MiniOBS
{
    partial class OgrenciDersIslemleri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDers = new System.Windows.Forms.ComboBox();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOgrenciAdsoyad = new System.Windows.Forms.Label();
            this.lblOgrenciNo = new System.Windows.Forms.Label();
            this.DersAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DersAd});
            this.dataGridView1.Location = new System.Drawing.Point(22, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 317);
            this.dataGridView1.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Bul";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Öğrenci No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ders:";
            // 
            // cbDers
            // 
            this.cbDers.DisplayMember = "DersAd";
            this.cbDers.FormattingEnabled = true;
            this.cbDers.Location = new System.Drawing.Point(89, 76);
            this.cbDers.Name = "cbDers";
            this.cbDers.Size = new System.Drawing.Size(134, 21);
            this.cbDers.TabIndex = 16;
            this.cbDers.ValueMember = "DersID";
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Location = new System.Drawing.Point(243, 76);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(96, 23);
            this.btnDersEkle.TabIndex = 17;
            this.btnDersEkle.Text = "Seçili Dersi Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Öğrenci:";
            // 
            // lblOgrenciAdsoyad
            // 
            this.lblOgrenciAdsoyad.AutoSize = true;
            this.lblOgrenciAdsoyad.ForeColor = System.Drawing.Color.Red;
            this.lblOgrenciAdsoyad.Location = new System.Drawing.Point(89, 44);
            this.lblOgrenciAdsoyad.Name = "lblOgrenciAdsoyad";
            this.lblOgrenciAdsoyad.Size = new System.Drawing.Size(0, 13);
            this.lblOgrenciAdsoyad.TabIndex = 19;
            // 
            // lblOgrenciNo
            // 
            this.lblOgrenciNo.AutoSize = true;
            this.lblOgrenciNo.ForeColor = System.Drawing.Color.Red;
            this.lblOgrenciNo.Location = new System.Drawing.Point(222, 44);
            this.lblOgrenciNo.Name = "lblOgrenciNo";
            this.lblOgrenciNo.Size = new System.Drawing.Size(0, 13);
            this.lblOgrenciNo.TabIndex = 20;
            // 
            // DersAd
            // 
            this.DersAd.DataPropertyName = "DersAd";
            this.DersAd.HeaderText = "Öğrencinin Kayıtlı Olduğu Dersler";
            this.DersAd.Name = "DersAd";
            // 
            // OgrenciDersIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 442);
            this.Controls.Add(this.lblOgrenciNo);
            this.Controls.Add(this.lblOgrenciAdsoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDersEkle);
            this.Controls.Add(this.cbDers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "OgrenciDersIslemleri";
            this.Text = "OgrenciDersIslemleri";
            this.Load += new System.EventHandler(this.OgrenciDersIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDers;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOgrenciAdsoyad;
        private System.Windows.Forms.Label lblOgrenciNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersAd;
    }
}