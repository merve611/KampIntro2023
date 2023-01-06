using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, decimal, float, double, bool => bunlara biz değer tip diyoruz. Sadece Stack de iş yapar
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            //sayi1 ?? 30

            //array, class, interface => bunlar referans tip olarak çıkar. Stack ta tanımlanan değişken new dediğin anda Heap te yeni bir alan oluştur ve değerleri oraya yaz.
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;        //sayilar1 in referans numarası = sayilar2 nin referans numarasına

            sayilar2[0] = 999;

            //sayilar[0] ?? 999

            //NOT : DEĞER TİPLERDE DEĞER ATIYOSUN, REFERANS TİPLERDE REFERANSI ATIYORSUN.


        }
    }
}
