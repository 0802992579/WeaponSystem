using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponClassLibrary;

/*
Ólafur Ásdísarson
2.5.2017
*/
namespace TestClass
{
    public class Inventory
    {
        List<Weapon> weapons = new List<Weapon>(); //contains Weapons
        double can_carry = 20;

        public void Add(Weapon weapon)
        {
            double i = 0;
            foreach (Weapon weapon1 in weapons)
            {
                i = i + weapon1.Weight;
            }
            i = i + weapon.Weight;
            if (i <= can_carry) { weapons.Add(weapon); }
            else Console.WriteLine("You can't carry that. You can only carry {0:N2} kg.", can_carry);
        }

        public void List() //list inventory 
        {
            double weight = 0;
            int i = 0;
            foreach (Weapon weapon in weapons)
            {
                Console.WriteLine(i++ + " " + weapon.ShortDescription());
                weight = weight + weapon.Weight;
            }
            if (i ==0)
            {
                Console.WriteLine("Nothing in inventory");
            }
            else
            {
                Console.WriteLine("You are carrying {0:N2} kg.", weight);
            }
           
        }

        public void Drop(int i) //drops item
        {
            if (i < weapons.Count())
            { 
                weapons.RemoveAt(i);
            }
        }

        public double Sell(int i) //sell items returns amount
        {
            if (i < weapons.Count())
            {
                double sell_for = weapons[i].Value;
                weapons.RemoveAt(i);
                Console.WriteLine("Sold for {0:N2} gold coins.", sell_for);
                return sell_for;
            }
            else
            {
                return 0;
            }
        }

        public void Describe(int i) //describes item
        {
            if (i < weapons.Count())
            {
                Console.WriteLine(weapons[i].ToString());
            }
        }


    }
}
