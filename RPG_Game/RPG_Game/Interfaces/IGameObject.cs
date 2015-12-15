namespace RPG_Game.Interfaces
{
    public interface IGameObject : IUpdateable, IDrawable
    {
        Position Position { get; set; }
    }
}
