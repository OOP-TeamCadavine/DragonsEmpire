namespace RPG_Game.Interfaces
{
    using Common;

    public interface IGameObject : IUpdateable, IDrawable, ICollidable
    {
        Position Position { get; set; }   
        
        bool Exists { get; set; } 
    }
}
