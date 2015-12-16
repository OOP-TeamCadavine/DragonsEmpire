using RPG_Game.Interfaces;

namespace RPG_Game.GameObjects.Characters.Player
{
    public abstract class Player : Character, IMovable
    {
        protected bool isMovingLeft;
        protected bool isMovingRight;
        protected bool isMovingUp;
        protected bool isMovingDown;
        protected int speed;


        protected Player(Position position, int attackPoints, int defensePoints, int healthPoints, int damage, int speed)
            : base(position, attackPoints, defensePoints, healthPoints, damage)
        {
            this.speed = speed;
        }

        public abstract void Move();
    }
}
