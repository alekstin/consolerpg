using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    abstract class EnemyWeapon
    {
        public int WeaponDamage { get; set; }
        public EnemyWeapon(int weaponDamage)
        {
            WeaponDamage = weaponDamage;
        }
    }
}
