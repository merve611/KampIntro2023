using System;

namespace HomeworkMyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> sehirler = new MyDictionary<int, string>();

            sehirler.Add(61, "Trabzon");
            Console.WriteLine(sehirler.Count);

            sehirler.Add(34, "İstanbul");
            sehirler.Add(69, "Bayburt");
            sehirler.Add(25, "Erzurum");


            for (int i = 0; i < sehirler.Count; i++)
            {
                Console.WriteLine("Plaka Kodu: "+ " " + "Şehir adı : " + sehirler.Values[i]);
            }

            sehirler.GetList();

        }
    }
}
