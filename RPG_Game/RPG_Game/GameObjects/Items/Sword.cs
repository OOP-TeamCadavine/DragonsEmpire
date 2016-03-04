using RPG_Game.Interfaces;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using RPG_Game.Attributes;

namespace RPG_Game.GameObjects.Items
{
    using RPG_Game.Common;

    [Item]
    public class Sword : Item, IAttackBoost 
    {
        private const int DefaultAttackBoost = 50;
        private static readonly Texture2D image = Assets.sword;

        public Sword(Position position)
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
