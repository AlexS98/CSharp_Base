using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7.Game.Equipment.Interfaces
{
    public interface IDestructable
    {
        int Durability { get; set; }
        void BlockDamage(int damage);
    }
}
