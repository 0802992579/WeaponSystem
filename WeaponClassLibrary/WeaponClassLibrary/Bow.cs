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
        public Bow(string name, int weight, int range, int value, string modifier)
            : base(name, weight, range, value, modifier)
        {
            this.DamageType = arrow.DamageType;
            this.Damage = arrow.Damage;
        }
    }
}
