using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //INTERFACE >> ARAYÜZ/ŞABLON
    interface IKrediManager  //okunurluk artması için interface I ile başlar
    {
        void Hesapla();
        void BiseyYap();
    }
    //interface anlamı, birisi Kredi Manager'i içerirse (:KrediManager işlemi)
    //onun içinde de hesapla olmak zorundadır
    //ınterface'i içeren her class, interface içindekileri de içermek zorundadır.

    //HER CLASSIN İÇİNDE IMPLEMENT INTERFACE DİYEREK 
    //BURADAKİ FONKSİYONLARI DİĞER CLASSLARA AKTARIYORUZ
}
