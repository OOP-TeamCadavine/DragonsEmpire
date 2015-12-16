<<<<<<< HEAD
﻿using System;

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
=======
﻿using System;

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
>>>>>>> e557b6a7038061d3a2839a8d4cb0ed6252476e52
