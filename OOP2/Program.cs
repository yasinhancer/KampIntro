using System;

namespace OOP2
{
    //yaptıklarımız sayesinde ortak olanlar musteri de, diğerleri kendi sınıflarında oldu. 
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Deniroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";


            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Gerçek - Tüzel birbirinin yerine kullanılamaz!
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            //görüldüğü üzre müşteri classı hem gerçek müşterinin, 
            //hem tüzel müşterinin referansını tutabiliyor.

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2); 
            //TEMEL SINIF SAYESİNDE (musteri)
            //iki referansı da tutabildiği için
            //iki farklı tipte müşteriyi aynı yere gönderebildik...


        }
    }
}
