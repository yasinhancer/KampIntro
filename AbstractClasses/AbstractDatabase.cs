using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses 
{
    abstract class AbstractDatabase
    {
       //aşağıdakiler abstractDatabase'i kalıtan her sınıf tarafından kullanılabilir.
       //yani aşağıdaki kodlar kalıtan sınıf tarafından -o sınıfın içerisine tekrardan yazmaya gerek olmadan, uzaktan-
       //kullanılabilir. interface olsaydı bu kodları kalıtan sınıfta da aynen yazmamız, sonra kullanmamız gerekecekti.
       //abstract class sayesinde bu aşamadan kurtuluyor ve ekstra kod kalabalığından korunmuş oluyoruz.
        public void add()
        {
            Console.WriteLine("Eklendi...");
        }

        public void delete()
        {
            Console.WriteLine("Silindi...");
        }

        //üsttekileri tekrardan yazmadan başka sınıflarda da kullanabiliyoruz kalıtım sayesinde.
        //Ancak aşağıdaki kodları bu şekilde gövdesiz yapmamın sebebi,
        //kalıtım alan sınıfların bu metotların içini istediği gibi, kendi ihtiyacına göre doldurabilmesi içindir.
        
        //yani sonuç olarak üstteki iki metotun sadece burda bulunması yeterli iken, aşağıdaki gövdesiz metotların
        //kalıtım alan sınıflarda bulunması ZORUNLUDUR.
        public abstract void update(); //abstract classlar gövde bulundurmaz. bu şekilde yalın oluşturulurlar.
        public abstract void get();
    }
}
