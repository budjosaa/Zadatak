using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoceClass;

namespace VocePrveKlaseClass
{
    class VocePrveKlase:Voce
    {
        public VocePrveKlase(int cen,string naz) : base(cen, naz) { }
        public override int getCena()
        {
            return base.getCena();
        }
        public override string getNaziv()
        {
            return base.getNaziv();
        }
        public override void setCena(int c)
        {
            base.setCena(c);
        }
        public override void setNaziv(string n)
        {
            base.setNaziv(n);
        }
    }
}
