using RPG_Game.GameObjects.Items;
using RPG_Game.Interfaces;
using System;
using Microsoft.Xna.Framework.Graphics;
using RPG_Game;
using Microsoft.Xna.Framework;

namespace Items
{
    public class Shield : Item, IDefenseRestore
    {
        private const int DefaultDefenseRestore = 10;

        public Shield(RPG_Game.Point position)
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
            //TODO : Add images
            throw new NotImplementedException();
        }
    }
}