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
    public class Bow : ProjectileWeapon
    {
        Projectile arrow = new Projectile("Arrow", 10, "Piercing", 2, 1);
        public Bow(string modifier, string name, int weight, int range, int value)
            : base(modifier, name, weight, range, value)
        {
            this.DamageType = arrow.DamageType;
            this.Damage = arrow.Damage;
        }
    }
}
