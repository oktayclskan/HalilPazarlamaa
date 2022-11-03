using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlama
{
    public class Depo
    {

        BulasikMakinesi[] BulasikMakineleri;
        CamasirMakinesi[] CamasirMakineleri;
        Buzdolabi[] Buzdolapları;
        Urun[] urunler;

        public Depo()
        {
            BulasikMakineleri = new BulasikMakinesi[0];
            CamasirMakineleri = new CamasirMakinesi[0];
            Buzdolapları = new Buzdolabi[0];
            urunler = new Urun[0]; 
            
        }
        
        public void Ekle(CamasirMakinesi cm)
        {
            CamasirMakinesi[] gecici = new CamasirMakinesi[CamasirMakineleri.Length + 1];
            Array.Copy(CamasirMakineleri, gecici, CamasirMakineleri.Length);
            gecici[gecici.Length - 1] = cm;
            CamasirMakineleri = gecici;
        }
        public void Ekle(BulasikMakinesi bm)
        {
            BulasikMakinesi[] gecici = new BulasikMakinesi[BulasikMakineleri.Length + 1];
            Array.Copy(BulasikMakineleri, gecici, BulasikMakineleri.Length);
            gecici[gecici.Length - 1] = bm;
            BulasikMakineleri = gecici;
        }
        public void Ekle(Buzdolabi bd)
        {
            Buzdolabi[] gecici = new Buzdolabi[Buzdolapları.Length + 1];
            Array.Copy(Buzdolapları, gecici, Buzdolapları.Length);
            gecici[gecici.Length - 1] = bd;
            Buzdolapları = gecici;

        }
        public void Ekle(Urun u)
        {
            Urun[] gecici = new Urun[urunler.Length + 1];
            Array.Copy(urunler, gecici, urunler.Length);
            gecici[gecici.Length - 1] = u;
            urunler = gecici;
        }

        public void Listele()
        {

            for (int i = 0; i < CamasirMakineleri.Length; i++)
            {
                Console.WriteLine((i + 1) + ".)" + CamasirMakineleri[i].Yazdır());
                Console.WriteLine("**************************************");
            }
            for (int i = 0; i < BulasikMakineleri.Length; i++)
            {
                Console.WriteLine((i + 1) + ".)" + BulasikMakineleri[i].Yazdır());
                Console.WriteLine("**************************************");
            }
            for (int i = 0; i < Buzdolapları.Length; i++)
            {
                Console.WriteLine((i + 1) + ".)" + Buzdolapları[i].Yazdır());
                Console.WriteLine("**************************************");
            }
            

        }
        Reyon[] reyonlar = new Reyon[0];
        public void reyonEkle(Reyon sınıf)
        {

            Reyon[] gecici = new Reyon[reyonlar.Length + 1];
            Array.Copy(reyonlar, gecici, reyonlar.Length);
            gecici[gecici.Length - 1] = sınıf;
            reyonlar = gecici;
        }
        public void ReyonYazdır()
        {
            for (int i = 0; i < reyonlar.Length; i++)
            {
                Console.WriteLine((i + 1) + ".)" + reyonlar[i].Reyonİsmi);
                Console.WriteLine("  ");
            }
        }
        public void AyriYazdir(int rno)
        {
            while (rno != 1 && rno != 2 && rno != 3 && rno != 4)
            {
                Console.WriteLine("LÜTFEN GEÇERLİ REYON NUMARASI YAZINIZ");
                rno = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            if (rno == 1)
            {
                for (int i = 0; i < BulasikMakineleri.Length; i++)
                {
                    Console.WriteLine($"{i + 1}) {BulasikMakineleri[i].Yazdır()} ");
                    Console.WriteLine("***************************");
                }
            }
            else if (rno == 2)
            {
                for (int i = 0; i < CamasirMakineleri.Length; i++)
                {
                    Console.WriteLine($"{i + 1}) {CamasirMakineleri[i].Yazdır()} ");
                    Console.WriteLine("***************************");
                }
            }
            else if (rno == 3)
            {
                for (int i = 0; i < Buzdolapları.Length; i++)
                {
                    Console.WriteLine($"{i + 1}) {Buzdolapları[i].Yazdır()} ");
                    Console.WriteLine("***************************");
                }
            }
            else if (rno == 4)
            {

                Listele();
            }
        }

        double toplam = 0;
        public double BZsatinAl(int urunno)
        {

            double fiyat = 0;

            fiyat = Buzdolapları[urunno - 1].Fiyat;
            toplam = Buzdolapları[urunno - 1].Fiyat + toplam;
            return fiyat;
        }
        public double CMsatinAl(int urunno)
        {

            double fiyat = 0;

            fiyat = CamasirMakineleri[urunno - 1].Fiyat;
            toplam = CamasirMakineleri[urunno - 1].Fiyat + toplam;

            return fiyat;
        }
        public double BMsatinAl(int urunno)
        {

            double fiyat = 0;

            fiyat = BulasikMakineleri[urunno - 1].Fiyat;
            toplam = BulasikMakineleri[urunno - 1].Fiyat + toplam;
            return fiyat;
        }
        public double GetToplam()
        {
            return toplam;
        }





    }

}
