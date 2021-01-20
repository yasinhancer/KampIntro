using System;

namespace VoidInt_Farkı
{
    class Program
    {
        static void Main(string[] args)
        {
            public int Topla(int sayi1, int sayi2) //bu şekilde yapıldığında, sonucunda bir int tipinde değer elde edileceği için bu değer daha sonra kullanılabilir.
            {
                return sayi1 + sayi2;
            }

            public void Topla2(int sayi1, int sayi2) //aşağıdaki gibi yapıldığında, elde edilen sonuç daha sonra kullanılamaz..
            {
                Console.WriteLine(sayi1 + sayi2);
            }
        }
    }
}
