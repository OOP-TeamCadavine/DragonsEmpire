using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace RPG_Game.GameObjects.Characters.Enemy
{
    public class GoldenDragon : Enemy
    {
        private const int DefaultHealth = 600;
        private const int DefaultDamage = 50;
        private const int DefaultAttack = 25;
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
            throw new NotImplementedException();
        }

        public override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
    }
}
