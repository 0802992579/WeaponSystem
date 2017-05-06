using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponClassLibrary
{
    public class Sword : MeleeWeapon
    {
        public Sword(string modifier, double weight, string damageType, int damage, double range, double value)
            : base(modifier, "Sword", weight, damageType, damage, range, value)
        {
            
        }


        public static new Sword CreateRandom() //creates and returns a random sword
        {
            double base_value = 10;
            double base_range = 1;
            int base_damage = 6;
            double base_weight = 1.2;
            Random random = new Random();
            var names = new List<string> { "Common", "Golden", "Two-Handed", "Badly made", "Sharpened" };
            var mod_value = new List<double> { 0, 200, 100, -10, 50 };
            var mod_damage = new List<int> { 0, -3, +5, -1, +2 };
            var mod_range = new List<double> { 0, 0, 0.5, -0.1, 0 };
            var mod_weight = new List<double> { 0, 10, 5, 0, 0 };

            int index = random.Next(names.Count);
            var name = names[index];

            double value = calc_value(mod_value, index, base_value, random.Next(0, 10));
            double range = calc_value(mod_range, index, base_range, (random.Next(1, 5)/10));
            int damage = calc_value(mod_damage, index, base_damage, random.Next(1, 4));
            double weight = calc_value(mod_weight, index, base_weight, (random.Next(5, 20)/10));

            Sword found_sword = new Sword(names[index], weight, "Slashing", damage, range, value);
            return found_sword;
        }

    }
}
