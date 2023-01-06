using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    //Class isimlendirmeleri Pascal Case dediğimiz kelimelerin ilk harfleri büyük olarak yazılır
    //Ortak kodları classların içine yazarız. 
    class Urun
    {

        //Property - özellik 
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdeti { get; set; }

    }
}
