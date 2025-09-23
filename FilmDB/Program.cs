using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDB
{
    internal class Program
    {
        struct Film
        {
            public string Cim;
            public string Rendezo;
            public int Ev;
            public int Hossz_perc;
        }
        static void Main(string[] args)
        {
            Film f = new Film();
            f.Cim = "Feláldozhatók";
            f.Rendezo = "Sylvester Stallone";
            f.Ev = 2010;
            f.Hossz_perc = 103;

            Console.WriteLine(f.Cim);
        }
    }
}
