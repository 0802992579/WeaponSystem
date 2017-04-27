using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponClassLibrary
{
    public class Bow : ProjectileWeapon
    {
        Projectile arrow = new Projectile("arrow", 10, "Piercing", 2, 1);
        public Bow(string name, int weight, int range, int value, string modifier)
            : base(name, weight, range, value, modifier)
        {
            this.DamageType = arrow.DamageType;
            this.Damage = arrow.Damage;
        }
    }
}
