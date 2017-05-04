using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponClassLibrary
{
    public class Sword : MeleeWeapon
    {
        public Sword(string modifier, double weight, string damageType, int damage, double range, double value)
            : base(modifier, "Sword", weight, damageType, damage, range, value)
        {
            
        }

        public override string ShortDescription()
        {
            return base.ShortDescription();
        }
    }
}
