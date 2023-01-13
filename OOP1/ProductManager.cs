using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager        //Manager, service gibi isimlendirmeler görürsen anlaki ürünle ilgili operasyonlar var bunun içinde : ekleme,güncelleme,silme
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

       
    }
}
