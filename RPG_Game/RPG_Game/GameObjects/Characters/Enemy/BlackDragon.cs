namespace RPG_Game.GameObjects.Characters.Enemy
{
    using Common;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Attributes;

    [Enemy]
    public class BlackDragon : Enemy
    {
        private const int DefaultHealth = 500;
        private const int DefaultDamage = 40;
        private const int DefaultAttack = 30;
        private const int DefaultDefense = 30;
        private const DragonType DragonType = Characters.Enemy.DragonType.Black;

        private static readonly Texture2D BlackDragonImage = Assets.BlackDragon;

        public BlackDragon(Position position)
            : base(position, DefaultAttack, DefaultDefense, DefaultHealth, DefaultDamage, DragonType, BlackDragonImage)
        {
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(Assets.BlackDragon, new Vector2(this.Position.XCoord, this.Position.YCoord));
        }
    }
}
