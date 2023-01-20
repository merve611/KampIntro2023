using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Metot injection
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendir.
            //
            
            krediManager.Hesapla();
            loggerService.Log();
            
        }


        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)     //Biden fazla kredi gönderebilir 
        {
            foreach (var kredi in krediler)     
            {   
                  kredi.Hesapla();          //Listedeki herbir kredinin hesabını yap
            }
        }

    }
}
