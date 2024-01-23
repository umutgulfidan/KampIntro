using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Umut";
            //musteri1.Soyadi = "Gülfidan";
            //musteri1.Id = 1;
            //musteri1.TcNo = "12345678910";
            //musteri1.MusteriNo = "123";
            //musteri1.SirketAdi = "????";
            // Gerçek Müşteri - Tüzel Müşteri Diye Ayırmalıyız
            // SOLID -> L Harfi
            // Kalıtım

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Adi = "Umut";
            musteri1.Soyadi = "Gülfidan";
            musteri1.MusteriNo = "132";
            musteri1.TcNo = "12345678910";
            musteri1.Id = 1;

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "456";
            musteri2.VergiNo = "123";
            musteri2.SirketAdi = "TEST";

            // MUsteri Sınıfı (BASE CLASS) sub classların referansını tutabilir
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            // Bu yüzden MusteriManager.Add() fonksiyonuna parametre olarak gerçek veya tuzel herhangi bir musteri yollayabilirim -> Polimorfizm
            // Ayrıca musterileri ayrı ayrı tuttuğum için yanlış veri girişlerini önlemiş oluyorum.
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);




        }
    }
}
