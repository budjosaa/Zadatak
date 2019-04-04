using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtkupnoMestoClass;
using UgovorClass;
using PoreskaIzjavaClass;
using AmbalazaClass;
namespace ProizvodjacClass
{
    class Proizvodjac
    {
        private List<Ambalaza> ambalaza;
        private string ime;
        private string prezime;
        private string JMBG;
        private string telefon;
        private Ugovor ugovor;
        private double povrsinaParcele;
        private string tekuciRacun;
        private OtkupnoMesto otkupnoMesto;
        private PoreskaIzjava poreskaIzjava;

        public Proizvodjac(string ime,string prezime,string jmbg,string telefon,
            Ugovor ugovor,double povrsinaParcele,string tekuciRacun,PoreskaIzjava poreskaIzjava)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.JMBG = jmbg;
            this.telefon = telefon;
            this.ugovor = ugovor;
            this.povrsinaParcele = povrsinaParcele;
            this.tekuciRacun = tekuciRacun;
            this.otkupnoMesto =otkupnoMesto;
            this.poreskaIzjava = poreskaIzjava;
        }
        public void zaduziAmbalazu(List<Ambalaza> listaAmbalaza)
        {
            this.ambalaza = listaAmbalaza;
        }
        public void setOtkupnoMesto(OtkupnoMesto mesto)
        {
            this.otkupnoMesto = mesto;
        }
    }
}
