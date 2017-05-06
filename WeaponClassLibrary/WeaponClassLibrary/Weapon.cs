using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Höfundur Ólafur Ásdísarson
17.4.2017
*/

namespace WeaponClassLibrary
{
    public class Weapon
    {
        public string Modifier { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public string DamageType { get; set; }
        public int Damage { get; set; }
        public double Range { get; set; }
        public double Value { get; set; }
      
        public Weapon(string modifier, string name, double weight, string damagetype, int damage, double range, double value)
        {
            Name = name;
            Weight = weight;
            DamageType = damagetype;
            Damage = damage;
            Range = range;
            Value = value;
            Modifier = modifier;
       }

        public override string ToString() //Describes weapon
        {
            return string.Format("Name: {0} {1}\nWeight: {2:N2} kg\nDamageType: {3}\nDamage: {4}\nRange: {5:N2} m\nValue: {6:N2} gold coins",
                 Modifier, Name, Weight, DamageType, Damage, Range, Value);
        }

        public virtual string ShortDescription() //returns name
        {
            return string.Format("{0} {1}", Modifier, Name);
        }

        public static void CreateRandom()
        {
            //nothing done      
        }

        //calculates value for properties for random item return double
        public static double calc_value(List<double> list, int index, double base_value, double rnd_nr)
        {
            double value =  base_value + list[index] + rnd_nr;
            if (value < 0)  { value = 0; }
            return value;
        }

        //calculates value for properties for random item return int
        public static int calc_value(List<int> list, int index, int base_value, int rnd_nr)
        {
            int value = base_value + list[index] + rnd_nr;
            if (value < 0) { value = 0; }
            return value;
        }
    }
}
