using System;
using System.Collections.Generic;

namespace ConsoleWordMatch
{

   public class Jokerler
    {
        string[] harfler = Alfabe.harfler_dizisi;

        //------------------------------------------------------
        public List<string> Jokerli_AnlamsizKelimeOlustur(string tempSekiz)
        {
            List<string> temp = new List<string>();
            foreach (string item in harfler)
            {
                string yeniString = item + tempSekiz;
                temp.Add(yeniString);
            }
            return temp;
        }
        public List<string> Jokerli_AnlamsizKelimeOlustur(List<string> tempList)
        {
            List<string> temp = new List<string>();
            foreach (string item in harfler)
            {
                foreach (var itemMetin in tempList)
                {
                    string yeniString = item + itemMetin;
                    temp.Add(yeniString);
                }

            }

            return temp;
        }
        public void Yazdir(List<string> harflerList)
        {
            Console.WriteLine("---Harfler---");
            foreach (var item in harflerList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();


        }

    }
}
