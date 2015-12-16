using System;

namespace RPG_Game.Events
{
    public class ButtonClickedEventArgs : EventArgs
    {
        private ButtonNames button;

        public ButtonClickedEventArgs(ButtonNames button)
        {
            this.button = button;
        }

        public ButtonNames Button 
        {
            get
            {
                return this.button;
            }
        }
    }
}
