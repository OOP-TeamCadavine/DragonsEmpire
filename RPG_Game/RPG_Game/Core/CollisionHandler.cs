namespace RPG_Game.Core
{
    using System.Collections.Generic;
    using GameObjects.Characters.Player;
    using GameObjects.Items;
    using Interfaces;

    public class CollisionHandler
    {
        public void HandleCollisions(Player player, IEnumerable<ICollidable> entities)
        {
            foreach (ICollidable entity in entities)
            {
                if (player.ColliderBox.Intersects(entity.ColliderBox))
                {
                    if (entity is Item)
                    {
                        ((Item)entity).Exists = false;
                        if (entity is IHeal)
                        {
                            player.HealthPoints += ((IHeal)entity).HealthRestore;
                        }
                        else if (entity is IDefenseRestore)
                        {
                            player.DefensePoints += ((IDefenseRestore)entity).DefenseRestore;
                        }
                        else if (entity is IAttackBoost)
                        {
                            player.AttackPoints += ((IAttackBoost)entity).AttackBoost;
                        }
                    }
                    else if (entity is ICharacter)
                    {
                        player.Attack((ICharacter)entity);
                        ((ICharacter)entity).Attack(player);
                    }
                }
            }
        }
    }
}
