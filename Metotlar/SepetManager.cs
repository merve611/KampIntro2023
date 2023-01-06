using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{   // Manager,service dal,dataacess,controller gibi ifadeler görürseniz bunlar bir operasyon tutuyor demektir. 
    // naming convention (isimlendirme kuralı) - Metotların Pascal case olarak yazılır
    


    class SepetManager
    {
        public void Ekle(Urun urun)     //Parametre ne işe yarar; Ekle( ) dediğinde ne ekliyotsun Urun ekliyorsun - Metodun imzasına göre fonksiyon çağırılır. 
        {
            Console.WriteLine("Tebrikler ! Sepete eklendi  " + urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyati, int stokAdeti)
        {
            Console.WriteLine("Tebrikler ! Sepete eklendi  " + urunAdi);
        }


    }
}





