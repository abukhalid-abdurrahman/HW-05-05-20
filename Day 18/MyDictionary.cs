using System;
using System.Collections;
using System.Collections.Generic;

namespace Day_18
{
    public class MyDictionary<TKey, KValue> : IEnumerable
    {
        private TKey[] keysList = new TKey[] { };
        private KValue[] valuesList = new KValue[] { };
        public int Count { get { return keysList.Length; } }
        public KValue this[int index]
        {
            get
            {
                return valuesList[index];
            }
            set
            {
                valuesList[index] = value;
            }
        }

        public KValue this[TKey index]
        {
            get
            {
                int findedIndex = FindElementIndex(index);
                return valuesList[findedIndex];
            }
            set
            {
                int findedIndex = FindElementIndex(index);
                valuesList[findedIndex] = value;
            }
        }

        private int FindElementIndex(TKey item)
        {
            int index = 0;
            for(int i = 0; i < keysList.Length; i++)
            {
                if((object)item == (object)keysList[i])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public void Add(TKey key, KValue value)
        {
            Array.Resize(ref keysList, keysList.Length + 1);
            keysList[keysList.Length - 1] = key;

            Array.Resize(ref valuesList, valuesList.Length + 1);
            valuesList[valuesList.Length - 1] = value;
        }
        public IEnumerator GetEnumerator()
        {
            return keysList.GetEnumerator();
        }
    }
}
