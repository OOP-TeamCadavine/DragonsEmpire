using RPG_Game.Interfaces;

namespace RPG_Game.GameObjects.Characters
{
    public abstract class Character : GameObject, ICharacter
    {
        protected Character(Position position, int attackPoints, int defensePoints, int healthPoints, int damage)
            : base(position)
        {
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
        }

        public int AttackPoints { get; set; }

        public int DefensePoints { get; set; }

        public int HealthPoints { get; set; }

        public int Damage { get; set; }

        public abstract void Attack();

        public abstract void Defense();
    }
}
