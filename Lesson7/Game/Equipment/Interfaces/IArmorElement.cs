using System;
using System.Collections.Generic;
using System.Text;
using Lesson7.Game.Equipment.Interfaces;

namespace Lesson7.Game.Equipment
{
    public interface IArmorElement : IDestructable
    {
        int CommonResistance { get; set; }
    }
}
