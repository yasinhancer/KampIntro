using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            //string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            //string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            //string kurs3 = "Java";
            
            //Bu şekilde tek tek yapmak yerine dizilerde tanımlarız:

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya Başlangıç İçin Temel Kurs" , 
                "Java" , "C++" , "Python" };


            for (int i = 0; i <kurslar.Length; i++) // i=i+x / i+=x >>> x=kaç kaç artır (i++ 1'er 1'er artır demektir.)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti.");
            
            // foreach dizilere uygulanır.dizileri tek tek dolaşmaya yarar. üsteki for gibi eleman (i) belirtmeye gerek kalmaz, Python'daki for döngüsünün aynısıdır.
            
            foreach (string kurs in kurslar) 
            {
                Console.WriteLine(kurs);
            }
            
            
            Console.WriteLine("sayfa sonu");
         
        }
    }
}
