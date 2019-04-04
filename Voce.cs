using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoceClass
{
    abstract class Voce
    {
        protected int cena;
        protected string naziv;
        public Voce(int cen, string naz)
        {
            this.cena = cen;
            this.naziv = naz;
        }
        public virtual void setCena(int c)
        {
            this.cena = c;
        }
        public virtual void setNaziv(string n)
        {
            this.naziv = n;
        }
        public virtual int getCena()
        {
            return this.cena;
        }
        public virtual string getNaziv()
        {
            return this.naziv;
        }
    }
}
