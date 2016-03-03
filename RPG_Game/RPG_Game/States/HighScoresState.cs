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
            this.scores.Save("Tedi", 600);
            this.scores.Save("Teo", 500);
        }


        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(Assets.scoresBackground, Vector2.Zero);

            spriteBatch.End();
         }

        public override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
    }
}
