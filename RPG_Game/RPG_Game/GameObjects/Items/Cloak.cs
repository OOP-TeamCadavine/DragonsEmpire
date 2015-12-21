using RPG_Game.Interfaces;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using RPG_Game.Attributes;

namespace RPG_Game.GameObjects.Items
{
    [Item]
    public class Cloak : Item, IDefenseRestore
    {
        private const int DefaultDefenseRestore = 15;
        private static readonly Texture2D image = Assets.cloak;

        public Cloak(Position position)
            : base(position, image)
        {
            this.DefenseRestore = DefaultDefenseRestore;
        }

        public int DefenseRestore { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: Defense restored ({1})", this.GetType().Name, this.DefenseRestore);
        }  
    }
}
