using RPG_Game.Interfaces;

namespace RPG_Game.GameObjects
{
    public abstract class GameObject : IGameObject
    {
        private Point position;

        protected GameObject(Point position)
        {
            this.Position = position;
        }

        public Point Position { get; set; }
    }

}

