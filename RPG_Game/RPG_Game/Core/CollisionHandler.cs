using RPG_Game.GameObjects.Items;

namespace RPG_Game.Core
{
    using System.Collections.Generic;

    using Interfaces;

    using GameObjects.Characters.Player;

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
                        ((Item) entity).Exists = false;
                    }
                }
            }
        }
    }
}
