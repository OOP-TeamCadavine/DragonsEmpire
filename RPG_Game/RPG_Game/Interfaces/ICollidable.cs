namespace RPG_Game.Interfaces
{
    using Microsoft.Xna.Framework;

    public interface ICollidable
    {
        Rectangle ColliderBox { get; set; }
    }
}
