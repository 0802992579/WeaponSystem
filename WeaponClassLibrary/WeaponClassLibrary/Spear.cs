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

        public static new Spear CreateRandom()
        {
            double base_value = 5;
            double base_range = 10;
            int base_damage = 4;
            double base_weight = 1;
            Random random = new Random();
            var names = new List<string> { "Common", "Golden", "Light", "Badly made", "Godly" };
            var mod_value = new List<double> { 0, 200, 100, -10, 250 };
            var mod_damage = new List<int> { 0, -3, 0, -1, +5 };
            var mod_range = new List<double> { 0, 0, 5, -3, 10 };
            var mod_weight = new List<double> { 0, 10, -0.5, 0, -0.5 };

            int index = random.Next(names.Count);
            var name = names[index];

            double value = calc_value(mod_value, index, base_value, random.Next(0, 10));
            double range = calc_value(mod_range, index, base_range, random.Next(1, 10));
            int damage = calc_value(mod_damage, index, base_damage, random.Next(1, 4));
            double weight = calc_value(mod_weight, index, base_weight, (random.Next(5, 20) / 10));

            Spear found_spear = new Spear(names[index], weight, damage, range, value);
            return found_spear;
        }

    }
}

