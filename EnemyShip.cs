/*
 * Enemy ship supclass of Enemy
 */

using System.Runtime.CompilerServices;

namespace OOPA5;

public class EnemyShip : Enemy
{
    
    public EnemyShip(Texture2D texture, Vector2 _position , bool _isDestroyed) : base(texture, _position, false)
    {
    }
}