namespace RPG_Game.States
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    using Events;

    using RPG_Game.Common;

    public class MainMenuState : State
    {        
        public event ButtonClickedEventHandler ButtonClicked;

        Rectangle buttonPlayArea = new Rectangle(870, 400, 204, 63);
        Rectangle buttonScoreArea = new Rectangle(870, 500, 204, 63);
        Rectangle buttonExitArea = new Rectangle(870, 600, 204, 63);

        public MainMenuState()
        {
            
        }
        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(Assets.mainMenuImage, Vector2.Zero);
            spriteBatch.Draw(Assets.buttonPlay, buttonPlayArea, Color.White);
            spriteBatch.Draw(Assets.buttonScore, buttonScoreArea, Color.White);
            spriteBatch.Draw(Assets.buttonExit, buttonExitArea, Color.White);
            
            spriteBatch.End();
        }

        public override void Update(GameTime gameTime)
        {
            if (buttonPlayArea.Contains(new Point(Mouse.GetState().X, Mouse.GetState().Y)) 
                && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                this.OnButtonClicked(ButtonNames.Play);
            }

            if (buttonScoreArea.Contains(new Point(Mouse.GetState().X, Mouse.GetState().Y))
                && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                this.OnButtonClicked(ButtonNames.Scores);
            }

            if (buttonExitArea.Contains(new Point(Mouse.GetState().X, Mouse.GetState().Y))
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
