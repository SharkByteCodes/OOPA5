/*
 * This is the space station that needs to be defended
 */

using System;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OOPA5;


public class Station //: Objects
{
    
    
    private readonly Texture2D _station; // goes INSIDE the class, not namespace.
    private Random _rng;
    
    private int _stationX;
    private int _stationY;
    
    public Station(Texture2D _stationC)
        {
        _station = _stationC;
        _rng = new Random();
        _stationX = _rng.Next(25, 750);
        _stationY = _rng.Next(25, 750);

        }



    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Begin();
        spriteBatch.Draw(_station, new Vector2(_stationX,_stationY), Color.Violet);
        spriteBatch.End();
    }
}