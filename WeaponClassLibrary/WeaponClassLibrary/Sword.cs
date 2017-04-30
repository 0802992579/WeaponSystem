using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponClassLibrary
{
    class Sword : MeleeWeapon
    {
        public Sword(string name, int weight, int damage, int range, int value, string modifier)
            : base(name, weight, damage, range, value, modifier)
        {
            
        }
    }
}
