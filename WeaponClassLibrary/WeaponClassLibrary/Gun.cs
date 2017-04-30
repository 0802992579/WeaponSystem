using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponClassLibrary
{
    class Gun : ProjectileWeapon
    {
        Projectile bullet = new Projectile("Bullet", 50, "Piercing", 2, 1);
        public Gun(string name, int weight, int range, int value, string modifier)
            : base(name, weight, range, value, modifier)
        {
            this.DamageType = bullet.DamageType;
            this.Damage = bullet.Damage;
        }
    }
}
