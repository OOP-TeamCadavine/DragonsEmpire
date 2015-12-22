using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using RPG_Game.Attributes;

namespace RPG_Game.GameObjects.Characters.Enemy
{
    [Enemy]
    public class BlackDragon : Enemy
    {
        private const int DefaultHealth = 500;
        private const int DefaultDamage = 40;
        private const int DefaultAttack = 30;
        private const int DefaultDefense = 30;
        private const DragonType DragonType = Characters.Enemy.DragonType.Black;
        private static readonly Texture2D image = Assets.blackDragon;

        public BlackDragon(Position position)
            : base(position, DefaultAttack, DefaultDefense, DefaultHealth, DefaultDamage, DragonType, image)
        {
        }
         

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(Assets.blackDragon, new Vector2(this.Position.XCoord, this.Position.YCoord));
        }

        
    }
}
