namespace RPG_Game.GameObjects.Items
{
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Attributes;
    using RPG_Game.Common;
    using RPG_Game.Interfaces;

    [Item]
    public class Cloak : Item, IDefenseRestore
    {
        private const int DefaultDefenseRestore = 15;

        private static readonly Texture2D ImageCloak = Assets.cloak;

        public Cloak(Position position)
            : base(position, ImageCloak)
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
