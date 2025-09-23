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
            /* Film f = new Film();
             f.cim = "Feláldozhatók";
             f.rendezo = "Sylvester Stallone";
             f.ev = 2010;
             f.hossz_p = 103;

             Film m = new Film();
             f.cim = "A halott menyasszony";
             f.rendezo = "Tim Burton";
             f.ev = 2005;
             f.hossz_p = 77;*/

            Film[] tömb = new Film[3];
            

            int szam = 0;

            for (int i = 0; i < 3; i++)
            {
                szam++;
                Console.WriteLine($"Add meg a(z) {szam} film címét: ");
                string bekert_film = Console.ReadLine();

                Console.WriteLine("Rendező: ");
                string rendezo = Console.ReadLine();

                Console.WriteLine("Év: ");
                int ev = int.Parse(Console.ReadLine());

                Console.WriteLine("Hossz (percben): ");
                int hossz = int.Parse(Console.ReadLine());

                Film film = new Film();
                film.cim = bekert_film;
                film.rendezo = rendezo;
                film.ev = ev;
                film.hossz_p = hossz;

                tömb[i] = film;
            }


            Console.ReadKey();
        }
        
    }
}
