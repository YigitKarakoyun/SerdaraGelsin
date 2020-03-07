using System;

namespace ConsoleWordMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jokerli_Basamaklilar jokerBasamaklilar = new Jokerli_Basamaklilar();
            //jokerBasamaklilar.JokerKarakterlerleriniDoldur();
            //jokerBasamaklilar.Yazdir(jokerBasamaklilar.uc_basamaklilar);

            Console.WriteLine("------------------------------");

            Jokerli_Permutasyon jip = new Jokerli_Permutasyon();
            jip.JokerlerDoldur();
            var result = jip.JokerliPermutasyonListesi(jip.jokerler.dort_basamaklilar);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }

}
