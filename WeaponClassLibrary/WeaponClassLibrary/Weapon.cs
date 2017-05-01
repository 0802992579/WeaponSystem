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

        public override string ToString()
        {
            return string.Format("Name: {0} {1}\nWeight: {2:N2}\nDamageType: {3}\nDamage: {4}\nRange: {5:N2}\nValue: {6:N2}",
                 Modifier, Name, Weight, DamageType, Damage, Range, Value);
        }

        public virtual void CreateRandom()
        {
            //nothing done      
        }
    }
}
