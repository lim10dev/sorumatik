namespace sorumatik
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cevapDogru = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gitSag = new System.Windows.Forms.Button();
            this.soru = new System.Windows.Forms.RichTextBox();
            this.soruAcikLabel = new System.Windows.Forms.Label();
            this.gitSol = new System.Windows.Forms.Button();
            this.labelCevapD = new System.Windows.Forms.Label();
            this.labelCevapC = new System.Windows.Forms.Label();
            this.labelCevapB = new System.Windows.Forms.Label();
            this.labelCevapA = new System.Windows.Forms.Label();
            this.cevapD = new System.Windows.Forms.TextBox();
            this.cevapC = new System.Windows.Forms.TextBox();
            this.cevapB = new System.Windows.Forms.TextBox();
            this.cevapA = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.isim_label = new System.Windows.Forms.Label();
            this.isim = new System.Windows.Forms.TextBox();
            this.kaydet = new System.Windows.Forms.Button();
            this.soruKaydedilecekYer = new System.Windows.Forms.SaveFileDialog();
            this.baslangic = new System.Windows.Forms.GroupBox();
            this.varolanDosya = new System.Windows.Forms.Button();
            this.yeniDosya = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.soruSec = new System.Windows.Forms.OpenFileDialog();
            this.geriDon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.baslangic.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cevapDogru);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.gitSag);
            this.groupBox1.Controls.Add(this.soru);
            this.groupBox1.Controls.Add(this.soruAcikLabel);
            this.groupBox1.Controls.Add(this.gitSol);
            this.groupBox1.Controls.Add(this.labelCevapD);
            this.groupBox1.Controls.Add(this.labelCevapC);
            this.groupBox1.Controls.Add(this.labelCevapB);
            this.groupBox1.Controls.Add(this.labelCevapA);
            this.groupBox1.Controls.Add(this.cevapD);
            this.groupBox1.Controls.Add(this.cevapC);
            this.groupBox1.Controls.Add(this.cevapB);
            this.groupBox1.Controls.Add(this.cevapA);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Soru";
            // 
            // cevapDogru
            // 
            this.cevapDogru.Location = new System.Drawing.Point(411, 32);
            this.cevapDogru.Name = "cevapDogru";
            this.cevapDogru.Size = new System.Drawing.Size(26, 20);
            this.cevapDogru.TabIndex = 9;
            this.cevapDogru.Text = "A";
            this.cevapDogru.TextChanged += new System.EventHandler(this.cevapDogru1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Doğru Cevap";
            // 
            // gitSag
            // 
            this.gitSag.Location = new System.Drawing.Point(191, 250);
            this.gitSag.Name = "gitSag";
            this.gitSag.Size = new System.Drawing.Size(33, 24);
            this.gitSag.TabIndex = 7;
            this.gitSag.Text = "->";
            this.gitSag.UseVisualStyleBackColor = true;
            this.gitSag.Click += new System.EventHandler(this.gitSag_Click);
            // 
            // soru
            // 
            this.soru.Location = new System.Drawing.Point(12, 19);
            this.soru.Name = "soru";
            this.soru.Size = new System.Drawing.Size(393, 110);
            this.soru.TabIndex = 1;
            this.soru.Text = "Soru 1";
            // 
            // soruAcikLabel
            // 
            this.soruAcikLabel.AutoSize = true;
            this.soruAcikLabel.Location = new System.Drawing.Point(147, 256);
            this.soruAcikLabel.Name = "soruAcikLabel";
            this.soruAcikLabel.Size = new System.Drawing.Size(38, 13);
            this.soruAcikLabel.TabIndex = 3;
            this.soruAcikLabel.Text = "Soru 1";
            // 
            // gitSol
            // 
            this.gitSol.Enabled = false;
            this.gitSol.Location = new System.Drawing.Point(108, 250);
            this.gitSol.Name = "gitSol";
            this.gitSol.Size = new System.Drawing.Size(33, 24);
            this.gitSol.TabIndex = 6;
            this.gitSol.Text = "<-";
            this.gitSol.UseVisualStyleBackColor = true;
            this.gitSol.Click += new System.EventHandler(this.gitSol_Click);
            // 
            // labelCevapD
            // 
            this.labelCevapD.AutoSize = true;
            this.labelCevapD.Location = new System.Drawing.Point(15, 224);
            this.labelCevapD.Name = "labelCevapD";
            this.labelCevapD.Size = new System.Drawing.Size(18, 13);
            this.labelCevapD.TabIndex = 8;
            this.labelCevapD.Text = "D)";
            // 
            // labelCevapC
            // 
            this.labelCevapC.AutoSize = true;
            this.labelCevapC.Location = new System.Drawing.Point(15, 198);
            this.labelCevapC.Name = "labelCevapC";
            this.labelCevapC.Size = new System.Drawing.Size(17, 13);
            this.labelCevapC.TabIndex = 7;
            this.labelCevapC.Text = "C)";
            // 
            // labelCevapB
            // 
            this.labelCevapB.AutoSize = true;
            this.labelCevapB.Location = new System.Drawing.Point(15, 172);
            this.labelCevapB.Name = "labelCevapB";
            this.labelCevapB.Size = new System.Drawing.Size(17, 13);
            this.labelCevapB.TabIndex = 6;
            this.labelCevapB.Text = "B)";
            // 
            // labelCevapA
            // 
            this.labelCevapA.AutoSize = true;
            this.labelCevapA.Location = new System.Drawing.Point(15, 142);
            this.labelCevapA.Name = "labelCevapA";
            this.labelCevapA.Size = new System.Drawing.Size(17, 13);
            this.labelCevapA.TabIndex = 5;
            this.labelCevapA.Text = "A)";
            // 
            // cevapD
            // 
            this.cevapD.Location = new System.Drawing.Point(39, 221);
            this.cevapD.Name = "cevapD";
            this.cevapD.Size = new System.Drawing.Size(365, 20);
            this.cevapD.TabIndex = 5;
            this.cevapD.Text = "D";
            // 
            // cevapC
            // 
            this.cevapC.Location = new System.Drawing.Point(38, 191);
            this.cevapC.Name = "cevapC";
            this.cevapC.Size = new System.Drawing.Size(366, 20);
            this.cevapC.TabIndex = 4;
            this.cevapC.Text = "C";
            // 
            // cevapB
            // 
            this.cevapB.Location = new System.Drawing.Point(38, 165);
            this.cevapB.Name = "cevapB";
            this.cevapB.Size = new System.Drawing.Size(367, 20);
            this.cevapB.TabIndex = 3;
            this.cevapB.Text = "B";
            // 
            // cevapA
            // 
            this.cevapA.Location = new System.Drawing.Point(38, 135);
            this.cevapA.Name = "cevapA";
            this.cevapA.Size = new System.Drawing.Size(367, 20);
            this.cevapA.TabIndex = 2;
            this.cevapA.Text = "A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.isim_label);
            this.groupBox2.Controls.Add(this.isim);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 63);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilgiler";
            // 
            // isim_label
            // 
            this.isim_label.AutoSize = true;
            this.isim_label.Location = new System.Drawing.Point(6, 33);
            this.isim_label.Name = "isim_label";
            this.isim_label.Size = new System.Drawing.Size(52, 13);
            this.isim_label.TabIndex = 2;
            this.isim_label.Text = "Test İsmi:";
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(71, 30);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(258, 20);
            this.isim.TabIndex = 0;
            this.isim.Text = "İsim";
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(353, 13);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(63, 63);
            this.kaydet.TabIndex = 2;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // baslangic
            // 
            this.baslangic.Controls.Add(this.varolanDosya);
            this.baslangic.Controls.Add(this.yeniDosya);
            this.baslangic.Controls.Add(this.label2);
            this.baslangic.Controls.Add(this.label1);
            this.baslangic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.baslangic.Location = new System.Drawing.Point(12, 12);
            this.baslangic.Name = "baslangic";
            this.baslangic.Size = new System.Drawing.Size(480, 360);
            this.baslangic.TabIndex = 3;
            this.baslangic.TabStop = false;
            this.baslangic.Text = "Başlangıç";
            // 
            // varolanDosya
            // 
            this.varolanDosya.Location = new System.Drawing.Point(317, 211);
            this.varolanDosya.Name = "varolanDosya";
            this.varolanDosya.Size = new System.Drawing.Size(82, 79);
            this.varolanDosya.TabIndex = 3;
            this.varolanDosya.Text = "Varolan Bir Dosya";
            this.varolanDosya.UseVisualStyleBackColor = true;
            this.varolanDosya.Click += new System.EventHandler(this.varolanDosya_Click);
            // 
            // yeniDosya
            // 
            this.yeniDosya.Location = new System.Drawing.Point(92, 211);
            this.yeniDosya.Name = "yeniDosya";
            this.yeniDosya.Size = new System.Drawing.Size(82, 79);
            this.yeniDosya.TabIndex = 2;
            this.yeniDosya.Text = "Yeni Dosya";
            this.yeniDosya.UseVisualStyleBackColor = true;
            this.yeniDosya.Click += new System.EventHandler(this.yeniDosya_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sorumatik Yazar\'a hoşgeldiniz.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlamak için bir dosya seçebilir, veya yeni bir \r\nsoru dosyası oluşturabilirsini" +
    "z.";
            // 
            // soruSec
            // 
            this.soruSec.DefaultExt = "soru";
            this.soruSec.FileName = "soru.soru";
            this.soruSec.Filter = "Soru Dosyaları (*.soru)|*.soru";
            this.soruSec.Title = "Bir soru Dosyası seçin";
            // 
            // geriDon
            // 
            this.geriDon.Location = new System.Drawing.Point(423, 13);
            this.geriDon.Name = "geriDon";
            this.geriDon.Size = new System.Drawing.Size(63, 63);
            this.geriDon.TabIndex = 4;
            this.geriDon.Text = "Ana Menüye Dön";
            this.geriDon.UseVisualStyleBackColor = true;
            this.geriDon.Click += new System.EventHandler(this.geriDon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 385);
            this.Controls.Add(this.baslangic);
            this.Controls.Add(this.geriDon);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(525, 424);
            this.MinimumSize = new System.Drawing.Size(525, 424);
            this.Name = "Form1";
            this.Text = "Sorumatik Yazar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.baslangic.ResumeLayout(false);
            this.baslangic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label isim_label;
        private System.Windows.Forms.TextBox cevapA;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.TextBox cevapD;
        private System.Windows.Forms.TextBox cevapC;
        private System.Windows.Forms.TextBox cevapB;
        private System.Windows.Forms.Label labelCevapD;
        private System.Windows.Forms.Label labelCevapC;
        private System.Windows.Forms.Label labelCevapB;
        private System.Windows.Forms.Label labelCevapA;
        private System.Windows.Forms.RichTextBox soru;
        private System.Windows.Forms.Button gitSag;
        private System.Windows.Forms.Label soruAcikLabel;
        private System.Windows.Forms.Button gitSol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog soruKaydedilecekYer;
        private System.Windows.Forms.TextBox cevapDogru;
        private System.Windows.Forms.GroupBox baslangic;
        private System.Windows.Forms.Button varolanDosya;
        private System.Windows.Forms.Button yeniDosya;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog soruSec;
        private System.Windows.Forms.Button geriDon;
    }
}

