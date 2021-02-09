using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace LinqFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1,CategoryName = "Bilgisayar"},
                new Category{CategoryId = 2,CategoryName = "Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId = 1,CategoryId = 1,ProductName = "Acer Leptop",QuantityPerUnit = "32 GB RAM",UnitPrice = 10000,UnitsInStock = 5},
                new Product{ProductId = 2,CategoryId = 1,ProductName = "Asus Leptop",QuantityPerUnit = "16 GB RAM",UnitPrice = 8000,UnitsInStock = 3},
                new Product{ProductId = 3,CategoryId = 1,ProductName = "HP Leptop",QuantityPerUnit = "8 GB RAM",UnitPrice = 6000,UnitsInStock = 2},
                new Product{ProductId = 4,CategoryId = 2,ProductName = "Samsung Telefon",QuantityPerUnit = "4 GB RAM",UnitPrice = 5000,UnitsInStock = 15},
                new Product{ProductId = 5,CategoryId = 2,ProductName = "Apple Telefon",QuantityPerUnit = "4 GB RAM",UnitPrice = 8000,UnitsInStock = 0},
            };

            //ClassicLinqTest(products);

            //JOIN OPERASYONLARI

            var result = from p in products
                         join c in categories
                             on p.CategoryId equals c.CategoryId
                             orderby p.ProductName  
                         select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            //join operasyonunu kullanmak amacıyla oluşturduğum Dto classındaki propları, iki tabloyu birleştirdikten sonra, sonuçlara eşitledim.
            foreach (var productDto in result)
            {
                Console.WriteLine(productDto.ProductName + "-" + productDto.CategoryName);
            }
            //bu şekilde join operasyonu kullanarak iki farklı tablodaki verileri bir yerde kullanabildim.
            
            //STRING INTERPOLATION
            foreach (var itemDto in result)
            {
                //string ifade 0. ve 1. index anlamındadır, virgülden sonra sırasıyla 0. ve 1. indexi yazarız
                Console.WriteLine("{0} --- {1}", itemDto.ProductName,itemDto.CategoryName); //üstteki ile aynı sonucu verir
            }














            Console.ReadLine();
        }

        private static void ClassicLinqTest(List<Product> products)
        {
            //FUNCTIONS
            Console.WriteLine(
                "************************************* FUNCTIONS **************************************************");
            //ANY > VAR MI YOK MU
            var aresult =
                products.Any(p => p.ProductName == "Acer Leptop"); //bu kullanımda listede 'Acer Leptop' var mı kontrol eder
            //sonuç olarak bool döndürür.
            Console.WriteLine(aresult);
            Console.WriteLine(
                "**************************************************************************************************");

            //FIND: SONUÇ OLARAK ARADIĞIM KRİTERE UYGUN NESNEYİ DÖNDÜRÜR
            var fresult = products.Find(p => p.ProductId == 3); //productId'si 3 olan nesneyi döndürür
            Console.WriteLine(fresult.ProductName); //hiç olmayan bir ürün bulunmaya çalışılırsa null döner
            Console.WriteLine(
                "**************************************************************************************************");

            //FINDALL: SONUÇ OLARAK ŞARTA UYAN TÜM NESNELERİ LİSTE OLARAK DÖNDÜRÜR - YERİNE WHERE KULLANILABİLİR
            var faresult = products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(faresult); //bir generic list döndürür
            Console.WriteLine(
                "**************************************************************************************************");

            //WHERE: ŞARTA UYANLARI BİR LİSTE HALİNE GETİRİR
            var wresult = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice)
                .ThenByDescending(p => p.ProductName);
            // order by eklenip sıralanabilir, then by ise orderby için değerleri aynı olanları kendi aralarında sıralamak için kullanılır
            foreach (var product in wresult)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine(
                "**************************************************************************************************");

            //aşağıdaki şekilde de şartlandırılabilir ve yine liste oluşur
            var result = from p in products
                         where p.UnitPrice >= 6000
                         orderby p.UnitPrice
                         select p.ProductName;
            //oluşan listeyi gezebilirim
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(
                "**************************************************************************************************");
        }
    }

    //DTO: DATA TRANSFORMATION OBJECT
    class ProductDto
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
