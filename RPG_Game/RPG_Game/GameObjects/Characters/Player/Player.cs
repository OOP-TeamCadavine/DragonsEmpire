using RPG_Game.Interfaces;

namespace RPG_Game.GameObjects.Characters.Player
{
    public abstract class Player : Character, IMovable
    {
        internal bool IsMovingLeft;
        internal bool IsMovingRight;
        internal bool IsMovingUp;
        internal bool IsMovingDown;
        internal int speed;

        protected Player(Position position, int attackPoints, int defensePoints, int healthPoints, int damage, int speed)
            : base(position, attackPoints, defensePoints, healthPoints, damage)
        {
            this.speed = speed;
        }

        public abstract void Move();
    }
}
