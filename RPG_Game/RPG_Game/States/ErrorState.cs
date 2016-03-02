using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using RPG_Game.Events;

namespace RPG_Game.States
{
    public class ErrorState : State
    {
        public event ButtonClickedEventHandler ButtonClicked;

        Rectangle okButtonArea = new Rectangle(120, 500, 350, 200);

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Begin();

            spriteBatch.Draw(Assets.errorBackground, Vector2.Zero);
            spriteBatch.Draw(Assets.okButton, okButtonArea, Color.White);

            spriteBatch.End();
        }

        public override void Update(GameTime gameTime)
        {
            if (okButtonArea.Contains(new Point(Mouse.GetState().X, Mouse.GetState().Y))
              && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                this.OnButtonClicked(ButtonNames.Ok);
            }
        }

        private void OnButtonClicked(ButtonNames button)
        {
            if (this.ButtonClicked != null)
            {
                ButtonClickedEventArgs args = new ButtonClickedEventArgs(button);
                this.ButtonClicked(this, args);
            }
        }
    }
}
