using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program //öncelikle System.Collections.Generic kütüphanesini ekliyoruz.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLAKA KODU İLE ŞEHİR SORGULAMA");
           
            //sözlükler, KEY ve VALUE lardan oluşur. her keye karşılık gelen bir value vardır.
            //value lara erişmek için keyleri kullanırız.

            //aşağıda ilk sırada key veri tipi, ikinci sırada ise value veri tipini yazdım ve sözlüğü oluşturdum.

            Dictionary<int, string> Sehir = new Dictionary<int, string>();

            Sehir.Add(01, "Adana");
            Sehir.Add(07, "Antalya");
            Sehir.Add(34, "İstanbul");
            Sehir.Add(35, "İzmir");
            Sehir.Add(57, "Sinop");
            //bu şekilde sırasıyla key ve ona karşılık gelen value değerlerini, olması gerektiği tipte ekledik. 

            Console.WriteLine("Plaka NO Giriniz: ");
            int PlakaNo = int.Parse(Console.ReadLine());

            
            //aşağıda yazdığım kodlar sayesinde, aranan key mevcut ise ona karşılık gelen değeri yazdırttım.
            //key mevcut olmayan durumlar için de şehir bulunamadı dedim.
            try
            {
                Console.WriteLine(PlakaNo + " plaka kodu " + Sehir[PlakaNo] + " şehrine aittir.");
            }
            catch 
            {
                Console.WriteLine("Şehir bulunamadı.");
            }
        }

    }
}
