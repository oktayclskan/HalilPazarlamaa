using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlama
{
    public class Urun
    {
        public int adet { get; set; }
        public string Yazdır()
        {
            return $"Ürün= {adet}";
        }
    }
}
