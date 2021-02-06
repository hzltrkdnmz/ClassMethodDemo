using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {

            Console.WriteLine(musteri.MusteriNo + " nolu " + musteri.Adi + " " + musteri.Soyadi + " eklendi.");
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriNo + " " + musteri.Adi + " " + musteri.Soyadi);

            }
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriNo + " " + musteri.Adi + " " + musteri.Soyadi + " silindi.");
        }
    }
}
