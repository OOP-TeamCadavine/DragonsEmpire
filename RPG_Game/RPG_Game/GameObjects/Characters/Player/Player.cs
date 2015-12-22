using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;

namespace RPG_Game.GameObjects.Characters.Player
{
    public abstract class Player : Character, IMovable
    {
        private const int WindowWidth = 1200;
        private const int WindowHeight = 700;
        protected Player(Position position, int attackPoints, int defensePoints, int healthPoints, int damage, int speed, Texture2D image)
            : base(position, attackPoints, defensePoints, healthPoints, damage, image)
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
            if (this.IsMovingLeft && this.Position.XCoord > 0)
            {
                this.Position = new Position(this.Position.XCoord - Speed, this.Position.YCoord);
            }
            if (this.IsMovingRight && this.Position.XCoord < WindowWidth - this.Image.Width)
            {
                this.Position = new Position(this.Position.XCoord + Speed, this.Position.YCoord);
            }
            if (this.IsMovingUp && this.Position.YCoord > 0)
            {
                this.Position = new Position(this.Position.XCoord, this.Position.YCoord - Speed);
            }
            if (this.IsMovingDown && this.Position.YCoord < WindowHeight - this.Image.Height)
            {
                this.Position = new Position(this.Position.XCoord, this.Position.YCoord + Speed);
            }
        }      

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            this.Move();
            this.ColliderBox = new Rectangle(this.Position.XCoord + this.Image.Width/4, this.Position.YCoord, this.Image.Width/2, this.Image.Height);
        }
    }
}
