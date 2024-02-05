using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Korisnik : Igrac, IAkcija
    {

        public void OdaberiAkciju(Igrac protivnik)
        {
            Console.WriteLine("Odaberi akciju: ");

            string OdabranaAkcija = Console.ReadLine();

            switch (OdabranaAkcija)
            {
                case "1":
                    Napad(protivnik);
                    break;
                case "2":
                    Ozdravi();
                    break;
                case "3":
                    Ojacaj();
                    break;
                default:
                    Console.WriteLine("Odaberite jednu od navedene 3 akcije");
                    break;
            }

            
            switch (TrenutniIgrac)
            {
                case "Korisnik":
                    TrenutniIgrac = "Racunalo";
                    break;
                case "Racunalo":
                    TrenutniIgrac = "Korisnik";
                    break;
            }
        }
    }
}

