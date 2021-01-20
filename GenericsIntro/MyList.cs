using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //T: ben sana hangi tipte eleman veriyorsam , varsayılan olarak onu kullan.
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }


        public void Add(T item)
        {
            T[] tempItems = items; //önceki veriler kaybolmasın diye, geçici veri tutmak için, geçici items yaptık.
            items = new T[items.Length + 1];
            for (int i = 0; i < tempItems.Length; i++) //önceden emaneten geçici dizeye verdiğim değerlerimi döngü vasıtasıyla yeni dizeme geçirdim. 
            {
                items[i] = tempItems[i];
            }

            items[items.Length - 1] = item;
        }





    }
}
