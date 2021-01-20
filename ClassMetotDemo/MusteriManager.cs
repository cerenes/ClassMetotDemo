﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.id+ " " + musteri.ad + " " + musteri.soyad + " " + musteri.meslek+ " "+ "Eklendi");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.id + " " + musteri.ad + " " + musteri.soyad + " " + musteri.meslek + " " + "Silindi");
        }

        public void Liste(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.id + " " + musteri.ad + " " + musteri.soyad + musteri.meslek + " ");
            }
        }
        




    }
}
