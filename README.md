# Object-Oriented Programming Assignment 5! The Final Boss Battle!

This final project for the course needs an emphasis on:

- [ ] Objects
* - [ ] Multiple Unique and properly implimented classes
- [ ] Use of inerhitance & polymorphism
- [ ] Good use of collectins, lists, or arrays
- [ ] Good use of MonoGame, Unity or GMS2 (is the game/experience/prototype working effectively in chosen engine
- [ ] Game/experience/prototype designed with some thought and is interesting
- [ ] Effective use of VCS tools (GitHub)
- [ ] *Bonus (ungraded but would be a cool idea) is use of object pooling.


Breakdown of concepts

Space Saver!

A game where you defend your space station from hostile space things << wow that's terrible!

Basically the player is in orbit of a space-station on which they live. but they're job is to protect the space station from comets and foreign ships and space monsters that are on a collision course for the station. Much like how we have lasers that help protect the earth from the same, >> wait, that's 200 years from now.
The player's mouse will be a target receptacle in which they fire a high speed cannon or machine gun, and destroy the enemy. But don't worry, friendly fire is on
Anyway, a basic prototype would include the following

* polymorphic objects will be enemies. parent (superclass) objects will be a default class for meteors, monsters, ships. each will have their own unique "heath", as in how many damage points (aka hit points / HP) it can take before it's destroyed, and how many damage points (aka attack points AP) that is dealt to the space station for every second the enemy is colliding with the station. something (do be determined) will be inherited from the superclass
* a use of collection/list can be a list of different ammo the player has acquired and can cycle through them.
* Monogame already tracks mouse movement and can drag sprites. auto-tracking the receptacle should be simple enough.
* Bonus feature with object pooling can the ammunition for the player (bullet-hell)

basic layout of classes (subject to change):

- Counter.cs: this will be a score keeping system (this will likely change)
- Player.cs: this will be "everything" related to the player, such as ammo count, ammo type, receptacle data, and so on.
- Ammo.cs: this defines all the different types of ammo (No less than 2 as proof of concept)
there should be 2 classes of ammo with a unique name
- Station.cs: this will be the object the player defends
- Ememy.cs: parent class of enemies
- Meteor.cs: subclass of Enemy
- Monster.cs subclass of Enemy
- BaddieShip.cs: subclass of Enemy. As the name implies, foreign/hostile ships on collision course

More to follow
