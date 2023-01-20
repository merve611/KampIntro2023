using System;

namespace HomeworkConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor: Bir clası newlediğimiz zaman çalışan bloktur. Yapıcı Blok. Bir kere çalışır
            Customer customer1 = new Customer { Id=1, FirstName="Engin", LastName="Demiroğ",City = "Ankara"};     //new dediğin esnada constructor çalışır

            Customer customer3 = new Customer();
            customer3.Id = 3;

            Customer customer2 = new Customer (2, "Derin", "Demiroğ", "Ankara" );

            Console.WriteLine(customer2.FirstName);
           
        }

        
    }

    class Customer
    {
        public Customer()       //Parametreli contructor - customer1 burdan çalışır
        {

        }
        public Customer(int id, string firstName, string lastName, string city)         //Parametreli constructor - customer2 burdan çalışır
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
