using System.Collections.Generic;

namespace ConsoleWordMatch
{
    public interface IJokerliBasamaklar
    {
        List<string> dokuz_basamaklilar { get; set; }
        List<string> sekiz_basamaklilar { get; set; }
        List<string> yedi_basamaklilar { get; set; }
        List<string> alti_basamaklilar { get; set; }
        List<string> bes_basamaklilar { get; set; }
        List<string> dort_basamaklilar { get; set; }
        List<string> uc_basamaklilar { get; set; }
    }
}
