using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Höfundur Ólafur Ásdísarson
22.4.2017
*/
namespace WeaponClassLibrary
{
    public class Projectile
    { 
    public string Name { get; set; }
    public int Weight { get; set; }
    public int Damage { get; set; }
    public string DamageType { get; set; }
    public int Value { get; set; }
   
    public Projectile(string name, int weight, string damagetype, int damage, int value)
    {
        Name = name;
        Weight = weight;
        DamageType = damagetype;
        Damage = damage;
        Value = value;
    }

    public override string ToString()
    {
        return string.Format("Name: {0}\nWeight: {1}\nDamageType: {2}\nDamage: {3}\nValue: {4}",
            Name, Weight, DamageType, Damage, Value);
    }

    }
}

