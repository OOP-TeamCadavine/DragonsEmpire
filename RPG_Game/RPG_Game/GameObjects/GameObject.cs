using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game.GameObjects
{
    public abstract class GameObject
    {
        private Point position;

        protected GameObject(Point position)
        {
            this.Position = position;
        }

        public Point Position { get; set; }
    }

}

