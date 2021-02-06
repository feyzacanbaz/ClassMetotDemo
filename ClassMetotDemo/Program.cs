using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 12345;
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Ak";
            musteri1.Bakiye = 5000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 65476;
            musteri2.Adi = "Ayşe";
            musteri2.Soyadi = "Toprak";
            musteri2.Bakiye = 3000;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 14242;
            musteri3.Adi = "Mehmet";
            musteri3.Soyadi = "Canan";
            musteri3.Bakiye = 7000;

            Musteri[] musteriler = new Musteri [] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Bakiye);
            }
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

        }
    }
}
