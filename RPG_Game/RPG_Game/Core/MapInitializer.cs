namespace RPG_Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Attributes;
    using Interfaces;
    using RPG_Game.Common;

    public class MapInitializer
    {
        private static readonly Random Rand = new Random();

        public List<IGameObject> PopulateMap()
        {
            List<IGameObject> entities = new List<IGameObject>();

            GenerateItems(entities);
            GenerateEnemies(entities);
   
            return entities;
        }

        public static void GenerateEnemies(IList<IGameObject> entities)
        {
            var allEnemies = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.IsClass)
                .Where(t => t.GetCustomAttributes(typeof(EnemyAttribute), false).Any())
                .ToArray();

            for (int i = 0; i < Constants.NumberOfEnemies; i++)
            {
                int currentXCoord = Rand.Next(Constants.MinLength, Constants.MapWidth);
                int currentYCoord = Rand.Next(Constants.MinLength, Constants.MapHeight);

                while (entities.Any(e => e.Position.XCoord == currentXCoord && e.Position.YCoord == currentYCoord))
                {
                    currentXCoord = Rand.Next(Constants.MinLength, Constants.MapWidth);
                    currentYCoord = Rand.Next(Constants.MinLength, Constants.MapHeight);
                }

                int entityIndex = Rand.Next(0, allEnemies.Length);

                var entity =
                    Activator.CreateInstance(allEnemies[entityIndex], new Position(currentXCoord, currentYCoord)) as
                    IGameObject;

                entities.Add(entity);

            }
        }

        public static void GenerateItems(IList<IGameObject> entities)
        {
            var allItems = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.IsClass)
                .Where(t => t.GetCustomAttributes(typeof (ItemAttribute), false).Any())
                .ToArray();

            for (int i = 0; i < Constants.NumberOfItems; i++)
            {
                int currentXCoord = Rand.Next(Constants.MinLength, Constants.MapWidth);
                int currentYCoord = Rand.Next(Constants.MinLength, Constants.MapHeight);

                while (entities.Any(e => e.Position.XCoord == currentXCoord && e.Position.YCoord == currentYCoord))
                {
                    currentXCoord = Rand.Next(Constants.MinLength, Constants.MapWidth);
                    currentYCoord = Rand.Next(Constants.MinLength, Constants.MapHeight);
                }

                int entityIndex = Rand.Next(0, allItems.Length);

                var entity =
                    Activator.CreateInstance(allItems[entityIndex], new Position(currentXCoord, currentYCoord)) as
                    IGameObject;

                entities.Add(entity);
            }
        }
    }
}
