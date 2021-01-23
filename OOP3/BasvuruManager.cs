using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method Injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices) //bu sayede buraya istediğim tipte kredi yollayabilirim.
        {
            //Başvuran bilgilerini değerlendirme
            //
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla(); 
            //böyle yapılırsa tüm başvurular konut kredisi tipinde hesaplanır!!!
            krediManager.Hesapla(); //başvuru kredi bağımsız hale geldi.
                                    //yani ben buraya hangi k. gönderirsem onun hesapla'sı çalışır.

            //hangi loglayıcı(lar) seçilmişse, onu logla
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            } 
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) //bana bir liste ver, listenin türü IKrediManager olsun. birden fazla kredi içerebilir. listenin adı krediler olacak
        {
            //listedeki her bir kredinin hesabını yaptırmak için foreach döngüsünü kullanıyorum.
            foreach (var kredi in krediler) 
            {
                kredi.Hesapla();
            }
        }
    }
}
