using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungMitarbeit3
{
    internal class Gast : Namen
    {
        

        public Gast(string vorname, string nachname) : base(vorname, nachname)
        {
        }

        public string KurzeBeschreibung { get; set; }
    }
}
