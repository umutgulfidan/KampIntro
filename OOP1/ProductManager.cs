using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        // int id , string productName gibi bir sürü parametre yollamak yerine tüm bunları içeren producti yolladık --> encapsulation
        public void Add(Product product)
        {
            Console.WriteLine("Ürün Eklendi: "+product.ProductName);
        }

    }
}
