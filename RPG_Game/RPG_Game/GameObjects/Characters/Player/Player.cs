using RPG_Game.Interfaces;

namespace RPG_Game.GameObjects.Characters.Player
{
    public abstract class Player : Character, IMovable
    {
<<<<<<< HEAD
        public bool isMovingLeft;
        public bool isMovingRight;
        public bool isMovingUp;
        public bool isMovingDown;
        public int speed;
=======
        internal bool isMovingLeft;
        internal bool isMovingRight;
        internal bool isMovingUp;
        internal bool isMovingDown;
        internal int speed;

>>>>>>> e557b6a7038061d3a2839a8d4cb0ed6252476e52

        protected Player(Position position, int attackPoints, int defensePoints, int healthPoints, int damage, int speed)
            : base(position, attackPoints, defensePoints, healthPoints, damage)
        {
            this.speed = speed;
        }

        public abstract void Move();
    }
}
