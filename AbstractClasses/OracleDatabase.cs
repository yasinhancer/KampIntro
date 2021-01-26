using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class OracleDatabase : AbstractDatabase
    {
        //abstract class sayesinde delete ve add metotlarını buraya yazmadan, uzaktan, kullanabiliyorum.
        //Aşağıdakiler ise birden fazla veritabanı olduğu için gövdesiz olarak geliyor,
        //ben veritabanına göre içini aşağıdaki gibi dolduruyorum..
        public override void get()
        {
            Console.WriteLine("Oracle Database verileri aldı.");
        }
        public override void update()
        {
            Console.WriteLine("Oracle Database verileri güncelledi.");
        }
    }
}
