using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri gercekMusteri = new GercekMusteri();
            gercekMusteri.MusteriNo = "1xxx";
            gercekMusteri.Id = 1;
            gercekMusteri.Adi = "Gxxxxx";
            gercekMusteri.Soyadi = "Bxxxxx";
            gercekMusteri.TcNo = "3xxxxxxxxxxx";

            TuzelMusteri tuzelMusteri = new TuzelMusteri();
            tuzelMusteri.MusteriNo = "2xxxxx";
            tuzelMusteri.Id = 2;
            tuzelMusteri.SirketAdi = "Rxxxxx";
            tuzelMusteri.VergiNo = "Çxxxxxx";

            Musteri yeniMusteri1 = new GercekMusteri();
            Musteri yeniMusteri2 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(gercekMusteri);
            musteriManager.Ekle(tuzelMusteri);
            musteriManager.Ekle(yeniMusteri1);
            musteriManager.Ekle(yeniMusteri2);

        }
    }
}
