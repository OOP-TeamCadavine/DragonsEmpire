using System;
using Microsoft.Xna.Framework;
using RPG_Game.GameObjects.Characters.Player;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.GameObjects.Items;

namespace RPG_Game.States
{
    public class GameState : State
    {
        Player player;
        Item pill;
        Item healthPotion;

        public GameState()
        {
            Random rnd = new Random();
            player = new Archangel(new Point(0, 0));
            pill = new Pill(new Point(rnd.Next(50, 1150), rnd.Next(50, 650)));
            healthPotion = new HealthPotion(new Point(rnd.Next(50, 1150), rnd.Next(50, 650)));
        }

        public override void Update(GameTime gameTime)
        {
            this.player.Update(gameTime);
            this.pill.Update(gameTime);
            this.healthPotion.Update(gameTime);
        }
        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(Assets.gameBackground, Vector2.Zero);
            this.pill.Draw(spriteBatch, gameTime);
            this.healthPotion.Draw(spriteBatch, gameTime);
            this.player.Draw(spriteBatch, gameTime);
            
            spriteBatch.End();
        }
    }
}
