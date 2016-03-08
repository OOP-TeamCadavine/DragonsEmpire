﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using RPG_Game.Attributes;

namespace RPG_Game.GameObjects.Characters.Enemy
{
    using Common;

    [Enemy]
    public class BlueDragon : Enemy
    {
        private const int DefaultHealth = 400;
        private const int DefaultDamage = 60;
        private const int DefaultAttack = 20;
        private const int DefaultDefense = 30;
        private const DragonType DragonType = Characters.Enemy.DragonType.Blue;
        private static readonly Texture2D image = Assets.blueDragon;

        public BlueDragon(Position position)
            : base(position, DefaultAttack, DefaultDefense, DefaultHealth, DefaultDamage, DragonType, image)
        {
        }               

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(Assets.blueDragon, new Vector2(this.Position.XCoord, this.Position.YCoord));
        }
    }
}
