using System;
using System.Collections.Generic;

namespace ConsoleWordMatch
{
    public class Kombinasyon
    {
        public List<string> HarfTane_AnlamsizKelimeOlustur(string tempSekizli)
        {
            List<string> temp = new List<string>() { tempSekizli };
            var tempCharDizisi = tempSekizli.ToCharArray();


            for (int i = 0; i < tempSekizli.Length - 1; i++)
            {
                char c1 = tempSekizli[i];
                tempCharDizisi[i] = tempSekizli[i + 1];
                tempCharDizisi[i + 1] = c1;
                string tempString = "";
                foreach (var item in tempCharDizisi)
                {
                    tempString += item.ToString();
                }
                tempCharDizisi = tempString.ToCharArray();
                temp.Add(tempString);
            }
            return temp;
        }

        public void Yazdir(List<string> temp)
        {
            Console.WriteLine("---Harfler---");
            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
