using RPG_Game.Interfaces;

namespace RPG_Game.GameObjects.Characters.Player
{
    public abstract class Player : Character, IMovable
    {               
        protected Player(Position position, int attackPoints, int defensePoints, int healthPoints, int damage, int speed)
            : base(position, attackPoints, defensePoints, healthPoints, damage)
        {
            this.Speed = speed;
        }

        public bool IsMovingLeft { get; set; }

        public bool IsMovingRight { get; set; }
        
        public bool IsMovingUp { get; set; }
        
        public bool IsMovingDown { get; set; }

        public int Speed { get; set; }

        public void Move()
        {
            if (this.IsMovingLeft)
            {
                this.Position = new Position(this.Position.XCoord - Speed, this.Position.YCoord);
            }
            if (this.IsMovingRight)
            {
                this.Position = new Position(this.Position.XCoord + Speed, this.Position.YCoord);
            }
            if (this.IsMovingUp)
            {
                this.Position = new Position(this.Position.XCoord, this.Position.YCoord - Speed);
            }
            if (this.IsMovingDown)
            {
                this.Position = new Position(this.Position.XCoord, this.Position.YCoord + Speed);
            }
        }
    }
}
