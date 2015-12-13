using System;
using Microsoft.Xna.Framework;
using RPG_Game.GameObjects.Characters.Player;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.GameObjects.Items;
using Items;

namespace RPG_Game.States
{
    public class GameState : State
    {
        Player player;
        Item pill;
        Item healthPotion;
        Item cloak;
        Item shield;

        public GameState()
        {
            Random rnd = new Random();
            player = new Archangel(new Point(0, 0));
            pill = new Pill(new Point(rnd.Next(50, 1150), rnd.Next(50, 650)));
            healthPotion = new HealthPotion(new Point(rnd.Next(50, 1150), rnd.Next(50, 650)));
            cloak = new Cloak(new Point (rnd.Next(50,1150), rnd.Next(50,650)));
            shield = new Shield(new Point(rnd.Next(50, 1150), rnd.Next(50, 650)));
        }

        public override void Update(GameTime gameTime)
        {
            this.player.Update(gameTime);
            this.pill.Update(gameTime);
            this.healthPotion.Update(gameTime);
            this.cloak.Update(gameTime);
            this.shield.Update(gameTime);
        }
        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(Assets.gameBackground, Vector2.Zero);
            this.pill.Draw(spriteBatch, gameTime);
            this.healthPotion.Draw(spriteBatch, gameTime);
            this.cloak.Draw(spriteBatch, gameTime);
            this.shield.Draw(spriteBatch, gameTime);
            this.player.Draw(spriteBatch, gameTime);
            
            spriteBatch.End();
        }
    }
}
