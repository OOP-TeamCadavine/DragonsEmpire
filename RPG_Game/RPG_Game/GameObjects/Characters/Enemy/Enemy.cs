using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RPG_Game.GameObjects.Characters.Enemy
{
    public class Enemy : Character
    {
        public Enemy(Point position, int attackPoints, int defensePoints, int healthPoinst, int damage)
            : base(position, attackPoints, defensePoints, healthPoinst, damage)
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
