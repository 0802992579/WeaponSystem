using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Höfundur Ólafur Ásdísarson
28.4.2017
*/

namespace WeaponClassLibrary
{
    class Spear : ThrowingWeapon
    {
        public Spear(string modifier, string name, double weight,  int damage, double range, double value )
            : base(modifier, name, weight, damage, range, value)
        {

        }
    }
}

