using ArgeMup.HazirKod;
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
        public AnaEkran()
        {
            InitializeComponent();

            Text = "ArGeMuP " + Kendi.Adı + " " + Kendi.Sürümü_Dosya;
            Icon = Properties.Resources.Barkod;

            Tür.Items.AddRange(string.Join("?", Enum.GetNames(typeof(BarcodeFormat))).Split('?')); Tür.Text = BarcodeFormat.QR_CODE.ToString();
            PDF417_GörüntüOranı.Items.AddRange(string.Join("?", Enum.GetNames(typeof(PDF417AspectRatio))).Split('?')); PDF417_GörüntüOranı.Text = PDF417AspectRatio.AUTO.ToString();
            ÇıktıŞekli.Items.AddRange(string.Join("?", Enum.GetNames(typeof(SymbolShapeHint))).Split('?')); ÇıktıŞekli.Text = SymbolShapeHint.FORCE_NONE.ToString();
            KarakterKodlama.Text = "ASCII";
        }
        private void AnaEkran_Shown(object sender, EventArgs e)
        {
            IDepo_Eleman Detaylar = Ortak.Depo_Ayarlar["Detaylar"];
            Tür.Text = Detaylar.Oku("Tür", BarcodeFormat.QR_CODE.ToString());
            Resim_Genişlik.Value = Detaylar.Oku_TamSayı("Resim Boyutu", 300, 0);
            Resim_Yükseklik.Value = Detaylar.Oku_TamSayı("Resim Boyutu", 300, 1);
            KarakterKodlama.Text = Detaylar.Oku("Karakter Kodlama", "ASCII");
            HataDüzeltme.Text = Detaylar.Oku("Hata Düzeltme", "M");
            KenarBoşluğu.Value = Detaylar.Oku_TamSayı("Kenar Boşluğu", 0);
            ÇıktıŞekli.Text = Detaylar.Oku("Çıktı Şekli", SymbolShapeHint.FORCE_NONE.ToString());
            PDF417_GörüntüOranı.Text = Detaylar.Oku("PDF417", PDF417AspectRatio.AUTO.ToString(), 0);
            PDF417_ResimGörüntüOranı.Value = (decimal)Detaylar.Oku_Sayı("PDF417", 3, 1);
            AztecKatmanSayısı.Value = Detaylar.Oku_TamSayı("AZTEC");
            PURE_BARCODE.Checked = Detaylar.Oku_Bit("PURE_BARCODE");
            GS1_FORMAT.Checked = Detaylar.Oku_Bit("GS1_FORMAT");
            Girdi.Text = "ArGeMuP";

            Ayar_Değişti(null, null);

            Kaydet.Enabled = false;
        }
        private void AnaEkran_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Kaydet.Enabled)
            {
                DialogResult dr = MessageBox.Show("Değişiklikleri kaydetmeden çıkmak istiyor musunuz?", Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        void Hata_Ekle(string Mesaj)
        {
            Hatalar.AppendText(Mesaj + Environment.NewLine);
            Hatalar.Select(Hatalar.Left, 0);

            if (Hatalar.Tag == null)
            {
                Hatalar.Tag = 0;
                Hatalar.BackColor = System.Drawing.Color.Bisque;
            }
            else
            {
                Hatalar.Tag = null;
                Hatalar.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void Sığdır_CheckedChanged(object sender, EventArgs e)
        {
            Barkod.SizeMode = Sığdır.Checked ? PictureBoxSizeMode.Zoom : PictureBoxSizeMode.Normal;
        }

        private void Ayar_Değişti(object sender, EventArgs e)
        {
            Kaydet.Enabled = true;

            if (string.IsNullOrEmpty(Girdi.Text)) return;

            IDepo_Eleman Detaylar = Ortak.Depo_Ayarlar["Detaylar"];
            Detaylar.Yaz("Tür", Tür.Text);
            Detaylar.Yaz("Resim Boyutu", (int)Resim_Genişlik.Value, 0);
            Detaylar.Yaz("Resim Boyutu", (int)Resim_Yükseklik.Value, 1);
            Detaylar.Yaz("Karakter Kodlama", KarakterKodlama.Text);
            Detaylar.Yaz("Hata Düzeltme", HataDüzeltme.Text);
            Detaylar.Yaz("Kenar Boşluğu", (int)KenarBoşluğu.Value);
            Detaylar.Yaz("Çıktı Şekli", ÇıktıŞekli.Text);
            Detaylar.Yaz("PDF417", PDF417_GörüntüOranı.Text, 0);
            Detaylar.Yaz("PDF417", (double)PDF417_ResimGörüntüOranı.Value, 1);
            Detaylar.Yaz("AZTEC", (int)AztecKatmanSayısı.Value);
            Detaylar.Yaz("PURE_BARCODE", PURE_BARCODE.Checked);
            Detaylar.Yaz("GS1_FORMAT", GS1_FORMAT.Checked);
            Detaylar.Yaz("İçerik", Girdi.Text);

            try
            {
                Hatalar.Text = Ortak.Üret(out System.Drawing.Image Resim);
                Barkod.Image?.Dispose();
                Barkod.Image = Resim;
                Hatalar.BackColor = SystemColors.Window;
            }
            catch (Exception ex)
            {
                Hata_Ekle(ex.Message);
            }
        }
        private void Kaydet_Click(object sender, EventArgs e)
        {
            Ortak.Depo_Ayarlar.Sil("Detaylar", true, true);
            Ayar_Değişti(null, null);

            Klasör.Oluştur(System.IO.Path.GetDirectoryName(Ortak.Depo_Komut["Ayarlar", 0]));
            System.IO.File.WriteAllText(Ortak.Depo_Komut["Ayarlar", 0], Ortak.Depo_Ayarlar.YazıyaDönüştür());

            Kaydet.Enabled = false;
        }
    }
}
