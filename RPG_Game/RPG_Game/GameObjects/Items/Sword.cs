using RPG_Game.Interfaces;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using RPG_Game.Attributes;

namespace RPG_Game.GameObjects.Items
{
    [Item]
    public class Sword : Item, IAttackBoost //
    {
        private const int DefaultAttackBoost = 50;

        public Sword(Position position)
            : base(position)
        {
            this.AttackBoost = DefaultAttackBoost;
        }

        public int AttackBoost { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: Attack boosted ({1})", this.GetType().Name, this.AttackBoost);
        }

        public override void Update(GameTime gameTime)
        {
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(Assets.sword, new Vector2(this.Position.XCoord, this.Position.YCoord));
        }
    }
}
