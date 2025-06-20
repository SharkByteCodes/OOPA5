/*
 * Parent Class for enemies
 */
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OOPA5;

public class Enemy
{
    private Vector2 _position;
    private Texture2D _texture;
    
    private Random _rng;
    
    
    public Enemy() //not number 1. I realized this pun after naming the class still funny I think.
                   //(non-arg constructor)
    {
        _rng = new Random();
        _position = new Vector2(_rng.Next(25,750),_rng.Next(25,750));  //set a random position
    }

    public Enemy(Vector2 _position, Texture2D _texture) //arguemtned constructor
    {
        _texture = _texture;
        _position = _position;
    }

    
    // Some accessors
    public Vector2 GetPosition() { return _position; }
    
    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Begin();
        spriteBatch.Draw(_texture, _position, Color.White);
        spriteBatch.End();
    }
}