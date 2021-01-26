using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerCheckService //ileride başka bir firmanın da doğrulama isteyebileceği opsiyonuna karşın bunu oluşturdum
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
