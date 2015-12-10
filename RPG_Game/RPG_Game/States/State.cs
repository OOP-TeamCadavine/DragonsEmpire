using Microsoft.Xna.Framework;

namespace RPG_Game.States
{
    public abstract class State : Interfaces.IDrawable, Interfaces.IUpdateable
    {
        public abstract void Draw(GameTime gameTime);
        public abstract void Update(GameTime gameTime);
    }
}
