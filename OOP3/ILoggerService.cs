using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Artık genelde ınterfacelere service yazacağız

    //İnterface içinde sadece imza metodları olur içi dolu olamaz.
    //Loglamanın birden fazla alternatifi sunulur; hem veritabanına logla hemde müşteriye sms at
    interface ILoggerService
    {
        //Şablonum loglama yapmak
        void Log();
    }
}
