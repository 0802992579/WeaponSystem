using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Höfundur Ólafur Ásdísarson
22.4.2017
*/

namespace WeaponClassLibrary
{
    public class MeleeWeapon : Weapon
    {
        public MeleeWeapon(string modifier, string name, double weight,string damageType, int damage, double range, double value)
            : base(modifier, name, weight, damageType, damage, range, value)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void CreateRandom()
        {
            base.CreateRandom();
        }
    }
}
