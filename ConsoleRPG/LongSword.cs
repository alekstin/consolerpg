using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    class LongSword : Weapon
    {
        public LongSword(int number) : base(2, number)
        {
            if (number == 1)
            {
                WeaponDamage = 4;
            }
            if (number == 2)
            {
                WeaponDamage = 8;
            }
            if (number == 3)
            {
                WeaponDamage = 15;
            }
        }
    }
}
