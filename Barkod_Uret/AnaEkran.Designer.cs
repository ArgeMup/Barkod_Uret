namespace Barkod_Uret
{
    partial class AnaEkran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.Tür = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Resim_Genişlik = new System.Windows.Forms.NumericUpDown();
            this.Resim_Yükseklik = new System.Windows.Forms.NumericUpDown();
            this.PURE_BARCODE = new System.Windows.Forms.CheckBox();
            this.İpUcu = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GS1_FORMAT = new System.Windows.Forms.CheckBox();
            this.Girdi = new System.Windows.Forms.TextBox();
            this.Hatalar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.KenarBoşluğu = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PDF417_ResimGörüntüOranı = new System.Windows.Forms.NumericUpDown();
            this.PDF417_GörüntüOranı = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ÇıktıŞekli = new System.Windows.Forms.ComboBox();
            this.AztecKatmanSayısı = new System.Windows.Forms.NumericUpDown();
            this.KarakterKodlama = new System.Windows.Forms.ComboBox();
            this.Barkod = new System.Windows.Forms.PictureBox();
            this.HataDüzeltme = new System.Windows.Forms.TextBox();
            this.Sığdır = new System.Windows.Forms.CheckBox();
            this.Kaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Resim_Genişlik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resim_Yükseklik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KenarBoşluğu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PDF417_ResimGörüntüOranı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AztecKatmanSayısı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barkod)).BeginInit();
            this.SuspendLayout();
            // 
            // Tür
            // 
            this.Tür.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tür.Location = new System.Drawing.Point(238, 12);
            this.Tür.Name = "Tür";
            this.Tür.Size = new System.Drawing.Size(190, 24);
            this.Tür.Sorted = true;
            this.Tür.TabIndex = 2;
            this.Tür.SelectedIndexChanged += new System.EventHandler(this.Ayar_Değişti);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tür";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resim Boyutları (piksel)";
            // 
            // Resim_Genişlik
            // 
            this.Resim_Genişlik.Location = new System.Drawing.Point(238, 42);
            this.Resim_Genişlik.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.Resim_Genişlik.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Resim_Genişlik.Name = "Resim_Genişlik";
            this.Resim_Genişlik.Size = new System.Drawing.Size(90, 22);
            this.Resim_Genişlik.TabIndex = 4;
            this.Resim_Genişlik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Resim_Genişlik.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.Resim_Genişlik.ValueChanged += new System.EventHandler(this.Ayar_Değişti);
            // 
            // Resim_Yükseklik
            // 
            this.Resim_Yükseklik.Location = new System.Drawing.Point(338, 42);
            this.Resim_Yükseklik.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.Resim_Yükseklik.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Resim_Yükseklik.Name = "Resim_Yükseklik";
            this.Resim_Yükseklik.Size = new System.Drawing.Size(90, 22);
            this.Resim_Yükseklik.TabIndex = 5;
            this.Resim_Yükseklik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Resim_Yükseklik.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.Resim_Yükseklik.ValueChanged += new System.EventHandler(this.Ayar_Değişti);
            // 
            // PURE_BARCODE
            // 
            this.PURE_BARCODE.AutoSize = true;
            this.PURE_BARCODE.Location = new System.Drawing.Point(15, 271);
            this.PURE_BARCODE.Name = "PURE_BARCODE";
            this.PURE_BARCODE.Size = new System.Drawing.Size(145, 20);
            this.PURE_BARCODE.TabIndex = 9;
            this.PURE_BARCODE.Text = "*PURE_BARCODE";
            this.İpUcu.SetToolTip(this.PURE_BARCODE, "Don\'t put the content string into the output image.");
            this.PURE_BARCODE.UseVisualStyleBackColor = true;
            this.PURE_BARCODE.CheckedChanged += new System.EventHandler(this.Ayar_Değişti);
            // 
            // İpUcu
            // 
            this.İpUcu.AutomaticDelay = 100;
            this.İpUcu.AutoPopDelay = 10000;
            this.İpUcu.InitialDelay = 100;
            this.İpUcu.IsBalloon = true;
            this.İpUcu.ReshowDelay = 20;
            this.İpUcu.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.İpUcu.ToolTipTitle = "Detaylar";
            this.İpUcu.UseAnimation = false;
            this.İpUcu.UseFading = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "*Hata Düzeltme";
            this.İpUcu.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "*PDF417 Resim Görüntü Oranı";
            this.İpUcu.SetToolTip(this.label7, "number of columns / number of rows");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "*Aztec Katman Sayısı";
            this.İpUcu.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // GS1_FORMAT
            // 
            this.GS1_FORMAT.AutoSize = true;
            this.GS1_FORMAT.Location = new System.Drawing.Point(238, 271);
            this.GS1_FORMAT.Name = "GS1_FORMAT";
            this.GS1_FORMAT.Size = new System.Drawing.Size(124, 20);
            this.GS1_FORMAT.TabIndex = 19;
            this.GS1_FORMAT.Text = "*GS1_FORMAT";
            this.İpUcu.SetToolTip(this.GS1_FORMAT, "Specifies whether the data should be encoded to the GS1 standard");
            this.GS1_FORMAT.UseVisualStyleBackColor = true;
            this.GS1_FORMAT.CheckedChanged += new System.EventHandler(this.Ayar_Değişti);
            // 
            // Girdi
            // 
            this.Girdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Girdi.Location = new System.Drawing.Point(15, 297);
            this.Girdi.Multiline = true;
            this.Girdi.Name = "Girdi";
            this.Girdi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Girdi.Size = new System.Drawing.Size(413, 64);
            this.Girdi.TabIndex = 25;
            this.İpUcu.SetToolTip(this.Girdi, "Girdi");
            this.Girdi.TextChanged += new System.EventHandler(this.Ayar_Değişti);
            // 
            // Hatalar
            // 
            this.Hatalar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Hatalar.Location = new System.Drawing.Point(15, 367);
            this.Hatalar.Multiline = true;
            this.Hatalar.Name = "Hatalar";
            this.Hatalar.ReadOnly = true;
            this.Hatalar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Hatalar.Size = new System.Drawing.Size(413, 62);
            this.Hatalar.TabIndex = 36;
            this.İpUcu.SetToolTip(this.Hatalar, "Hatalar");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Karakter Kodlama";
            // 
            // KenarBoşluğu
            // 
            this.KenarBoşluğu.Location = new System.Drawing.Point(238, 128);
            this.KenarBoşluğu.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.KenarBoşluğu.Name = "KenarBoşluğu";
            this.KenarBoşluğu.Size = new System.Drawing.Size(190, 22);
            this.KenarBoşluğu.TabIndex = 12;
            this.KenarBoşluğu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KenarBoşluğu.ValueChanged += new System.EventHandler(this.Ayar_Değişti);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kenar Boşluğu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "PDF417 Görüntü Oranı";
            // 
            // PDF417_ResimGörüntüOranı
            // 
            this.PDF417_ResimGörüntüOranı.DecimalPlaces = 2;
            this.PDF417_ResimGörüntüOranı.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PDF417_ResimGörüntüOranı.Location = new System.Drawing.Point(238, 215);
            this.PDF417_ResimGörüntüOranı.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.PDF417_ResimGörüntüOranı.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PDF417_ResimGörüntüOranı.Name = "PDF417_ResimGörüntüOranı";
            this.PDF417_ResimGörüntüOranı.Size = new System.Drawing.Size(190, 22);
            this.PDF417_ResimGörüntüOranı.TabIndex = 14;
            this.PDF417_ResimGörüntüOranı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PDF417_ResimGörüntüOranı.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.PDF417_ResimGörüntüOranı.ValueChanged += new System.EventHandler(this.Ayar_Değişti);
            // 
            // PDF417_GörüntüOranı
            // 
            this.PDF417_GörüntüOranı.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PDF417_GörüntüOranı.Location = new System.Drawing.Point(238, 186);
            this.PDF417_GörüntüOranı.Name = "PDF417_GörüntüOranı";
            this.PDF417_GörüntüOranı.Size = new System.Drawing.Size(190, 24);
            this.PDF417_GörüntüOranı.Sorted = true;
            this.PDF417_GörüntüOranı.TabIndex = 15;
            this.PDF417_GörüntüOranı.SelectedIndexChanged += new System.EventHandler(this.Ayar_Değişti);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Çıktı Şekli";
            // 
            // ÇıktıŞekli
            // 
            this.ÇıktıŞekli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ÇıktıŞekli.Location = new System.Drawing.Point(238, 156);
            this.ÇıktıŞekli.Name = "ÇıktıŞekli";
            this.ÇıktıŞekli.Size = new System.Drawing.Size(190, 24);
            this.ÇıktıŞekli.Sorted = true;
            this.ÇıktıŞekli.TabIndex = 17;
            this.ÇıktıŞekli.SelectedIndexChanged += new System.EventHandler(this.Ayar_Değişti);
            // 
            // AztecKatmanSayısı
            // 
            this.AztecKatmanSayısı.Location = new System.Drawing.Point(238, 243);
            this.AztecKatmanSayısı.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.AztecKatmanSayısı.Minimum = new decimal(new int[] {
            256,
            0,
            0,
            -2147483648});
            this.AztecKatmanSayısı.Name = "AztecKatmanSayısı";
            this.AztecKatmanSayısı.Size = new System.Drawing.Size(190, 22);
            this.AztecKatmanSayısı.TabIndex = 23;
            this.AztecKatmanSayısı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AztecKatmanSayısı.ValueChanged += new System.EventHandler(this.Ayar_Değişti);
            // 
            // KarakterKodlama
            // 
            this.KarakterKodlama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KarakterKodlama.Items.AddRange(new object[] {
            "ASCII",
            "UTF-8"});
            this.KarakterKodlama.Location = new System.Drawing.Point(238, 70);
            this.KarakterKodlama.Name = "KarakterKodlama";
            this.KarakterKodlama.Size = new System.Drawing.Size(120, 24);
            this.KarakterKodlama.Sorted = true;
            this.KarakterKodlama.TabIndex = 24;
            this.KarakterKodlama.SelectedIndexChanged += new System.EventHandler(this.Ayar_Değişti);
            // 
            // Barkod
            // 
            this.Barkod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Barkod.BackColor = System.Drawing.Color.Black;
            this.Barkod.Location = new System.Drawing.Point(434, 12);
            this.Barkod.Name = "Barkod";
            this.Barkod.Size = new System.Drawing.Size(436, 457);
            this.Barkod.TabIndex = 26;
            this.Barkod.TabStop = false;
            // 
            // HataDüzeltme
            // 
            this.HataDüzeltme.Location = new System.Drawing.Point(238, 100);
            this.HataDüzeltme.Name = "HataDüzeltme";
            this.HataDüzeltme.Size = new System.Drawing.Size(190, 22);
            this.HataDüzeltme.TabIndex = 27;
            this.HataDüzeltme.Text = "M";
            this.HataDüzeltme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HataDüzeltme.TextChanged += new System.EventHandler(this.Ayar_Değişti);
            // 
            // Sığdır
            // 
            this.Sığdır.AutoSize = true;
            this.Sığdır.Location = new System.Drawing.Point(364, 74);
            this.Sığdır.Name = "Sığdır";
            this.Sığdır.Size = new System.Drawing.Size(64, 20);
            this.Sığdır.TabIndex = 34;
            this.Sığdır.Text = "Sığdır";
            this.Sığdır.UseVisualStyleBackColor = true;
            this.Sığdır.CheckedChanged += new System.EventHandler(this.Sığdır_CheckedChanged);
            // 
            // Kaydet
            // 
            this.Kaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Kaydet.Enabled = false;
            this.Kaydet.Location = new System.Drawing.Point(15, 435);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(413, 34);
            this.Kaydet.TabIndex = 35;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 481);
            this.Controls.Add(this.Hatalar);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.Sığdır);
            this.Controls.Add(this.HataDüzeltme);
            this.Controls.Add(this.Barkod);
            this.Controls.Add(this.Girdi);
            this.Controls.Add(this.KarakterKodlama);
            this.Controls.Add(this.AztecKatmanSayısı);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GS1_FORMAT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ÇıktıŞekli);
            this.Controls.Add(this.PDF417_GörüntüOranı);
            this.Controls.Add(this.PDF417_ResimGörüntüOranı);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.KenarBoşluğu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PURE_BARCODE);
            this.Controls.Add(this.Resim_Yükseklik);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Resim_Genişlik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tür);
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaEkran_FormClosing);
            this.Shown += new System.EventHandler(this.AnaEkran_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Resim_Genişlik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resim_Yükseklik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KenarBoşluğu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PDF417_ResimGörüntüOranı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AztecKatmanSayısı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barkod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Tür;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Resim_Genişlik;
        private System.Windows.Forms.NumericUpDown Resim_Yükseklik;
        private System.Windows.Forms.CheckBox PURE_BARCODE;
        private System.Windows.Forms.ToolTip İpUcu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown KenarBoşluğu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown PDF417_ResimGörüntüOranı;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox PDF417_GörüntüOranı;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ÇıktıŞekli;
        private System.Windows.Forms.NumericUpDown AztecKatmanSayısı;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox GS1_FORMAT;
        private System.Windows.Forms.ComboBox KarakterKodlama;
        private System.Windows.Forms.TextBox Girdi;
        private System.Windows.Forms.PictureBox Barkod;
        private System.Windows.Forms.TextBox HataDüzeltme;
        private System.Windows.Forms.CheckBox Sığdır;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.TextBox Hatalar;
    }
}

