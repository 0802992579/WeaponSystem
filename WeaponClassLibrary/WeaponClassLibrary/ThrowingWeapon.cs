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
    public class ThrowingWeapon : Weapon
    {
        public ThrowingWeapon(string modifier, string name, double weight, int damage, double range, double value )
            : base(modifier, name, weight, "Piercing", damage, range, value)
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

        public override string ShortDescription()
        {
            return base.ShortDescription();
        }
    }
}

