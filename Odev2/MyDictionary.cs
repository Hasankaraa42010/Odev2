using System;
using System.Collections.Generic;
using System.Text;

namespace Odev2
{
    class MyDictionary<kutuphane,sınıf>
    {
        kutuphane[] elemanlar;
        sınıf[] ogrenciler;
        //constuctor
        public MyDictionary()
        {
            elemanlar = new kutuphane[0];
            ogrenciler = new sınıf[0];
        }
        public void Add(kutuphane eleman,sınıf ogrenci)
        {
            kutuphane[] geciciDizi = elemanlar;
            sınıf[] geciciDizi2 = ogrenciler;
            elemanlar = new kutuphane[elemanlar.Length + 1];
            ogrenciler = new sınıf[ogrenciler.Length + 1];
            for (int i = 0; i < geciciDizi.Length; i++)
            {
                elemanlar[i] = geciciDizi[i];
            }
            for (int i = 0; i < geciciDizi2.Length; i++)
            {
                ogrenciler[i] = geciciDizi2[i];
            }
            ogrenciler[ogrenciler.Length - 1] = ogrenci;
            elemanlar[elemanlar.Length - 1] = eleman;
        }
        public int Length
        {
            get { return elemanlar.Length; }
            
        }
        public int Lenght2
        {
            get { return ogrenciler.Length; }
        }
        public sınıf [] Ogrenciler
        {
            get { return ogrenciler; }
        }
        public kutuphane[] Elemanlar
        {
            get { return elemanlar; }
        }
    }
}
