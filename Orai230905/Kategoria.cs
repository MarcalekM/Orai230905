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
    
        public Kategoria(string beolvasottSor)
        {
            var darabok = beolvasottSor.Split(';');
            this.KategoriaNev = darabok[0];
            this.TulelokSzama = int.Parse(darabok[1]);
            this.EltuntekSzama = int.Parse(darabok[2]);
        }
    
    }
}
