using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponClassLibrary
{
    class Sword : MeleeWeapon
    {
        public Sword(string modifier, string name, double weight, string damageType, int damage, double range, double value)
            : base(modifier, name, weight, damageType, damage, range, value)
        {
            
        }
    }
}
