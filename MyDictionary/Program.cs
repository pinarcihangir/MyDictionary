using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenciler = new MyDictionary<int, string>();
            ogrenciler.Add(1,"Pınar");
            ogrenciler.Add(2, "Gül");
            ogrenciler.Add(3, "Ezgi");

            Console.WriteLine("Öğrenci no : " + ogrenciler.keys[0] + "  İsim : " + ogrenciler.values[0]);
            Console.WriteLine("Öğrenci no : " + ogrenciler.keys[1] + "  İsim : " + ogrenciler.values[1]);
            Console.WriteLine("Öğrenci no : " + ogrenciler.keys[2] + "  İsim : " + ogrenciler.values[2]);


        }

    }

    class MyDictionary<K, V>
    {
        K[] keyArray;
        V[] valueArray;

        K[] tempKeyArray;
        V[] tempValueArray;

        public MyDictionary()
        {
            keyArray = new K[0];
            valueArray = new V[0];
        }

        public void Add(K key, V value)
        {
            tempKeyArray = keyArray;
            tempValueArray = valueArray;

            keyArray = new K[keyArray.Length + 1];
            valueArray = new V[valueArray.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keyArray[i] = tempKeyArray[i];
            }

            for (int i = 0; i < tempValueArray.Length; i++)
            {
                valueArray[i] = tempValueArray[i];
            }

            keyArray[keyArray.Length - 1] = key;
            valueArray[valueArray.Length - 1] = value; 
        }

        public int CountKey
        {
            get { return keyArray.Length; }
        }

        public int CountValue
        {
            get { return valueArray.Length; }
        }

        public K[] keys
        {
            get { return keyArray; }
        }

        public V[] values
        {
            get { return valueArray; }
        }


    }
}
