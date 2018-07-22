using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    class Character
    {
        public int Exp { get; set; }
        public int HP { get; set; }
        public int DealDamage { get; set; }
        public int TakeDamage { get; set; }
        public int OnDeath { get; set; }
        public string Name { get; set; }

        public Character(string Name, int Exp, int HP, int DealDamage, int TakeDamage, int OnDeath)
        {
        }
    }
}
