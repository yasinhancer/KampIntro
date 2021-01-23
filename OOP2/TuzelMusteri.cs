using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //COORPORATE CUSTOMER
    class TuzelMusteri: Musteri //inheritance >> tüzel müşteri bir müşteridir demek.Bu sayede müşterileri iki kola ayırmış gibi olduk.
    { 
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}   


