using System;
using System.Collections.Generic;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenci = new MyDictionary<int, string>() ;
            ogrenci.Add(322,"Leyla Başar");
            ogrenci.Add(323, "Aslan Ballı");
            ogrenci.Add(326, "Ekrem Yalın");     
            
            ogrenci.Listed();

        }
    }
}
