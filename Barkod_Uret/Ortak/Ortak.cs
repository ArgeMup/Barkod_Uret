using ArgeMup.HazirKod;
using System;
using ZXing.Common;
using ZXing.Datamatrix.Encoder;
using ZXing.PDF417.Internal;
using ZXing;
using System.Drawing;

namespace Barkod_Uret
{
    public static class Ortak
    {
        public static Depo_ Depo_Komut = null, Depo_Ayarlar = null;
        public static YeniYazılımKontrolü_ YeniYazılımKontrolü;

        public static string Üret(out Image Resim)
        {
            Resim = null;
            IDepo_Eleman Detaylar = Depo_Ayarlar["Detaylar"];
            BarcodeWriter barcodeWriter = new BarcodeWriter();

            try
            {
                barcodeWriter.Format = (BarcodeFormat)Enum.Parse(typeof(BarcodeFormat), Detaylar.Oku("Tür", BarcodeFormat.QR_CODE.ToString()));
                barcodeWriter.Options = new EncodingOptions
                {
                    Width = Detaylar.Oku_TamSayı("Resim Boyutu", 300, 0),
                    Height = Detaylar.Oku_TamSayı("Resim Boyutu", 300, 1)
                };

                if (Detaylar.Oku("Karakter Kodlama", "ASCII") != "ASCII")
                {
                    barcodeWriter.Options.Hints[EncodeHintType.CHARACTER_SET] = "UTF-8";
                    barcodeWriter.Options.Hints[EncodeHintType.DISABLE_ECI] = true;
                    barcodeWriter.Options.Hints[EncodeHintType.PDF417_AUTO_ECI] = false;
                }

                barcodeWriter.Options.Hints[EncodeHintType.ERROR_CORRECTION] = Detaylar.Oku("Hata Düzeltme", "M");
                barcodeWriter.Options.Hints[EncodeHintType.MARGIN] = Detaylar.Oku_TamSayı("Kenar Boşluğu", 0);
                barcodeWriter.Options.Hints[EncodeHintType.DATA_MATRIX_SHAPE] = (SymbolShapeHint)Enum.Parse(typeof(SymbolShapeHint), Detaylar.Oku("Çıktı Şekli", SymbolShapeHint.FORCE_NONE.ToString()), false);

                barcodeWriter.Options.Hints[EncodeHintType.PDF417_ASPECT_RATIO] = (PDF417AspectRatio)Enum.Parse(typeof(PDF417AspectRatio), Detaylar.Oku("PDF417", PDF417AspectRatio.AUTO.ToString(), 0), false);
                barcodeWriter.Options.Hints[EncodeHintType.PDF417_IMAGE_ASPECT_RATIO] = (float)Detaylar.Oku_Sayı("PDF417", 3, 1);
                barcodeWriter.Options.Hints[EncodeHintType.AZTEC_LAYERS] = Detaylar.Oku_TamSayı("AZTEC");

                barcodeWriter.Options.Hints[EncodeHintType.PURE_BARCODE] = Detaylar.Oku_Bit("PURE_BARCODE");
                barcodeWriter.Options.Hints[EncodeHintType.GS1_FORMAT] = Detaylar.Oku_Bit("GS1_FORMAT");
            }
            catch (Exception) { return "Parametreleri kontrol ediniz"; }

            Resim = barcodeWriter.Write(Detaylar.Oku("İçerik", "ArGeMuP"));
            return null;
        }
    }
}
