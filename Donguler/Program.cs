using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için Temel Kurs";
            string kurs3 = "Java";

           

            //Liste formatında göstermek istediğiniz verilerinizi bu tarz string-integer değişkenlerle değilde, dizilerle(array) tanımlarız.

            string[] kurslar = new string[] { "Yazılım geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için Temel Kurs","Java", "Python"};    
            
            //Döngüler birşeyleri tekrar etmek için kullanılan yapılardır.

            for (int i = 1; i <kurslar.Length; i++)         //kurs ne kadar elemana sahip ise length onu verir
            {
                Console.WriteLine(kurslar[i]);      //Kursların i. elemanı
            }
            Console.WriteLine("--------For bitti----------");

            foreach (string kurs in kurslar)            //foreach dizi temelli yapıları tek tek dönmeye yarar --- kurslar'i tek tek dolaş, kurs:alias her bir elemana isim veriyoruz
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu  -  footer");

        }
    }
}
