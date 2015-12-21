using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using RPG_Game.Attributes;

namespace RPG_Game.GameObjects.Items
{
    [Item]
    public class HealthSoup : Item, IHeal
    {
        private const int DefaultHealthRestore = 100;
        private static readonly Texture2D image = Assets.soup;
        public HealthSoup(Position position)
            : base(position, image)
        {
            this.HealthRestore = DefaultHealthRestore;
        }

        public int HealthRestore { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: Health restore ({1})", this.GetType().Name, this.HealthRestore);
        }        
    }
}
