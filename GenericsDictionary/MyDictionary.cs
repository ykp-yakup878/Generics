using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDictionary
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] Values;

        TKey[] tempKeys;
        TValue[] tempValues;

        public MyDictionary()
        {
            keys = new TKey[0];
            Values = new TValue[0];
        }
        public void Add(TKey item,TValue item2)
        {
            tempKeys = keys;
            tempValues = Values;
            keys = new TKey[keys.Length + 1];
            Values = new TValue[Values.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            for (int i = 0; i < tempValues.Length; i++)
            {
                Values[i] = tempValues[i];
            }
            keys[keys.Length - 1] = item;
            Values[Values.Length - 1] = item2;

        }
        //private int myVar;

        public int Count
        {
            get { return keys.Length; }
        }
        public void Out()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine($"{keys[i]}:{Values[i]}");
            }
        }

    }
}
