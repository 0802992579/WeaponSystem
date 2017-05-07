*************************
WeaponClass Basic Info
*************************

WeaponSystem is class system to create and control stats for weapons.
It is a dll system that can be imported into other programs
The main class in the system is the Weapon Class that all other Weapons classes inherit from.
Three other classes inherit from the Weapon Class - MeleeWeapon, ProjectileWeapon, Throwing Weapon
All weapons inherit from these three Classes.
Four weapons are provided in the system Sword (inherites form MeleeWeapon), Spear (inherites from ThrowingWeapon) and Bow and Gun (inherites from Projectile Weapon)

The WeaponSystem also has a class called Projectile which is a type of Projectile that Projectile uses 
Two Projectiles are provided Arrow and Bullet - that Bow and Gun use

*************************
WeaponClass Class Diagram
*************************
                              ------------------
			      +    Weapon    +
                              ------------------
				      ^
				      |	
-------------------           ------------------		------------------
+   MeleeWeapon   +           + ThrowingWeapon +		+ProjectileWeapon+
-------------------           ------------------		------------------
	^			      ^				^		^
	|			      |				|		|
-------------------           ------------------	------------------	------------------
+      Sword      +           +      Spear     +	+      Bow       +	+      Gun       +
-------------------           ------------------	------------------	------------------



*************************************
Every weapon derived from WeaponClass
*************************************
Properties
----------
string Modifier 	- modifier of the the name 
string Name 		- the name of the Weapon
double Weight 		- the weight of the Weapon in  kg
string DamageType 	- type of damage e.g. Blunt, Slashing, Piercing
int Damage 		- the damage done
double Range 		- the range of the Weapon in metres
double value 		- the value of the Weapon if sold in 

weapons derived from ProjectileWeapon also have
Projectile [name]	- guns have bullet, bows have arrow


Functions
----------
(with various variables)- initializer
ToString 		- returns a long description of the Weapon
ShortDesciption()	- return a string with Modifier + Name
static CreateRandom() 	- creates a random version of the weapon


****************
Test Class
****************
A test class to test the Weapon Class is provided.
It takes the form of a simple game where the player can find weapons and sell
The test class uses a simple InventoryClass 

****************
InventoryClass
****************
Properties
List<Weapon> weapons 	- list of weapons carried
double can_carry	- amount in kg player cn carry

Functions
Add(Weapon weapon)	- adds a weapon til the list
List()			- lists all weapons carried
Drop(int i)		- drops a weapon - i = number
Sell(int i)		- sells a weapon - i = number
ShortDesciption()	- describes a weapon - i = number
Describe(int i)		- return a string with Modifier + Name
