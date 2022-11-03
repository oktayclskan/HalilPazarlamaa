using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Depo d = new Depo();

            #region Urunler

            

            Buzdolabi b1 = new Buzdolabi();
            b1.UrunTipi = "Buzdolabı";
            b1.Marka = "BOSCH";
            b1.Model = "KDN86AIE0N";
            b1.EnerjiTipi = "E";
            b1.SogutmaTipi = "No-Frost";
            b1.HızlıSogutma = "Yok";
            b1.Hacim = "158 L";
            b1.Fiyat = 23499;
            d.Ekle(b1);

            Buzdolabi b2 = new Buzdolabi();
            b2.UrunTipi = "Buzdolabı";
            b2.Marka = "SAMSUNG";
            b2.Model = "RB50RS334SA/TR";
            b2.EnerjiTipi = "F";
            b2.SogutmaTipi = "No-Frost";
            b2.HızlıSogutma = "Var";
            b2.Hacim = "120 L";
            b2.Fiyat = 16999;
            d.Ekle(b2);

            Buzdolabi b3 = new Buzdolabi();
            b3.UrunTipi = "Buzdolabı";
            b3.Marka = "LG";
            b3.Model = "GR-H802HlH";
            b3.EnerjiTipi = "B";
            b3.SogutmaTipi = "No-Frost";
            b3.HızlıSogutma = "var";
            b3.Hacim = "590 L";
            b3.Fiyat = 21999;
            d.Ekle(b3);

            CamasirMakinesi c1 = new CamasirMakinesi();
            c1.UrunTipi = "Çamaşır Makinesi";
            c1.Marka = "BOSCH";
            c1.YıkamaKapasitesi = "8 KG ";
            c1.EnerjiSinifi = "B";
            c1.YuklemeTipi = "Önden Yüklemeli";
            c1.KontrolTipi = "Mekanik+Elektronik";
            c1.ProgramSayisi = "6";
            c1.Fiyat = 8999;
            d.Ekle(c1);

            CamasirMakinesi c2 = new CamasirMakinesi();
            c2.UrunTipi = "Çamaşır Makinesi";
            c2.Marka = "GRUNDIG";
            c2.Model = "GWM 81013 S";
            c2.YıkamaKapasitesi = "9 KG ";
            c2.EnerjiSinifi = "C";
            c2.YuklemeTipi = "Önden Yüklemeli";
            c2.KontrolTipi = "Mekanik+Elektronik";
            c2.ProgramSayisi = "15";
            c2.Fiyat = 9650;
            d.Ekle(c2);

            CamasirMakinesi c3 = new CamasirMakinesi();
            c3.UrunTipi = "Çamaşır Makinesi";
            c3.Marka = "BOSCH";
            c3.Model = " WGA252X0TR";
            c3.YıkamaKapasitesi = "10 KG ";
            c3.EnerjiSinifi = "A";
            c3.YuklemeTipi = "Önden Yüklemeli";
            c3.KontrolTipi = "Mekanik+Elektronik";
            c3.ProgramSayisi = "10+";
            c3.Fiyat = 11999;
            d.Ekle(c3);

            BulasikMakinesi bm1 = new BulasikMakinesi();
            bm1.UrunTipi = "Bulaşık Makinesi";
            bm1.Marka = "BOSCH";
            bm1.Model = "SMS4IMI60T";
            bm1.ProgramSayısı = "6";
            bm1.UzaktanKontrol = "Var";
            bm1.Boyutlar = "600 mm x 845 mm x 600 mm";
            bm1.Fiyat = 10999;
            d.Ekle(bm1);

            BulasikMakinesi bm2 = new BulasikMakinesi();
            bm2.UrunTipi = "Bulaşık Makinesi";
            bm2.Marka = "VESTEL";
            bm2.Model = "BM 4202 X";
            bm2.ProgramSayısı = "4";
            bm2.UzaktanKontrol = "Yok";
            bm2.Boyutlar = "59.8 cm x 85 cm x 59.8 cm";
            bm2.Fiyat = 6999;
            d.Ekle(bm2);

            BulasikMakinesi bm3 = new BulasikMakinesi();
            bm3.UrunTipi = "Bulaşık Makinesi";
            bm3.Marka = "ALTUS";
            bm3.Model = "AL 404 MP";
            bm3.ProgramSayısı = "4";
            bm3.UzaktanKontrol = "Yok";
            bm3.Boyutlar = "59.8 cm x 85 cm x 59.8 cm";
            bm3.Fiyat = 5099;
            d.Ekle(bm3);



            Reyon r1 = new Reyon();
            r1.Reyonİsmi = "BULAŞIK MAKİNELERİ";
            d.reyonEkle(r1);
            Reyon r2 = new Reyon();
            r2.Reyonİsmi = "ÇAMAŞIR MAKİNELERİ";
            d.reyonEkle(r2);
            Reyon r3 = new Reyon();
            r3.Reyonİsmi = "BUZDOLAPLARI";
            d.reyonEkle(r3);
            Reyon r4 = new Reyon();
            r4.Reyonİsmi = "TÜM ÜRÜNLERİ YAZDIR";
            d.reyonEkle(r4);


           

            double fiyat = d.GetToplam();
            string devammı = "e";
            while (devammı == "e")
            {
                Console.WriteLine("                             HOŞGELDİNİZ                                      ");
                Console.WriteLine("REYON SEÇİNİZ");
                Console.WriteLine(" ");
                d.ReyonYazdır();

                int rno = Convert.ToInt32(Console.ReadLine());
                d.AyriYazdir(rno);
                Console.WriteLine("ALMAK İSTEDİĞİNİZ ÜRÜN NUMARASINI GİRİNİZ");
                int urnno = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (rno==1)
                {
                    fiyat = d.BMsatinAl(urnno);
                }
                if (rno==2)
                {
                    fiyat= d.CMsatinAl(urnno);
                }
                if (rno==3)
                {
                    fiyat = d.BZsatinAl(urnno);
                }
                
                
                Console.WriteLine("ÜRÜN FİYATIMIZ " + fiyat + " TL");

                Console.WriteLine("ALİŞVERİŞE DEVAM EDİLSİN Mİ ? E/H");
                devammı = Console.ReadLine();
                Console.Clear();
            }
            if (devammı != "e")
            {
                Console.WriteLine("");
                Console.WriteLine("Genel Toplam = " + d.GetToplam()) ;
                Console.WriteLine("");
                
                Console.WriteLine("İYİ GÜNLER DİLERİZ");
            }


            #endregion


        }
    }
}
