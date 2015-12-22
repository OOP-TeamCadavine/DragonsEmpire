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
    public class GetNameState : State
    {
        public event ButtonClickedEventHandler ButtonClicked;

        Rectangle doneButton = new Rectangle(120, 500, 350, 200);
        Rectangle enterNameButton = new Rectangle(100,300,400,300);

        public GetNameState()
        {
            
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(Assets.nameStateBackground, Vector2.Zero);
            spriteBatch.Draw(Assets.doneButton, doneButton, Color.White);
            spriteBatch.Draw(Assets.enterName, enterNameButton, Color.White);
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
