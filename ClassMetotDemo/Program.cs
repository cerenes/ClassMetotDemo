using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.id = 1;
            musteri1.ad = "Ceren";
            musteri1.soyad = "Esirgenci";
            musteri1.meslek = "Bilişim Uzmanı";

            Musteri musteri2 = new Musteri();
            musteri2.id = 2;
            musteri2.ad = "Esra";
            musteri2.soyad = "Şahinler";
            musteri2.meslek = "Bilgisayar Bilimci";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager mM= new MusteriManager();
            mM.Ekle(musteri1);
            mM.Sil(musteri2);
            mM.Liste(musteriler);
            Console.ReadKey();
        }

    }
   
}
