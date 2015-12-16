using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RPG_Game.GameObjects.Characters.Enemy
{
    public class GoldenDragon : Enemy
    {
        private const int DefaultHealth = 600;
        private const int DefaultDamage = 50;
        private const int DefaultAttack = 30;
        private const int DefaultDefense = 25;

        public GoldenDragon(Position position)
            : base(position, DefaultAttack, DefaultDefense, DefaultHealth, DefaultDamage)
        {
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void Defense()
        {
            throw new NotImplementedException();
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(Assets.goldenDragon, new Vector2(this.Position.XCoord, this.Position.YCoord));
        }

        public override void Update(GameTime gameTime)
        {
        }
    }
}
