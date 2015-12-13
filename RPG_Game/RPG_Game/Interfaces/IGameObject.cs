namespace RPG_Game.Interfaces
{
    public interface IGameObject : IUpdateable, IDrawable
    {
        Point Position { get; set; }
    }
}
