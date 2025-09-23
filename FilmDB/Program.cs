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
            public string cim;
            public string rendezo;
            public int ev;
            public int hossz_p;
        }
        static void Main(string[] args)
        {
            Film f = new Film();
            f.cim = "Feláldozhatók";
            f.rendezo = "Sylvester Stallone";
            f.ev = 2010;
            f.hossz_p = 103;

            Film m = new Film();
            f.cim = "A halott menyasszony";
            f.rendezo = "Tim Burton";
            f.ev = 2005;
            f.hossz_p = 77;

            Console.ReadKey();
        }
        
    }
}
