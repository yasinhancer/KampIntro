using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi : " + urun.Adi);
        }
    
        //bir class içinde birden fazla metot olabilir
        public void Ekle2(string UrunAdi, string Aciklama, double Fiyat)
        {

            Console.WriteLine("Tebrikler, Sepete Eklendi : " + UrunAdi);

        }
    
    
    
    
    
    }
}
