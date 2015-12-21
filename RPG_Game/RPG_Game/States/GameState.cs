using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using RPG_Game.GameObjects.Characters.Player;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;


namespace RPG_Game.States
{
    public class GameState : State
    {
        public static Player player;
        private IList<IGameObject> entities; 

        public GameState()
        {
            player = new Archangel(new Position(0, 0));

            entities = MapInitializer.PopulateMap();
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
