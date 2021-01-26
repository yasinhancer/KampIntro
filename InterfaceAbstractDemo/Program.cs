using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    //SENARYO;
    //KAHVE DÜKKANLARI İÇİN MÜŞTERİ YÖNETİMİ YAPAN BİR SİSTEM YAZMAK İSTİYORUZ. STARBUCKS VE NERO FİRMASI İÇİN ÇALIŞIYORUZ.
    //İKİ FİRMA DA MÜŞTERİLERİNİ VERİTABANINA KAYDETMEK İSTİYOR.
    //STARBUCKS MÜŞTERİLERİNİ KAYDEDERKEN MUTLAKA MERNİS DOĞRULAMASI İSTİYOR. NERO BÖYLE BİRŞEY İSTEMİYOR.
    //STARBUCKS AYRICA; MÜŞTERİLER İÇİN HER KAHVE ALIMINDA YILDIZ KAZANDIRMAK İSTİYOR.
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer{DateOfBirth = new DateTime(2002,9,12), FirstName = "Yasin",LastName = "Hançer",NationalityId = "44038876190"});
            Console.ReadLine();
            //NOT: TC KİMLİK DOĞRULAMA SERVİSİ DOĞUM TARİHİNDEN YILI BAZ ALIR.
        }

        //TÜM KODLAR SAYESİNDE, SONRASINDA NERO DA KİMLİK DOĞRULAMA İSTERSE KOLAYLIKLA EKLEYEBİLİRİM.
    }
}
