namespace sorumatikEmu
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
            this.soruKapsayici = new System.Windows.Forms.GroupBox();
            this.bitir = new System.Windows.Forms.Button();
            this.cevaplarList = new System.Windows.Forms.ListBox();
            this.soruLabel = new System.Windows.Forms.Label();
            this.soruSonra = new System.Windows.Forms.Button();
            this.soruOnce = new System.Windows.Forms.Button();
            this.cevapD = new System.Windows.Forms.RadioButton();
            this.cevapC = new System.Windows.Forms.RadioButton();
            this.cevapB = new System.Windows.Forms.RadioButton();
            this.cevapA = new System.Windows.Forms.RadioButton();
            this.soru = new System.Windows.Forms.RichTextBox();
            this.soruSec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.soruKapsayici.SuspendLayout();
            this.SuspendLayout();
            // 
            // soruKapsayici
            // 
            this.soruKapsayici.Controls.Add(this.bitir);
            this.soruKapsayici.Controls.Add(this.cevaplarList);
            this.soruKapsayici.Controls.Add(this.soruLabel);
            this.soruKapsayici.Controls.Add(this.soruSonra);
            this.soruKapsayici.Controls.Add(this.soruOnce);
            this.soruKapsayici.Controls.Add(this.cevapD);
            this.soruKapsayici.Controls.Add(this.cevapC);
            this.soruKapsayici.Controls.Add(this.cevapB);
            this.soruKapsayici.Controls.Add(this.cevapA);
            this.soruKapsayici.Controls.Add(this.soru);
            this.soruKapsayici.Location = new System.Drawing.Point(12, 12);
            this.soruKapsayici.Name = "soruKapsayici";
            this.soruKapsayici.Size = new System.Drawing.Size(396, 339);
            this.soruKapsayici.TabIndex = 0;
            this.soruKapsayici.TabStop = false;
            this.soruKapsayici.Text = "Soru seçilmedi.";
            this.soruKapsayici.Visible = false;
            // 
            // bitir
            // 
            this.bitir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bitir.Location = new System.Drawing.Point(126, 291);
            this.bitir.Name = "bitir";
            this.bitir.Size = new System.Drawing.Size(67, 36);
            this.bitir.TabIndex = 8;
            this.bitir.Text = "Sınavı\r\nBitir";
            this.bitir.UseVisualStyleBackColor = true;
            this.bitir.Visible = false;
            this.bitir.Click += new System.EventHandler(this.bitir_Click);
            // 
            // cevaplarList
            // 
            this.cevaplarList.FormattingEnabled = true;
            this.cevaplarList.Items.AddRange(new object[] {
            "1-",
            "2-",
            "3-",
            "4-",
            "5-",
            "6-",
            "7-",
            "8-",
            "9-",
            "10-"});
            this.cevaplarList.Location = new System.Drawing.Point(314, 19);
            this.cevaplarList.Name = "cevaplarList";
            this.cevaplarList.Size = new System.Drawing.Size(67, 134);
            this.cevaplarList.TabIndex = 4;
            this.cevaplarList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cevaplarList_MouseClick);
            // 
            // soruLabel
            // 
            this.soruLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.soruLabel.AutoSize = true;
            this.soruLabel.Location = new System.Drawing.Point(82, 303);
            this.soruLabel.Name = "soruLabel";
            this.soruLabel.Size = new System.Drawing.Size(38, 13);
            this.soruLabel.TabIndex = 7;
            this.soruLabel.Text = "Soru 1";
            // 
            // soruSonra
            // 
            this.soruSonra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.soruSonra.Location = new System.Drawing.Point(126, 291);
            this.soruSonra.Name = "soruSonra";
            this.soruSonra.Size = new System.Drawing.Size(67, 36);
            this.soruSonra.TabIndex = 6;
            this.soruSonra.Text = "Sonraki soru";
            this.soruSonra.UseVisualStyleBackColor = true;
            this.soruSonra.Click += new System.EventHandler(this.soruSonra_Click);
            // 
            // soruOnce
            // 
            this.soruOnce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.soruOnce.Enabled = false;
            this.soruOnce.Location = new System.Drawing.Point(9, 291);
            this.soruOnce.Name = "soruOnce";
            this.soruOnce.Size = new System.Drawing.Size(67, 36);
            this.soruOnce.TabIndex = 5;
            this.soruOnce.Text = "Önceki soru";
            this.soruOnce.UseVisualStyleBackColor = true;
            this.soruOnce.Click += new System.EventHandler(this.soruOnce_Click);
            // 
            // cevapD
            // 
            this.cevapD.AutoSize = true;
            this.cevapD.Location = new System.Drawing.Point(6, 250);
            this.cevapD.Name = "cevapD";
            this.cevapD.Size = new System.Drawing.Size(36, 17);
            this.cevapD.TabIndex = 4;
            this.cevapD.Text = "D)";
            this.cevapD.UseVisualStyleBackColor = true;
            // 
            // cevapC
            // 
            this.cevapC.AutoSize = true;
            this.cevapC.Location = new System.Drawing.Point(6, 220);
            this.cevapC.Name = "cevapC";
            this.cevapC.Size = new System.Drawing.Size(35, 17);
            this.cevapC.TabIndex = 3;
            this.cevapC.Text = "C)";
            this.cevapC.UseVisualStyleBackColor = true;
            // 
            // cevapB
            // 
            this.cevapB.AutoSize = true;
            this.cevapB.Location = new System.Drawing.Point(6, 190);
            this.cevapB.Name = "cevapB";
            this.cevapB.Size = new System.Drawing.Size(35, 17);
            this.cevapB.TabIndex = 2;
            this.cevapB.Text = "B)";
            this.cevapB.UseVisualStyleBackColor = true;
            // 
            // cevapA
            // 
            this.cevapA.AutoSize = true;
            this.cevapA.Checked = true;
            this.cevapA.Location = new System.Drawing.Point(6, 160);
            this.cevapA.Name = "cevapA";
            this.cevapA.Size = new System.Drawing.Size(35, 17);
            this.cevapA.TabIndex = 1;
            this.cevapA.TabStop = true;
            this.cevapA.Text = "A)";
            this.cevapA.UseVisualStyleBackColor = true;
            // 
            // soru
            // 
            this.soru.BackColor = System.Drawing.SystemColors.ControlLight;
            this.soru.Location = new System.Drawing.Point(6, 19);
            this.soru.Name = "soru";
            this.soru.ReadOnly = true;
            this.soru.Size = new System.Drawing.Size(302, 134);
            this.soru.TabIndex = 0;
            this.soru.Text = "";
            // 
            // soruSec
            // 
            this.soruSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.soruSec.Location = new System.Drawing.Point(419, 19);
            this.soruSec.Name = "soruSec";
            this.soruSec.Size = new System.Drawing.Size(91, 146);
            this.soruSec.TabIndex = 1;
            this.soruSec.Text = "Soru seç\r\n(seçili soru yok)";
            this.soruSec.UseVisualStyleBackColor = true;
            this.soruSec.Click += new System.EventHandler(this.soruSec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlamak için ilk önce \r\nbir soru dosyası seçiniz.";
            // 
            // dosyaAc
            // 
            this.dosyaAc.DefaultExt = "soru";
            this.dosyaAc.Filter = "Soru belgesi|*.soru";
            this.dosyaAc.Title = "Bir \".soru\" dosyası seçiniz.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 363);
            this.Controls.Add(this.soruSec);
            this.Controls.Add(this.soruKapsayici);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sorumatik Okuyucu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.soruKapsayici.ResumeLayout(false);
            this.soruKapsayici.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox soruKapsayici;
        private System.Windows.Forms.RadioButton cevapD;
        private System.Windows.Forms.RadioButton cevapC;
        private System.Windows.Forms.RadioButton cevapB;
        private System.Windows.Forms.RadioButton cevapA;
        private System.Windows.Forms.RichTextBox soru;
        private System.Windows.Forms.Button soruOnce;
        private System.Windows.Forms.Button soruSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog dosyaAc;
        private System.Windows.Forms.Button soruSonra;
        private System.Windows.Forms.Label soruLabel;
        private System.Windows.Forms.ListBox cevaplarList;
        private System.Windows.Forms.Button bitir;
    }
}

