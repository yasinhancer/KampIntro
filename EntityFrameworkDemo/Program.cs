using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ORM : Object Relational Mapping
            //Entity Framework > bir ORM'dir
            //NHibernate > Entity F alternatifi
            //Dapper > Entity F alternatifi

            //GetAll();
            GetProductsByCategory(1); //1 numaralı kategorideki ürünleri istedim

            Console.ReadLine();
        }

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();
            foreach (var item in northwindContext.Products)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void GetProductsByCategory(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();
            var result = northwindContext.Products.Where(p => p.CategoryId == categoryId); //şarta uyanları liste haline getirir

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
