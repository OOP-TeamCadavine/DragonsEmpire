namespace RPG_Game.States
{
    using System.Linq;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Common;

    public class HighScoresState : State
    {
        public HighScoresState()
        {
            HighScores.Save("Tedi", new Score(10, 600));
            HighScores.Save("Teo", new Score(2, 100));
            HighScores.Save("Maria", new Score(20, 400));
            HighScores.Save("Pesho", new Score(15, 900));
            HighScores.Save("Gosho", new Score(4, 200));
            HighScores.Save("Teddy", new Score(2, 300));
            HighScores.Save("Mimi", new Score(24, 1000));
            HighScores.Save("Goshko", new Score(1, 200));
            HighScores.Save("Tedddi", new Score(23, 1000));
            HighScores.Save("Mimmmmi", new Score(22, 1000));
            HighScores.Save("ItShouldntAppear", new Score(1, 10));
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(Assets.scoresBackground, Vector2.Zero);

            HighScores.Load();
            int counter = 1;
            int position = 170;
            var highScores = HighScores.GetScores().OrderByDescending(s => s.Value).Take(10);
            foreach (var score in highScores)
            {
                spriteBatch.DrawString(
                    Assets.name, 
                    string.Format("{0}. {1, -30} {2, -30} {3}", counter, score.Key, score.Value.EnemyKilled, score.Value.Experience), 
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
