using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sorumatik
{
    public partial class Form1 : Form
    {
        public string[] degisim = { "", "", "", "" ,"" ,"" , "", "", "", "", " ", "\n", "\r", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "!", "'", "^", "#", "+", "$", "%", "&", "/", "{", "(", "[", ")", "]", "=", "}", "?", "*", "\\", "-", "_", "\"", ">", "<", "|", ".", ":", ",", "~", "¨", "@", "é", ";", "`", "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "Q", "R", "S", "Ş", "T", "U", "Ü", "W", "X", "V", "Y", "Z", "a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "ı", "i", "j", "k", "l", "m", "n", "o", "ö", "p", "q", "r", "s", "ş", "t", "u", "ü", "w", "x", "v", "y", "z", "â", "Â", "ê", "Ê", "û", "Û", "\t", "\b", "\v", "\f", "\a", "⍰" };
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
                } // Eğer sayı 2 basamaklıysa 3 basamaklı olması için 0 ekler, nedeninin ben de bilmiyorum ama çalışıyorsa sorun yok :D
                s += degisim[Convert.ToInt32(ram)];
                // degisim kümesinin ram'inci değerini alır (örn 99, 102) ve bunu döndürülecek değere ekler.
            }
            return s;
        }
        public string soruBil; // Testin ismini içeren bilgi.
        public int soruSayi = 0; // Daha sonra eklemeyi düşündüğüm istediğiniz kadar soru ekleme fikri için (👀)
        public int soruAcik = 0; // Ekranda açık olan sorunun numarası
        public string[] sorular = { "079106110114010013;057;058;059;061;057;", "079106110114010014;057;058;059;061;057;",
                                    "079106110114010015;057;058;059;061;057;", "079106110114010016;057;058;059;061;057;",
                                    "079106110114010017;057;058;059;061;057;", "079106110114010018;057;058;059;061;057;",
                                    "079106110114010019;057;058;059;061;057;", "079106110114010020;057;058;059;061;057;",
                                    "079106110114010021;057;058;059;061;057;", "079106110114010022;057;058;059;061;057;" };
                                    // Soruların rakamsal değerleri. Daha sonra encode() metoduyla okunabilir hale getirilecek.
        public void biriSecildi(bool varmi, string icerikBelki = "")
            // "Var olan bir soru" ya da "Yeni soru" butonlarından birine basıldığında gerçekleşir.
            // bool varmi = Basılan buton "Var olan bir soru" butonu mu?
            // string icerikBelki = Eğer program "birlikte aç" şeklinde açıldıysa testin konumunu kapsar.
        {
            soruSayi = 0;
            soruAcik = 0;
            gitSag.Enabled = true;
            gitSol.Enabled = false;
            soruAcikLabel.Text = "Soru 1";
            // Her şeyi sıfırlar.
            string[] soruicerik;
            if (varmi) // Eğer var olan bir soru butonu seçildiyse
            {
                if (icerikBelki == "") // Eğer program birlikte aç şeklinde açılmadıysa gerçekleşir.
                {
                    var b = DialogResult.Yes;
                    while(b == DialogResult.Yes)
                    {
                      try
                      {
                           var a = soruSec.ShowDialog(); // Dosya seçmeni ister.
                         if (a == DialogResult.OK) // Eğer dosya seçildiyse
                              {
                                  var d = soruSec.OpenFile();
                                  StreamReader r = new StreamReader(d);
                                  var icerik = r.ReadToEnd();
                                // Konumdaki dosyayı okur.
                               soruicerik = icerik.Split(',');
                               soruBil = soruicerik[0];
                               isim.Text = encode(soruBil);
                               for (int i = 1; i < 11; i++)
                               {
                                   sorular[i - 1] = soruicerik[i];
                               }
                               // Soru bilgilerini ekrana yazar veya saklar.
                               baslangic.Visible = false;
                                // Eğer bir hata olsaydı buraya kadar olurdu o yüzden soruyu göstermekte sıkıntı yok. 
                               soruDegisti();
                           }
                           b = DialogResult.No; // Döngüyü tamamlar.
                       }
                       catch (Exception) // Eğer yukardaki kodda (özellikle 108. satırda) bir hata olursa gerçekleşecek kod.
                       {
                           baslangic.Visible = true;
                            // Soruları gizler.
                           if (MessageBox.Show("Bu dosyayı okurken hata oluştu. Yeniden bir dosya seçmek istiyor musunuz?", "Hata", MessageBoxButtons.YesNo) == DialogResult.No)
                                // Eğer yeniden dosya seçmek istenmiyorsa
                           {
                               geriDon_Click("h", EventArgs.Empty);
                               b = DialogResult.No;
                           }
                           else
                                // Eğer yeniden dosya seçilmek isteniyorsa
                           {
                               geriDon_Click("h", EventArgs.Empty);
                               b = DialogResult.Yes;
                           }
                       }
                    }
                } else // Eğer birlikte aç'ta bir dosya açılırsa
                {
                    try
                    {
                            StreamReader r = new StreamReader(icerikBelki);
                            var icerik = r.ReadToEnd();
                            soruicerik = icerik.Split(',');
                            soruBil = soruicerik[0];
                            isim.Text = encode(soruBil);
                            for (int i = 1; i < 11; i++)
                            {
                                sorular[i - 1] = soruicerik[i];
                            }
                            baslangic.Visible = false;
                        // Yukarıdaki kodun hemen hemen aynısı
                            soruDegisti();
                    }
                    catch (Exception) // Eğer açılan dosya bozuksa
                    {
                        baslangic.Visible = true;
                        if (MessageBox.Show("Bu dosyayı okurken hata oluştu veya böyle bir dosya yok. Sorumatik'e geri dönmek ister misiniz?", "Hata", MessageBoxButtons.YesNo) == DialogResult.No)
                        { // Eğer sorumatik yazara geri dönmek istenmiyorsa
                            this.Close();
                        }
                        else
                        { // Sorumatiğe geri dönmek istiyorsa
                            geriDon_Click("h", EventArgs.Empty);
                        }
                    }
                }

            } else // Eğer yeni dosya oluşturmak seçildiyse
            {
                for(int i = 0; i<10; i++)
                {
                    sorular[i] = $"{decode("Soru " + (i + 1))};057;058;059;061;057;";
                }
                isim.Text = "isim";
                // Tüm soruları varsayılana çevirir.
                baslangic.Visible = false; // Soruyu gösterir
                soruDegisti();
            }

        }
        //\"{soru}\" \"{cevapA}\"\"{cevapB}\"\"{cevapC}\" \"{cevapD}\"
        public Form1()
        {
            InitializeComponent();
        } // Program kodu karışmıyorum yeniden >.<
        private void kaydet_Click(object sender, EventArgs e)
            // Kaydet tuşuna basıldığında gerçekleşir.
        {
            sorular[soruAcik] = $"{decode(soru.Text)};{decode(cevapA.Text)};{decode(cevapB.Text)};{decode(cevapC.Text)};{decode(cevapD.Text)};{decode(cevapDogru.Text)}";
            soruBil = $"{decode(isim.Text)},{string.Join(",", sorular)}";
            // Sorunun yazılarını bir dosyaya kaydetmek üzere depolar.
            soruKaydedilecekYer.Title = "Soru Belgenizi Kaydedin";
            soruKaydedilecekYer.FileName = isim.Text;
            soruKaydedilecekYer.DefaultExt = "soru";
            soruKaydedilecekYer.Filter = "Soru Dosyaları (*.soru)|*.soru";
            soruKaydedilecekYer.ShowDialog();
            // Soruyu kaydedeceğin yeri seçtiren diyaloğu gösterir
            var konum = Path.GetFullPath(soruKaydedilecekYer.FileName);
            string ad = soruKaydedilecekYer.FileName;
            if (ad != "") // Eğer dosya ismi "" değil ise
            {
                if (!File.Exists(konum)) // Eğer dosya orada daha önceden yoksa
                {
                    File.Create(konum).Close(); // Dosya oluştur
                    using (StreamWriter sw = File.AppendText(konum))
                    {
                        sw.Write(soruBil); // Soru bilgisini yaz
                    }
                }
                else // Eğer dosya önceden varsa
                {
                    File.WriteAllText(konum, String.Empty); // Tüm içeriği sil
                    using(StreamWriter sw = File.AppendText(konum))
                    {
                        sw.Write(soruBil);
                    }
                    // Bir daha yaz.
                }
                // Kaynak: https://stackoverflow.com/questions/42869618/create-a-textfile-from-winform-and-write-and-read-from-the-textfile 

            }

        }
        void soruDegisti()
            // Soru değiştiğinde gerçekleşen metod.
        {
            string[] sorular2 = sorular[soruAcik].Split(';');
            soru.Text = encode(sorular2[0]);
            cevapA.Text = encode(sorular2[1]);
            cevapB.Text = encode(sorular2[2]);
            cevapC.Text = encode(sorular2[3]);
            cevapD.Text = encode(sorular2[4]);
            cevapDogru.Text = encode(sorular2[5]);
            // Soru bilgisini alır.
        } 


        private void gitSag_Click(object sender, EventArgs e)
            // Sağ ok butonuna basıldığında gerçekleşir.
        {
            sorular[soruAcik] = $"{decode(soru.Text)};{decode(cevapA.Text)};{decode(cevapB.Text)};{decode(cevapC.Text)};{decode(cevapD.Text)};{decode(cevapDogru.Text)}";
            // Soru bilgisini kaydeder.
            if (soruAcik == 8)
            {
                gitSag.Enabled = false;
            } else
            {
                gitSol.Enabled = true;
            } // Eğer daha fazla ileri gidemezsen (soru numaran 9'sa)
            soruDegisti();
            soruAcik++;
            soruAcikLabel.Text = $"Soru {soruAcik + 1}";
            soruDegisti();
        }

        private void gitSol_Click(object sender, EventArgs e)
            // Sol ok butonuna basıldığında gerçekleşir.
        {
            sorular[soruAcik] = $"{decode(soru.Text)};{decode(cevapA.Text)};{decode(cevapB.Text)};{decode(cevapC.Text)};{decode(cevapD.Text)};{decode(cevapDogru.Text)}";
            // Soru bilgisini kaydeder.
            if (soruAcik == 1)
            {
                gitSol.Enabled = false;
            }
            else
            {
                gitSag.Enabled = true;
            } // Eğer daha fazla geri gidemezsen (soru numaran 1'se)
            soruDegisti();
            soruAcik--;
            soruAcikLabel.Text = $"Soru {soruAcik + 1}";
            soruDegisti();
        }

        private void cevapDogru1_TextChanged(object sender, EventArgs e)
            // Doğru cevap metin alanının değeri değiştiğinde gerçekleşir.
        {
            string[] cevaplar = { "A", "B", "C", "D"};
            if (!(cevaplar.Contains(cevapDogru.Text.ToUpper())))
                // Eğer A B C veya D şıklarından biri girilmezse
            {
                MessageBox.Show("A, B, C veya D şıklarından birini girmelisiniz.");
                cevapDogru.Text = "A";
            }
            cevapDogru.Text = cevapDogru.Text.ToUpper();
        }

        private void Form1_Load(object sender, EventArgs e)
            // Uygulama ilk yüklendiğinde gerçekleşir.
        {
            baslangic.Visible = true;
            baslangic.Location = new Point(12, 12);
            this.MaximumSize = new Size(525, 424);
            this.MinimumSize = new Size(525, 424);
            this.Size = new Size(525, 424);
            // Görüntü ayarlaması.
            if (sender.ToString() != "") // Eğer bu metod program ilk yüklendiğinde başlayıp kod içerisinden ayrı olarak başlamadıysa
            {
                try
                {
                    string OpenWith = Environment.GetCommandLineArgs()[1]; 
                    // İlk önce birlikte açılma olayının olmayıp olmadığını anlamak için buraya 2. bir argüman girilmiş mi bakar.
                    // Eğer girilmemişse hata verir ve içinde sadece return; olan kod dizisine gider.
                    try
                    {
                        StreamReader sr = new StreamReader(OpenWith);
                        biriSecildi(true, OpenWith);
                        // Bu dosyanın var olup olmadığını kontrol eder.
                        // Eğer varsa biriSecildi() metoduna bu dosyanın konumunu gönderir.
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
        }

        private void yeniDosya_Click(object sender, EventArgs e)
            // Yeni bir dosya oluştur butonuna basıldığında gerçekleşir.
        {
            biriSecildi(false);
        }

        private void varolanDosya_Click(object sender, EventArgs e)
            // Varolan bir dosyayı seç butonuna basıldığında gerçekleşir.
        {
            biriSecildi(true);
        }

        private void geriDon_Click(object sender, EventArgs e)
            // Geri dön Butonuna basıldığında gerçekleşir ( Bu buton sadece soru açıkken vardır ) 
        {
            if(sender.ToString() == "h") // Eğer bu metod kod içinden çağrıldıysa
            {
                Form1_Load("", EventArgs.Empty);
            } else
            {

                var a = MessageBox.Show("Geri dönmek istediğinize emin misiniz? Eğer kaydedilmemiş soru dosyanız varsa dosyalar kaybolur.", "Sorumatik Yazar", MessageBoxButtons.YesNo);

                if (a == DialogResult.Yes)
                {
                    Form1_Load("", EventArgs.Empty);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
            // Uygulama kapanırken gerçekleşir.
        {
            if (!baslangic.Visible)
            {
                e.Cancel = !(MessageBox.Show("Uygulamayı kapatmak istediğinize emin misiniz? Eğer kaydedilmemiş soru dosyanız varsa dosyalar kaybolur.", "Sorumatik Yazar", MessageBoxButtons.YesNo) == DialogResult.Yes);
            } // Eğer ekranda bir soru varken kapat tuşuna basılırsa diyaloğun cevabına göre programı kapatır ya da açık tutar.
        }
    }
}
