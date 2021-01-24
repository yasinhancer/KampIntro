using System;

namespace ReferenceAndValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //VALUE TYPES - DEĞER TİPLER >>> 'DEĞER EŞİTLEMESİ YAPILIR'
            //int, decimal, float, enum, boolean = value types / değer tipler
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;  // burada sayı1=20 oldu. ancak bir sonraki değişmeden etkilenmez.

            sayi2 = 100; //bu değişim sadece sayi2 için etkili oldu, sayi1 hala 20...

            //dolayısıyla değer tiplerin sadece o anki değeri değişir, sonraki değişmelerden etkilenmez..
            //yani değer tipler birbirinin kopyasını alır, sonraki değişmeden etkilenmez.

            //REFERENCE TYPES - REFERANS TİPLER >>> 'ADRES EŞİTLEMESİ YAPILIR'

            //arrays, classes, interface... = reference types / referans tiplerdir.

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2; //sayilar1'in adresini sayilar2'nin adresine eşitle demektir.
            sayilar2[0] = 1000;

            Console.WriteLine("sayilar1[0] = " + sayilar1[0]); //sonuç 1000 olur. Çünkü;

            //REFERANS tiplerde adres vardır.  
            //Burada { 1, 2, 3 } kümesinin adres kodu 101 olsun.
            //{ 10, 20, 30 } bu kümenin de adres kodu 102 olsun.
            //sayilar1 { 1, 2, 3 } 101 nolu adrese eşit durumda.
            //aynı mantıkla sayilar2 de { 10, 20, 30 } 102 nolu adrese eşit durumda.
            //sayilar1 = sayilar2 dediğimde, sayilar1'in gideceği adres artık 101 değil 102 oldu.
            //bundan dolayı 102 nolu adreste bir değişiklik yapıldığında, 
            //sayilar1 de sayilar2 de o adrese gittiği için, ikisi de etkilenir.

            //yani sonuç olarak sayilar1[0] ve sayilar2[0] eşit ve 1000 olur.


            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person2 = person1;
            person1.FirstName = "Derin";
            Console.WriteLine(person2.FirstName); //görüldüğü üzre referans tipten dolayı person2 de değişti.


            //mirası aldığım sınıfa, mirası alan kişiyi atayabilirim. aşağıdaki gibi;
            Customer customer = new Customer();
            Person person3 = customer; //bu şekilde bir eşitleme yapılabilir, sorun olmaz.
            customer.FirstName = "Yasin";
            Console.WriteLine(person3.FirstName);

            //ANCAK person'ı miras alan farklı 2 sınıfı birbirine eşitleyemem! aşağıdaki gibi;
            //Employee deneme = customer; HATALI KOD

            customer.CreditCardNumber = "1234567890";

            Console.WriteLine(((Customer)person3).CreditCardNumber);
            //BOXING işlemi, person3'ü customer içine aldım ve veriye ulaştım. 
            //kredi kartı numarası customer sınıfı üzerinden verildiği için boxing yaptım.

            Employee employee = new Employee();
            employee.FirstName = "Veli";

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
            //base sınıf olan person sayesinde, employee ve customer'ı da burada kullanabiliyorum.
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    //customer ve employee için inheritance yaptık. dolayısıyla person içindeki özellikleri ikisi de içerdi.

    class PersonManager
    {
        public void Add(Person person)  //hem customer hem employee içersin diye ikisinin base'i olan person istedim.
        {
            Console.WriteLine(person.FirstName);
        }
    }





}
