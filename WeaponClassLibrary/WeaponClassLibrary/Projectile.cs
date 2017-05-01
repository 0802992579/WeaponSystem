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
    public double Weight { get; set; }
    public int Damage { get; set; }
    public string DamageType { get; set; }
    public double Value { get; set; }
   
    public Projectile(string name, double weight, string damagetype, int damage, double value)
    {
        Name = name;
        Weight = weight;
        DamageType = damagetype;
        Damage = damage;
        Value = value;
    }

    public override string ToString()
    {
        return string.Format("Name: {0}\nWeight: {1:N2}\nDamageType: {2}\nDamage: {3}\nValue: {4:N2}",
            Name, Weight, DamageType, Damage, Value);
    }

    }
}

