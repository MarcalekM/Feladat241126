using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Feladat241126
{
    internal class Auto
    {
        private List<Szemely> tulajdonosok;

        public string Rendszam { get; set; }
        public string Gyarto { get; set; }
        public string Modell { get; set; }
        public int Terfogat { get; set; }
        public int Teljesitmeny { get; set; }
        public float Fogyasztas { get; set; }

        public string TulajdonosokLekérdezése() => string.Join('\n', tulajdonosok);

        public void UjTulajdonosokListábaVétele(params string[] nevek)
        {
            foreach (var nev in nevek) tulajdonosok.Add(new(nev));
        }

        public override string ToString()
        {
            return $"[{Rendszam}] {Gyarto} {Modell} ({Teljesitmeny} hp, {Terfogat} cc, {Fogyasztas} mpg)";
        }

        public Auto(string rendszam) : this(rendszam, "Peugeto", "206", 1124, 60, 41.27f)
        {
            tulajdonosok = [];
        }

        public Auto(string rendszam, string gyarto, string modell, int terfogat, int teljesitmeny, float fogyasztas, params string[] nevek)
        {
            Rendszam = rendszam ;
            Gyarto = gyarto ;
            Modell = modell ;
            Terfogat = terfogat ;
            Teljesitmeny = teljesitmeny ;
            Fogyasztas = fogyasztas;
            tulajdonosok = [];
            foreach (var nev in nevek) tulajdonosok.Add(new(nev));
        }
    }
}
