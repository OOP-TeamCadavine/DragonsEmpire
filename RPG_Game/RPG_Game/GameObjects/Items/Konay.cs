namespace RPG_Game.GameObjects.Items
{
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Attributes;
    using RPG_Game.Common;
    using RPG_Game.Interfaces;

    [Item]
    public class Konay : Item, IAttackBoost 
    {
        private const int DefaultAttackBoost = 23;

        private static readonly Texture2D ImageKonay = Assets.konay;

        public Konay(Position position)
            : base(position, ImageKonay)
        {
            this.AttackBoost = DefaultAttackBoost;
        }

        public int AttackBoost { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: Attack boosted ({1})", this.GetType().Name, this.AttackBoost);
        }        
    }
}
