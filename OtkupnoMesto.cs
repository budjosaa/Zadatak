using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProizvodjacClass;
using VoceClass;

namespace OtkupnoMestoClass
{
    class OtkupnoMesto
    {
        private List<Voce> voce;
        private string ime;
        private Proizvodjac proizvodjac;
        private int cenaVocaPrveKlase;
        private int cenaVocaDrugeKlase;
        private int cenaVocaTreceKlase;

        public OtkupnoMesto(string ime,Proizvodjac proizvodjac,int cena1Klase,int cena2Klase,int cena3Klase)
        {
            this.ime = ime;
            this.proizvodjac = proizvodjac;
            this.cenaVocaPrveKlase = cena1Klase;
            this.cenaVocaDrugeKlase = cena2Klase;
            this.cenaVocaTreceKlase = cena3Klase;
        }
        public int getCenaVocaPrveKlase()
        {
            return this.cenaVocaPrveKlase;
        }
        public int getCenaVocaDrugeKlase()
        {
            return this.cenaVocaDrugeKlase;
        }
        public int getCenaVocaTreceKlase()
        {
            return this.cenaVocaTreceKlase;
        }
        public List<Voce> getVoceOtkupnoMesto()
        {
            return this.voce;
        }
    }
}
