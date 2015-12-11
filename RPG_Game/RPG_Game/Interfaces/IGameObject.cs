using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace RPG_Game.Interfaces
{
    public interface IGameObject : Interfaces.IUpdateable, Interfaces.IDrawable
    {
        Point Position { get; set; }

        
    }
}
