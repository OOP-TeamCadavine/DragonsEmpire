using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game.Interfaces;
using RPG_Game.Attributes;

namespace RPG_Game.GameObjects.Items
{
    [Item]
    public class HealthSoup : Item, IHeal
    {
        private const int DefaultHealthRestore = 100;

        public HealthSoup(Position position)
            : base(position)
        {
            this.HealthRestore = DefaultHealthRestore;
        }

        public int HealthRestore { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: Health restore ({1})", this.GetType().Name, this.HealthRestore);
        }

        public override void Update(GameTime gameTime)
        {
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(Assets.soup, new Vector2(this.Position.XCoord, this.Position.YCoord));
        }
    }
}
