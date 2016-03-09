namespace RPG_Game.GameObjects.Characters
{
    using System;

    using Common;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Interfaces;

    public abstract class Character : GameObject, ICharacter
    {
        private const int CriticalHitChance = 6;
        private readonly int initialHealth;

        private int healthPoints;

        protected Character(
            Position position,
            int attackPoints,
            int defensePoints,
            int healthPoints,
            int damage, 
            Texture2D image)
            : base(position, image)
        {
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.initialHealth = healthPoints;
            this.HealthPoints = healthPoints;
            this.Damage = damage;
        }

        public int AttackPoints { get; set; }

        public int DefensePoints { get; set; }

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }

            set
            {
                this.healthPoints = value > this.initialHealth ? this.initialHealth : value;
            }
        }

        public int Damage { get; set; }

        public virtual void Attack(ICharacter target)
        {
            Random rnd = new Random();
            int criticalHit = rnd.Next(0, 100);
            int multiplier = 1;
            if (criticalHit < CriticalHitChance)
            {
                multiplier = 0;
            }

            target.HealthPoints -= Math.Max(this.Damage + this.AttackPoints - (target.DefensePoints * multiplier), 0);  
        }
    

        public override void Update(GameTime gameTime)
        {
            if (this.HealthPoints <= 0)
            {
                this.HealthPoints = 0;
                this.Exists = false;
            }
        }
    }
}
