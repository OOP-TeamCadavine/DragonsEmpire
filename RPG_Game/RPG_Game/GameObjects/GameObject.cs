using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RPG_Game.GameObjects
{
    using RPG_Game.Interfaces;

    public abstract class GameObject : IGameObject
    {
        protected GameObject(Point position)
        {
            this.Position = position;
        }

        public Point Position { get; set; }

        public abstract void Draw(SpriteBatch spriteBatch, GameTime gameTime);

        public abstract void Update(GameTime gameTime);
    }

}

