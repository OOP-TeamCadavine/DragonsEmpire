namespace RPG_Game.GameObjects.Characters.Enemy
{
    using Microsoft.Xna.Framework.Graphics;

    public abstract class Enemy : Character
    {
        protected Enemy(Position position, int attackPoints, int defensePoints, int healthPoints, int damage, DragonType type, Texture2D image)
            : base(position, attackPoints, defensePoints, healthPoints, damage, image)
        {
            this.Type = type;
        }

        public DragonType Type { get; protected set; }
    }
}
