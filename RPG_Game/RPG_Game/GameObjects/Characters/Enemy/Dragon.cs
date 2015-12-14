using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace RPG_Game.GameObjects.Characters.Enemy
{
    public class Dragon : Enemy
    {
        private const int DefaultHealth = 600;
        private const int DefaultDamage = 50;
        private const int DefaultAttack = 25;
        private const int DefaultDefense = 25;

        public Dragon(Point position)
            : this(position, DefaultAttack, DefaultDefense, DefaultHealth, DefaultDamage)
        {
        }
        public Dragon(Point position, int attackPoints, int defensePoints, int healthPoints, int damage)
            : base(position, attackPoints, defensePoints, healthPoints, damage)
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
