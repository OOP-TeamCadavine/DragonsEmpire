using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using RPG_Game;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;

namespace RPG_Game.States
{
    public class MainMenuState : State
    {
        public delegate void ButtonClicked(Texture2D button);

        public event ButtonClicked OnClick;

        Rectangle buttonPlayArea = new Rectangle(650, 200, 650, 400);
        Rectangle buttonScoreArea = new Rectangle(650, 300, 650, 400);
        Rectangle buttonExitArea = new Rectangle(650, 400, 650, 400);

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
                OnClick(Assets.buttonPlay);
            }
        }
    }
}
