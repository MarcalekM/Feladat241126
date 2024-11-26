using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Feladat241126
{
    internal class Szemely
    {
        public Guid Guid { get; }
        public string Nev { get; set; }
        public override string ToString() => $"{Nev} (GUID: {Guid})";

        public Szemely(string nev) { 
            Guid = Guid.NewGuid();
            Nev = nev;
        }
    }
}
