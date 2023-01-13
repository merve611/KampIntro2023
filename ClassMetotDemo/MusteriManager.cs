using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler ! Müşteri Eklenidi : " +musteri.MusteriAd);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(" Müşteri Listesine eriştiniz :");
            Console.WriteLine(musteri.MusteriAd );
            Console.WriteLine(musteri.MusteriSoyad);
            Console.WriteLine(musteri.MusteriId);

        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " ismli müşteri silindi");
        }
        
    }
}
