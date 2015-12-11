using RPG_Game.Interfaces;

namespace RPG_Game.GameObjects.Items
{
    public abstract class Item : IGameObject
    {
        protected Item(Point position)
        {
            this.Position = position;
        }

        public Point Position { get; set; }
    }
}
