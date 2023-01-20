using System;

namespace HomeworkReferancesTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int,decimal,float,enum,boolean -> value types - değer tipterle ilgili herşey sadece Stack te oluşur
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;
            //sayi2 = 100;

            //Console.WriteLine("Sayi 1 : "+ sayi1);      //20


            ////arrays, class,interface, -> referances types - referans tipleride stack ın yanı sıra belleğin diğer bölümü heap de devreye giriyor
            //int[] sayilar1 = new int[] {1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;
            
            //Console.WriteLine("Sayilar1[0] = " +sayilar1[0]) ;  //1000

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1;
            person1.FirstName = "Derin";

            //Console.WriteLine(person2.FirstName);



     
            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "12234566210";
            
            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer;      //Base sınıfa onu inherite eden sınıfların referansını atayabilirsiniz.Aslında person3 aslında yine customer ın adresini tutuyor
            customer.FirstName = "Ahmet";


            //Console.WriteLine(((Customer)person3).CreditCardNumber);   //person3' e customer boxing'i yap. Genel bir parantez içine alıyorum ki ona . dediğimde artık customer da olan kredi kartı numarasına erişebilirsniz

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    //Person customer ında employee nın de adresini tutabiliyor.

    class Customer:Person       //Miras aldığınız sinifa(person) sınıf türünde bir şeye gidipte mirası alan sınıdı atıyabilirsiniz. Person : base (temel class)
    {
        public String CreditCardNumber { get; set; }

    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager     
    {   
        public void Add(Person person)      //Bu sayede ben yazılımda aynı kodu farklı nesneler için çalıştırabilmeme imkan sağlıyor
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
