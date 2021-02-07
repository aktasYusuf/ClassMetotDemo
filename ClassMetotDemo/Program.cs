using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Yusuf";
            musteri1.Soyad = "Aktaş";
            musteri1.Yas = 21;
            musteri1.HesapNo = 2111988645145;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Yasin ";
            musteri2.Soyad = "Perihan";
            musteri2.Yas = 41;
            musteri2.HesapNo = 2135135135135;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Duygu";
            musteri3.Soyad = "Havin";
            musteri3.Yas = 16;
            musteri3.HesapNo = 2186412154315;

            Console.WriteLine("-------------------------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);

            Console.WriteLine("-------------------------------");

            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriListele(musteri2);
            musteriManager.MusteriListele(musteri3);

            Console.WriteLine("-------------------------------");

            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriSil(musteri3);
        }


    }
}
