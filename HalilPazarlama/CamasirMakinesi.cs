using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlama
{
    public class CamasirMakinesi
    {
        public string UrunTipi { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public String YıkamaKapasitesi { get; set; }
        public string EnerjiSinifi { get; set; }
        public string YuklemeTipi { get; set; }
        public string KontrolTipi { get; set; }
        public string ProgramSayisi { get; set; }
        public double Fiyat { get; set; }
        public string Yazdır()
        {
            return $"Ürün= {UrunTipi}\n Marka= {Marka}\n Model= {Model}\n Yıkama Kapasitesi= {YıkamaKapasitesi}\n Enerji Sınıfı={EnerjiSinifi}\n Yükleme Tipi= {YuklemeTipi}\n Kontrol Tipi= {KontrolTipi}\n Program Sayısı= {ProgramSayisi}\n Fiyat= {Fiyat}";
        }

    }
}
