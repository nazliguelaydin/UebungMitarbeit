using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungMitarbeit3
{
    internal class MitarbeiterIn : Namen
    {
        public MitarbeiterIn(string vorname, string nachname) : base(vorname, nachname)
        {
        }

        public int Personalnummer { get; set; }
    }
}
