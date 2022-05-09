using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungMitarbeit3
{
    internal class Namen
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }

        public Namen(string vorname, string nachname)
        {
            this.Vorname = vorname;
            this.Nachname = nachname;   
        }

        List<Name> namen = new List<Name>();

        public void AddName(Name n)
        {
            namen.Add(n);
        }
    }
}
