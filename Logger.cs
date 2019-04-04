using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProizvodjacClass;
using UgovorClass;
using PoreskaIzjavaClass;
using OtkupnoMestoClass;
using VoceClass;
using VoceFactoryClass;
using HladnjacaClass;

namespace LoggerClass
{
    class Logger
    {
        private static Logger logger;
        private Logger() { }
        public static Logger getInstance()
        {
            if (logger == null)
            {
                logger = new Logger();
            }
            return logger;
        }
        public Proizvodjac createProizvodjac(string ime, string prezime, string jmbg, string telefon,
            Ugovor ugovor, double povrsinaParcele, string tekuciRacun, PoreskaIzjava poreskaIzjava)
        {
            return new Proizvodjac(ime, prezime, jmbg, telefon, ugovor, povrsinaParcele, tekuciRacun,  poreskaIzjava);
        }
        public OtkupnoMesto createOtkupnoMest(string ime, Proizvodjac proizvodjac, int cena1Klase, int cena2Klase, int cena3Klase)
        {
            return new OtkupnoMesto(ime, proizvodjac, cena1Klase, cena2Klase, cena3Klase);
        }
        public List<Voce> createVoce(OtkupnoMesto otkupnoMesto)
        {
            List<Voce> listaVoca = new List<Voce>();
            VoceFactory voceFactory = new VoceFactory();
            Random rnd = new Random();
            string[] tipovi = new string[] { "Jabuka", "Kruska","Malina" };
            for (int i=0; i < 100; i++)
            {
                listaVoca.Add(voceFactory.randomVoce(rnd.Next(1, 4), tipovi[rnd.Next(0, tipovi.Length)], otkupnoMesto.getCenaVocaPrveKlase(), otkupnoMesto.getCenaVocaDrugeKlase(), otkupnoMesto.getCenaVocaTreceKlase()));
            }
            return listaVoca;
        }
        public void otkupiVoce(Hladnjaca h ,List<Voce> voces)
        {
            Console.WriteLine(h.otkupiVoce(voces));
        }
        public void pregledVoca(Hladnjaca h)
        {
            Console.WriteLine(h.pregledVoca());
        }
        
        
    }
}
