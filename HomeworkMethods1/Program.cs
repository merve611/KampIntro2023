using System;
using System.Linq;

namespace HomeworkMethods1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();

            //int result = Add2(2);
            //Ref keywordü aynı out keywordü gibi değer tipleri referans tiplerine çevirir, Farkı ref keywordünde number1 i mutlaka set etmiş olmak gerekiyor. Yani bir değerinin olması gerekiyor. Out un metodun içinde set edilmiş olması lazım. Onun dışında yerlerde set edilmesi bir anlam ifade etmez

            ///int number1 = 20;                           //Aşağıda number1 e 30 verdim fakat inr değer tip olduğu için değeri yine 20 dir. Ben değişmesini istersem ref keywordü ile verilen değeri almasını etkilenmesini sağlarım
            ///int number2 = 100;
            ///var result2 = Add3(ref number1, number2);

            ///Console.WriteLine(result2);
            ///Console.WriteLine(number1);

            ///Console.WriteLine();

            //Console.WriteLine(result);

            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,4,3));
            Console.WriteLine(Add4(2,3,5,9,7,1,6,5));
            Console.ReadLine();

        }



        //void; git şunu yap demek bi işlem yap - biyere bişey yaz- git biyere bir kayot yap
        static void Add()
        {
            Console.WriteLine("Added");

        }

        static int Add2(int number1, int number2 = 20)  //Metotlarda parametrelere değer atayarak default değer verebiliriz. Eğer fonksiyon çağırılırken parametre verilmezse tanımlanan default değerini alır
        {
            int result =  number1 + number2;
            return result;
        }

        static int Add3(ref int number1, int number2)       //ref keywordü değer tipleri referans tip olarak kullanmamızı sağlar. 
        {
            number1 = 30;
            return number1 + number2;

        }
        
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)      //Aynı ismi kullanıp farklı parametreler kullanırsan bir sıkıntı olmaz Buna Overloading -> metotların aşırı yüklenmesi denir.
        {
            return number1 * number2 * number3;
        }

        static int Add4(params int[] numbers)       //Params ile metodumuza aynı tipte istediğimiz kadar parametre gönderebileceğimiz anlamına geliyor. Params Metodun parametrelerinin son parametresi olmak zorunda 
        {
            return numbers.Sum();

        }

        
        //ref ve out keywordu değer tipleri referans tip yapmamızı sağlıyor. Farkları ise out keywordu başlangıçta değer istemezken (metot içerisinde kullanma şartı ile)
        //ref keyword unde değer atamak zorundayız.

    }
}
