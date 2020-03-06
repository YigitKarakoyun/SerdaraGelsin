﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWordMatch
{
    public class RastgeleYapici
    {
        Random rastgele = new Random();
        string[] harfler = Alfabe.harfler_dizisi;
        //------------------------------------------------------
        public List<string> HarfTane_AnlamsizKelimeOlustur2()
        {
            var tempYirmiBes = HarfTane_AnlamsizKelimeOlustur();

            List<string> temp = new List<string>();

            return temp;
        }
        //------------------------------------------------------
        public string[] HarfTane_AnlamsizKelimeOlustur()
        {
            string tempSekiz = SekizTane_HarfOlustur();

            string[] temp = new string[harfler.Length];
            int say = 0;
            foreach (string item in harfler)
            {
                string yeniString = item + tempSekiz;
                temp[say++]=(yeniString);
            }
                    
            return temp;
        }
        //------------------------------------------------------
        public string SekizTane_HarfOlustur()
        {
            string temp = "";
            for (int i = 0; i < 8; i++)
            {
                temp += BirTane_HarfOlustur();
            }
            return temp;
        }

        //-------------------------------------------------------
        public string BirTane_HarfOlustur()
        {
            int diziBoyut = harfler.Length;
            int rastgeleIndeks = rastgele.Next(diziBoyut);
            return harfler[rastgeleIndeks];
        }
        //Yazdır sil
        //------------------------------------------------------
        public void Yazdir(string harfler)
        {
            Console.WriteLine("---Harfler---");
            foreach (var item in harfler)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            Console.WriteLine();


        }
        public void Yazdir(string[] harflerList)
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
