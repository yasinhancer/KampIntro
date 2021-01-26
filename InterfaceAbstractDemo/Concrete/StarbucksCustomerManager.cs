using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Concrete
{
    //override sayesinde abstract sınıftaki bir metodun üzerinde ekstra oynama yapıyorum ( orada virtual keywordünü ekledikten sonra )
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer)) //oradaki varsayılan değer true olduğundan, kişi doğrulanmış ise kaydedilecek.
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person."); //doğrulanmamış ise bu kod çalışacak
            }
        }
    }
}
