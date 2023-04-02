# Barkod_Uret
Genel amaçlı komut satırından barkod üretme uygulaması ArgeMup@yandex.com

## Thanks
Many thanks to the team of the [zxing.net project](https://https://github.com/micjahn/ZXing.Net) for their great work. Barkod_Uret would not be possible without your work!

Many thanks to the team of the [zxing project](https://github.com/zxing/zxing) for their great work. ZXing.Net would not be possible without your work!

    Komut satırından kullanım
        Seçenek 1 - Barkod_Uret.exe <Komut Verme Depo Dosyasının Yolu>
        Seçenek 2 - Barkod_Uret.exe <Komut Verme Depo Dosyası İçeriğinin Base64 Hali>
        Seçenek 3 - Barkod_Uret.exe YeniYazilimKontrolu                                  (Kontrolü bitirip kapanır)
        Seçenek 4 - Barkod_Uret.exe                                                      (Bu durumda değişiklikleri kendi alt klasörüne kaydeder)

    Komut Verme Depo Dosyası İçeriği
        Komut / Ayarla VEYA
        Komut / Dosyaya Kaydet / Dosya adı
        Ayarlar / <Ayarlar Depo Dosya Yolu>
        Güncel İçerik / Yazdırılacak Bilgi

    Ayarlar Depo Dosyası İçeriği
        Detaylar
            Tür / (BarcodeFormat)
            Resim Boyutu (piksel) / Genişlik / Yükseklik
            Karakter Kodlama / ASCII veya UTF-8
            Hata Düzeltme / (ERROR_CORRECTION)
            Kenar Boşluğu / (MARGIN)
            Çıktı Şekli / (DATA_MATRIX_SHAPE)
            PDF417 / (PDF417_ASPECT_RATIO) / (PDF417_IMAGE_ASPECT_RATIO)
            AZTEC / (AZTEC_LAYERS)
            PURE_BARCODE / bit
            GS1_FORMAT / bit
            İçerik / Yazdırılacak Bilgi