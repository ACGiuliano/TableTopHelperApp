using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopHelper
{
    internal class Attributes
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Stamina { get; set; }
        public int Charisma { get; set; }
        public int Manipulation { get; set; }
        public int Composure { get; set; }
        public int Intelligence { get; set; }
        public int Wits { get; set; }
        public int Resolve { get; set; }

        public Attributes(int strength, int dexterity, int stamina, int charisma, int manipulation, int composure, int intelligence, int wits, int resolve)
        {
            Strength = strength;
            Dexterity = dexterity;
            Stamina = stamina;
            Charisma = charisma;
            Manipulation = manipulation;
            Composure = composure;
            Intelligence = intelligence;
            Wits = wits;
            Resolve = resolve;
        }

        // / Default constructor initializes all attributes to 1
        public Attributes()
        {
            Strength = 1;
            Dexterity = 1;
            Stamina = 1;
            Charisma = 1;
            Manipulation = 1;
            Composure = 1;
            Intelligence = 1;
            Wits = 1;
            Resolve = 1;
        }
    }
}
