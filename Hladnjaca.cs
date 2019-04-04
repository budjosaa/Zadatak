using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBasicHladnjacaInterface;
using AmbalazaClass;
using VoceClass;
using DokumentClass;
using VocePrveKlaseClass;
using VoceDrugeKlaseClass;
using VoceTreceKlaseClass;

namespace HladnjacaClass
{
    class Hladnjaca:IBasicHladnjaca
    {
        private Dokument dokument = new Dokument();
        private List<Ambalaza> listaAmbalaza = new List<Ambalaza>();
        private List<Voce> listaVocaZaOtkup;
        private int brojOtkupljenogVocaPrveKlase;
        private int brojOtkupljenogVocaDrugeKlase;
        private int brojOtkupljenogVocaTreceKlase;
        public double otkupiVoce(List<Voce> listaVocaZaOtkup)
        {
            this.dokument.setJedinstveniBroj((new Random().Next(0, 1231231)));
            int ukupnaCena=0;
            foreach(Voce vocka in listaVocaZaOtkup)
            {
                try {
                    if (vocka is VocePrveKlase)
                    {
                        this.brojOtkupljenogVocaPrveKlase += 1;
                    } else if (vocka is VoceDrugeKlase)
                    {
                        this.brojOtkupljenogVocaDrugeKlase += 1;
                    }
                    else if (vocka is VoceTreceKlase)
                    {
                        this.brojOtkupljenogVocaTreceKlase += 1;
                    } }
                catch(Exception ex)
                {
                    ex.Message.ToString();
                }
                ukupnaCena += vocka.getCena();
                }
            this.listaVocaZaOtkup = listaVocaZaOtkup;
            return ukupnaCena;
            
            
            
        }
        public List<Voce> pregledVoca()
        {
            return this.listaVocaZaOtkup;
        }
        
    }
}
