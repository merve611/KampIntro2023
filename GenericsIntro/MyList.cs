using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>     //MyList imde T ile çalışacağım, Bana bit tip ver aşayı ona göre yapılandıracağım.
    {
        T[] items;

        //Bir class new lendiğinde çalışan bloğa constructor denir.
        //ctor yazip tab-tab yaptığımda aşağıdaki constructor metodu oluşur. MyList i biryerde new'lersem bu otomatik çalışır.
        public MyList()   
        {
            items = new T[0];       //Array'i oluşturdun ve sıfır elemanlı olarak verdin
        }
        
        public void Add(T item)                //item = eleman
        {
            T[] tempArray = items;                  //tempArray = geçici dizi -- geçici dizinin referansı = ıtemsın referansı 
            items = new T[items.Length + 1];        //Dizinin eleman sayısını bir artırıyorum

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];        //Benim ıtems'ımın i. elemanı = tempArray den gelen i. eleman. Yani emaneten verdiğim değerleri sırasıyla kendi üzerime yeni alıyorum
            }
            items[items.Length - 1] = item;         //items dizisinin son elemanı = item Yani eklenmek istenen eleman dizinin son eleman yerine eklendi. 
        }

           

    }
}
