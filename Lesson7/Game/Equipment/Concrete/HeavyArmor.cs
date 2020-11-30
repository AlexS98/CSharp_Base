using Lesson7.Game.Equipment.Interfaces;

namespace Lesson7.Game.Equipment.Concrete
{
    public class HeavyArmor : Armor, IMeleeResistance, IRangedResistance
    {
        public int MeleeResistance { get; set; }
        public int RangeResistance { get; set; }

        public HeavyArmor()
        {
            MeleeResistance = 30;
            RangeResistance = 50;
        }
    }
}
