using ArgeMup.HazirKod;
using ArgeMup.HazirKod.Ekİşlemler;
using System.IO;

namespace Barkod_Uret
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [System.STAThread]
        static void Main(string[] BaşlangıçParamaetreleri)
        {
            #if DEBUG
            Depo_ KomutVermeDeposu = new Depo_();
            KomutVermeDeposu["Ayarlar", 0] = @"C:\Deneme\Ayarlar.mup";

            ////Seçenek 1
            //KomutVermeDeposu["Komut", 0] = "Ayarla";
            //BaşlangıçParamaetreleri = new string[] { @"C:\Deneme\Komut.txt" };
            //File.WriteAllText(BaşlangıçParamaetreleri[0], KomutVermeDeposu.YazıyaDönüştür());

            ////Seçenek 2 A
            //KomutVermeDeposu["Komut", 0] = "Ayarla";
            //BaşlangıçParamaetreleri = new string[] { ArgeMup.HazirKod.Dönüştürme.D_Yazı.Taban64e(KomutVermeDeposu.YazıyaDönüştür()) };

            ////Seçenek 2 B
            //KomutVermeDeposu["Komut"].İçeriği = new string[] { "Dosyaya Kaydet", @"C:\Deneme\Çıktı\Çıktı.png" };
            //KomutVermeDeposu["Güncel İçerik", 0] = "En Güncel İçerik";
            //BaşlangıçParamaetreleri = new string[] { ArgeMup.HazirKod.Dönüştürme.D_Yazı.Taban64e(KomutVermeDeposu.YazıyaDönüştür()) };

            ////Seçenek 3
            //BaşlangıçParamaetreleri = new string[] { "YeniYazilimKontrolu" };

            ////Seçenek 4
            #endif

            if (BaşlangıçParamaetreleri != null && BaşlangıçParamaetreleri.Length == 1)
            {
                if (BaşlangıçParamaetreleri[0] == "YeniYazilimKontrolu")
                {
                    Dosya.Sil(Kendi.Klasörü + "\\zxing.dll");
                    
                    YeniYazılımKontrolü_ YeniYazılımKontrolü = new YeniYazılımKontrolü_();
                    YeniYazılımKontrolü.Başlat(new System.Uri("https://github.com/ArgeMup/Barkod_Uret/blob/main/Barkod_Uret/bin/Release/Barkod_Uret.exe?raw=true"));
                    while (!YeniYazılımKontrolü.KontrolTamamlandı) System.Threading.Thread.Sleep(1000);
                    YeniYazılımKontrolü.Durdur();
                    return;
                }
                else if (File.Exists(BaşlangıçParamaetreleri[0]))
                {
                    Ortak.Depo_Komut = new Depo_(File.ReadAllText(BaşlangıçParamaetreleri[0]));
                }
                else
                {
                    BaşlangıçParamaetreleri[0] = BaşlangıçParamaetreleri[0].Taban64ten().Yazıya();
                    Ortak.Depo_Komut = new Depo_(BaşlangıçParamaetreleri[0]);
                }
            }

            if (!System.IO.File.Exists(ArgeMup.HazirKod.Kendi.Klasörü + "\\zxing.dll")) System.IO.File.WriteAllBytes(ArgeMup.HazirKod.Kendi.Klasörü + "\\zxing.dll", Properties.Resources.zxing);

            if (Ortak.Depo_Komut == null)
            {
                Ortak.Depo_Komut = new Depo_();
                Ortak.Depo_Komut["Komut", 0] = "Ayarla";
                Ortak.Depo_Komut["Ayarlar", 0] = Kendi.Klasörü + "\\Ayarlar.mup";
            }

            Ortak.Depo_Ayarlar = new Depo_(File.Exists(Ortak.Depo_Komut["Ayarlar", 0]) ? File.ReadAllText(Ortak.Depo_Komut["Ayarlar", 0]) : null);

            if (Ortak.Depo_Komut["Komut", 0] == "Dosyaya Kaydet")
            {
                string snç = null;
                try
                {
                    if (!Dosya.Sil(Ortak.Depo_Komut["Komut", 1])) throw new System.Exception("Dosya bir uygulama içinde açık olduğundan silinemedi." + System.Environment.NewLine + Ortak.Depo_Komut["Komut", 1]);

                    if (!System.String.IsNullOrWhiteSpace(Ortak.Depo_Komut["Güncel İçerik", 0])) Ortak.Depo_Ayarlar["Detaylar/İçerik", 0] = Ortak.Depo_Komut["Güncel İçerik", 0];

                    snç = Ortak.Üret(out System.Drawing.Image Resim);
                    if (Resim != null)
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(Ortak.Depo_Komut["Komut", 1]));
                        Resim.Save(Ortak.Depo_Komut["Komut", 1], System.Drawing.Imaging.ImageFormat.Png);
                    }
                    else snç += System.Environment.NewLine + "Resim üretilmedi";
                }
                catch (System.Exception ex)
                {
                    snç += ex.Message;
                }

                if (!System.String.IsNullOrEmpty(snç)) File.WriteAllText(Kendi.Klasörü + "\\Hatalar.txt", snç);
                else if (File.Exists(Kendi.Klasörü + "\\Hatalar.txt")) File.Delete(Kendi.Klasörü + "\\Hatalar.txt");
                return;
            }

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new AnaEkran());
        }
    }
}
