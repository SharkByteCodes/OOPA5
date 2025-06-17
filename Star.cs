/*
 * Adopted starSprite from GoblinDanceParty project
 * This is purely to add aesthetic and I don't believe adds to the graded material?
 */
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OOPA5;

public class Star
{
    private float _starsX;
    private float _starsY;
    private List <Star> _stars; // first list
    
    
    private Texture2D _starRound; //_starPent is originally starSprite (might not be used)
    
    private Random _rng;
    private float _starScale;
    private float _starRotation;
    

    public Star(Texture2D _starRound)
    {
        this._starRound = _starRound;
        _rng = new Random();
        _starScale = _rng.Next(25, 75) / 100f;
        _starRotation = _rng.Next(0, 101) / 100f;

        _starsX = _rng.Next(25, 750);
        _starsY = _rng.Next(25, 750);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Begin();
            spriteBatch.Draw(_starRound, new Vector2(_starsX, _starsY), null, Color.White, _starRotation, Vector2.Zero, _starScale, SpriteEffects.None, 0f);
        
        
        spriteBatch.End();
    }
    
    //getters to keep Game1 cleaner (hopefully)
    public float GetStarScale() {return _starScale;}
    public float GetStarRotation() {return _starRotation;}
}