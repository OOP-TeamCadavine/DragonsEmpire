namespace RPG_Game.States
{
    using System.Linq;
    using Common;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class HighScoresState : State
    {
        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(Assets.scoresBackground, Vector2.Zero);

            HighScores.Load();
            int counter = 1;
            int position = 180;
            var highScores = HighScores.GetScores().OrderByDescending(s => s.Value).Take(10);
            foreach (var score in highScores)
            {
                string experience = score.Value.Experience.ToString();
                string killed = score.Value.EnemyKilled.ToString();

                spriteBatch.DrawString(
                    Assets.name, 
                    string.Format("{0}. {1}", counter, score.Key.PadRight(20)), 
                    new Vector2(150, position), 
                    Color.White);
                spriteBatch.DrawString(
                    Assets.name,
                    string.Format("{0}",  experience.PadLeft(50)),
                    new Vector2(150, position),
                    Color.White);
                spriteBatch.DrawString(
                    Assets.name,
                    string.Format("{0}", killed.PadLeft(95)),
                    new Vector2(150, position),
                    Color.White);

                position += 50;
                counter++;
            }

            spriteBatch.End();
         }

        public override void Update(GameTime gameTime)
        {
        }
    }
}
