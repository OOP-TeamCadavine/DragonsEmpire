using System;

namespace RPG_Game.Exceptions
{
    public class PlayerNameNullPointerException : Exception
    {
        public PlayerNameNullPointerException(string message)
            :base(message)
        {
            
        }
    }
}
