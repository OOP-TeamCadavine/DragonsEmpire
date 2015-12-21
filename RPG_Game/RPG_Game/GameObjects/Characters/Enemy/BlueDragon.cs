﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using RPG_Game.Attributes;

namespace RPG_Game.GameObjects.Characters.Enemy
{
    [Enemy]
    public class BlueDragon : Enemy
    {
        private const int DefaultHealth = 400;
        private const int DefaultDamage = 60;
        private const int DefaultAttack = 20;
        private const int DefaultDefense = 30;
        private const DragonType DragonType = Characters.Enemy.DragonType.Blue;

        public BlueDragon(Position position)
            : base(position, DefaultAttack, DefaultDefense, DefaultHealth, DefaultDamage, DragonType)
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
            spriteBatch.Draw(Assets.blueDragon, new Vector2(this.Position.XCoord, this.Position.YCoord));
        }

        public override void Update(GameTime gameTime)
        {  
        }
    }
}
