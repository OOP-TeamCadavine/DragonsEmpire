namespace RPG_Game.States
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    using Events;

    using RPG_Game.Common;

    public class MainMenuState : State
    {        
        private Rectangle buttonPlayArea = new Rectangle(870, 400, 204, 63);
        private Rectangle buttonScoreArea = new Rectangle(870, 500, 204, 63);
        private Rectangle buttonExitArea = new Rectangle(870, 600, 204, 63);

        public MainMenuState()
        {
        }

        public event ButtonClickedEventHandler ButtonClicked;

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(Assets.MainMenuImage, Vector2.Zero);
            spriteBatch.Draw(Assets.ButtonPlay, this.buttonPlayArea, Color.White);
            spriteBatch.Draw(Assets.ButtonScore, this.buttonScoreArea, Color.White);
            spriteBatch.Draw(Assets.ButtonExit, this.buttonExitArea, Color.White);
            
            spriteBatch.End();
        }

        public override void Update(GameTime gameTime)
        {
            if (this.buttonPlayArea.Contains(new Point(Mouse.GetState().X, Mouse.GetState().Y)) 
                && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                this.OnButtonClicked(ButtonNames.Play);
            }

            if (this.buttonScoreArea.Contains(new Point(Mouse.GetState().X, Mouse.GetState().Y))
                && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                this.OnButtonClicked(ButtonNames.Scores);
            }

            if (this.buttonExitArea.Contains(new Point(Mouse.GetState().X, Mouse.GetState().Y))
                && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                this.OnButtonClicked(ButtonNames.Exit);
            }
        }

        protected void OnButtonClicked(ButtonNames button)
        {
            if (this.ButtonClicked != null)
            {
                ButtonClickedEventArgs args = new ButtonClickedEventArgs(button);
                this.ButtonClicked(this, args);
            }
        }
    }
}
