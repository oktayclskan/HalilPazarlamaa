using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlama
{
    public class BulasikMakinesi
    {
        public string UrunTipi { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public String ProgramSayısı { get; set; }
        public string UzaktanKontrol { get; set; }
        public string Boyutlar { get; set; }
        public double Fiyat { get; set; }

        public string Yazdır()
        {
            return $"Ürün= {UrunTipi}\n Marka= {Marka}\n Model= {Model}\n Program Sayısı= {ProgramSayısı}\n Uzaktan Kontrol={UzaktanKontrol}\n Boyutları= {Boyutlar}\n Fiyat= {Fiyat}";
        }

    }
}
