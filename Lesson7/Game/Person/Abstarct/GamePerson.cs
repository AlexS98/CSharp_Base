using Lesson7.Game.Abstract;
using Lesson7.Game.Equipment.Interfaces;

namespace Lesson7
{
    public abstract class GamePerson : IDamagable
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public CharacterClass Class { get; set; }
        public bool Gender { get; set; }

        public int HealthPoints { get; set; }
        public int Mana { get; set; }
        public uint Level { get; set; }
        public int Money { get; set; }

        public Armor Armor { get; set; }
        public Helmet Helmet { get; set; }
        public Weapon Weapon { get; set; }

        public void ReceiveDamage(int damage, int attackType)
        {
            switch (attackType)
            {
                case 1:
                    {
                        int resistance = 0;

                        if(Armor != null)
                        {
                            resistance += Armor.CommonResistance;

                            if (Armor is IMeleeResistance meleeArmor)
                            {
                                resistance += meleeArmor.MeleeResistance;
                            }

                            Armor.BlockDamage(damage);
                        }

                        if (Helmet != null)
                        {
                            resistance += Helmet.CommonResistance;

                            if (Helmet is IMeleeResistance meleeHelmet)
                            {
                                resistance += meleeHelmet.MeleeResistance;
                            }

                            Helmet.BlockDamage(damage);
                        }

                        if (damage <= resistance)
                        {
                            break;
                        }
                        else
                        {
                            HealthPoints -= damage - resistance;
                        }


                        break;
                    }
                case 2:
                    {
                        // IRangedResistance
                        break;
                    }
                case 3:
                    {
                        // IMagicResistance
                        break;
                    }
                default: break;
            }
        }
    }
}
