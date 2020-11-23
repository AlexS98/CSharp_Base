using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    public class Character : GamePerson
    {
        public User Owner { get; set; }
        public Inventory Inventory { get; set; }

        public Character(string name, string race, CharacterClass @class, bool gender, User user)
        {
            Name = name;
            Race = race;
            Class = @class;
            Gender = gender;
            Owner = user;
        }


    }
}
