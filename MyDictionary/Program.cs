using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dersler = new MyDictionary<int, string>();
            dersler.Add(144, "Ağ Temelleri");
            dersler.Add(458, "Bilgisayar Mimarisi");
            dersler.Add(669, "Web Tabanlı Programlama");

            Console.Write("Seçilen dersler : ");

            Console.WriteLine(dersler.Count);
            dersler.Show();
            Console.ReadLine();
        }
    }
}