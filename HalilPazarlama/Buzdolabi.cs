using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlama
{
    public class Buzdolabi
    {
        public string UrunTipi { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string EnerjiTipi { get; set; }
        public string SogutmaTipi { get; set; }
        public String HızlıSogutma { get; set; }
        public string Hacim { get; set; }
        public double Fiyat { get; set; }

        public string Yazdır()
        {
            return $"Ürün= {UrunTipi}\n Marka= {Marka}\n Model= {Model}\n Enerji Tipi= {EnerjiTipi}\n Soğutma Tipi={SogutmaTipi}\n Hızlı Soğutma= {HızlıSogutma}\n Hacim= {Hacim}\n Fiyat= {Fiyat}";
        }
    }
}
