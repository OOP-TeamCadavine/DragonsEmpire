using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;

namespace RPG_Game.GameObjects.Characters
{
    using Common;

    public abstract class Character : GameObject, ICharacter
    {
        private readonly int InitialHealth;

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
            this.InitialHealth = healthPoints;
            this.HealthPoints = healthPoints;
            this.Damage = damage;
        }

        public int AttackPoints { get; set; }

        public int DefensePoints { get; set; }

        public int HealthPoints
        {
            get { return this.healthPoints; }
            set
            {
                this.healthPoints = value > this.InitialHealth ? this.InitialHealth : value;
            }
        }

        public int Damage { get; set; }

        public virtual void Attack(ICharacter target)
        {
            target.HealthPoints -= this.Damage + this.AttackPoints - target.DefensePoints;  
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
