using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Igrac : PocetnoStanje
    {

        public string TrenutniIgrac = "Korisnik";


        public int Zdravlje
        {
            get { return zdravlje; }
            set { zdravlje = value; }
        }


        public int NapadackaMoc
        {
            get { return napad; }
            set { napad = value; }
        }


        public int Red
        {
            get { return red; }
            set { red = value; }
        }

        public virtual void Napad(Igrac protivnik)
        {
            protivnik.Zdravlje -= this.NapadackaMoc;
            this.Red++;

        }


        public void Ozdravi()
        {
            this.Zdravlje++;
            this.Red++;
        }

        public void Ojacaj()
        {
            this.NapadackaMoc++;
            this.Red++;
        }

        public void IspisStanja()
        {
            Console.WriteLine(this.TrenutniIgrac + "\nTrenutno imate: " + this.Zdravlje + " zdravlja , napad vam je: " + this.NapadackaMoc + " bodova, red je: " + this.Red);
            if(this.Zdravlje < 0)
            {
                Console.WriteLine("Nazalost izgubili ste igru");
                
            }
        }


        }
    }

