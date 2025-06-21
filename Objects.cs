/*
 * Well, how 'bout that. The inheritance is working!!
 * First example of working inheritance is calling the random object position generation for the space station.
 *
 *
 * Parst of this includes adapteations from GameDev Quickie: https://youtu.be/-1FkHPdCp_E?si=yqEJu5YDlC6nb1MS
 */

namespace OOPA5;

public class Objects
{
    
    // some variables
    
    private Vector2 _position;
    
    public Random _rng;
    
    public Objects() // zero-arg
        {
        _rng = new Random();
        _position = new Vector2(_rng.Next(50, 700), _rng.Next(50, 700));
        
        }

    public Objects(Vector2 position)
    {
        _position = position;
    }
    
    
    // accessors
    public Vector2 ObjectPosition() {return _position;}
}