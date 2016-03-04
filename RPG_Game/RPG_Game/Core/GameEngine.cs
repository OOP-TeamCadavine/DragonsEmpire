using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using RPG_Game.Core;
using RPG_Game.Events;
using RPG_Game.States;

namespace RPG_Game
{
    using RPG_Game.Common;

    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class GameEngine : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private MapInitializer mapInitializer;
        private PlayerController playerController;
        private CollisionHandler collisionHandler;
        private EnterNameState enterNameState;
        private MainMenuState menu;
        private string playerName;

        public GameEngine()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferHeight = 700;
            graphics.PreferredBackBufferWidth = 1200;
            graphics.ApplyChanges();
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
            MainMenuState menu = new MainMenuState();
            menu.ButtonClicked += new ButtonClickedEventHandler(MainMenu_ButtonClicked);
            StateManager.CurrentState = menu;
            enterNameState = new EnterNameState();
            enterNameState.ButtonClicked += new ButtonClickedEventHandler(GetNameState_ButtonClicked);
            mapInitializer = new MapInitializer();
            playerController = new PlayerController();
            collisionHandler = new CollisionHandler();

            base.Initialize();
        }
      

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();   
            
            if (StateManager.CurrentState != null)
            {
                StateManager.CurrentState.Update(gameTime);
            }
            if (StateManager.CurrentState is GameOverState && Keyboard.GetState().IsKeyDown(Keys.Enter))
            {
                menu = new MainMenuState();
                menu.ButtonClicked += new ButtonClickedEventHandler(MainMenu_ButtonClicked);
                StateManager.CurrentState = menu;
                enterNameState = new EnterNameState();
                enterNameState.ButtonClicked += new ButtonClickedEventHandler(GetNameState_ButtonClicked);
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            if (StateManager.CurrentState != null)
            {
                StateManager.CurrentState.Draw(spriteBatch, gameTime);
            }
          
            base.Draw(gameTime);
        }

        private void MainMenu_ButtonClicked(object sender, ButtonClickedEventArgs eventArgs)
        {
            switch (eventArgs.Button)
            {
                case ButtonNames.Play:
                    StateManager.CurrentState = enterNameState;
                    break;                   
                case ButtonNames.Scores:
                    StateManager.CurrentState = new HighScoresState();
                    break;
                case ButtonNames.Exit:
                    this.Exit();
                    break;
            }
        }

        private void GetNameState_ButtonClicked(object sender, ButtonClickedEventArgs eventArgs)
        {
            switch (eventArgs.Button)
            {
                    case ButtonNames.Done:
                    playerName = enterNameState.PlayerName;
                    StateManager.CurrentState = new GameState(playerName, mapInitializer, playerController, collisionHandler);
                    break;
            }
        }
    }
}
