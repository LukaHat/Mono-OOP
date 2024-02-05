using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Racunalo : Igrac, IAkcija
    {
        public void OdaberiAkciju(Igrac protivnik)
        {
            Console.WriteLine("Racunalo bira nasumicnu akciju");
            Random NasumicniBroj = new Random();
            string OdabranaAkcija = NasumicniBroj.Next(1,3).ToString();
            Console.WriteLine("Nasumicno odabrana akcija: " + OdabranaAkcija);

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
