namespace RPG_Game.GameObjects.Characters.Enemy
{
    public abstract class Enemy : Character
    {
        public Enemy(Point position, int attackPoints, int defensePoints, int healthPoints, int damage)
            : base(position, attackPoints, defensePoints, healthPoints, damage)
        {                
        }        
    }
}
