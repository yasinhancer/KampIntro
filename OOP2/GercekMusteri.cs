using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //INDIVIDUAL CUSTOMER
    class GercekMusteri:Musteri //inheritance >> gerçek müşteri bir müşteridir demek.Bu sayede müşterileri iki kola ayırmış gibi olduk.
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
   
}

