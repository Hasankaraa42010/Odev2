using System;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> kutuphanem = new MyDictionary<string, string>();
            kutuphanem.Add("Hasan Kara", "mehmet");

            kutuphanem.Add("Hasan 2 Karaa", "ali");
            Console.WriteLine("Eleman ismi=="+kutuphanem.Elemanlar[0]+" Ogrenci İsmi== "+kutuphanem.Ogrenciler[0]);
            Console.WriteLine("Eleman ismi==" + kutuphanem.Elemanlar[1] + " Ogrenci İsmi== " + kutuphanem.Ogrenciler[1]);



        }
    }
}