using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" "+ musteri.Soyad + " Adlı müşteri kaydı yapıldı.");
        }
        public void MusteriListele( Musteri musteri)
        {
            
            Console.WriteLine("Müşteri Adı: " + musteri.Ad);
            Console.WriteLine("Müşteri soyadı: " + musteri.Soyad);
            Console.WriteLine("Müşteri yaşı: " + musteri.Yas);
            Console.WriteLine("Müşteri hesap numarası: " + musteri.HesapNo);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.HesapNo + " Hesap numaralı müşterinin, hesap kaydı silinmiştir.");
        }

    }
}
