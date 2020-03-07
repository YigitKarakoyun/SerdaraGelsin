using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWordMatch
{
    class Jokerli_Permutasyon
    {
        Jokerli_Basamaklilar jokerliBasamaklilar = new Jokerli_Basamaklilar();
        public IJokerliBasamaklar jokerler;
        Permutasyon_Yapici permutasyon = new Permutasyon_Yapici();

        public Jokerli_Permutasyon()
        {
            jokerler = jokerliBasamaklilar;
        }

        public void JokerlerDoldur()
        {
            jokerliBasamaklilar.JokerKarakterlerleriniDoldur();
            
        }
        public List<string> JokerliPermutasyonListesi(List<string> basamakList)
        {
            List<string> list = new List<string>();
            foreach (var item in basamakList)
            {
                permutasyon.Permutasyon_Stringi(item);
                foreach (var item2 in permutasyon.list)
                {
                    list.Add(item2);
                }
            }
            return list;
        }

    }
}
