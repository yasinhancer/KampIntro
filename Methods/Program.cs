using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Muz";
            urun2.Fiyati = 30;
            urun2.Aciklama = "Muz gibi muz..";

            Product urun3 = new Product();
            urun3.Adi = "Karpuz";
            urun3.Fiyati = 80;
            urun3.Aciklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] { urun1, urun2, urun3 };

            foreach (var x in urunler)
            {
                Console.WriteLine(x.Adi);


            }


            //instance - örnek
            //encapsulation

            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);
            sepetmanager.Ekle(urun3);

            //alttaki gibi yapmak daha uğraştırıcı olacağı için class oluşturuyoruz
            sepetmanager.Ekle2("Armut", "Yeşil Armut", 12);
            sepetmanager.Ekle2("Elma", "Yeşil Elma", 12);
            sepetmanager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12);
            //bu şekilde yapılırsa eğer yeni bir veri eklenmesi gerektirdiğinde tüm kodlarla tek tek uğraşmak gerekicek...
        }
    }
}


//Methodlar tekrar tekrar kullanılabilir kod bloklarıdır. 
// Don't Repeat Yourself!  - DRY

