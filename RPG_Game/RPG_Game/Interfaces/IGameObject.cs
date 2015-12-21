namespace RPG_Game.Interfaces
{
    public interface IGameObject : IUpdateable, IDrawable, ICollidable
    {
        Position Position { get; set; }   
        
        bool Exists { get; set; } 
    }
}
