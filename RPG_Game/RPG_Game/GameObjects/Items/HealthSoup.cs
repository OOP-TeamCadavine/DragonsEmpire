namespace RPG_Game.GameObjects.Items
{
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Attributes;
    using RPG_Game.Common;
    using RPG_Game.Interfaces;

    [Item]
    public class HealthSoup : Item, IHeal
    {
        private const int DefaultHealthRestore = 100;

        private static readonly Texture2D ImageSoup = Assets.soup;

        public HealthSoup(Position position)
            : base(position, ImageSoup)
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
