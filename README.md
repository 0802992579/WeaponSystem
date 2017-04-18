WeaponSystem is class system is create and control stats for weapons.

The main class in the system is the Weapon Class that all other Weapons classes inherit from.
Three other classes inherit from the Weapon Class - MeleeWeapon, ProjectileWeapon, Throwing Weapon
All weapons inherit from these three Classes.
Four weapons are provided in the system Sword (inherites form MeleeWeapon), Spear (inherites from ThrowingWeapon) and Bow and Gun (inherites from Projectile Weapon)

The WeaponSystem also has a class called Projectile which is a type of Projectile that Projectile uses 
Two Projectiles are provided Arrow and Bullet - that Bow and Gun use

The WeaponSystem can create a Random Weapon that can be found by the user

There is also Inventory class where the user stores Weapons and uses them

****************
WeaponClass
****************
Properties
String Name - the name of the Weapon
Int Weight - the weight of the Weapon
String DamageType - type of damage Blunt, Slashing, Piercing
Int Damage - the damage done
Int Range - the range of the Weapon
int value - the Value of the Weapon if sold
String Modifier -

Functions
Weapon() - initializer
ToString - returns a description of the Weapon
CreateRandom() - creates a random version of the Weapon

*****************
MeleeWeapon and ThrowingWeapon 
*****************
Same properties and functions as in the function class

*****************
ProjectileWeapon
*****************
Same properties and functions as in the function class
Properties
a Instance of the Class Projectile which describes what kind of Projectile it can use

****************
Projectile
****************
Properties
String Name - the name of the Weapon
Int Weight - the weight of the Weapon
String DamageType - type of damage Blunt, Slashing, Piercing
Int Damage - the damage done
int value - the Value of the Weapon if sold

Functions
Projectile() - initializer
ToString - returns a description of the Projectile

****************
InventoryClass
****************
Properties
List Item - item incl. weapons stored in the Inventory

Functions
Inventory() - initializer
AddItem()
DropItem()
UseItem()
