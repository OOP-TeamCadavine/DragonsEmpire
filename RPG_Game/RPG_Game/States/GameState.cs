using RPG_Game.Core;

namespace RPG_Game.States
{
    using System.Collections.Generic;
    using Microsoft.Xna.Framework;    
    using Microsoft.Xna.Framework.Graphics;

    using Interfaces;

    using GameObjects.Characters.Player;

    public class GameState : State
    {
        public static Player player;
        private readonly string playerName;
        private List<IGameObject> entities;
        private PlayerController playerController;
        private CollisionHandler collisionHandler;


        public GameState(string playerName, MapInitializer mapInitializer, PlayerController playerController, CollisionHandler collisionHandler)
        {
            this.playerName = playerName;
            player = new Archangel(new Position(0, 0));
            this.playerController = playerController;
            this.collisionHandler = collisionHandler;
            entities = mapInitializer.PopulateMap();
        }


        public override void Update(GameTime gameTime)
        {
            playerController.HandleInput();
            collisionHandler.HandleCollisions(player, entities);
            foreach (var entity in entities)
            {
                entity.Update(gameTime);
            }
            this.entities.RemoveAll(x => !x.Exists);
            player.Update(gameTime);
            if (!player.Exists)
            {
                StateManager.CurrentState = new GameOverState();
            }   

        }
        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(Assets.gameBackground, Vector2.Zero);                   
            foreach (var entity in entities)
            {                
                entity.Draw(spriteBatch, gameTime);
            }

            player.Draw(spriteBatch, gameTime);
            spriteBatch.End();
        }
    }
}
