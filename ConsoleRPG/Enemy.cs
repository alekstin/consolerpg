using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    class Enemy
    {
        public int HP { get; set; }
        public string Name { get; set; }
        public int Dmg { get; set; }

        public Enemy(string Name, int HP,int Dmg)
        {
        }

    }
}
