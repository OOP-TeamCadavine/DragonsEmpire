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
        private List<IGameObject> entities;
        private KeyboardHandler keyboardHandler;
        private CollisionHandler collisionHandler;


        public GameState(MapInitializer mapInitializer, KeyboardHandler keyboardHandler, CollisionHandler collisionHandler)
        {
            player = new Archangel(new Position(0, 0));
            this.keyboardHandler = keyboardHandler;
            this.collisionHandler = collisionHandler;
            entities = mapInitializer.PopulateMap();
        }


        public override void Update(GameTime gameTime)
        {
            keyboardHandler.HandleInput();
            collisionHandler.HandleCollisions(player, entities);
            this.entities.RemoveAll(x => !x.Exists);
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
