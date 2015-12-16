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
using RPG_Game.GameObjects.Characters.Enemy;

namespace RPG_Game.States
{
    public class GameState : State
    {
        public static Player player;

        public const int MinLength = 50;
        public const int MapWidth = 1150;
        public const int MapHeight = 650;
        private const int NumberOfEnemies = 3;
        private const int NumberOfItems = 3;

        private readonly IList<IGameObject> entities = new List<IGameObject>();

        private static readonly Random Rand = new Random();

        public GameState()
        { 
            player = new Archangel(new Position(0, 0));
           
            GenerateEnemies(this.entities);
            GenerateItems(this.entities);
        }

        private static void GenerateEnemies(IList<IGameObject> enemies)
        {
            Enemy blueDragon = new BlueDragon(new Position(Rand.Next(MinLength, MapWidth), Rand.Next(MinLength, MapHeight)));
            Enemy blackDragon = new BlackDragon(new Position(Rand.Next(MinLength, MapWidth), Rand.Next(MinLength, MapHeight)));
            Enemy goldenDragon = new GoldenDragon(new Position(Rand.Next(MinLength, MapWidth), Rand.Next(MinLength, MapHeight)));

            enemies.Add(blackDragon);
            enemies.Add(blueDragon);
            enemies.Add(goldenDragon);
        }

        private static void GenerateItems(IList<IGameObject> items)
        {
            Item pill = new Pill(new Position(Rand.Next(MinLength, MapWidth), Rand.Next(MinLength, MapHeight)));
            Item healthPotion = new HealthPotion(new Position(Rand.Next(MinLength, MapWidth), Rand.Next(MinLength, MapHeight)));
            Item cloak = new Cloak(new Position(Rand.Next(MinLength, MapWidth), Rand.Next(MinLength, MapHeight)));
            Item shield = new Shield(new Position(Rand.Next(MinLength, MapWidth), Rand.Next(MinLength, MapHeight)));

            items.Add(pill);
            items.Add(healthPotion);
            items.Add(cloak);
            items.Add(shield);
        }

        public override void Update(GameTime gameTime)
        {
            KeyboardHandler.HandleInput();
            player.Update(gameTime);     

        }
        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Begin();

            spriteBatch.Draw(Assets.gameBackground, Vector2.Zero);        
            player.Draw(spriteBatch, gameTime);

            foreach (var entity in entities)
            {
                entity.Draw(spriteBatch, gameTime);
            }

            spriteBatch.End();
        }
    }
}
