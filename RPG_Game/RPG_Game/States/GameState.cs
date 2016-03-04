namespace RPG_Game.States
{
    using System.Collections.Generic;
    using System.Linq;
    using Common;
    using Core;
    using GameObjects.Characters.Enemy;
    using GameObjects.Characters.Player;
    using GameObjects.Items;
    using Interfaces;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class GameState : State
    {
        public static Player player;
        private readonly string playerName;
        private List<IGameObject> entities;
        private PlayerController playerController;
        private CollisionHandler collisionHandler;
        private string health = string.Empty;
        private string killedDragons = string.Empty;
        private string experience = string.Empty;

        private Rectangle toolbarArea = new Rectangle(200, 500, 750, 350);

        public GameState(string playerName, MapInitializer mapInitializer, PlayerController playerController, CollisionHandler collisionHandler)
        {
            this.playerName = playerName;
            player = new Archangel(new Position(0, 0), playerName);
            this.playerController = playerController;
            this.collisionHandler = collisionHandler;
            this.entities = mapInitializer.PopulateMap();
        }

        public override void Update(GameTime gameTime)
        {
            this.playerController.HandleInput();
            this.collisionHandler.HandleCollisions(player, this.entities);

            foreach (var entity in this.entities)
            {
                entity.Update(gameTime);
            }

            this.entities.RemoveAll(x => !x.Exists);
            player.Update(gameTime);

            if (!player.Exists)
            {
                StateManager.CurrentState = new GameOverState();
            }

            IList<IGameObject> items = this.entities.Where(i => i is Item).ToList();
            IList<IGameObject> enemies = this.entities.Where(i => i is Enemy).ToList();

            if (items.Count == 0)
            {
                MapInitializer.GenerateItems(this.entities);
            }

            if (enemies.Count == 0)
            {
                MapInitializer.GenerateEnemies(this.entities);
            }

            this.health = player.HealthPoints.ToString();
            this.killedDragons = player.Score.EnemyKilled.ToString();
            this.experience = player.Score.Experience.ToString();
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(Assets.gameBackground, Vector2.Zero);     
            spriteBatch.Draw(Assets.toolbar, this.toolbarArea, Color.White);
            spriteBatch.DrawString(Assets.health, this.health, new Vector2(310,660), Color.White);
            spriteBatch.DrawString(Assets.experience, this.experience, new Vector2(570, 660), Color.White);
            spriteBatch.DrawString(Assets.dragonsKilled, this.killedDragons, new Vector2(790, 660), Color.White);

            foreach (var entity in this.entities)
            {                
                entity.Draw(spriteBatch, gameTime);
            }

            player.Draw(spriteBatch, gameTime);

            spriteBatch.End();
        }
    }
}
