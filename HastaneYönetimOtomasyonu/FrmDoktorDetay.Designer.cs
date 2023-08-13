namespace HastaneYönetimOtomasyonu
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            this.grbDoktorBilgi = new System.Windows.Forms.GroupBox();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.grbRandevulist = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbHızliErişim = new System.Windows.Forms.GroupBox();
            this.btnÇıkış = new System.Windows.Forms.Button();
            this.BtnDuyurular = new System.Windows.Forms.Button();
            this.btnBilgiDüzenle = new System.Windows.Forms.Button();
            this.grbDoktorBilgi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbRandevulist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbHızliErişim.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDoktorBilgi
            // 
            this.grbDoktorBilgi.Controls.Add(this.LblAdSoyad);
            this.grbDoktorBilgi.Controls.Add(this.label3);
            this.grbDoktorBilgi.Controls.Add(this.lblTc);
            this.grbDoktorBilgi.Controls.Add(this.label2);
            this.grbDoktorBilgi.Location = new System.Drawing.Point(22, 22);
            this.grbDoktorBilgi.Name = "grbDoktorBilgi";
            this.grbDoktorBilgi.Size = new System.Drawing.Size(407, 165);
            this.grbDoktorBilgi.TabIndex = 0;
            this.grbDoktorBilgi.TabStop = false;
            this.grbDoktorBilgi.Text = "Doktor Bilgi";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(173, 103);
            this.LblAdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(98, 28);
            this.LblAdSoyad.TabIndex = 17;
            this.LblAdSoyad.Text = "Null Null ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ad Soyad:";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(173, 55);
            this.lblTc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(144, 28);
            this.lblTc.TabIndex = 15;
            this.lblTc.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "TC Kimlik No: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(24, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 241);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Detay";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(412, 206);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // grbRandevulist
            // 
            this.grbRandevulist.Controls.Add(this.dataGridView1);
            this.grbRandevulist.Location = new System.Drawing.Point(448, 40);
            this.grbRandevulist.Name = "grbRandevulist";
            this.grbRandevulist.Size = new System.Drawing.Size(720, 579);
            this.grbRandevulist.TabIndex = 2;
            this.grbRandevulist.TabStop = false;
            this.grbRandevulist.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(714, 544);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // grbHızliErişim
            // 
            this.grbHızliErişim.Controls.Add(this.btnÇıkış);
            this.grbHızliErişim.Controls.Add(this.BtnDuyurular);
            this.grbHızliErişim.Controls.Add(this.btnBilgiDüzenle);
            this.grbHızliErişim.Location = new System.Drawing.Point(31, 464);
            this.grbHızliErişim.Name = "grbHızliErişim";
            this.grbHızliErişim.Size = new System.Drawing.Size(414, 165);
            this.grbHızliErişim.TabIndex = 3;
            this.grbHızliErişim.TabStop = false;
            this.grbHızliErişim.Text = "Hızlı Erişim";
            // 
            // btnÇıkış
            // 
            this.btnÇıkış.Location = new System.Drawing.Point(28, 102);
            this.btnÇıkış.Name = "btnÇıkış";
            this.btnÇıkış.Size = new System.Drawing.Size(370, 49);
            this.btnÇıkış.TabIndex = 2;
            this.btnÇıkış.Text = "Çıkış";
            this.btnÇıkış.UseVisualStyleBackColor = true;
            this.btnÇıkış.Click += new System.EventHandler(this.btnÇıkış_Click);
            // 
            // BtnDuyurular
            // 
            this.BtnDuyurular.Location = new System.Drawing.Point(219, 51);
            this.BtnDuyurular.Name = "BtnDuyurular";
            this.BtnDuyurular.Size = new System.Drawing.Size(179, 49);
            this.BtnDuyurular.TabIndex = 1;
            this.BtnDuyurular.Text = "Duyurular";
            this.BtnDuyurular.UseVisualStyleBackColor = true;
            this.BtnDuyurular.Click += new System.EventHandler(this.BtnDuyurular_Click);
            // 
            // btnBilgiDüzenle
            // 
            this.btnBilgiDüzenle.Location = new System.Drawing.Point(28, 51);
            this.btnBilgiDüzenle.Name = "btnBilgiDüzenle";
            this.btnBilgiDüzenle.Size = new System.Drawing.Size(179, 49);
            this.btnBilgiDüzenle.TabIndex = 0;
            this.btnBilgiDüzenle.Text = "Bilgi Düzenle ";
            this.btnBilgiDüzenle.UseVisualStyleBackColor = true;
            this.btnBilgiDüzenle.Click += new System.EventHandler(this.btnBilgiDüzenle_Click);
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1200, 788);
            this.Controls.Add(this.grbHızliErişim);
            this.Controls.Add(this.grbRandevulist);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbDoktorBilgi);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDoktorDetay";
            this.Text = "FrmDoktorDetay";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.grbDoktorBilgi.ResumeLayout(false);
            this.grbDoktorBilgi.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grbRandevulist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbHızliErişim.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDoktorBilgi;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbRandevulist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox grbHızliErişim;
        private System.Windows.Forms.Button btnÇıkış;
        private System.Windows.Forms.Button BtnDuyurular;
        private System.Windows.Forms.Button btnBilgiDüzenle;
    }
}