using System;

namespace ConsoleWordMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            RastgeleYapici rastgeleYapici = new RastgeleYapici();
            var sekiz = rastgeleYapici.SekizTane_HarfOlustur();
            rastgeleYapici.Yazdir(sekiz);


            BasamakBasamak basamak = new BasamakBasamak();

            var yedi = basamak.YediAltiBesDortUcListesi(sekiz);
            basamak.Yazdir(yedi);

            //var alti = basamak.YediAltiBesDortUcListesi(yedi);
            //basamak.Yazdir(alti);

            //var bes = basamak.YediAltiBesDortUcListesi(alti);
            //basamak.Yazdir(bes);

            //var dort = basamak.YediAltiBesDortUcListesi(bes);
            //basamak.Yazdir(dort);

            //var uc = basamak.YediAltiBesDortUcListesi(dort);
            //basamak.Yazdir(uc);

            //var iki = basamak.YediAltiBesDortUcListesi(uc);
            //basamak.Yazdir(iki);

            Jokerler jokerler = new Jokerler();
            //var sekizkombin = jokerler.Jokerli_AnlamsizKelimeOlustur(sekiz);
            //jokerler.Yazdir(sekizkombin);

            var yedicombin = jokerler.Jokerli_AnlamsizKelimeOlustur(yedi);
            jokerler.Yazdir(yedicombin);
            Console.Read();
        }
    }

}
