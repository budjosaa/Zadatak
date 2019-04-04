using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoceClass;
using VoceDrugeKlaseClass;
using VocePrveKlaseClass;
using VoceTreceKlaseClass;
namespace VoceFactoryClass
{
    class VoceFactory
    {
       
        public Voce randomVoce(int klasa,string naziv,int cena1Klase,int cena2Klase,int cena3Klase )
        {
            if (klasa == 1)
            {
                return new VocePrveKlase(cena1Klase, naziv);
            }
            else if(klasa == 2)
            {
                return new VoceDrugeKlase(cena2Klase, naziv);
            }
            else
            {
                return new VoceTreceKlase(cena3Klase, naziv);
            }
  
        }
    }
}
