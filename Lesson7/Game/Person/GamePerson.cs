using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    public class GamePerson
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public CharacterClass Class { get; set; }
        public bool Gender { get; set; }

        public int Health { get; set; }
        public int Mana { get; set; }
        public uint Level { get; set; }
        public int Money { get; set; }

        public Armor Armor { get; set; }
        public Helmet Helmet { get; set; }
        public Weapon Weapon { get; set; }
    }
}
