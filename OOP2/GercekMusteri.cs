using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate
    class GercekMusteri :Musteri    //Gerçek musteri de bir musteridir
    {
       
        public string Adi { get; set; }     //Eğerki bir nesne de bir değeri kullanmak zorundaki gibi görünmüyorsa o nesneye ait değilmiş gibi duruyorsa demekki orada soyutlama hatası yapıyorsun deriz
        public string Soyadi { get; set; }
        public string TcNo { get; set; }        //bir veri üzerinde matematiksel işlem yapmıyorsan (çarpmıyorsan,bölmüyorsan) bunlar metinsel olarak planlanırsa daha iyi sonuç alınır.
    }
}
