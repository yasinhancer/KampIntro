using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //BİRİNCİ KULLANIM
            Customer customer1 = new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };

            //İKİNCİ KULLANIM
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Doğan";
            customer3.LastName = "Hançer";
            customer3.City = "Sinop";
            
            //ÜÇÜNCÜ KULLANIM
            Customer customer2 = new Customer (2, "Yasin", "Hançer", "İstanbul");

            //ikinci kullanımda olduğu gibi kullanabilmek için, aşağıdaki customer sınıfı içinde açtığım 
            //constructor'dan verileri istiyorum
            //ancak, ayrıca constructor yazdığım için default olan (1.) constructor'ı kullanamıyorum.
            //bunu düzeltmek için ise, class içine yeni bir constructor açmam gerekiyor
            //NOT: 1. KULLANIM = 2. KULLANIM

            //üçüncü kullanımda, verileri yazdırabilmem için, aşağıda isimleri eşitliyorum.
            Console.WriteLine(customer2.FirstName);
        }


        static void Method(int id, string firstName,string lastName,string city) 
        { 
        
        }




    }

    class Customer
    {
        public Customer() //birinci (default) yapıyı kullanabilmek için açtığım constructor
        {

        }
        
        
        public Customer(int id, string firstName, string lastName, string city) //içinde değişkenleri eşitliyorum, ekrana yazdırabilmek için.
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
