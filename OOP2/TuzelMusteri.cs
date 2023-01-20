using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Individual
    //Miras inheritance
    class TuzelMusteri:Musteri  //Tuzel musteri bir musteridir, Musteride olan özellikler artık tuzelde de gerçekte de vardır.
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
