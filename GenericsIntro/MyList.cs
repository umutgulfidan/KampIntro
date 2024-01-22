using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] list;
        public MyList() {
            list = new T[0];
        }
        public MyList(params T[] items)
        {
            list = new T[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                list[i] = items[i];
            }
        }
        public void Add(T item) {
            T[] tempArray = new T[list.Length];
            tempArray = list;
            list = new T[list.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                list[i] = tempArray[i];
            }
            list[list.Length-1] = item;
        }

        public void Clear()
        {
            list = new T[0];
        }
        public bool Contains(T item)
        {
            bool isContains = false;
            foreach (T item1 in list)
            {
                if(item1.Equals(item))
                {
                    isContains = true;
                }
            }
            return isContains;
        }
        public int Lenght
        {
            get { return list.Length; }
        }
        public T[] Items {
            get { return list; }
        }

    }
}
