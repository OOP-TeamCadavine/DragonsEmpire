using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Attributes;

namespace RPG_Game.GameObjects.Characters.Enemy
{
    using RPG_Game.Common;

    [Enemy]
    public class GoldenDragon : Enemy
    {
        private const int DefaultHealth = 600;
        private const int DefaultDamage = 50;
        private const int DefaultAttack = 30;
        private const int DefaultDefense = 25;
        private const DragonType DragonType = Characters.Enemy.DragonType.Golden;
        private static readonly Texture2D image = Assets.goldenDragon;

        public GoldenDragon(Position position)
            : base(position, DefaultAttack, DefaultDefense, DefaultHealth, DefaultDamage, DragonType, image)
        {
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(Assets.goldenDragon, new Vector2(this.Position.XCoord, this.Position.YCoord));
        }

        
    }
}
