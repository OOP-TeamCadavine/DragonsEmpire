using System;
using Microsoft.Xna.Framework;
using RPG_Game.GameObjects.Characters.Player;
using Microsoft.Xna.Framework.Graphics;

namespace RPG_Game.States
{
    public class GameState : State
    {
        Player player;
        public GameState()
        {
            player = new Archangel(new Point(0, 0));
        }

        public override void Update(GameTime gameTime)
        {
            this.player.Update(gameTime);
        }
        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(Assets.gameBackground, Vector2.Zero);
            this.player.Draw(spriteBatch, gameTime);
            spriteBatch.End();
        }
    }
}
