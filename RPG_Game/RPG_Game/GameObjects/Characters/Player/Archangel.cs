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

        float time;
        // duration of time to show each frame
        float frameTime = 0.1f;
        // an index of the current frame being shown
        int frameIndex;
        // total number of frames in our spritesheet
        const int totalFrames = 8;
        // define the size of our animation frame
        const int frameHeight = 140;
        const int frameWidth = 150;
        Rectangle source;
        private readonly Vector2 Origin = Vector2.Zero;

        public Archangel(Point position)
            : this(position, DefaultAttack, DefaultDefense, DefaultHealth, DefaultDamage, DefaultSpeed)
        {
        }
        public Archangel(Point position, int attackPoints, int defensePoints, int healthPoints, int damage, int speed)
            : base(position, attackPoints, defensePoints, healthPoints, damage, speed)
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
            if (isMovingRight || isMovingUp || isMovingDown)
            {
                spriteBatch.Draw(Assets.archangelFly, new Vector2(this.position.XCoord, this.position.YCoord), source, Color.White, 0.0f,
      Origin, 1.0f, SpriteEffects.None, 0.0f);
            }
            else if (isMovingLeft)
            {
                spriteBatch.Draw(Assets.archangelFlyLeft, new Vector2(this.position.XCoord, this.position.YCoord), source, Color.White, 0.0f,
      Origin, 1.0f, SpriteEffects.None, 0.0f);
            }
            else
            {
                spriteBatch.Draw(Assets.archangel, new Vector2(this.position.XCoord, this.position.YCoord));
            }
        }

        public override void Move()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                this.isMovingLeft = true;
                this.position.XCoord -= speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                this.isMovingRight = true;
                this.position.XCoord += speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                this.isMovingUp = true;
                this.position.YCoord -= speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                this.isMovingDown = true;
                this.position.YCoord += speed;
            }
            if (Keyboard.GetState().IsKeyUp(Keys.Left))
            {
                this.isMovingLeft = false;
            }
            if (Keyboard.GetState().IsKeyUp(Keys.Right))
            {
                this.isMovingRight = false;
            }
            if (Keyboard.GetState().IsKeyUp(Keys.Up))
            {
                this.isMovingUp = false;
            }
            if (Keyboard.GetState().IsKeyUp(Keys.Down))
            {
                this.isMovingDown = false;
            }
        }

        public override void Update(GameTime gameTime)
        {
            this.Move();
            if (isMovingDown || isMovingRight || isMovingUp)
            {
                time += (float)gameTime.ElapsedGameTime.TotalSeconds;
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
            else if (isMovingLeft)
            {
                time += (float)gameTime.ElapsedGameTime.TotalSeconds;
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
            source = new Rectangle(frameIndex * frameWidth, 0, frameWidth, frameHeight);

        }
    }
}
