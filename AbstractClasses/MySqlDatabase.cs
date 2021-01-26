using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class MySqlDatabase : AbstractDatabase
    {
        public override void get()
        {
            Console.WriteLine("MySql Database verileri aldı.");
        }
        public override void update()
        {
            Console.WriteLine("MySql Database verileri güncelledi.");
        }
    }
}
