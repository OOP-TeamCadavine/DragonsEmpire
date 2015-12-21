using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RPG_Game.GameObjects
{
    using RPG_Game.Interfaces;

    public abstract class GameObject : IGameObject
    {
        protected GameObject(Position position)
        {
            this.Position = position;
        }

        public Position Position { get; set; }

        public Rectangle ColliderBox { get; set; }

        public abstract void Draw(SpriteBatch spriteBatch, GameTime gameTime);

        public abstract void Update(GameTime gameTime);
    }

}

