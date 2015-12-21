using System.Runtime.CompilerServices;

namespace RPG_Game.GameObjects.Characters.Enemy
{
    public abstract class Enemy : Character
    {
        protected Enemy(Position position, int attackPoints, int defensePoints, int healthPoints, int damage, DragonType type)
            : base(position, attackPoints, defensePoints, healthPoints, damage)
        {
            this.Type = type;
        }

        public DragonType Type { get; protected set; }
    }
}
