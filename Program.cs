using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggerClass;
using VoceFactoryClass;
using VoceClass;
using ProizvodjacClass;
using HladnjacaClass;
using UgovorClass;
using PoreskaIzjavaClass;
using OtkupnoMestoClass;
namespace Zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Ugovor ugovor = new Ugovor();
            PoreskaIzjava poreskaIzjava = new PoreskaIzjava();
           Proizvodjac Pero= Logger.getInstance().createProizvodjac("Pero", "Peric", "06156166", "066123456", ugovor, 20, "123456789", poreskaIzjava);
           OtkupnoMesto Cacak= Logger.getInstance().createOtkupnoMest("cacak", Pero, 5, 4, 3);
            List<Voce> proizvedeneVocke = Logger.getInstance().createVoce(Cacak);
            Hladnjaca hladnjaca = new Hladnjaca();
            Pero.setOtkupnoMesto(Cacak);
            Logger.getInstance().otkupiVoce(hladnjaca, proizvedeneVocke);
            Logger.getInstance().pregledVoca(hladnjaca);

            //Nisam stigao sve funkcionalnosti da odradim ,nadam se da ce biti dovoljno...
            

        }
    }
}
