namespace RPG_Game.States
{
    using System;

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class HighScoresState : State
    {
        //refactor:
        HighScores scores = new HighScores();

        public HighScoresState()
        {
            this.scores.Load();
        }


        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        public override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
    }
}
