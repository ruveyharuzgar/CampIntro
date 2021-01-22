using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T>
    {
        T[] values;

        public MyDictionary()
        {
            values = new T[0];
            Console.WriteLine("Constractur çalıştı.Dizi sıfırlandı. ");
        }
       public void Add(T item)
        {
            Console.WriteLine("Ekleme methodu çalıştı.");
            T[] tempArray = values; 
            values= new T[values.Length+1]; 

            for (int i = 0; i <tempArray.Length; i++)
            {
                values[i] = tempArray[i];
             
            }
            values[values.Length-1]= item;
            
            Console.ReadLine();
        }

        public T [] Show
        {
            get { return values; }
        }

    }
}
