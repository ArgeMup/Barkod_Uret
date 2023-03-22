using System;
using System.Windows.Forms;

namespace Barkod_Uret
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] Parametreler)
        {
            if (!System.IO.File.Exists(ArgeMup.HazirKod.Kendi.Klasörü + "\\zxing.dll")) System.IO.File.WriteAllBytes(ArgeMup.HazirKod.Kendi.Klasörü + "\\zxing.dll", Properties.Resources.zxing);

            if (Parametreler != null && Parametreler.Length > 0)
            {
                System.IO.Directory.SetCurrentDirectory(ArgeMup.HazirKod.Kendi.Klasörü);
                AnaEkran.Üret(Parametreler).Save("cikti.png", System.Drawing.Imaging.ImageFormat.Png);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new AnaEkran());
            }
        }
    }
}
