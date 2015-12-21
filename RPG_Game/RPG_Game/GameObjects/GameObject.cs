using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RPG_Game.GameObjects
{
    using RPG_Game.Interfaces;

    public abstract class GameObject : IGameObject
    {
        private Texture2D image;

        protected GameObject(Position position, Texture2D image)
        {
            this.Position = position;
            this.Image = image;
            this.ColliderBox = new Rectangle(this.Position.XCoord, this.Position.YCoord, this.image.Width, this.image.Height);
            this.Exists = true;
        }

        public Texture2D Image
        {
            get { return this.image; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Image cannot be null.");
                }
                this.image = value;
            }
        }
        public Position Position { get; set; }

        public bool Exists { get; set; }

        public Rectangle ColliderBox { get; set; }

        public abstract void Draw(SpriteBatch spriteBatch, GameTime gameTime);

        public abstract void Update(GameTime gameTime);
    }

}

