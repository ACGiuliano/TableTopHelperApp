using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopHelper
{
    internal class Character
    {
        public string Name { get; set; }
        public string Clan { get; set; }
        public string Concept { get; set; }
        public string Ambition { get; set; }
        public string Desire { get; set; }
        public string Sire { get; set; }
        public int Generation { get; set; }

        public Character(string name, string clan, string concept, string ambition, string desire, string sire, int generation)
        {
            Name = name;
            Clan = clan;
            Concept = concept;
            Ambition = ambition;
            Desire = desire;
            Sire = sire;
            Generation = generation;
        }
    }
}
