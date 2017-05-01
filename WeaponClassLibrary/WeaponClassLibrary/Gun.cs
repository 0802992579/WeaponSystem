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
    class Gun : ProjectileWeapon
    {
        Projectile bullet = new Projectile("Bullet", 0.5, "Piercing", 100, 0.1);
        public Gun(string modifier, string name, double weight, double range, double value)
             : base(modifier, name, weight, range, value)
        {
            this.DamageType = bullet.DamageType;
            this.Damage = bullet.Damage;
        }
    }
}
