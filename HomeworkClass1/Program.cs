using System;

namespace HomeworkClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductId = 1;
            product1.ProductName = "Hp Smart Yazıcı";
            product1.UnitPrice = 5777;
            product1.Discount = 100;
            product1.StockQuantity = 250;


            Product product2 = new Product();
            product2.ProductId = 2;
            product2.ProductName = "Epson l210";
            product2.UnitPrice = 2399;
            product2.Discount = 150;
            product2.StockQuantity = 150;


            Product product3 = new Product();
            product3.ProductId = 3;
            product3.ProductName = "Canon G177";
            product3.UnitPrice = 3349;
            product3.Discount = 130;
            product3.StockQuantity = 250;


            Product product4 = new Product();
            product4.ProductId = 4;
            product4.ProductName = "Brother MFC3930";
            product4.UnitPrice = 6500;
            product4.Discount = 500;
            product4.StockQuantity = 300;


            Product[] products = new Product[] { product1, product2, product3, product4 };

            Console.WriteLine("---------------for--------------");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün Id : " + products[i].ProductId + "    Ürün İsmi: " + products[i].ProductName);
            }

            Console.WriteLine("---------------foreach--------------");


            foreach (Product product in products)
            {
                Console.WriteLine("Ürün Id : " +product.ProductId + "    Ürün ismi :" + product.ProductName );
            }

            Console.WriteLine("---------------while--------------");

            int x = 0;
            while (x < products.Length)
            {
                Console.WriteLine("Ürün Id : " + products[x].ProductId + "   Ürün ismi : " + products[x].ProductName);
                x++;
            }

        }
    }


    class Product {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float UnitPrice { get; set; }
        public int Discount { get; set; }
        public int StockQuantity { get; set; }



    }


}
