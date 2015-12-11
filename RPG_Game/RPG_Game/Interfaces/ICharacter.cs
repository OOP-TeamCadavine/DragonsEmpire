namespace RPG_Game.Interfaces
{
    public interface ICharacter : IAttack, IDefense, IGameObject
    {
        int HealthPoints { get; set; }

        int DefensePoints { get; set;}

        int AttackPoints { get; set;}

    }
}
