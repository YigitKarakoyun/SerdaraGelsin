using System;


namespace ConsoleWordMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            Jokerli_Permutasyon jip = new Jokerli_Permutasyon();
            jip.JokerlerDoldur();
            var result = jip.Jokerli_AltiBasamaklilar_Listesi();

            //jip.Yazdir(result);
            //Altı basamaktan sonra iptal oluyor haberin olsun :)
            Console.WriteLine(result.Count);
            Console.Read();
        }
    }

}
