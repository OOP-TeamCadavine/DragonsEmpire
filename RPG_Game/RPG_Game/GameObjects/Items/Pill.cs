namespace RPG_Game.GameObjects.Items
{
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Attributes;
    using RPG_Game.Common;
    using RPG_Game.Interfaces;

    [Item]
    public class Pill : Item, IHeal
    {
        private const int DefaultHealthRestore = 10;

        private static readonly Texture2D ImagePill = Assets.Pill;

        public Pill(Position position)
            : base(position, ImagePill)
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

