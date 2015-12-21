namespace RPG_Game.GameObjects.Items
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public abstract class Item : GameObject
    {
        protected Item(Position position, Texture2D image)
            : base(position, image)
        {
            this.ColliderBox = new Rectangle(position.XCoord, position.YCoord, image.Width, image.Height);
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
