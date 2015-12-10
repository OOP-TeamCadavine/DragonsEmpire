namespace RPG_Game.Interfaces
{
    public interface IAttack
    {
        int Damage { get; set; }

        void Attack();
    }
}