using System;
using System.Collections.Generic;

namespace GenericsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Dictionary--------");
            Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            Console.WriteLine(ogrenci.Count);
            ogrenci.Add(0, "Yakup Bekar");
            Console.WriteLine(ogrenci[0]);
            Console.WriteLine(ogrenci.Count);

            Console.WriteLine("--------MyDictionary--------");
            MyDictionary<int, string> ogrenci2 = new MyDictionary<int, string>();
            Console.WriteLine(ogrenci2.Count);
            ogrenci2.Add(0, "Yakup BEKAR");
            ogrenci2.Add(1, "Burak GÜLEÇ");
            ogrenci2.Add(2, "Yüksel ÇETİN");
            ogrenci2.Add(3, "Yunus Can AKDENİZ");
            ogrenci2.Out();
            Console.WriteLine(ogrenci2.Count);
        }
    }
}
