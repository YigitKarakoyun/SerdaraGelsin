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
            //for (int i = 0; i < 8; i++)
            //{
            //    string[] harfler = rastgeleYapici.SekizTaneHarfOlustur();
            //    rastgeleYapici.Yazdir(harfler);
            //}
            var harfler = rastgeleYapici.HarfTane_AnlamsizKelimeOlustur();
            rastgeleYapici.Yazdir(harfler);
            Console.Read();
        }
    }
    
}
