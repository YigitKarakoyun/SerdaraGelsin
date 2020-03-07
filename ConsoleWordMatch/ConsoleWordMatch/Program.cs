using System;

namespace ConsoleWordMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Jokerli_Basamaklilar jokerBasamaklilar = new Jokerli_Basamaklilar();
            jokerBasamaklilar.JokerKarakterlerleriniDoldur();
            jokerBasamaklilar.Yazdir(jokerBasamaklilar.uc_basamaklilar);

            Console.Read();
        }
    }

}
