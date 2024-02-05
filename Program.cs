using System;

namespace ConsoleApp1 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Koliko redova zelite da igra traje: ");
            string TrajanjeIgre = Console.ReadLine();
            int TranjeIgreBroj = int.Parse(TrajanjeIgre);

            var Akcije = new List<string>();
            Akcije.Add("1) Napad");
            Akcije.Add("2) Ozdravi");
            Akcije.Add("3) Ojacaj");



            Console.WriteLine("Dobro dosli u igru, igra traje " + TrajanjeIgre + " redova, a dostupne akcije su: ");
            Akcije.ForEach(action =>Console.WriteLine(action));

              Racunalo Racunalo1 = new Racunalo();
              Korisnik Korisnik1 = new Korisnik();


            for(int i = 0; i < TranjeIgreBroj; i++) {
                Korisnik1.OdaberiAkciju(Racunalo1);
                Korisnik1.IspisStanja();

                Racunalo1.OdaberiAkciju(Korisnik1);
                Racunalo1.IspisStanja();
            }

            if(Korisnik1.Zdravlje > Racunalo1.Zdravlje)
            {
                Console.WriteLine("Cestitamo pobijedili ste!");
            }
            else
            {
                Console.WriteLine("Racunalo je pobijedilo");
            }
        }
    }
}