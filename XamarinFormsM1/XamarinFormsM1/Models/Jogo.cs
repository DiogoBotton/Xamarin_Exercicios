using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsM1.Models
{
    public class Jogo
    {
        public static List<Jogo> Jogos = new List<Jogo>();
        public Time TimeCasa{ get; set; }
        public Time TimeVisitante { get; set; }
        public int PlacarCasa { get; set; }
        public int PlacarVisitante { get; set; }
        public string Estadio { get; set; }

        public Jogo()
        {

        }
    }
}
