namespace RPG_Game.GameObjects.Characters.Enemy
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Attributes;
    using RPG_Game.Common;

    [Enemy]
    public class GoldenDragon : Enemy
    {
        private const int DefaultHealth = 600;
        private const int DefaultDamage = 50;
        private const int DefaultAttack = 30;
        private const int DefaultDefense = 25;
        private const DragonType DragonType = Characters.Enemy.DragonType.Golden;

        private static readonly Texture2D GoldenDragonImage = Assets.GoldenDragon;

        public GoldenDragon(Position position)
            : base(position, DefaultAttack, DefaultDefense, DefaultHealth, DefaultDamage, DragonType, GoldenDragonImage)
        {
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(Assets.GoldenDragon, new Vector2(this.Position.XCoord, this.Position.YCoord));
        }
    }
}
