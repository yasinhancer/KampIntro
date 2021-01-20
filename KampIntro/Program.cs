using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - veri tipinin ne olduğunu başına yazmalıyız!
            //Do not repeat yourself - değişken tanımla, sürekli kendini tekrarlama!
            //kodumuz bittiğinde ; bırakmayı unutmuyoruz!
            
            //Veri Tipleri
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true; //true veya false olabilir,normalde veri k.'dan gelir.

            //Şart Blokları - if/else if/else
            double dolarDun = 7.35;
            double dolarBugun = 7.55;
           
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış oku");
            }
            else
            {
                Console.WriteLine("Değişmedi oku");
            }


                if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

                Console.WriteLine(kategoriEtiketi); 


        }

    }
}
