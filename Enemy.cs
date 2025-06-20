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
    private int _enemyX;
    private int _enemyY;
    
    private Random _rng;
    
    
    public Enemy() //not number 1
    {
        _rng = new Random();
        _enemyX = _rng.Next(25, 750);
        _enemyY = _rng.Next(25, 750);
    }
}