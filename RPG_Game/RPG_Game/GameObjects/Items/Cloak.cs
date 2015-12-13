using RPG_Game.GameObjects.Items;
using RPG_Game.Interfaces;
using System;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game;
using Microsoft.Xna.Framework;

namespace Items
{
    public class Cloak : Item, IDefenseRestore
    {
        private const int DefaultDefenseRestore = 15;

        public Cloak(RPG_Game.Point position)
            : base(position)
        {
            this.DefenseRestore = DefaultDefenseRestore;
        }

        public int DefenseRestore { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: Defense restored ({1})", this.GetType().Name, this.DefenseRestore);
        }

        public override void Update(GameTime gameTime)
        {
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(Assets.cloak, new Vector2(this.Position.X, this.Position.Y));
        }     
    }
}
