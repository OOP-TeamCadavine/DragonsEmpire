using RPG_Game.GameObjects.Characters.Player;
using RPG_Game.GameObjects.Items;
using RPG_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG_Game.GameObjects.Characters.Enemy;
using System.Reflection;
using RPG_Game.Attributes;

namespace RPG_Game
{
    public class MapInitializer
    {
        public static Player player;

        public const int MinLength = 100;
        public const int MapWidth = 1100;
        public const int MapHeight = 600;
        private const int NumberOfEnemies = 3;
        private const int NumberOfItems = 2;

        private static readonly Random Rand = new Random();


        public static IList<IGameObject> PopulateMap()
        {
            IList<IGameObject> entities = new List<IGameObject>();

            GenerateEnemies(entities);
            GenerateItems(entities);

            return entities;
        }

        private static void GenerateEnemies(IList<IGameObject> entities)
        {
            var allEnemies = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.IsClass)
                .Where(t => t.GetCustomAttributes(typeof (EnemyAttribute), false).Any())
                .ToArray();

            for (int i = 0; i < NumberOfEnemies; i++)
            {
                int currentXCoord = Rand.Next(MinLength, MapWidth);
                int currentYCoord = Rand.Next(MinLength, MapHeight);

                while (entities.Any(e => e.Position.XCoord == currentXCoord && e.Position.YCoord == currentYCoord))
                {
                    currentXCoord = Rand.Next(MinLength, MapWidth);
                    currentYCoord = Rand.Next(MinLength, MapHeight);
                }

                int entityIndex = Rand.Next(0, allEnemies.Length);

                var entity = Activator.CreateInstance(allEnemies[entityIndex],
                    new Position(currentXCoord, currentYCoord)) as IGameObject;

                entities.Add(entity);

            }
        }

        private static void GenerateItems(IList<IGameObject> entities)
        {
            var allItems = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.IsClass)
                .Where(t => t.GetCustomAttributes(typeof (ItemAttribute), false).Any())
                .ToArray();

            for (int i = 0; i < NumberOfItems; i++)
            {
                int currentXCoord = Rand.Next(MinLength, MapWidth);
                int currentYCoord = Rand.Next(MinLength, MapHeight);

                while (entities.Any(e => e.Position.XCoord == currentXCoord && e.Position.YCoord == currentYCoord))
                {
                    currentXCoord = Rand.Next(MinLength, MapWidth);
                    currentYCoord = Rand.Next(MinLength, MapHeight);
                }

                int entityIndex = Rand.Next(0, allItems.Length);

                var entity = Activator.CreateInstance(allItems[entityIndex],
                    new Position(currentXCoord, currentYCoord)) as IGameObject;

                entities.Add(entity);
            }
        }
    }
}
