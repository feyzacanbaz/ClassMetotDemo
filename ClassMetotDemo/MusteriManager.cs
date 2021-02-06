using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Id:" + musteri.Id+ " " + "Adı:" + musteri.Adi+ " " + "Soyadı:" + musteri.Soyadi + " " + "Bakiye:" + musteri.Bakiye);
            Console.WriteLine("Müşteri eklendi");
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Id:" + musteri.Id + " " + "Adı:" + musteri.Adi + " " + "Soyadı:" + musteri.Soyadi + " " + "Bakiye:" + musteri.Bakiye);
            Console.WriteLine("Müşteri silindi");
        }

        public void Listeleme(Musteri musteri)
        { 
            Console.WriteLine("Id:" + musteri.Id + " " + "Adı:" + musteri.Adi + " " + "Soyadı:" + musteri.Soyadi + " " + "Bakiye:" + musteri.Bakiye);
            Console.WriteLine("Müşteri listelendi");
        }
    }
}
