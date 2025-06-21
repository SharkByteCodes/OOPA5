/*
 * Parent Class for enemies
 *
 * adopts some elements from Critical Design Memeory Game
 */

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace OOPA5;

public class Enemy : Objects
{
    private Vector2 _position;
    private readonly Texture2D _texture;
    
    private Random _rng;

    private bool _isDestroyed;
    
    public Enemy(Texture2D texture) //not number 1. I realized this pun after naming the class still funny I think.
                   //(non-arg constructor)
    {
        _rng = new Random();
        _position = new Vector2(ObjectPosition().X, ObjectPosition().Y);  //set a random position
        _isDestroyed  = false;
        texture = _texture;
    }

    protected Enemy(Texture2D texture,Vector2 position, bool _isDestroyed) //arguemtned constructor
    {
        _texture = texture;
        _position = position;
        _isDestroyed = _isDestroyed;
    }

    public bool SetIsDestroyed
    {
        set { _isDestroyed = true; }
    }

    public void Update(GameTime gameTime)
    {
        //if (MouseState.LeftButton == ButtonState.Pressed)
    }
    public void Draw(SpriteBatch spriteBatch)
    {
        if (!_isDestroyed)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(this._texture, _position, Color.White);
            spriteBatch.End();
        }
    }
}