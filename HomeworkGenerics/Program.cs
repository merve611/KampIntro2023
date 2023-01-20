using System;
using System.Collections.Generic;

namespace HomeworkGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Genericlerle hangi tipi verirseniz içindeki operasyonlar Add gibi parametre olarak o tipte vermemiz gerekiyor. String ise string tipinde
            List<string> sehirler = new List<string>();
            sehirler.Add("Trabzon");
            sehirler.Add("Trabzon");
            sehirler.Add("Trabzon");
            sehirler.Add("Trabzon");
            Console.WriteLine(sehirler.Count);


            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Trabzon");
            sehirler2.Add("Trabzon");
            sehirler2.Add("Trabzon");
            sehirler2.Add("Trabzon");
            sehirler2.Add("Trabzon");
            Console.WriteLine(sehirler2.Count);
        }
    }
    class MyList<T>     //Generic class
    {
        T[] _array;
        T[] _tempArray; //geçici array
        public MyList()
        {
            _array = new T[0];  //0 elemanlı bir array
        }

        public void Add(T item)     //T hangi tipi verirseniz ona dönüşüyor.
        {
            _tempArray = _array;    //temparray array ın referansını tutuyor
            _array = new T[_array.Length + 1];    //eleman sayısını 1 artırdım
            for (int  i = 0;  i <_tempArray.Length;  i++)
            {
                _array[i] = _tempArray[i];      //yeni newlenip oluşturulan array referansına eski değerler yükleniyor
            }
            _array[_array.Length - 1] = item;   //eklenen elemanı dizinin son eleman yerine ekle. 
        }
        
        
        public int Count               //propfull e tab tab yaptığımda bu oluştu;
        {
            get { return _array.Length; }       //MyList in count unu çağırırsam o aslında array ın eleman sayısını veriyor
           
        }


    }
}
