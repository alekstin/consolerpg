using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    abstract class Weapon
    {
        public int WeaponDamage { get; set; }
        public int Upgrade { get; set; }
        public Weapon(int weaponDamage, int upgrade)
        {
            WeaponDamage = weaponDamage;
            Upgrade = upgrade;
        }

    }

}
