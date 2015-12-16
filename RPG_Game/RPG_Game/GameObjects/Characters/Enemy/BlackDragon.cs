using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace RPG_Game.GameObjects.Characters.Enemy
{
    public class BlackDragon : Enemy
    {
        private const int DefaultHealth = 500;
        private const int DefaultDamage = 40;
        private const int DefaultAttack = 30;
        private const int DefaultDefense = 30;

        public BlackDragon(Position position)
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
