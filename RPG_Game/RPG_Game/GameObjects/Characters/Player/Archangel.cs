using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace RPG_Game.GameObjects.Characters.Player
{
    public class Archangel : Player
    {
        private const int DefaultHealth = 500;
        private const int DefaultDamage = 50;
        private const int DefaultAttack = 30;
        private const int DefaultDefense = 30;
        private const int DefaultSpeed = 5;
        private static readonly Texture2D image = Assets.archangel; 

        // define the size of our animation frame
        private const int frameHeight = 140;
        private const int frameWidth = 150;

        // total number of frames in our spritesheet
        private const int totalFrames = 8;

        private float time;
        // duration of time to show each frame
        private float frameTime = 0.1f;
        // an index of the current frame being shown
        private int frameIndex;
              
        private Rectangle source;
        private readonly Vector2 Origin = Vector2.Zero;

        public Archangel(Position position)
            : this(position, DefaultAttack, DefaultDefense, DefaultHealth, DefaultDamage, DefaultSpeed)
        {
        }
        public Archangel(Position position, int attackPoints, int defensePoints, int healthPoints, int damage, int speed)
            : base(position, attackPoints, defensePoints, healthPoints, damage, speed, image)
        {
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void Defense()
        {
            throw new NotImplementedException();
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            if (IsMovingRight || IsMovingDown)
            {
                spriteBatch.Draw(Assets.archangelFly, new Vector2(this.Position.XCoord, this.Position.YCoord), source, Color.White, 0.0f,
      Origin, 1.0f, SpriteEffects.None, 0.0f);
            }
            else if (IsMovingLeft || IsMovingUp)
            {
                spriteBatch.Draw(Assets.archangelFlyLeft, new Vector2(this.Position.XCoord, this.Position.YCoord), source, Color.White, 0.0f,
      Origin, 1.0f, SpriteEffects.None, 0.0f);
            }
            else
            {
                spriteBatch.Draw(Assets.archangel, new Vector2(this.Position.XCoord, this.Position.YCoord));
            }
        }        

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);            
            if (IsMovingDown || IsMovingRight)
            {
                AnimateMovingRight(gameTime);
            }
            else if (IsMovingLeft || IsMovingUp)
            {
                AnimateMovingLeft(gameTime);
            }
            source = new Rectangle(frameIndex * frameWidth, 0, frameWidth, frameHeight);

        }

        private void AnimateMovingLeft(GameTime gameTime)
        {
            time += (float) gameTime.ElapsedGameTime.TotalSeconds;
            if (time > frameTime)
            {
                frameIndex--;
                time = 0f;
            }
            if (frameIndex < 0)
            {
                frameIndex = totalFrames - 1;
            }
        }

        private void AnimateMovingRight(GameTime gameTime)
        {
            time += (float) gameTime.ElapsedGameTime.TotalSeconds;
            if (time > frameTime)
            {
                frameIndex++;
                time = 0f;
            }
            if (frameIndex >= totalFrames)
            {
                frameIndex = 0;
            }
        }
    }
}
