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
        public string Name { get; set; }
        public int Weight { get; set; }
        public string DamageType { get; set; }
        public int Damage { get; set; }
        public int Range { get; set; }
        public int Value { get; set; }
        public string Modifier { get; set; }

        public Weapon(string name, int weight, string damagetype, int damage, int range, int value, string modifier)
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
            return string.Format("Name: {0}\nWeight: {1}\nDamageType: {2}\nDamage: {3}\nRange: {4}\nValue: {5}\nModifier: {6}",
                Name, Weight, DamageType, Damage, Range, Value, Modifier);
        }

        public virtual void CreateRandom()
        {
            //nothing done      
        }
    }
}
