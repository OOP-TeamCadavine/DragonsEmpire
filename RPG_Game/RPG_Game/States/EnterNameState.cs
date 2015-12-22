using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Events;
using Microsoft.Xna.Framework.Input;

namespace RPG_Game.States
{
    public class EnterNameState : State
    {
        public event ButtonClickedEventHandler ButtonClicked;

        Rectangle doneButton = new Rectangle(120, 500, 350, 200);
        Rectangle enterNameButton = new Rectangle(100,300,400,300);

        private Keys[] lastPressedKeys = new Keys[10];
        private string playerName = string.Empty;

        public string PlayerName
        {
            get { return this.playerName; }
        }
        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(Assets.nameStateBackground, Vector2.Zero);
            spriteBatch.Draw(Assets.doneButton, doneButton, Color.White);
            spriteBatch.Draw(Assets.enterName, enterNameButton, Color.White);
            spriteBatch.DrawString(Assets.name, playerName, new Vector2(200, 430), Color.Black);

            spriteBatch.End();
        }

        public override void Update(GameTime gameTime)
        {
            if (doneButton.Contains(new Point(Mouse.GetState().X, Mouse.GetState().Y))
               && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                this.OnButtonClicked(ButtonNames.Done);
            }

            if (enterNameButton.Contains(new Point(Mouse.GetState().X, Mouse.GetState().Y))
                && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                this.OnButtonClicked(ButtonNames.EnterName);
            }
            GetKeys();
        }

        protected void OnButtonClicked(ButtonNames button)
        {
            if (this.ButtonClicked != null)
            {
                ButtonClickedEventArgs args = new ButtonClickedEventArgs(button);
                this.ButtonClicked(this, args);
            }
        }

        public void GetKeys()
        {
            KeyboardState kbState = Keyboard.GetState();
            Keys[] pressedKeys = kbState.GetPressedKeys();

            foreach (var key in lastPressedKeys)
            {
                if (!pressedKeys.Contains(key))
                {
                    GetKeyUp(key);
                }
            }

            foreach (var key in pressedKeys)
            {
                if (!lastPressedKeys.Contains(key))
                {
                    GetKeyDown(key);
                }
            }

            lastPressedKeys = pressedKeys;

        }

        private void GetKeyDown(Keys key)
        {
            if (key == Keys.Back && playerName.Length > 0)
            {
                playerName = playerName.Remove(playerName.Length - 1);
            }
            else if (key == Keys.Space)
            {
                playerName += ' ';
            }
            else if(key >= Keys.A && key <= Keys.Z)
            {
                playerName += key.ToString();
            }

        }

        private void GetKeyUp(Keys key)
        {
        }
    }
}
