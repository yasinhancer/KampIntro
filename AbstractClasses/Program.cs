using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //miras yapısı sayesinde abstract class üzerinden nesne oluşturdum.
            AbstractDatabase abstractDatabase1 = new MySqlDatabase();
            AbstractDatabase abstractDatabase2 = new OracleDatabase();

            //GÖVDELİ METOTLARIM
            //aşağıdaki iki kod, temel sınıfta (abstract) olduğu için, nerde kullanırsak kullanalım, aynı sonucu verdi.
            abstractDatabase1.add();
            abstractDatabase2.add();
            
            //GÖVDESİZ/ABSTRACT METOTLARIM
            //aşağıdaki kodlarım ise, gövdesiz olarak gitti ve orada veritabanına özel olarak içi dolduruldu.
            //bu yüzden hangi veritabanı için kullanırsam onun içerisinde yazdığım kod çalışıyor.
            abstractDatabase1.update();
            abstractDatabase2.update();
            abstractDatabase1.get();
            abstractDatabase2.get();

            Console.ReadLine();

            //ABSTRACT CLASS SAYESİNDE INTERFACE'DEN FARKLI OLARAK, GÖVDELİ YAZDIĞIM ADD VE DELETE METOTLARINI,
            //KALITIM ALAN SINIFLARDA TEKRAR YAZMADAN KULLANABİLDİM, TEMEL FARKLARDAN BİRİSİ BUDUR.
        }
    }
}
