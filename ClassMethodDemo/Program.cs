using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriNo = "1234567890";
            musteri1.Adi = "Hazel";
            musteri1.Soyadi = "Türk";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriNo = "1456787654";
            musteri2.Adi = "Beyza";
            musteri2.Soyadi = "Türk";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("-----------Müşteriler--------------");
            musteriManager.MusteriListele(musteriler);
            Console.WriteLine("-----------------------------------");
            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriNo = "123367890";
            musteri3.Adi = "Ela";
            musteri3.Soyadi = "Gün";

            musteriManager.MusteriEkle(musteri3);
            Console.WriteLine("-----------------------------------");
            musteriManager.MusteriSil(musteri2);
        }
    }
}
