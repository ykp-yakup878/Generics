using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------List--------");

            List<string> aylar = new List<string>();
            Console.WriteLine(aylar.Count);
            aylar.Add("Kasım");
            Console.WriteLine(aylar[0]);
            Console.WriteLine(aylar.Count);

            Console.WriteLine("-------MyList'im--------");

            MyList<string> gunler = new MyList<string>();
            Console.WriteLine(gunler.Count);
            gunler.Add("Pazartesi");
            gunler.Add("Salı");
            gunler.Add("Çarşamba");
            Console.WriteLine(gunler.Count);

            Console.WriteLine("--------Dictionary--------");

            Dictionary<int, string> student = new Dictionary<int, string>();     //key ve değer olmak üzere iki ayrı değişkeni olan sınıftır

            student.Add(1, "Yakup Bekar");
            student.Add(2, "Yüksel Çetin");
            student.Add(3, "Yunus Can Akdeniz");
            student.Add(4, "Burak Güleç");
            student.Add(5, "Ahmet Taha Yüksek");
            foreach (var item in student)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
                Console.WriteLine(item.ToString());
                //Console.WriteLine(item.GetHashCode());
                Console.WriteLine("/////////////////////////");
            }

            Console.WriteLine("--------Dictionary2--------");

            Dictionary<string, string> days = new Dictionary<string, string>
            {
                {"Mo","Monday"  },
                {"Tu","Tuesday"  },
                {"We","Wednesday"  },
                {"Th","Thursday"  },
                {"Fr","Friday"  },
                {"Sa","Saturday"  },
                {"Su","Sunday"  }
            };
            Console.WriteLine("dil->en");
            Console.Write("Gün Kısalımı Gir:");
            string deger = Console.ReadLine();
            try
            {
                Console.WriteLine(days[deger]);
            }
            catch (Exception)
            {

                Console.WriteLine("Böyle Bir Değer Yok");
            }


        }

        class MyList<T>                                     //Generic Class
        {
            T[] _array;
            T[] _tempArray;
            public MyList()
            {
                _array = new T[0];                          //_array değerini yeni/new bellekte sıfırdan başlat
            }
            public void Add(T item)                         //Add() -> Methods
            {
                _tempArray = _array;                        //_array'deki değerleri _tempArray'e atar.
                _array = new T[_array.Length + 1];              //new yaptığın zaman _array'e yeni bellek/referans açılır/atar ve boş gelir.
                                                                //yani değerlerin olduğu belleği _tempArray'e atadığımız için kullanabiliriz.
                for (int i = 0; i < _tempArray.Length; i++) //i 0 dan başla _tempArray'daki değerler kadar çalış
                {
                    _array[i] = _tempArray[i];              //_tempArray'deki değerleri i kadar _array'deki indexlere ekle
                }
                _array[_array.Length - 1] = item;           //_arraydeki değerlerin -1 çıkar/geri gel item'dan gelen değeri ekle
            }

            //private int _count;

            public int Count                                //Property -> Özellik
            {
                get { return _array.Length; }
            }
        }
    }
}
