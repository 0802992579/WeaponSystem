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
        public MeleeWeapon(string name, int weight, int damage, int range, int value, string modifier)
            : base(name, weight, "Blunt", damage, range, value, modifier)
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
