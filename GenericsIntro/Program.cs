using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);


            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara"); //aşağıdaki t sayesinde ben <> içinde ne verirsem, o tipte işlem yapıyor.
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count); //yazdığım kodlar neticesinde, eleman ekleyebiliyorum.

        }
    }

    class MyList<T> //Generic class / T sayesinde hangi tipte veri verirsem onu kullanacak.
    {
        T[] _array;
        T[] _tempArray; //her eklemede array mantığından dolayı önceki verilerim kaybolmasın diye geçici bir liste tutuyorum
        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item) //kendi listemin içine eleman ekleyebilmek için yapıyorum.
        {
            _tempArray = _array; //burada önce temp array(geçici liste) adresi ile normal listemin adresini eşitliyorum ki verilerim kaybolmasın, hepsi aynı yere gitsin. 
            _array = new T[_array.Length + 1]; //bu kod sayesinde her ekleme işleminden sonra eleman sayısı 1 artacak.
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i]; //bu kod sayesinde elimdeki veriler teker teker yeni listeme aktarılacak.
            }
            _array[_array.Length - 1] = item; // bu kod sayesinde yeni eklemek istediğim veri yerine yerleşecek(sondan birinci)
        }
        //yukarıdaki temp arrayin adresini normal listeme eşitlediğim için, öncelikle elimdeki veriler for döngüm sayesinde gidip yeni listeye yerleşecek, sonra yeni bir veri eklenecek.
        
        public int Count //bu sayede kendi oluşturduğum listenin de count değerini alabiliyorum.
        {
            get { return _array.Length; }
        }
    }
}
