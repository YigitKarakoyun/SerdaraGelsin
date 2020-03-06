using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWordMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            RastgeleYapici rastgeleYapici = new RastgeleYapici();
            var harfler = rastgeleYapici.HarfTane_AnlamsizKelimeOlustur();
            //rastgeleYapici.Yazdir(harfler);

            //---------------------------------------------------------------
            Kombinasyon kombinasyon = new Kombinasyon();
            var harf = harfler[0];
            var sonucListesi = kombinasyon.HarfTane_AnlamsizKelimeOlustur(harf);
            kombinasyon.Yazdir(sonucListesi);
            Console.Read();
        }
    }
    
}
