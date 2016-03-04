using RPG_Game.Interfaces;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Attributes;
using Microsoft.Xna.Framework;

namespace RPG_Game.GameObjects.Items
{
    using RPG_Game.Common;

    [Item]
    public class Shield : Item, IDefenseRestore
    {
        private const int DefaultDefenseRestore = 10;
        private static readonly Texture2D image = Assets.shield;
        public Shield(Position position)
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