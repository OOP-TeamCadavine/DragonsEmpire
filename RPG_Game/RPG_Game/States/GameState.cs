using System;
using Microsoft.Xna.Framework;
using RPG_Game.GameObjects.Characters.Player;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.GameObjects.Items;
using System.Collections.Generic;
using RPG_Game.Interfaces;
using System.Reflection;
using System.Linq;
using RPG_Game.Attributes;

namespace RPG_Game.States
{
    public class GameState : State
    {
        public static Player player;
        Item pill;
        Item healthPotion;
        Item cloak;
        Item shield;
        public const int MapWidth = 1200;
        public const int MapHeight = 700;
        private const int NumberOfEnemies = 2;
        private const int NumberOfItems = 3;
        private readonly IList<IGameObject> enemies;
        private readonly IList<IGameObject> items;

        private static readonly Random Rand = new Random();

        public GameState()
        {




            Random rnd = new Random();
            player = new Archangel(new Position(0, 0));
            pill = new Pill(new Position(rnd.Next(50, 1150), rnd.Next(50, 650)));
            healthPotion = new HealthPotion(new Position(rnd.Next(50, 1150), rnd.Next(50, 650)));
            cloak = new Cloak(new Position(rnd.Next(50, 1150), rnd.Next(50, 650)));
            shield = new Shield(new Position(rnd.Next(50, 1150), rnd.Next(50, 650)));
        }


        public static IList<IGameObject> GenerateEntities()
        {
            IList<IGameObject> entities = new List<IGameObject>();

            //GenerateEnemies(entities);
            GenerateItems(entities);

            return entities;
        }

        // TODO: finish the method + method for GenerateEnemies
        private static void GenerateItems(IList<IGameObject> entities)
        {
            var itemTypes = Assembly.GetExecutingAssembly()
                 .GetTypes()
                 .Where(t => t.CustomAttributes
                     .Any(a => a.AttributeType == typeof(ItemAttribute)))
                     .ToArray();
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
