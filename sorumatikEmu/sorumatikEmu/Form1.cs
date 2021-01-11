using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace sorumatikEmu
{
    public partial class Form1 : Form
    {
        public string[] dogruCevaplar = { "", "", "", "", "", "", "", "", "", "" };
        public string icerik; // Soru gövde ve şıklarındaki yazılar + doğru şık.
        public int soruAcik = 0; // Ekranda gözüken soru
        public bool isFileCorrupted = false; // Eğer seçilen dosya bozuksa true olur.
        public string[] cevaplar = { "", "", "", "", "", "", "", "", "", "" }; // Seçilen şık.
        public string[] degisim = { "", "", "", "", "", "", "", "", "", "", " ", "\n", "\r", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "!", "'", "^", "#", "+", "$", "%", "&", "/", "{", "(", "[", ")", "]", "=", "}", "?", "*", "\\", "-", "_", "\"", ">", "<", "|", ".", ":", ",", "~", "¨", "@", "é", ";", "`", "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "Q", "R", "S", "Ş", "T", "U", "Ü", "W", "X", "V", "Y", "Z", "a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "ı", "i", "j", "k", "l", "m", "n", "o", "ö", "p", "q", "r", "s", "ş", "t", "u", "ü", "w", "x", "v", "y", "z", "â", "Â", "ê", "Ê", "û", "Û", "\t", "\b", "\v", "\f", "\a", "⍰" };
        // ^ Encode ve Decode'da kullanılan harfler-rakamlar-semboller
        public string decode(string x)
            // x değerini daha sonra encode() metoduyla okunmak üzere rakamsal değere dönüştürür.
        {
            string s = "";
            // Ana değer- döndürülecek
            foreach (char c in x) // x değerindin her harfi için alttaki kodlar gerçekleşecek.
            {
                string a = Array.FindIndex(degisim, row => row.Contains(c.ToString())).ToString();
                // c, x'ten bir harftir. Bu metod c değerinin degisim kümesindeki yerini bulur.
                if (a.ToString() == "-1")
                    // Eğer harf degisim kümesinde yoksa Array.FindIndex() metodu -1 değerini döndürür,
                {
                    a = Array.FindIndex(degisim, row => row.Contains(degisim[degisim.Length - 1])).ToString();
                    // bu da harfin geçerli olmadığı anlamında gelir ve bu da soru işaretine dönüşür.
                }
                else
                { // Eğer harf degisim kümesinde varsa:
                    while (a.ToString().Length < 3)
                    {
                        a = "0" + a.ToString();
                    } // Eğer bulunan küme değeri 2 basamaklıysa başına hataları önlemek için 0 ekler. 
                }
                s += a;
                // ana değer olan s'ye sayı değeri olan a'yı ekler
            }
            return s;
        }

        public string encode(string x)
            // x sayısal değerini yazıya çevirir.
        {
            string ram = "000";
            // decode() metodunda numaralar 3'erli gruplara ayrılmıştı. 
            // ram değeri bu 3'erli gruplardan birini temsil eder. Alttaki kodda hata
            // olmaması için normal değeri "000" olur.
            string s = ""; // Döndürülecek değer
            for (int i = 0; i < x.Length; i += 3)
                // i'ye 3 eklememizin sebebi decode() metodunda harfleri 3'erli gruplara ayırmamızdı.
            {
                ram = x[i].ToString() + x[i + 1].ToString() + x[i + 2].ToString();
                // Bu 3'erli gruplardan 1, 2 ve 3. harfleri alır.
                if (ram[0] == '0')
                {
                    ram = ram[1].ToString() + ram[2];
                } // Eğer sayı 2 basamaklıysa 3 basamaklı olması için 0 ekler, neden bunu while döngüsüne aldığımı ben de bilmiyorum ama çalışıyorsa sorun yok :D
                s += degisim[Convert.ToInt32(ram)];
                // degisim kümesinin ram'inci değerini alır (örn 99, 102) ve bunu döndürülecek değere ekler.
            }
            return s;
        }
        // Bir soru yüklenirse gerçekleşecek metod.
        public void SoruYuklendi(string x) // x = sorunun içeriği
        {
            if (string.IsNullOrEmpty(x)) // Eğer dosyada hiç bir şey yoksa:
            {
                MessageBox.Show("Soru dosyanızda bir sorun var. Lütfen dosyanın doğru olup olmadığını kontrol ediniz.\nEğer bir sorun olmadığını düşünüyorsanız benimle iletişime geçebilirsiniz.");
                System.Diagnostics.Process.Start(Environment.GetCommandLineArgs()[0]); // Programı yeninden başlatır.
                isFileCorrupted = true; // Dosyanın bozuk olduğunu belirtir.
                this.Close(); // Programı kapatır, bu sırada metodun 2. satırındaki kod hâla devam eder.
                return; // Alttaki kodları iptal eder.
            }
            try // Dosyada bir bozukluk olup olmadığını kontrol eder.
            {
                this.Text = "Sorumatik Okuyucu - " + encode(x.Split(',')[0]);
                soruSec.Text = $"Soru Seç (Seçili soru: \"{encode(x.Split(',')[0])}\")";
                soruAcik = 0;
                soruLabel.Text = "Soru 1";
                cevaplarList.SelectedIndex = 0;
                soruKapsayici.Visible = true;
                this.MaximumSize = new Size(538, 402);
                this.MinimumSize = new Size(538, 402);
                this.Size = new Size(538, 402);
                soruKapsayici.Text = $"Çözüyorsunuz: \"{encode(x.Split(',')[0])}\"";
                soruSonra.Visible = true;
                soruSonra.Enabled = true;
                soruOnce.Enabled = false;
                soruSonra.Visible = true;
                bitir.Visible = false;
                // Hoşgeldin ekranını kapatır, soru ile ilgili bilgileri uygulamanın başlığına yazar vb.
                for (int i = 0; i < 10; i++)
                {
                    dogruCevaplar[i] = encode(x.Split(',')[i + 1].Split(';')[5]);
                } // Doğru cevapları alır.
                for (int i = 0; i < 10; i++)
                {
                    cevaplarList.Items[i] = $"{i + 1}- ";
                    cevaplar[i] = "";
                } // Tüm önceden verilen şıkları siler.
                SoruYaz(x);
            }
            catch (Exception)
            {
                MessageBox.Show("Soru dosyanızda bir sorun var. Lütfen dosyanın doğru olup olmadığını kontrol ediniz.\nEğer bir sorun olmadığını düşünüyorsanız benimle iletişime geçebilirsiniz.");
                System.Diagnostics.Process.Start(Environment.GetCommandLineArgs()[0]); // Programı yeninden başlatır.
                isFileCorrupted = true; // Dosyanın bozuk olduğunu belirtir.
                this.Close(); // Programı kapatır, bu sırada metodun 2. satırındaki kod hâla devam eder.
                return; // Diğer kodları iptal eder.
            }
        } 
        // Programın kendi kodu karışmıyorum >.<
        public Form1()
        {
            InitializeComponent();
        }
        void SoruYaz(string x)
        {
            try // Alttaki kodu dener, hata olursa catch() kısmındaki kod devreye girer.
            {
                icerik = x;
                string[] sorular = x.Split(',');
                // Her soru programda ',' işaretiyle ayrıldığı için bu da her soruyu (şıklar da dahil) alır.
                string[] soruBilgi = sorular[soruAcik + 1].Split(';');
                // Sorudaki kök, şıklar ve doğru cevap ';' ile ayrıldığı için bu tüm bilgileri alır.
                soru.Text = encode(soruBilgi[0]);
                cevapA.Text = "A) " + encode(soruBilgi[1]);
                cevapB.Text = "B) " + encode(soruBilgi[2]);
                cevapC.Text = "C) " + encode(soruBilgi[3]);
                cevapD.Text = "D) " + encode(soruBilgi[4]);
                // Kök ve şıkları ekrana yazar.
            }
            catch (Exception)
            {
                // O işlemlerden biri yanlış giderse soru boşsa olacak şey yeniden olur.
                MessageBox.Show("Soru dosyanızda bir sorun var. Lütfen dosyanın doğru olup olmadığını kontrol ediniz.\nEğer bir sorun olmadığını düşünüyorsanız benimle iletişime geçebilirsiniz.");
                System.Diagnostics.Process.Start(Environment.GetCommandLineArgs()[0]);
                isFileCorrupted = true;
                this.Close();
            }
        }

        public void soruSec_Click(object sender, EventArgs e)
            // Soru Seç butonuna basıldığında gerçekleşir.
        {
            string soruicerik;
            
                if(dosyaAc.ShowDialog() == DialogResult.OK)
                // Bir Dosya seçildiğinde gerçekleşir.
                {

                try
                {
                    var fileStream = dosyaAc.OpenFile(); // Dosyayı açar.
                    StreamReader reader = new StreamReader(fileStream);
                    soruicerik = reader.ReadToEnd(); // Dosyanın içeriğinin tamamını okur.
                    SoruYuklendi(soruicerik);
                }
                catch (Exception) // Öyle bir dosya yoksa:
                {
                    this.MaximumSize = new Size(401, 350);
                    this.MinimumSize = new Size(401, 350);
                    this.Size = new Size(401, 350);
                    this.Text = "Sorumatik Yazar";
                    soruSec.Text = "Soru seç\r\n(seçili soru yok)";
                    soruKapsayici.Visible = false;
                    // Başlangıç ekranına geri gider.
                    DialogResult a = MessageBox.Show("Bu dosyayı okurken hata oluştu. Bir daha dosya seçmek ister misiniz?", "Hata", MessageBoxButtons.YesNo);
                    if (a == DialogResult.Yes)
                    {
                        soruSec_Click("", EventArgs.Empty);
                    } // Yeniden Soru Seç'e bastığınızda olacak olayları basmadan yapar.
                }
                }
        }
        void isaretle()
            // Sorular arasında geçiş yaptığında önceden cevapladığın şık neyse onu yazar.
        {
            //string secilenCevap = icerik.Split(',')[soruAcik].Split(';')[5];
            string secilenCevap = cevaplar[soruAcik];
            switch (secilenCevap)
            {
                case "A":
                    cevapA.Checked = true;
                    cevapB.Checked = false;
                    cevapC.Checked = false;
                    cevapD.Checked = false;
                    break;
                case "B":
                    cevapA.Checked = false;
                    cevapB.Checked = true;
                    cevapC.Checked = false;
                    cevapD.Checked = false;
                    break;
                case "C":
                    cevapA.Checked = false;
                    cevapB.Checked = false;
                    cevapC.Checked = true;
                    cevapD.Checked = false;
                    break;
                case "D":
                    cevapA.Checked = false;
                    cevapB.Checked = false;
                    cevapC.Checked = false;
                    cevapD.Checked = true;
                    break;
                case "":
                    cevapA.Checked = false;
                    cevapB.Checked = false;
                    cevapC.Checked = false;
                    cevapD.Checked = false;
                    break;
            }
        }
        private void soruSonra_Click(object sender, EventArgs e)
            // sonraki soru butonuna bastığında gerçekleşir.
        {
            {

                if (cevapA.Checked)
                {
                    cevaplar[soruAcik] = "A";
                }
                else if (cevapB.Checked)
                {
                    cevaplar[soruAcik] = "B";
                }
                else if (cevapC.Checked)
                {
                    cevaplar[soruAcik] = "C";
                }
                else if (cevapD.Checked)
                {
                    cevaplar[soruAcik] = "D";
                }
                else
                {
                    cevaplar[soruAcik] = "";
                }
                // Cevabını kaydeder.
            }
            cevaplarList.Items[soruAcik] = $"{soruAcik + 1}- {cevaplar[soruAcik]}";
            cevaplarList.SelectedIndex = soruAcik + 1;
            // Cevapların olduğu listeye cevabını ekler.
            if (soruAcik == 8)
            {
                soruSonra.Enabled = false;
                soruSonra.Visible = false;
                bitir.Visible = true;
            } else
            {
                soruOnce.Enabled = true;
            }
            // Açık soru 8 olduğunda buna 1 daha eklersek bu 9 olur (yani 10) ve o yüzden sınavı bitir düğmesini gösterir
            SoruYaz(icerik);
            soruAcik++;
            soruLabel.Text = $"Soru {soruAcik + 1}";
            isaretle();
            SoruYaz(icerik);
            // Soru numarasını yazar ve işaretler.
        }

        private void soruOnce_Click(object sender, EventArgs e)
            // Önceki Soru butonuna tıklandığında gerçekleşir, hemen hemen her şey yukardakiyle aynı.
        {
            {

                if (cevapA.Checked)
                {
                    cevaplar[soruAcik] = "A";
                }
                else if (cevapB.Checked)
                {
                    cevaplar[soruAcik] = "B";
                }
                else if (cevapC.Checked)
                {
                    cevaplar[soruAcik] = "C";
                }
                else if (cevapD.Checked)
                {
                    cevaplar[soruAcik] = "D";
                }
                else
                {
                    cevaplar[soruAcik] = "";
                }
            }
            cevaplarList.Items[soruAcik] = $"{soruAcik + 1}- {cevaplar[soruAcik]}";
            cevaplarList.SelectedIndex = soruAcik - 1;
            if (soruAcik == 1)
            {
                soruOnce.Enabled = false;
            } else
            {
                soruSonra.Visible = true;
                soruSonra.Enabled = true;
                bitir.Visible = false;
            }
            SoruYaz(icerik);
            soruAcik--;
            soruLabel.Text = $"Soru {soruAcik + 1}";
            isaretle();
            SoruYaz(icerik);
        }

        private void bitir_Click(object sender, EventArgs e)
            // Sınavı Bitir tuşuna basıldığında gerçekleşir.
        {
            {

                if (cevapA.Checked)
                {
                    cevaplar[9] = "A";
                }
                else if (cevapB.Checked)
                {
                    cevaplar[9] = "B";
                }
                else if (cevapC.Checked)
                {
                    cevaplar[9] = "C";
                }
                else if (cevapD.Checked)
                {
                    cevaplar[9] = "D";
                }
                else
                {
                    cevaplar[9] = "";
                }
                // Cevabı kaydeder.
            }
            cevaplarList.Items[soruAcik] = $"{soruAcik + 1}- {cevaplar[soruAcik]}";
            // Cevabı listeye de kaydeder.
            List<int> yanlisVeyaBosCevaplar = new List<int>(); // Yanlış veya boş cevapların olduğu liste
            int dogruCevapSayi = 0; // Doğru cevap sayısı
            for (int i = 0; i<10; i++) // 10 kere tekrarlayacak
            {
                if ( cevaplar[i] == (dogruCevaplar[i]) ) // cevap doğruysa
                {
                    dogruCevapSayi++;
                } else // Cevap yanlışsa
                {
                    yanlisVeyaBosCevaplar.Add(i + 1); // Yanlış veya boş soru listesine ekler.
                }
            }
            if (yanlisVeyaBosCevaplar.Count == 0) // Eğer hiç yanlış yoksa
            {
                MessageBox.Show($"Tebrikler! 10 Soruluk \"{encode(icerik.Split(',')[0])}\" testinde {dogruCevapSayi} doğrunuz var!");
            }
            else
            {
                MessageBox.Show($"Tebrikler! 10 Soruluk \"{encode(icerik.Split(',')[0])}\" testinde {dogruCevapSayi} doğrunuz var!\nYanlış-Boş yaptığınız sorular: {string.Join(", ", yanlisVeyaBosCevaplar.ToArray())}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
            // Uygulama ilk açıldığında
        {
            this.MaximumSize = new Size(401, 350);
            this.MinimumSize = new Size(401, 350);
            this.Size = new Size(401, 350);
            // Görüntü ayarları.
            try
            {
                string OpenWith = Environment.GetCommandLineArgs()[1];
                // İlk önce birlikte açılma olayının olmayıp olmadığını anlamak için buraya 2. bir argüman girilmiş mi bakar.
                // Eğer girilmemişse hata verir ve içinde sadece return; olan kod dizisine gider.
                try
                {
                    StreamReader sr = new StreamReader(OpenWith);
                    SoruYuklendi(sr.ReadToEnd());
                    // Bu dosyanın var olup olmadığını kontrol eder.
                    // Eğer varsa SoruYuklendi metoduna bu dosyanın içeriğini gönderir.
                    // Eğer yoksa alttaki catch() bloğuna yönlendiriliriz.
                }
                catch (Exception)
                {
                    MessageBox.Show("Dosyayı okurken bir hata oluştu.");
                    return; // Dosyada hata olduğunu söyleyerek programın işleyişine devam eder.
                }
            }
            catch (Exception)
            {
                return; // Eğer uygulama düz bi şekilde açıldıysa normal işleyişine devam eder.
            }
        }

        private void cevaplarList_MouseClick(object sender, MouseEventArgs e)
            // Cevapların olduğu listeye tıklanırsa
        {
            int indx = cevaplarList.IndexFromPoint(e.Location);
            if (indx != ListBox.NoMatches)
            {
                if(indx > soruAcik)
                {
                    while (indx > soruAcik)
                    {
                        soruSonra_Click(1, EventArgs.Empty);
                    }
                } else if (indx < soruAcik)
                {
                    while (indx < soruAcik)
                    {
                        soruOnce_Click(1, EventArgs.Empty);
                    }
                }
            }
            // Stackoverflow kodu >.< Listeden bir ögeye tıklandığında o ögeye erişene kadar bu metodları gerçekleştirir.
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
            // Uygulama kapanırken gerçekleşir.
        {
            if (soruKapsayici.Visible && !isFileCorrupted)
            {
                e.Cancel = (MessageBox.Show("Testten çıkmak istediğize emin misiniz?", "Sorumatik Okuyucu", MessageBoxButtons.YesNo) == DialogResult.No);
            } // Eğer soru gözüküyorsa ve dosya bozuk değilse yönlendirmeye göre uygulamayı kapatır.
        }
    }
}
