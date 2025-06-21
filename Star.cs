/*
 * Adopted starSprite from GoblinDanceParty project
 * This is purely to add aesthetic and I don't believe adds to the graded material?
 */

//using System;

namespace OOPA5;

public class Star : Objects
{
    
    // A bunch of lists, this is adopted from goblin dance party
    private int _numStars;
    private List<int> _starX; // star X location
    private List<int> _starY; // star Y location
    private List<float> _starRotation; // star rotation
    private List<float> _starSize; // star scale
    
    private Random _rng; // Random number generator for stars
    
    
    private readonly Texture2D _starRound; //_starPent is originally starSprite (might not be used)

    
    
    
    public Star(Texture2D starRound) // constructor to call textur from Game1.cs :) Credit: https://youtu.be/-Q2h5HGi0fI?t=564
    {
        _starRound = starRound;
        _rng = new Random();
        _numStars = _rng.Next(50, 125);
        _starX = new List<int>(); // list for x pos
        _starY = new List<int>(); // list for y pos
        _starRotation = new List<float>(); // list for rotation
        _starSize = new List<float>(); // list for size
        
        // So it appears the above commands needed to be part of the Star Object. It took way to long to get this working.
        
        // for loops for the above lists
             

        for (int i = 0; i < _numStars; i++)
        {
            _starX.Add(_rng.Next(25, 750)); //it's not broken, don't fix (refactor) today.
            _starY.Add(_rng.Next(25, 750));
            _starRotation.Add(_rng.NextSingle());
            _starSize.Add(_rng.Next(25, 50) / 200f);
        }
    } 
    
    
    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Begin();
        for (int i = 0; i < _numStars; i++)
        {
            spriteBatch.Draw(_starRound,
                            new Vector2(_starX[i], _starY[i]),
                            null,
                            Color.Gray,
                            _starRotation[i],
                            Vector2.Zero,
                            _starSize[i],
                            SpriteEffects.None,
                            0f);
        }
        spriteBatch.End();
    }


    
    public int GetNumbStars() { return _numStars; } // Debug info
}