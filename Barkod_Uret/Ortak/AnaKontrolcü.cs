using ArgeMup.HazirKod;
using ArgeMup.HazirKod.Ekİşlemler;
using System.IO;
using System.Windows.Forms;

namespace Barkod_Uret
{
    public class AnaKontrolcü
    {
        public static bool YanUygulamaOlarakÇalışıyor
        {
            get => Şube != null;
        }
        public static Form BoştaBekleyenAnaUygulama;
        static AnaEkran YanUygulamaAyarlamaPenceresi;
        static string YanUygulama_SonAçılan_Depo_Ayarlar_DosyaYolu;

        static YanUygulama.Şube_ Şube;
        static System.Threading.Mutex Kilit;

        public static void Açıl(int ŞubeErişimNoktası)
        {
            if (ŞubeErişimNoktası > 0)
            {
                Şube = new YanUygulama.Şube_(ŞubeErişimNoktası, GeriBildirim_İşlemi_Uygulama);
                Kilit = new System.Threading.Mutex();
                BoştaBekleyenAnaUygulama = new System.Windows.Forms.Form() { Opacity = 0, ShowInTaskbar = false, Visible = false };

#if DEBUG
                Depo_ KomutVermeDeposu = new Depo_();
                KomutVermeDeposu["Ayarlar", 0] = @"C:\Deneme\Ayarlar.mup";

                //Seçenek 1
                KomutVermeDeposu["Komut", 0] = "Ayarla";

                //Seçenek 2
                //KomutVermeDeposu["Komut"].İçeriği = new string[] { "Dosyaya Kaydet", @"C:\Deneme\Çıktı\Çıktı.png" };
                //KomutVermeDeposu["Güncel İçerik", 0] = "En Güncel İçerik";

                //------------------------------------------

                byte[] dizi = KomutVermeDeposu.YazıyaDönüştür().BaytDizisine();
                GeriBildirim_İşlemi_Uygulama(true, dizi, null);
                Application.Exit();
#endif
            }
            else
            {
                Ortak.Depo_Komut = new Depo_();
                Ortak.Depo_Komut["Komut", 0] = "Ayarla";
                Ortak.Depo_Komut["Ayarlar", 0] = Kendi.Klasörü + "\\Ayarlar.mup";
                
                Ortak.Depo_Ayarlar = new Depo_(Temkinli.Dosya.Oku_Yazı(Ortak.Depo_Komut["Ayarlar", 0]));

                BoştaBekleyenAnaUygulama = new AnaEkran();
            }
        }
        static void GeriBildirim_İşlemi_Uygulama(bool BağlantıKuruldu, byte[] Bilgi, string Açıklama)
        {
            if (!BağlantıKuruldu)
            {
#if !DEBUG
                Application.Exit();
#endif
                return;
            }

            if (YanUygulamaAyarlamaPenceresi != null)
            {
                try
                {
                    YanUygulamaAyarlamaPenceresi.Kaydet.Enabled = false;
                    YanUygulamaAyarlamaPenceresi.Dispose();
                }
                finally { YanUygulamaAyarlamaPenceresi = null; }
            }
            
            string içerik = Bilgi.Yazıya();
            if (içerik.BoşMu() || !Kilit.WaitOne(5000)) return;

            string Sonuç = null;

            try
            {
                Ortak.Depo_Komut = new Depo_(içerik);

                if (YanUygulama_SonAçılan_Depo_Ayarlar_DosyaYolu != Ortak.Depo_Komut["Ayarlar", 0])
                {
                    Ortak.Depo_Ayarlar = new Depo_(Temkinli.Dosya.Oku_Yazı(Ortak.Depo_Komut["Ayarlar", 0]));

                    YanUygulama_SonAçılan_Depo_Ayarlar_DosyaYolu = Ortak.Depo_Komut["Ayarlar", 0];
                }

                if (Ortak.Depo_Komut["Komut", 0] == "Dosyaya Kaydet")
                {
                    if (!Temkinli.Dosya.Sil(Ortak.Depo_Komut["Komut", 1]))
                    {
                        Sonuç = "Dosya bir uygulama içinde açık olduğundan silinemedi." + System.Environment.NewLine + Ortak.Depo_Komut["Komut", 1];
                    }
                    else
                    {
                        if (!string.IsNullOrWhiteSpace(Ortak.Depo_Komut["Güncel İçerik", 0])) Ortak.Depo_Ayarlar["Detaylar/İçerik", 0] = Ortak.Depo_Komut["Güncel İçerik", 0];

                        Sonuç = Ortak.Üret(out System.Drawing.Image Resim);
                        if (Resim != null)
                        {
                            Directory.CreateDirectory(Path.GetDirectoryName(Ortak.Depo_Komut["Komut", 1]));
                            Resim.Save(Ortak.Depo_Komut["Komut", 1], System.Drawing.Imaging.ImageFormat.Png);

                            Sonuç = Ortak.Depo_Komut["Benzersiz_Tanımlayıcı", 0]; //Başarılı
                        }
                        else Sonuç += System.Environment.NewLine + "Resim üretilmedi";
                    }
                }
                else if (Ortak.Depo_Komut["Komut", 0] == "Ayarla")
                {
                    BoştaBekleyenAnaUygulama.Invoke(new System.Action(() =>
                    {
                        YanUygulamaAyarlamaPenceresi = new AnaEkran();
                        YanUygulamaAyarlamaPenceresi.Show();

                        W32_3.SetForegroundWindow(YanUygulamaAyarlamaPenceresi.Handle);
                    }));

                    Sonuç = Ortak.Depo_Komut["Benzersiz_Tanımlayıcı", 0]; //Başarılı
                }
                else Sonuç = "Geçersiz komut " + Ortak.Depo_Komut["Komut", 0];
            }
            catch (System.Exception ex)
            {
                Sonuç += ex.Message;
            }

            Kilit.ReleaseMutex();

#if DEBUG
            Dosya.Yaz("epst.txt", Sonuç);
#else
            byte[] cevap_dizi = Sonuç.BaytDizisine();
            if (cevap_dizi != null && cevap_dizi.Length > 0) Şube.Gönder(cevap_dizi);
#endif
        }

        public static void Kapan(string Bilgi)
        {
            Günlük.Ekle("Kapatıldı " + Bilgi, Hemen: true);

            Ortak.YeniYazılımKontrolü?.Durdur(); Ortak.YeniYazılımKontrolü = null;
            Şube?.Dispose(); Şube = null;
            Kilit?.Dispose(); Kilit = null;

            ArgeMup.HazirKod.ArkaPlan.Ortak.Çalışsın = false;
        }
    }
}
