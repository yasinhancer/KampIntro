using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Kerem", "Murat", "Halil" };
            //Console.WriteLine(0);
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            // buradan sonra dizinin sınırları genişletilemeyeceğinden, yeni bir eleman eklenemez.

            //CONTOL+K SONRA CONTROL+C = TOPLU YORUM SATIRINA AL. CONTROL+U = TOPLU YORUMDAN ÇIKAR

            //yeni eleman eklemeyi denersek;

            //isimler = new string[5]; //isimler array'ini 5 elemanlıya çevirdik.

            //ANCAK, yeni bir dizi oluştuğu için, önceki elemanların tamamı SİLİNDİ.
            //YANİ, diziler genişletildiği durumda, yeni bir dizi oluşturulduğu için, 
            //önceki tüm veriler silinir!



            //Bu yüzden, diziler yerine KOLEKSİYONları kullanırız.

            List<string> isimler2 = new List<string> { "Engin", "Kerem", "Murat", "Halil" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("İlker");

            Console.WriteLine("YENİ VERİ EKLENDİKTEN SONRA");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[4]);

            //Görüldüğü üzere, önceki veriler kaybolmadı. Koleksiyonu genişletebildim.













        }


    }
}
