namespace RPG_Game.States
{
    using System.Linq;
    using Common;
    using Events;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    public class EnterNameState : State
    {
        private Rectangle doneButton = new Rectangle(120, 500, 350, 200);
        private Rectangle enterNameButton = new Rectangle(100, 300, 400, 300);

        private Keys[] lastPressedKeys = new Keys[Constants.MaxLengthName];
        private string playerName = string.Empty;

        public event ButtonClickedEventHandler ButtonClicked;

        public string PlayerName
        {
            get { return this.playerName; }
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Begin();

            spriteBatch.Draw(Assets.NameStateBackground, Vector2.Zero);
            spriteBatch.Draw(Assets.DoneButton, this.doneButton, Color.White);
            spriteBatch.Draw(Assets.EnterName, this.enterNameButton, Color.White);
            spriteBatch.DrawString(Assets.Name, this.playerName, new Vector2(200, 430), Color.Black);

            spriteBatch.End();
        }

        public override void Update(GameTime gameTime)
        {
            if (this.doneButton.Contains(new Point(Mouse.GetState().X, Mouse.GetState().Y))
               && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                this.OnButtonClicked(ButtonNames.Done);
            }

            if (this.enterNameButton.Contains(new Point(Mouse.GetState().X, Mouse.GetState().Y))
                && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                this.OnButtonClicked(ButtonNames.EnterName);
            }

            this.GetKeys();
        }

        public void GetKeys()
        {
            KeyboardState kbState = Keyboard.GetState();
            Keys[] pressedKeys = kbState.GetPressedKeys();

            foreach (var key in this.lastPressedKeys)
            {
                if (!pressedKeys.Contains(key))
                {
                    this.GetKeyUp(key);
                }
            }

            foreach (var key in pressedKeys)
            {
                if (!this.lastPressedKeys.Contains(key))
                {
                    this.GetKeyDown(key);
                }
            }

            this.lastPressedKeys = pressedKeys;
        }

        protected void OnButtonClicked(ButtonNames button)
        {
            if (this.ButtonClicked != null)
            {
                ButtonClickedEventArgs args = new ButtonClickedEventArgs(button);
                this.ButtonClicked(this, args);
            }
        }

        private void GetKeyDown(Keys key)
        {
            if (key == Keys.Back && this.playerName.Length > 0)
            {
                this.playerName = this.playerName.Remove(this.playerName.Length - 1);
            }
            else if (key == Keys.Space)
            {
                this.playerName += ' ';
            }
            else if(key >= Keys.A && key <= Keys.Z)
            {
                this.playerName += key.ToString();
            }
        }

        private void GetKeyUp(Keys key)
        {
        }
    }
}
