namespace RPG_Game.States
{
    using System.Linq;

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class HighScoresState : State
    {
        public HighScoresState()
        {
            HighScores.Save("Tedi", 600);
            HighScores.Save("Teo", 500);
            HighScores.Save("Maria", 400);
            HighScores.Save("Pesho", 900);
            HighScores.Save("Gosho", 200);
            HighScores.Save("Teddy", 300);
            HighScores.Save("Mimi", 1000);
            HighScores.Save("Goshko", 200);
            HighScores.Save("Tedddi", 320);
            HighScores.Save("Mimmmmi", 1000);
            HighScores.Save("ItShouldntAppear", 10);
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
                spriteBatch.DrawString(Assets.name, string.Format("{0}. {1} {2}{3}", counter, score.Key, new string(' ', 50), score.Value), new Vector2(150, position), Color.White);
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
