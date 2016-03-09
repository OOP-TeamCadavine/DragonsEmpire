namespace RPG_Game.GameObjects.Characters.Player
{
    using Common;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class Archangel : Player
    {
        private const int DefaultHealth = 1000;
        private const int DefaultDamage = 50;
        private const int DefaultAttack = 30;
        private const int DefaultDefense = 30;
        private const int DefaultSpeed = 5;

        // define the size of our animation frame
        private const int FrameHeight = 140;
        private const int FrameWidth = 150;

        // total number of frames in our spritesheet
        private const int TotalFrames = 8;

        private static readonly Texture2D ArchangelImage = Assets.archangel;

        private readonly Vector2 origin = Vector2.Zero;

        private float time;

        // duration of time to show each frame
        private float frameTime = 0.1f;

        // an index of the current frame being shown
        private int frameIndex;
              
        private Rectangle source;

        public Archangel(Position position, string name)
            : this(position, DefaultAttack, DefaultDefense, DefaultHealth, DefaultDamage, DefaultSpeed, name)
        {
        }

        public Archangel(Position position, int attackPoints, int defensePoints, int healthPoints, int damage, int speed, string name)
            : base(position, attackPoints, defensePoints, healthPoints, damage, speed, ArchangelImage, name)
        {
        }               

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            if (this.IsMovingRight || this.IsMovingDown)
            {
                spriteBatch.Draw(
                    Assets.archangelFly,
                    new Vector2(this.Position.XCoord, this.Position.YCoord),
                    this.source,
                    Color.White,
                    0.0f,
                    this.origin,
                    1.0f,
                    SpriteEffects.None,
                    0.0f);
            }
            else if (this.IsMovingLeft || this.IsMovingUp)
            {
                spriteBatch.Draw(
                    Assets.archangelFlyLeft,
                    new Vector2(this.Position.XCoord, this.Position.YCoord),
                    this.source,
                    Color.White,
                    0.0f,
                    this.origin,
                    1.0f,
                    SpriteEffects.None,
                    0.0f);
            }
            else
            {
                spriteBatch.Draw(Assets.archangel, new Vector2(this.Position.XCoord, this.Position.YCoord));
            }
        }        

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);            
            if (this.IsMovingDown || this.IsMovingRight)
            {
                this.AnimateMovingRight(gameTime);
            }
            else if (this.IsMovingLeft || this.IsMovingUp)
            {
                this.AnimateMovingLeft(gameTime);
            }

            this.source = new Rectangle(this.frameIndex * FrameWidth, 0, FrameWidth, FrameHeight);
        }

        private void AnimateMovingLeft(GameTime gameTime)
        {
            this.time += (float) gameTime.ElapsedGameTime.TotalSeconds;
            if (this.time > this.frameTime)
            {
                this.frameIndex--;
                this.time = 0f;
            }
            if (this.frameIndex < 0)
            {
                this.frameIndex = TotalFrames - 1;
            }
        }

        private void AnimateMovingRight(GameTime gameTime)
        {
            this.time += (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (this.time > this.frameTime)
            {
                this.frameIndex++;
                this.time = 0f;
            }

            if (this.frameIndex >= TotalFrames)
            {
                this.frameIndex = 0;
            }
        }
    }
}
