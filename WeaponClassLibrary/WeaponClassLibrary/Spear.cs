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
    public class Spear : ThrowingWeapon
    {
        public Spear(string modifier, double weight,  int damage, double range, double value )
            : base(modifier, "Spear", weight, damage, range, value)
        {

        }
    }
}

