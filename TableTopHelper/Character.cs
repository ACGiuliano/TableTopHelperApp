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
        public int Health { get; set; }
        public int Willpower { get; set; }
        public int Humanity { get; set; } = 7; // Default humanity value for a new character in VtM

        public Attributes Attributes { get; set; } = new Attributes();

        public Character(string name, string clan, string concept, string ambition, string desire, string sire, int generation, int health, int willpower, int humanity, Attributes attributes)
        {
            Name = name;
            Clan = clan;
            Concept = concept;
            Ambition = ambition;
            Desire = desire;
            Sire = sire;
            Generation = generation;
            Health = health;
            Willpower = willpower;
            Humanity = humanity;
            Attributes = attributes;
        }
    }
}
