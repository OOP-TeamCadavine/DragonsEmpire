using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;

namespace RPG_Game.GameObjects.Items
{
    public abstract class Item : GameObject
    {
        private Texture2D image;

        protected Item(Position position, Texture2D image)
            : base(position)
        {
            this.Image = image;
            this.ColliderBox = new Rectangle(position.XCoord, position.YCoord, image.Width, image.Height);
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
        
        public override void Update(GameTime gameTime)
        {
            
        }


        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {

            spriteBatch.Draw(this.Image, new Vector2(this.Position.XCoord, this.Position.YCoord));
        }

    }
}
