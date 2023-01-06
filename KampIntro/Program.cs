using System;
//.NET Framework sadece C# ve Windows ortamında çalışıyorken, .NET Core C#, Windows, Linux , Macos gibi ortamların hespinde çalışır. Biz .Net Core üzerinden gidiyoruz.
namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği 
            //Do not repeat yourself - Kendini tekrarlama 
            //değer tutucu , alias
           
            
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;                 //int tam sayıları tutar
            double faizOranı = 1.45;
            bool sistemeGirisYapmismi = false;          //Bu bir veri kaynağından gelen veridir. Gerçek hayatta örneğin web uygulamasıysa catch e bakar, mobil uygulamaysa bellekte o değere bakar vb..
            double dolarınDun = 7.55;
            double dolarBugun = 7.45;


            if (dolarınDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarınDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }


           
            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);

            Console.WriteLine(kategoriEtiketi);




        }
    }
}
