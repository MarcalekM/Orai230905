using System;
using System.Collections.Generic;
using System.Text;

namespace Orai230905
{
    class Kategoria
    {
        public string KategoriaNev { get; set; }
        public int TulelokSzama { get; set; }
        public int EltuntekSzama { get; set; }
        public int UtasokSzama => EltuntekSzama + TulelokSzama;
        
    
        public Kategoria(string beolvasottSor)
        {
            var darabok = beolvasottSor.Split(';');
            KategoriaNev = darabok[0];
            TulelokSzama = int.Parse(darabok[1]);
            EltuntekSzama = int.Parse(darabok[2]);
        }
    
    }
}
