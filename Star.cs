/*
 * Adopted starSprite from GoblinDanceParty project
 * This is purely to add aesthetic and I don't believe adds to the graded material?
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OOPA5;

public class Star
{
    //private float _starsX;
    //private float _starsY;
    
    // A bunch of lists, this is adopted from goblin dance party
    private int _numStars;
    private List <Star> _stars; // first list
    private List<int> _starX; // star X location
    private List<int> _starY; // star Y location
    private List<float> _starRotation; // star rotation
    private List<float> _starSize; // star scale
    
    
    
    private Texture2D _starRound; //_starPent is originally starSprite (might not be used)
    
    private Random _rng;
    private float _starScale;
    private float _starRotate;
    

    /*public Star(Texture2D _starRound)
    {
        this._starRound = _starRound;
        _rng = new Random();
        _starScale = _rng.Next(25, 75) / 100f;
        _starRotate = _rng.Next(0, 101) / 100f;

        _starsX = _rng.Next(25, 750);
        _starsY = _rng.Next(25, 750);
    }*/
    
    
    public void Initialize() // setup the stars
    {
        
        //initialize for the stars
        _rng = new Random();
        _numStars = _rng.Next(25, 150);
        _starX = new List<int>(); // list for x pos
        _starY = new List<int>(); // list for y pos
        _starRotation = new List<float>(); // list for rotation
        _starSize = new List<float>(); // list for size
        
        // for loops for the above lists

        for (int i = 0; i < _numStars; i++)
        {
            _starX.Add(_rng.Next(25, 750));
            _starY.Add(_rng.Next(25, 750));
            _starRotation.Add(_rng.NextSingle());
            _starSize.Add(_rng.Next(25, 80) / 200f);
        }
        Debug.WriteLine("Star Count" + _numStars);
    }

    public void Draw(SpriteBatch _spriteBatch)
    {
        _spriteBatch.Begin();
        for (int i = 0; i < _numStars; i++)
        {
            _spriteBatch.Draw(_starRound,
                            new Vector2(_starX[i], _starY[i]),
                            null,
                            Color.White,
                            _starRotation[i],
                            Vector2.Zero,
                            _starSize[i],
                            SpriteEffects.None,
                            0f);
        }
            //spriteBatch.Draw(_starRound, new Vector2(_starsX, _starsY), null, Color.White, _starRotation, Vector2.Zero, _starScale, SpriteEffects.None, 0f);
        
        
        _spriteBatch.End();
    }



    
    //getters to keep Game1 cleaner (hopefully)
    //public float GetStarScale() {return _starScale;}
    //public float GetStarRotation() {return _starRotation;}
}