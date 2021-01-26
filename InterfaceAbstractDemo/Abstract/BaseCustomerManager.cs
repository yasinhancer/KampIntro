using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Abstract
{
    //aşağıdaki kod herkeste tamamen aynı şekilde çalışacğı için abstract kullandım
    //ayrıca, ICustomerService burada implemente edildiği için, abstract sınıfı kalıtım alanlar dolaylı yoldan,
    //ICustomerService içerisindeki operasyonları da içerecek

    public abstract class BaseCustomerManager : ICustomerService 
    {
        public virtual void Save(Customer customer) //virtual sayesinde kodu ezebilirim
        {
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}
