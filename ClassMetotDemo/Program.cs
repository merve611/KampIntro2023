using System;

namespace ClassMetotDemo 
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAd = "Merve";
            musteri1.MusteriSoyad = "ÇAKIROĞLU";
            musteri1.MusteriİletisimNo = 123456;


            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAd = "Emirhan";
            musteri2.MusteriSoyad = "AKKOYUNLU";
            musteri2.MusteriİletisimNo = 789456;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriAd = "Aleyna";
            musteri3.MusteriSoyad = "Şeref";
            musteri3.MusteriİletisimNo = 456321;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };



            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            musteriManager.Listele(musteri1);
            
            musteriManager.Listele(musteri3);

            musteriManager.Silme(musteri1);



          
        }
    }
}
