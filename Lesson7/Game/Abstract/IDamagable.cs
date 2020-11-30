using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7.Game.Abstract
{
    public interface IDamagable
    {
        int HealthPoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="damage"></param>
        /// <param name="attackType">1 - melee, 2 - range, 3 - mag</param>
        void ReceiveDamage(int damage, int attackType);
    }
}
