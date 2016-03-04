using RPG_Game.Interfaces;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using RPG_Game.Attributes;

namespace RPG_Game.GameObjects.Items
{
    using RPG_Game.Common;

    [Item]
    public class Konay : Item, IAttackBoost 
    {
        private const int DefaultAttackBoost = 23;
        private static readonly Texture2D image = Assets.konay;

        public Konay(Position position)
            : base(position, image)
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
