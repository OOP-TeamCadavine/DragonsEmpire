using Microsoft.Xna.Framework.Input;
using RPG_Game.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game
{
    public static class KeyboardHandler
    {
        public static void HandleInput()
        {
            if (StateManager.CurrentState is GameState)
            {
                if (Keyboard.GetState().IsKeyDown(Keys.Left))
                {
                    GameState.player.isMovingLeft = true;                    
                }
                if (Keyboard.GetState().IsKeyDown(Keys.Right))
                {
                    GameState.player.isMovingRight = true;                  
                }
                if (Keyboard.GetState().IsKeyDown(Keys.Up))
                {
                    GameState.player.isMovingUp = true;
                }
                if (Keyboard.GetState().IsKeyDown(Keys.Down))
                {
                    GameState.player.isMovingDown = true;
                }
                if (Keyboard.GetState().IsKeyUp(Keys.Left))
                {
                    GameState.player.isMovingLeft = false;
                }
                if (Keyboard.GetState().IsKeyUp(Keys.Right))
                {
                    GameState.player.isMovingRight = false;
                }
                if (Keyboard.GetState().IsKeyUp(Keys.Up))
                {
                    GameState.player.isMovingUp = false;
                }
                if (Keyboard.GetState().IsKeyUp(Keys.Down))
                {
                    GameState.player.isMovingDown = false;
                }
            }
        }
    }
}
