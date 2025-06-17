using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;



namespace OOPA5;



internal class Player : Game1  // Inherits boilerplate from the Game1 class (makes Content.Load work nicely)
                                // Although, I'm sure this isn't what you were looking for with inheritance.
                                // I have a good feeling this will have problems if I get too carried away with dev?
{
    
    
   

    public Player()
    {

        // Sets the mouse cursor to scope / receptacle for targeting
        //_mouseScope = Content.Load<Texture2D>("img/player/fireReceptacle"); // tried, but I'm missing something here..

    }
}