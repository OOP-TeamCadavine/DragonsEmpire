using Microsoft.Xna.Framework;

namespace RPG_Game.Interfaces
{
    public interface IGameObject : IUpdateable, IDrawable
    {
        Position Position { get; set; }

        Rectangle ColliderBox { get; set; }
    }
}
