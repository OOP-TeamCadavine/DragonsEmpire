namespace RPG_Game.Core
{
    using Common;
    using Events;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using States;

    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class GameEngine : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private MapInitializer mapInitializer;
        private PlayerController playerController;
        private CollisionHandler collisionHandler;
        private EnterNameState enterNameState;
        private MainMenuState menu;
        private string playerName;

        public GameEngine()
        {
            this.graphics = new GraphicsDeviceManager(this);
            this.Content.RootDirectory = "Content";
            this.graphics.PreferredBackBufferHeight = 700;
            this.graphics.PreferredBackBufferWidth = 1200;
            this.graphics.ApplyChanges();
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            this.IsMouseVisible = true;
            MainMenuState mainMenuState = new MainMenuState();
            mainMenuState.ButtonClicked += new ButtonClickedEventHandler(this.MainMenuButtonClicked);
            StateManager.CurrentState = mainMenuState;
            this.enterNameState = new EnterNameState();
            this.enterNameState.ButtonClicked += new ButtonClickedEventHandler(this.GetNameStateButtonClicked);
            this.mapInitializer = new MapInitializer();
            this.playerController = new PlayerController();
            this.collisionHandler = new CollisionHandler();

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            this.spriteBatch = new SpriteBatch(this.GraphicsDevice);
            Assets.Init(this);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed
                || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                this.Exit();
            }
                
            if (StateManager.CurrentState != null)
            {
                StateManager.CurrentState.Update(gameTime);
            }

            if (StateManager.CurrentState is HighScoresState && Keyboard.GetState().IsKeyDown(Keys.Enter))
            {
                this.menu = new MainMenuState();
                this.menu.ButtonClicked += new ButtonClickedEventHandler(this.MainMenuButtonClicked);
                StateManager.CurrentState = this.menu;
                this.enterNameState = new EnterNameState();
                this.enterNameState.ButtonClicked += new ButtonClickedEventHandler(this.GetNameStateButtonClicked);
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            this.GraphicsDevice.Clear(Color.CornflowerBlue);

            if (StateManager.CurrentState != null)
            {
                StateManager.CurrentState.Draw(this.spriteBatch, gameTime);
            }
          
            base.Draw(gameTime);
        }

        private void MainMenuButtonClicked(object sender, ButtonClickedEventArgs eventArgs)
        {
            switch (eventArgs.Button)
            {
                case ButtonNames.Play:
                    StateManager.CurrentState = this.enterNameState;
                    break;                   
                case ButtonNames.Scores:
                    StateManager.CurrentState = new HighScoresState();
                    break;
                case ButtonNames.Exit:
                    this.Exit();
                    break;
            }
        }

        private void GetNameStateButtonClicked(object sender, ButtonClickedEventArgs eventArgs)
        {
            switch (eventArgs.Button)
            {
                    case ButtonNames.Done:
                    this.playerName = this.enterNameState.PlayerName;
                    StateManager.CurrentState = new GameState(this.playerName, this.mapInitializer, this.playerController, this.collisionHandler);
                    break;
            }
        }
    }
}
