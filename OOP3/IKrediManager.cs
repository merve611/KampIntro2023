using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{   //interface ; Eğerki birisi bu interfaceyi kullanırsa o arkadaş bu metodu kullanmak zorunda 
    //Başına I koyarak interface olduğunu anlarız
    //Interfacelerı genelde operasyonlarda kullanırız
    //interface ler new lenemez
    //Interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.

    interface IKrediManager          //KrediManager base görevi görür, bu tip imzanın aynı olduğu içeriğinin farklı olduğu durumlarda biz base de oluşturduğumuz classı interface olarak oluştururuz.
    {
        void Hesapla();

        void BiseyYap();

    }
}


//Loglama : kim ne zaman hangi operasyonu çağırdı yani bir nevi o sistemde olan haraketleri döktüğümüz bir dökümdür.
//Loglama : Loglarınızı bir dosyada tutabilirsiniz, Loglarınızı veri tabanında tutabilirsiniiz, loglarınızı sms olarak atabilirsiniz (örn: biri bir krediye başvuru yaptığında sms gitmesi)
//Hepsi logluyor hepsinin imzası aynı 