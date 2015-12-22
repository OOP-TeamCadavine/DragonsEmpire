namespace RPG_Game.States
{
    using System;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class GameoverState : State
    {
        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(Assets.gameOverBackground, Vector2.Zero);          
            spriteBatch.End();
        }

        public override void Update(GameTime gameTime)
        {
           
        }
    }
}
