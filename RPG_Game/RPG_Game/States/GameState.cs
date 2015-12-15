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
        public static Player player;
        Item pill;
        Item healthPotion;
        Item cloak;
        Item shield;

        public GameState()
        {
            Random rnd = new Random();
            player = new Archangel(new Position(0, 0));
            pill = new Pill(new Position(rnd.Next(50, 1150), rnd.Next(50, 650)));
            healthPotion = new HealthPotion(new Position(rnd.Next(50, 1150), rnd.Next(50, 650)));
            cloak = new Cloak(new Position(rnd.Next(50, 1150), rnd.Next(50, 650)));
            shield = new Shield(new Position(rnd.Next(50, 1150), rnd.Next(50, 650)));
        }

        public override void Update(GameTime gameTime)
        {
            KeyboardHandler.HandleInput();
            player.Update(gameTime);
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
            player.Draw(spriteBatch, gameTime);

            spriteBatch.End();
        }
    }
}
