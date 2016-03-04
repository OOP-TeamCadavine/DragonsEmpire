using Microsoft.Xna.Framework.Input;

namespace RPG_Game.States
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    using RPG_Game.Common;

    public class GameOverState : State
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
