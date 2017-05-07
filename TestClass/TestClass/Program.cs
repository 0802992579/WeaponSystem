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
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            Random random = new Random();
            double money = 0;
            firstWeapon(inventory);

            string userInput;
            int nr = 0;
            do
            {
                userInput = DisplayMenu();
                switch (userInput)
                {
                    case "L": //List inventory
                        inventory.List();
                        ListMoney(money);
                        break;
                    case "I": //Describe item
                        nr = GetItem();
                        inventory.Describe(nr);
                        break;
                    case "D": //Drop item
                        nr = GetItem();
                        inventory.Drop(nr);
                        break;
                    case "S": //Sell item
                        nr = GetItem();
                        money = money + inventory.Sell(nr);
                        break;
                    case "Q": //QUit
                        return;
                    case "F": //Find random item
                        int val = random.Next(0, 4);
                        switch (val)
                        {
                            case 0:
                               // Sword.
                                Sword found_sword = Sword.CreateRandom();
                                Console.WriteLine("You found a: ");
                                Console.WriteLine(found_sword.ToString());
                                if (PickUp().Equals("Y")) { inventory.Add(found_sword); }
                                break;
                            case 1:
                                // bow
                                Bow found_bow = Bow.CreateRandom();
                                Console.WriteLine("You found a: ");
                                Console.WriteLine(found_bow.ToString());
                                if (PickUp().Equals("Y")) { inventory.Add(found_bow); }
                                break;
                            case 2:
                                // spear
                                Spear found_spear = Spear.CreateRandom();
                                Console.WriteLine("You found a: ");
                                Console.WriteLine(found_spear.ToString());
                                if (PickUp().Equals("Y")) { inventory.Add(found_spear); }
                                break;
                            case 3:
                                // gun
                                Gun found_gun = Gun.CreateRandom();
                                Console.WriteLine("You found a: ");
                                Console.WriteLine(found_gun.ToString());
                                if (PickUp().Equals("Y")) { inventory.Add(found_gun); }
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }

             } while (!userInput.Equals('Q')) ;
         }

        public static string DisplayMenu()
        {
            //write menu
            Console.WriteLine("---------------------------");
            Console.WriteLine("Menu");
            Console.WriteLine("---------------------------");
            Console.WriteLine("L - list inventory");
            Console.WriteLine("F - find a random weapon");
            Console.WriteLine("D - drop an item from inventory");
            Console.WriteLine("I - describe an item");
            Console.WriteLine("S - sell an item");
            //Console.WriteLine("M - show money");
            Console.WriteLine("Q - quit");
            Console.Write("Choose: ");
            string result = Console.ReadLine().ToUpper();
            return result;
        }

        public static int GetItem() //ask for item nr and return
        {
            Console.Write("Item nr: ");
            int result = Convert.ToInt32( Console.ReadLine());
            return result;
        }

        public static string PickUp() //ask should pick up
        {
            Console.Write("Do you want to pick up this weapon? (Y/N)");
            string result = Console.ReadLine().ToUpper();
            return result;
        }
        public static void ListMoney(double money) //lists money
        {
            Console.WriteLine("You have got {0:N2} gold coins", money);
        }
        public static void firstWeapon(Inventory inventory) //creates weapon to start with
        {
            Sword sword = new Sword("Your first", 2.1, "Slashing", 4, 1.2, 1.1);
            inventory.Add(sword);
        }
    }
}
