namespace RPG_Game.Core
{
    using Microsoft.Xna.Framework.Input;
    using RPG_Game.States;

    public class PlayerController
    {
        public void HandleInput()
        {
            if (StateManager.CurrentState is GameState)
            {
                GameState gameState = (GameState)StateManager.CurrentState;

                if (Keyboard.GetState().IsKeyDown(Keys.Left))
                {
                    gameState.GetPlayer().IsMovingLeft = true;                    
                }

                if (Keyboard.GetState().IsKeyDown(Keys.Right))
                {
                    gameState.GetPlayer().IsMovingRight = true;                  
                }

                if (Keyboard.GetState().IsKeyDown(Keys.Up))
                {
                    gameState.GetPlayer().IsMovingUp = true;
                }

                if (Keyboard.GetState().IsKeyDown(Keys.Down))
                {
                    gameState.GetPlayer().IsMovingDown = true;
                }

                if (Keyboard.GetState().IsKeyUp(Keys.Left))
                {
                    gameState.GetPlayer().IsMovingLeft = false;
                }

                if (Keyboard.GetState().IsKeyUp(Keys.Right))
                {
                    gameState.GetPlayer().IsMovingRight = false;
                }

                if (Keyboard.GetState().IsKeyUp(Keys.Up))
                {
                    gameState.GetPlayer().IsMovingUp = false;
                }

                if (Keyboard.GetState().IsKeyUp(Keys.Down))
                {
                    gameState.GetPlayer().IsMovingDown = false;
                }
            }
        }
    }
}
