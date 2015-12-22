namespace RPG_Game.Interfaces
{
    public interface ICharacter : IAttack, IDefense
    {
        int HealthPoints { get; set; }

        int AttackPoints { get; set;}
    }
}
