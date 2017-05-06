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
        public Bow(string modifier, double weight, double range, double value)
            : base(modifier, "Bow", weight, range, value)
        {
            this.DamageType = arrow.DamageType;
            this.Damage = arrow.Damage;
        }


        public static new Bow CreateRandom()
        {
            double base_value = 7;
            double base_range = 100;
           // int base_damage = 4;
            double base_weight = 1;
            Random random = new Random();
            var names = new List<string> { "Common", "Compound", "Light", "Badly made", "Oak" };
            var mod_value = new List<double> { 0, 200, 100, -10, 250 };
            //var mod_damage = new List<int> { 0, 3, 0, -1, 3 };
            var mod_range = new List<double> { 0, 10, 5, -20, 5 };
            var mod_weight = new List<double> { 0, 10, -0.5, 0, 2};

            int index = random.Next(names.Count);
            var name = names[index];

            double value = calc_value(mod_value, index, base_value, random.Next(0, 10));
            double range = calc_value(mod_range, index, base_range, random.Next(1, 10));
            //int damage = calc_value(mod_damage, index, base_damage, random.Next(1, 4));
            double weight = calc_value(mod_weight, index, base_weight, (random.Next(5, 20) / 10));

            Bow found_bow = new Bow(names[index], weight, range, value);
            return found_bow;
        }
    }
}
