using System;
using System.Collections.Generic;
using System.Text;
using Lesson7.Game.Equipment.Interfaces;

namespace Lesson7.Game.Equipment.Concrete
{
    public class InfantryArmor : Armor, IRangedResistance
    {
        public int RangeResistance { get; set; }
    }
}
