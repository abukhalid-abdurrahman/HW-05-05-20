using System;
using System.Collections;

namespace Day_18
{
    public class MyList<T> : IEnumerable
    {
        private T[] list = new T[] { };
        public int Count { get { return list.Length; } }
        public T this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }
        public void Add(T item)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = item;
        }
        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
