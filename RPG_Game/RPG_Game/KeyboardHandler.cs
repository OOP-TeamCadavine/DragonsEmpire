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
                    GameState.player.IsMovingLeft = true;                    
                }
                if (Keyboard.GetState().IsKeyDown(Keys.Right))
                {
                    GameState.player.IsMovingRight = true;                  
                }
                if (Keyboard.GetState().IsKeyDown(Keys.Up))
                {
                    GameState.player.IsMovingUp = true;
                }
                if (Keyboard.GetState().IsKeyDown(Keys.Down))
                {
                    GameState.player.IsMovingDown = true;
                }
                if (Keyboard.GetState().IsKeyUp(Keys.Left))
                {
                    GameState.player.IsMovingLeft = false;
                }
                if (Keyboard.GetState().IsKeyUp(Keys.Right))
                {
                    GameState.player.IsMovingRight = false;
                }
                if (Keyboard.GetState().IsKeyUp(Keys.Up))
                {
                    GameState.player.IsMovingUp = false;
                }
                if (Keyboard.GetState().IsKeyUp(Keys.Down))
                {
                    GameState.player.IsMovingDown = false;
                }
            }
        }
    }
}
