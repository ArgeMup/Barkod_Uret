using ArgeMup.HazirKod.Ekİşlemler;
using System;
using System.Drawing;
using System.Windows.Forms;

using ZXing;
using ZXing.Common;
using ZXing.Datamatrix.Encoder;
using ZXing.PDF417.Internal;

namespace Barkod_Uret
{
    public partial class AnaEkran : Form
    {
        public static string[] Parametreler = null;

        public AnaEkran()
        {
            InitializeComponent();

            Tür.Items.AddRange(string.Join("?", Enum.GetNames(typeof(BarcodeFormat))).Split('?')); Tür.Text = BarcodeFormat.QR_CODE.ToString();
            PDF417_GörüntüOranı.Items.AddRange(string.Join("?", Enum.GetNames(typeof(PDF417AspectRatio))).Split('?')); PDF417_GörüntüOranı.Text = PDF417AspectRatio.AUTO.ToString();
            ÇıktıŞekli.Items.AddRange(string.Join("?", Enum.GetNames(typeof(SymbolShapeHint))).Split('?')); ÇıktıŞekli.Text = SymbolShapeHint.FORCE_NONE.ToString();
            KarakterKodlama.Text = "ASCII";
        }
        private void AnaEkran_Shown(object sender, EventArgs e)
        {
            Girdi.Text = "ArGeMuP";

            Ayar_Değişti(null, null);
        }
        private void Ayar_Değişti(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Girdi.Text)) return;

            try
            {
                string[] Parametreler = new string[]
                {
                    Tür.Text,
                    Resim_Genişlik.Value.ToString(),
                    Resim_Yükseklik.Value.ToString(),
                    KarakterKodlama.Text,
                    HataDüzeltme.Text,
                    KenarBoşluğu.Value.ToString(),
                    ÇıktıŞekli.Text,
                    PDF417_GörüntüOranı.Text,
                    PDF417_ResimGörüntüOranı.Value.ToString(),
                    AztecKatmanSayısı.Value.ToString(),
                    PURE_BARCODE.Checked ? "E" : "H",
                    GS1_FORMAT.Checked ? "E" : "H",
                    Girdi.Text
                };

                Image çıktı = Üret(Parametreler);
                if (Barkod.Image != null) Barkod.Image.Dispose();
                Barkod.Image = çıktı;

                Parametre_İzleme.Text = string.Join(" ", Parametreler).Trim();
            }
            catch (Exception ex)
            {
                Parametre_İzleme.Text = ex.Message;
            }
        }

        public static Image Üret(string[] Parametreler)
        {
            var barcodeWriter = new BarcodeWriter();
            string mesaj = "";
            try
            {
                barcodeWriter.Format = (BarcodeFormat)Enum.Parse(typeof(BarcodeFormat), Parametreler[0], false);
                barcodeWriter.Options = new EncodingOptions
                {
                    Width = int.Parse(Parametreler[1]),
                    Height = int.Parse(Parametreler[2])
                };


                if (Parametreler[3] != "ASCII")
                {
                    barcodeWriter.Options.Hints[EncodeHintType.CHARACTER_SET] = "UTF-8";
                    barcodeWriter.Options.Hints[EncodeHintType.DISABLE_ECI] = true;
                    barcodeWriter.Options.Hints[EncodeHintType.PDF417_AUTO_ECI] = false;
                }

                barcodeWriter.Options.Hints[EncodeHintType.ERROR_CORRECTION] = Parametreler[4];
                barcodeWriter.Options.Hints[EncodeHintType.MARGIN] = int.Parse(Parametreler[5]);
                barcodeWriter.Options.Hints[EncodeHintType.DATA_MATRIX_SHAPE] = (SymbolShapeHint)Enum.Parse(typeof(SymbolShapeHint), Parametreler[6], false);

                barcodeWriter.Options.Hints[EncodeHintType.PDF417_ASPECT_RATIO] = (PDF417AspectRatio)Enum.Parse(typeof(PDF417AspectRatio), Parametreler[7], false);
                barcodeWriter.Options.Hints[EncodeHintType.PDF417_IMAGE_ASPECT_RATIO] = float.Parse(Parametreler[8]);
                barcodeWriter.Options.Hints[EncodeHintType.AZTEC_LAYERS] = int.Parse(Parametreler[9]);

                barcodeWriter.Options.Hints[EncodeHintType.PURE_BARCODE] = Parametreler[10] == "E";
                barcodeWriter.Options.Hints[EncodeHintType.GS1_FORMAT] = Parametreler[11] == "E";

                for (int i = 12; i < Parametreler.Length; i++)
                {
                    mesaj += Parametreler[i] + " ";
                }
                mesaj = mesaj.Trim();

                if (mesaj.StartsWith("0x")) mesaj = mesaj.BaytDizisine_HexYazıdan().Yazıya();
            }
            catch (Exception) { throw new Exception("Parametreleri kontrol ediniz");}
            
            return barcodeWriter.Write(mesaj);
        }
    }
}
