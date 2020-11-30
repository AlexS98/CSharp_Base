using System;
using System.Collections.Generic;
using System.Text;
using Lesson7.Game.Equipment;

namespace Lesson7
{
    public abstract class Armor : ICarriable, IArmorElement
    {
        public int Weight { get; set; }
        public int Size { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public int CommonResistance { get; set; }
        public int Durability { get; set; }

        public void BlockDamage(int damage)
        {
            Durability -= (int)(damage * 0.15);
        }
    }
}
