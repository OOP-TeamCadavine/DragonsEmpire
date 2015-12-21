using RPG_Game.Interfaces;

namespace RPG_Game.GameObjects.Characters.Player
{
    public abstract class Player : Character, IMovable
    {       
        internal int speed;

        protected Player(Position position, int attackPoints, int defensePoints, int healthPoints, int damage, int speed)
            : base(position, attackPoints, defensePoints, healthPoints, damage)
        {
            this.speed = speed;
        }

        public bool IsMovingLeft { get; set; }

        public bool IsMovingRight { get; set; }
        
        public bool IsMovingUp { get; set; }
        
        public bool IsMovingDown { get; set; }

        public abstract void Move();
    }
}
