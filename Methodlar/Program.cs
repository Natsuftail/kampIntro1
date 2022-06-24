using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunadi = "elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };  // array kullanımı 

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elaması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir";

            Urun[] urunler = new Urun[] { urun1, urun2 };


            // type safe -- tip güvenli

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("---------------methodlar----------------");
            // instance - örnek
            //encapsulation 


            SepetManager sepetManager = new SepetManager();
            sepetManager.ekle(urun1);
            sepetManager.ekle(urun2);

            sepetManager.ekle2("Armut", "Yesil Armut", 12);
            sepetManager.ekle2("Elma", "Yesil Elma", 12);
            sepetManager.ekle2("Karpuz", "Yesil Karpuz", 12);




        }
    }
}
// Dont repeat yourself - DRY - Clean Code - Best Practice 