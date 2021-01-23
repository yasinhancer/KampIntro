//using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager // HER ZAMAN CLASS İSİMLERİ PASCALCASE ŞEKLİNDE YAZILIR!! PC: HER KELİMENİN İLK HARFİ BÜYÜK
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
