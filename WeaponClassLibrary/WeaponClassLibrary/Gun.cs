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
    public class Gun : ProjectileWeapon
    {
        Projectile bullet = new Projectile("Bullet", 0.5, "Piercing", 100, 0.1);
        public Gun(string modifier, double weight, double range, double value)
             : base(modifier, "Gun", weight, range, value)
        {
            this.DamageType = bullet.DamageType;
            this.Damage = bullet.Damage;
        }


        public static new Gun CreateRandom()
        {
            double base_value = 50;
            double base_range = 200;
            //int base_damage = 4;
            double base_weight = 0.5;
            Random random = new Random();
            var names = new List<string> { "9mm", ".25 caliber", "4mm", "Badly made 6mm", ".32 caliber" };
            var mod_value = new List<double> { 10, 10, -10, -20, 25 };
            //var mod_damage = new List<int> { 0, -3, 0, -1, +5 };
            var mod_range = new List<double> { 0, 200, -100, -100, 250 };
            var mod_weight = new List<double> { 0.1, 0.1, -0.1, -0.1, 0.1 };

            int index = random.Next(names.Count);
            var name = names[index];

            double value = calc_value(mod_value, index, base_value, random.Next(0, 10));
            double range = calc_value(mod_range, index, base_range, random.Next(1, 10));
            //int damage = calc_value(mod_damage, index, base_damage, random.Next(1, 4));
            double weight = calc_value(mod_weight, index, base_weight, (random.Next(1, 10) / 10));

            Gun found_gun = new Gun(names[index], weight, range, value);
            return found_gun;
        }
    }
}
