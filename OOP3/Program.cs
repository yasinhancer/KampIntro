using System;
using System.Collections.Generic;

namespace OOP3
{
    //tüm işlemleri burda yapmak yerine her kredi türü için ayrı class açıyorum.
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            IKrediManager tasitKrediManager = new TasitKrediManager();

            IKrediManager konutKrediManager = new KonutKrediManager();

            IKrediManager esnafKrediManager = new EsnafKredisiManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();

            ILoggerService fileLoggerService = new FileLoggerService();

            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { databaseLoggerService, smsLoggerService };

            BasvuruManager basvuruManager = new BasvuruManager();


            basvuruManager.BasvuruYap(esnafKrediManager, loggers);
            //artık buraya hangisini hesaplamak istiyorsak onu yazabiliriz.....

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager, konutKrediManager };
            //liste ve döngüm sayesinde sınırsız sayıda kredi türü seçip bunları hesaplatabilirim...
            
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            //interface'ler de o interface'i implement eden class'ın 
            //referans numarasını tutabiliyor görüldüğü üzere..


            //TÜM BU ALGORİTMAM SAYESİNDE, HİÇBİR KOD BOZULMADAN, HİÇBİR KODA DOKUNMADAN,
            //YENİ BİR KREDİ TÜRÜ, YENİ LOGGER SERVİSİ EKLEYEBİLDİM, KODLARIM ARASINDA KAYBOLMADIM.
            
        }
    }
}
