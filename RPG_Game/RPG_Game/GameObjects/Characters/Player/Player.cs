namespace RPG_Game.GameObjects.Characters.Player
{
    using System;
    using System.Collections.Specialized;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    
    using Exceptions;
    
    using Interfaces;

    public abstract class Player : Character, IMovable,IExperience
    {
        private const int WindowWidth = 1200;
        private const int WindowHeight = 700;
        private string name;
        private int experience;

        protected Player(Position position, int attackPoints, int defensePoints,
            int healthPoints, int damage, int speed, Texture2D image, string name)
            : base(position, attackPoints, defensePoints, healthPoints, damage, image)
        {
            this.Speed = speed;
            this.Name = name;
            this.Experience = 0;
            this.DragonsKilled = 0;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new PlayerNameNullPointerException("Player name cannot be null or empty!");
                }
                else if (value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Player name must be less than or equal to 10 letters.");
                }
                this.name = value;
            }
        }

        public int Experience
        {
            get { return this.experience; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.experience = value;
            }
        }

        public int DragonsKilled { get; set; }

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
            this.ColliderBox = new Rectangle(this.Position.XCoord + this.Image.Width / 4, this.Position.YCoord, this.Image.Width / 2, this.Image.Height);
        }
    }
}
