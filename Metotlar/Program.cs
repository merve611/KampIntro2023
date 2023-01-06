using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";


            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürün Adı : " +urun.Adi  +  "  Ürün Fiyatı : " + urun.Fiyati + "  Ürün Aciklaması : " + urun.Aciklama );
            }

            Console.WriteLine("----------------------------");

            Console.WriteLine("----------------Metotlar--------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //Encapsulation (Kapsulleme): Örneğin bir fonksiyon yazdın ve buna parametlerini verdin. Parametre olarak verdiğin class Ürünlerin propertylerini barındıran bir class olsun 
            //Daha sonra senden urune başka bir property daha eklemeni istediler, tek yapman gereken urunun özelliklerini barındıran classa o özelliği eklemek
            //Bazı yazılımcılar direkt özellikleri metoda parametre olarak vermektedir. Bu yanlış. Bu şekilde yapılırsa fonksiyonun kullanıldığı her yeri tek tek bulup yeni parametre eklemek 
            //zorunda kalınılır ve büyük bir iş yükü oluşur. 
            //Kısacası ayrı ayrı yazacağın ve duzensiz olacak yapıyı bir kapsülün içine sokuyorsun.

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12,20);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,5);


        }
    }
}



//Metotlar tekrar tekrar kullanılabilirliği sağlayan bir ottam sunar
//Do not Repeat Yourself - Kendini Tekrar Etme  (DRY)